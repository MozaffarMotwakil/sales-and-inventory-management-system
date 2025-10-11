using System;

namespace DTOs.Warehouses
{
    public class clsWarehouseDTO
    {
        public int? WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string Address { get; set; }
        public bool IsMainWarehouse { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public clsWarehouseDTO() { }

        public clsWarehouseDTO(int? warehouseID, string warehouseName, string address,
            bool isMainWarehouse, bool isActive, int? createdByUserID, DateTime? createdAt,
            int? updatedByUserID, DateTime? updatedAt)
        {
            WarehouseID = warehouseID;
            WarehouseName = warehouseName;
            Address = address;
            IsMainWarehouse = isMainWarehouse;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
            CreatedAt = createdAt;
            UpdatedByUserID = updatedByUserID;
            UpdatedAt = updatedAt;
        }

    }
}
