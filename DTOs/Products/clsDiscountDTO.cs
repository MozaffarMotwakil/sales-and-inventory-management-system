using System;

namespace DTOs.Products
{
    public class clsDiscountDTO
    {
        public int? DiscountID { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountValue { get; set; }
        public bool DiscountValueType { get; set; }
        public int MinimumQuantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}