using System;

namespace DTOs.Products
{
    public class clsTaxDTO
    {
        public int? TaxID { get; set; }
        public string TaxName { get; set; }
        public decimal TaxRate { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
