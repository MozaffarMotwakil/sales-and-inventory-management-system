using System;

namespace DTOs.Products
{
    public class clsUnitDTO
    {
        public int? UnitID { get; set; }
        public string UnitName { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public clsUnitDTO() { }
    }
}
