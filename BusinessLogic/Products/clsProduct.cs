using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using DataAccess.Products;
using DTOs.Products;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using BusinessLogic.Suppliers;

namespace BusinessLogic.Products
{
    public class clsProduct
    {
        public class ProductSavedEventArgs : EventArgs
        {
            public int ProductID { get; }
            public string ProductName { get; }
            public enMode OperationMode { get; }
            public DateTime Timestamp { get; }
            public int UserID { get; }

            public ProductSavedEventArgs(int productID, string productName, enMode mode)
            {
                ProductID = productID;
                ProductName = productName;
                OperationMode = mode;
                Timestamp = DateTime.Now;
                UserID = clsAppSettings.CurrentUser.UserID;
            }
        }

        public static event EventHandler<ProductSavedEventArgs> ProductSaved;

        protected virtual void OnProductSaved(int productID, string productName, enMode mode)
        {
            ProductSaved?.Invoke(this, new ProductSavedEventArgs(productID, productName, mode));
        }

        public class ProductDeletedEventArgs : EventArgs
        {
            public int ProductID { get; }
            public string ProductName { get; }
            public DateTime Timestamp { get; }
            public int UserID { get; }

            public ProductDeletedEventArgs(int productID, string productName)
            {
                ProductID = productID;
                ProductName = productName;
                Timestamp = DateTime.Now;
                UserID = clsAppSettings.CurrentUser.UserID;
            }
        }

        public static event EventHandler<ProductDeletedEventArgs> ProductDeleted;

        protected static void OnProductDeleted(int productID, string productName)
        {
            ProductDeleted?.Invoke(null, new ProductDeletedEventArgs(productID, productName));
        }

        public int? ProductID { get; private set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public clsCategory CategoryInfo { get; private set; }
        public clsUnit MainUnitInfo { get; private set; }
        public List<clsProductUnitConversion> UnitConversions { get; }
        public clsSupplier MainSupplierInfo { get; private set; }
        public float SellingPrice { get; set; }
        public string Description { get; set; }
        private string _CurrentImagePath { get; set; }
        public string ImagePath { get; set; }
        public bool IsDeleted { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; }
        public DateTime? UpdatedAt { get; }
        private enMode _Mode { get; set; }

        public clsProduct(string productName, string barcode, int categoryID, int mainUnitID, List<clsProductUnitConversion> unitConversions,
            string mainSupplierName, float sellingPrice, string description, string imagePath)
        {
            ProductID = null;
            ProductName = productName;
            Barcode = barcode;
            CategoryInfo = clsCategory.Find(categoryID);
            MainUnitInfo = clsUnit.Find(mainUnitID);
            UnitConversions = unitConversions;
            MainSupplierInfo = clsSupplier.Find(mainSupplierName);
            SellingPrice = sellingPrice;
            Description = description;
            _CurrentImagePath = null;
            ImagePath = imagePath;
            CreatedByUserInfo = clsAppSettings.CurrentUser;
            _Mode = enMode.Add; 
        }

        private clsProduct (clsProductDTO productDTO)
        {
            ProductID = productDTO.ProductID;
            ProductName = productDTO.ProductName;
            Barcode = productDTO.Barcode;
            CategoryInfo = clsCategory.Find(productDTO.CategoryID);
            MainUnitInfo = clsUnit.Find(productDTO.MainUnitID);
            UnitConversions = clsProductUnitConversion.ConvertAlternativeUnitsTableToList(productDTO.UnitConversions);
            MainSupplierInfo = clsSupplier.Find(productDTO.MainSupplierID ?? -1);
            SellingPrice = productDTO.SellingPrice;
            Description = productDTO.Description;
            _CurrentImagePath = productDTO.ImagePath;
            ImagePath = productDTO.ImagePath;
            CreatedByUserInfo = clsUser.Find(productDTO.CreatedByUserID);
            CreatedAt = productDTO.CreatedAt;
            UpdatedByUserInfo = productDTO.UpdatedByUserID is null ? 
                clsAppSettings.CurrentUser :
                clsUser.Find(productDTO.UpdatedByUserID ?? -1);
            UpdatedAt = productDTO.UpdatedAt;
            _Mode = enMode.Update;
        }

        public static clsProduct Find(int productID)
        {
            if (productID < 1)
            {
                return null;
            }

            clsProductDTO productDTO = clsProductData.FindProductByID(productID);
            return productDTO is null ? null : new clsProduct(productDTO);
        }

        public static bool Delete(int productID)
        {
            if (productID < 1)
            {
                return false;
            }

            Find(productID)?.DeleteImage();

            if (clsProductData.DeleteProduct(productID))
            {
                OnProductDeleted(productID, GetProductName(productID));
                return true;
            }

            return false;
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

        public static DataTable GetAllProducts()
        {
            return clsProductData.GetAllProducts();
        }

        public static string GenerateBarcode()
        {
            return "INV-" + Guid.NewGuid();
        }

        public void ChangeCategory(int newCategoryID)
        {
            CategoryInfo = clsCategory.Find(newCategoryID);
        }

        public void ChangeMainUnit(int newUnitID)
        {
            MainUnitInfo = clsUnit.Find(newUnitID);
        }

        public void ChangeMainSuppliert(int newSupplierID)
        {
            MainSupplierInfo = clsSupplier.Find(newSupplierID);
        }

        public void ChangeMainSupplier(string newSupplierName)
        {
            MainSupplierInfo = clsSupplier.Find(newSupplierName);
        }

        public void DeleteMainSupplier()
        {
            MainSupplierInfo = null;
        }

        public virtual clsProductDTO MappingToDTO()
        {
            return new clsProductDTO
            {
                ProductID = this.ProductID,
                ProductName = this.ProductName,
                Barcode = this.Barcode,
                CategoryID = this.CategoryInfo.CategoryID,
                MainUnitID = this.MainUnitInfo.UnitID,
                UnitConversions = clsProductUnitConversion.ConvertAlternativeUnitsListToTable(this.UnitConversions),
                MainSupplierID = this.MainSupplierInfo?.SupplierID,
                SellingPrice = this.SellingPrice,
                Description = this.Description,
                ImagePath = this.ImagePath,
                CreatedByUserID = this.CreatedByUserInfo.UserID,
                UpdatedByUserID = this.UpdatedByUserInfo?.UserID
            };
        }

        public virtual clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            clsProduct currentProductInDB = Find(ProductID ?? -1);
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(ProductName))
            { 
                validationResult.AddError("إسم المنتج", "لا يمكن أن يكون إسم المنتج فارغا");
            }

            if ((_Mode == enMode.Update && currentProductInDB.ProductName != this.ProductName && IsProductNameExists(this.ProductName)) || 
                (_Mode == enMode.Add && IsProductNameExists(ProductName)))
            {
                validationResult.AddError("إسم المنتج", "المنتج موجود بالفعل");
            }

            if (string.IsNullOrWhiteSpace(Barcode))
            {
                validationResult.AddError("الباركود", "لا يمكن أن يكون الباركود فارغا");
            }

            if ((_Mode == enMode.Update && currentProductInDB.Barcode != this.Barcode && IsBarcodeExists(this.Barcode)) ||
                (_Mode == enMode.Add && IsBarcodeExists(Barcode)))
            {
                validationResult.AddError("الباركود", "الباركود موجود بالفعل");
            }

            if (CategoryInfo is null)
            {
                validationResult.AddError("التصنيف/الفئة", "يجب تعيين تصنيف");
            }

            if (MainUnitInfo is null)
            {
                validationResult.AddError("وحدة القياس الأساسية", "يجب تعيين وحدة القياس الأساسية");
            }

            if (UnitConversions != null)
            {
                for (int i = 0; i < UnitConversions.Count; i++)
                {
                    if (UnitConversions[i].AlternativeUnitID == this.MainUnitInfo.UnitID)
                    {
                        validationResult.AddError("وحدة القياس البديلة", "لا يمكن أن تكون وحدة القياس الأساسية وحدة قياس بديلة");
                    }

                    for (int j = 0; j < UnitConversions.Count; j++)
                    {
                        if (j != i && UnitConversions[i].AlternativeUnitID == UnitConversions[j].AlternativeUnitID)
                        {
                            validationResult.AddError("وحدة القياس البديلة", "لا يمكن أن تتكرر وحدة القياس البديلة");
                        }
                    }
                }
            }

            if (!float.TryParse(SellingPrice.ToString(), out float sellingPrice) || sellingPrice < 1)
            {
                validationResult.AddError("سعر البيع", "يجب أن يكون سعر البيع رقم أكبر من صفر");
            }

            return validationResult;
        }

        public void TrimAllStringFields()
        {
            ProductName.Trim(); Barcode.Trim(); Description.Trim();
        }

        private void DeleteImage()
        {
            if (File.Exists(this._CurrentImagePath))
            {
                File.Delete(this._CurrentImagePath);
            }

            this._CurrentImagePath = string.Empty;
        }

        private void SaveImage()
        {
            if (_CurrentImagePath != ImagePath)
            {
                if (string.IsNullOrEmpty(ImagePath))
                {
                    this.DeleteImage();
                }
                else
                {
                    if (!string.IsNullOrEmpty(_CurrentImagePath))
                    {
                        this.DeleteImage();
                    }

                    this._CurrentImagePath = clsAppSettings.GetNewImagePathWithGUIDForProduct();
                    File.Copy(ImagePath, this._CurrentImagePath);
                    this.ImagePath = this._CurrentImagePath;
                }
            }
        }

        public clsValidationResult Save()
        {
            clsValidationResult validationResult = this.Validated();

            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            this.SaveImage();

            return _ExecuteSaving(this.MappingToDTO(), this._Mode, validationResult);
        }

        private clsValidationResult _ExecuteSaving(clsProductDTO productDTO, enMode mode, clsValidationResult validationResult)
        {
            bool isSaved = mode is enMode.Add ?
                clsProductData.AddProduct(productDTO) :
                clsProductData.UpdateProduct(productDTO);

            if (isSaved)
            {
                if (this._Mode is enMode.Add)
                {
                    this.ProductID = productDTO.ProductID;
                }

                OnProductSaved(this.ProductID ?? -1, this.ProductName, this._Mode);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }

    }
}
