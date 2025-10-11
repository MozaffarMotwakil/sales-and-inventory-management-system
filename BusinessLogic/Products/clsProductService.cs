using System;
using System.Data;
using System.IO;
using BusinessLogic.Interfaces;
using BusinessLogic.Validation;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsProductService : IEntityListManager<clsProduct>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private void OnProductSaved(int productID, string productName, enMode mode)
        {
            EntitySaved?.Invoke(null, new EntitySavedEventArgs(productID, productName, mode));
        }

        private void OnProductDeleted(int productID, string productName)
        {
            EntityDeleted?.Invoke(null, new EntityDeletedEventArgs(productID, productName));
        }

        public clsProduct Find(int productID)
        {
            if (productID < 1)
            {
                return null;
            }

            clsProductDTO productDTO = clsProductData.FindProductByID(productID);
            return productDTO is null ? null : new clsProduct(productDTO);
        }

        public bool Delete(int productID)
        {
            if (productID < 1)
            {
                return false;
            }

            clsProduct product = Find(productID);

            if (clsProductData.DeleteProduct(productID))
            {
                DeleteImage(product);
                OnProductDeleted(productID, product.ProductName);
                return true;
            }

            return false;
        }

        public DataTable GetAll()
        {
            return clsProductData.GetAllProducts();
        }

        public static bool IsBarcodeExists(string barcode)
        {
            return clsProductData.IsBarcodeExists(barcode);
        }

        public static bool IsProductNameExists(string productName)
        {
            return clsProductData.IsProductNameExists(productName);
        }

        public static string GetProductName(int prouctID)
        {
            return clsProductData.GetProductName(prouctID);
        }

        public static string GenerateBarcode()
        {
            return "INV-" + Guid.NewGuid();
        }

        public clsValidationResult Validated(clsProduct product)
        {
            clsValidationResult validationResult = product.Validated();
            clsProduct currentProductInDB = Find(product.ProductID ?? -1);

            if ((product.Mode == enMode.Update && currentProductInDB.ProductName != product.ProductName && IsProductNameExists(product.ProductName)) ||
                (product.Mode == enMode.Add && IsProductNameExists(product.ProductName)))
            {
                validationResult.AddError("إسم المنتج", "المنتج موجود بالفعل");
            }

            if ((product.Mode == enMode.Update && currentProductInDB.Barcode != product.Barcode && IsBarcodeExists(product.Barcode)) ||
                (product.Mode == enMode.Add && IsBarcodeExists(product.Barcode)))
            {
                validationResult.AddError("الباركود", "الباركود موجود بالفعل");
            }

            return validationResult;
        }

        private void DeleteImage(clsProduct product)
        {
            if (File.Exists(product.CurrentImagePath))
            {
                File.Delete(product.CurrentImagePath);
            }

            product.CurrentImagePath = string.Empty;
        }

        private void SaveImage(clsProduct product)
        {
            if (product.CurrentImagePath != product.ImagePath)
            {
                if (string.IsNullOrEmpty(product.ImagePath))
                {
                    DeleteImage(product);
                }
                else
                {
                    if (!string.IsNullOrEmpty(product.CurrentImagePath))
                    {
                        DeleteImage(product);
                    }

                    product.CurrentImagePath = clsAppSettings.GetNewImagePathWithGUIDForProduct();
                    File.Copy(product.ImagePath, product.CurrentImagePath);
                    product.ImagePath = product.CurrentImagePath;
                }
            }
        }

        public clsValidationResult Save(clsProduct product)
        {
            clsValidationResult validationResult = Validated(product);

            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            SaveImage(product);

            return _ExecuteSaving(product.MappingToDTO(), product.Mode, validationResult);
        }

        private clsValidationResult _ExecuteSaving(clsProductDTO productDTO, enMode mode, clsValidationResult validationResult)
        {
            if (mode is enMode.Add)
            {
                productDTO.CreatedByUserID = clsAppSettings.CurrentUser.UserID;
            }
            else
            {
                if (productDTO.UpdatedByUserID == null)
                {
                    productDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
                }
            }

            bool isSaved = mode is enMode.Add ?
                clsProductData.AddProduct(productDTO) :
                clsProductData.UpdateProduct(productDTO);

            if (isSaved)
            {
                OnProductSaved(productDTO.ProductID ?? -1, productDTO.ProductName, mode);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }

    }
}
