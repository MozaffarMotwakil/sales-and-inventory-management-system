using System;
using System.Collections.Generic;
using DTOs.Products;
using BusinessLogic.Users;
using BusinessLogic.Suppliers;
using BusinessLogic.Validation;

namespace BusinessLogic.Products
{
    public class clsProduct 
    {
        public int? ProductID { get; private set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public clsCategory CategoryInfo { get; private set; }
        public clsUnit MainUnitInfo { get; private set; }
        public List<clsProductUnitConversion> UnitConversions { get; } = new List<clsProductUnitConversion>();
        public clsSupplier MainSupplierInfo { get; private set; }
        public float SellingPrice { get; set; }
        public string Description { get; set; }
        internal string CurrentImagePath { get; set; }
        public string ImagePath { get; set; }
        public bool IsDeleted { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; }
        public DateTime? UpdatedAt { get; }
        public enMode Mode { get; private set; }

        public clsProduct(string productName, string barcode, int categoryID, int mainUnitID, List<clsProductUnitConversion> unitConversions,
            string mainSupplierName, float sellingPrice, string description, string imagePath)
        {
            ProductID = null;
            ProductName = productName;
            Barcode = barcode;
            CategoryInfo = clsCategory.Find(categoryID);
            MainUnitInfo = clsUnit.Find(mainUnitID);
            UnitConversions = unitConversions;
            MainSupplierInfo = clsSupplierService.GetInstance().Find(mainSupplierName);
            SellingPrice = sellingPrice;
            Description = description;
            ImagePath = imagePath;
            Mode = enMode.Add; 
        }

        internal clsProduct (clsProductDTO productDTO)
        {
            ProductID = productDTO.ProductID;
            ProductName = productDTO.ProductName;
            Barcode = productDTO.Barcode;
            CategoryInfo = clsCategory.Find(productDTO.CategoryID);
            MainUnitInfo = clsUnit.Find(productDTO.MainUnitID);
            UnitConversions = clsProductUnitConversion.ConvertAlternativeUnitsTableToList(productDTO.UnitConversions);
            MainSupplierInfo = clsSupplierService.GetInstance().Find(productDTO.MainSupplierID ?? -1);
            SellingPrice = productDTO.SellingPrice;
            Description = productDTO.Description;
            CurrentImagePath = productDTO.ImagePath;
            ImagePath = productDTO.ImagePath;
            CreatedByUserInfo = clsUser.Find(productDTO.CreatedByUserID);
            CreatedAt = productDTO.CreatedAt;
            UpdatedByUserInfo = productDTO.UpdatedByUserID is null ?
                null :
                clsUser.Find(productDTO.UpdatedByUserID ?? -1);
            UpdatedAt = productDTO.UpdatedAt;
            Mode = enMode.Update;
        }

        public void ChangeCategory(int newCategoryID)
        {
            CategoryInfo = clsCategory.Find(newCategoryID);
        }

        public void ChangeMainUnit(int newUnitID)
        {
            MainUnitInfo = clsUnit.Find(newUnitID);
        }

        public void ChangeMainSupplier(string newSupplierName)
        {
            if (MainSupplierInfo?.PartyInfo.PartyName == newSupplierName)
            {
                return;
            }

            clsSupplier newSupplier = clsSupplierService.GetInstance().Find(newSupplierName);

            if (newSupplier != null)
            {
                MainSupplierInfo = newSupplier;
            }
            else
            {
                this.DeleteMainSupplier();
            }
        }

        public void DeleteMainSupplier()
        {
            MainSupplierInfo = null;
        }

        public clsProductDTO MappingToDTO()
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

        public void TrimAllStringFields()
        {
            ProductName = ProductName.Trim();
            Barcode = Barcode.Trim();
            Description = Description.Trim();
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                validationResult.AddError("إسم المنتج", "لا يمكن أن يكون إسم المنتج فارغا");
            }

            if (string.IsNullOrWhiteSpace(Barcode))
            {
                validationResult.AddError("الباركود", "لا يمكن أن يكون الباركود فارغا");
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
                    if (UnitConversions[i].AlternativeUnitID == MainUnitInfo.UnitID)
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

    }
}
