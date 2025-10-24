using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using BusinessLogic.Interfaces;
using BusinessLogic.Validation;
using DataAccess.Parties;
using DataAccess.Products;
using DataAccess.Warehouses;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsProductService : IEntityListManager<clsProduct>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsProductService _Instance;

        private clsProductService() { }

        public static clsProductService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsProductService();
            }

            return _Instance;
        }

        private void OnProductSaved(int productID, string productName, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(productID, productName, mode));
        }

        private void OnProductDeleted(int productID, string productName)
        {
            EntityDeleted?.Invoke(this, new EntityDeletedEventArgs(productID, productName));
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

            try
            {
                if (clsProductData.DeleteProduct(productID))
                {
                    DeleteImage(product);
                    OnProductDeleted(productID, product.ProductName);
                    return true;
                }
            }
            catch (SqlException ex) when (ex.Number >= 50000)
            {
                throw new InvalidOperationException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception(clsAppSettings.ErrorToConnectionFormDB, ex);
            }

            return false;
        }

        public DataTable GetAll()
        {
            return clsProductData.GetAllProducts();
        }

        public static DataTable GetAllProductUnits(int productID)
        {
            DataTable productUnits = clsProductUnitData.GetAllUnitsByProductID(productID);
            DataColumn[] primaryKey = new DataColumn[1] { productUnits.Columns["UnitID"] };
            productUnits.PrimaryKey = primaryKey;
            return productUnits;
        }

        public static bool IsProductExists(int productID)
        {
            return clsProductData.IsProductExists(productID);
        }

        public static bool IsProductExistsByBarcode(string barcode)
        {
            return clsProductData.IsProductExistsByBarcode(barcode);
        }

        public static bool IsProductExistsByName(string productName)
        {
            return clsProductData.IsProductExistsByName(productName);
        }

        public static bool IsBarcodeExists(int? currentProductID, string barcode)
        {
            return clsProductData.IsBarcodeExists(currentProductID, barcode);
        }

        public static string GenerateBarcode()
        {
            return "INV-" + Guid.NewGuid();
        }

        public clsValidationResult Validated(clsProduct product)
        {
            clsValidationResult validationResult = product.Validated();
            clsProduct currentProductInDB = Find(product.ProductID ?? -1);

            if ((product.Mode == enMode.Update && currentProductInDB.ProductName != product.ProductName && IsProductExistsByName(product.ProductName)) ||
                (product.Mode == enMode.Add && IsProductExistsByName(product.ProductName)))
            {
                validationResult.AddError("إسم المنتج", "المنتج موجود بالفعل");
            }

            if (IsBarcodeExists(product.ProductID, product.Barcode))
            {
                validationResult.AddError("الباركود", $"الباركود \"{product.Barcode}\" موجود بالفعل");
            }

            foreach (clsProductUnitConversion unitConversion in product.UnitConversions)
            {
                if (IsBarcodeExists(product.ProductID, unitConversion.Barcode))
                {
                    validationResult.AddError("الباركود", $"الباركود \"{unitConversion.Barcode}\" موجود بالفعل");
                }
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
                productDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
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
