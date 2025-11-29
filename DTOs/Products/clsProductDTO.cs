using System;
using System.Data;

namespace DTOs.Products
{
    public class clsProductDTO
    {
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public int CategoryID { get; set; }
        public int MainUnitID { get; set; }
        public DataTable UnitConversions { get; set; }
        public int? MainSupplierID { get; set; }
        public float SellingPrice { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public clsProductDTO() { }

        public clsProductDTO(int? productID, string productName, string barcode, int categoryID, int mainUnitID,
            DataTable unitConversions, int? mainSupplierID, float sellingPrice, string description, string imagePath, 
            bool isDeleted, int? createdByUserID, DateTime? createdAt, int? updatedByUserID, DateTime? updatedAt)
        {
            ProductID = productID;
            ProductName = productName;
            Barcode = barcode;
            CategoryID = categoryID;
            MainUnitID = mainUnitID;
            UnitConversions = unitConversions;
            MainSupplierID = mainSupplierID;
            SellingPrice = sellingPrice;
            Description = description;
            ImagePath = imagePath;
            IsActive = isDeleted;
            CreatedByUserID = createdByUserID;
            CreatedAt = createdAt;
            UpdatedByUserID = updatedByUserID;
            UpdatedAt = updatedAt;
        }

    }
}
