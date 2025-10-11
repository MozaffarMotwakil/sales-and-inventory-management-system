using System;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DataAccess.Warehouses;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsWarehouse
    {
        public int? WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string Address { get; set; }
        public bool IsMainWarehouse { get; set; }
        public bool IsActive { get; set; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; }
        public DateTime? UpdatedAt { get; }
        public enMode Mode { get; }

        public clsWarehouse(string warehouseName, string address, bool isMainWarehouse)
        {
            WarehouseID = null;
            WarehouseName = warehouseName;
            Address = address;
            IsMainWarehouse = isMainWarehouse;
            IsActive = true;
            Mode = enMode.Add;
        }

        internal clsWarehouse(clsWarehouseDTO warehouseDTO)
        {
            WarehouseID = warehouseDTO.WarehouseID;
            WarehouseName = warehouseDTO.WarehouseName;
            Address = warehouseDTO.Address;
            IsMainWarehouse = warehouseDTO.IsMainWarehouse;
            IsActive = warehouseDTO.IsActive;
            CreatedByUserInfo = clsUser.Find(warehouseDTO.CreatedByUserID ?? -1);
            CreatedAt = warehouseDTO.CreatedAt;
            UpdatedByUserInfo = clsUser.Find(warehouseDTO.UpdatedByUserID ?? -1);
            UpdatedAt = warehouseDTO.UpdatedAt;
            Mode = enMode.Update;
        }

        public bool SetActive()
        {
            if (Mode == enMode.Add) 
            {
                return false;
            }

            return clsWarehouseData.SetWarehouseActive(this.WarehouseID ?? -1);
        }

        public bool SetInActive()
        {
            if (Mode == enMode.Add)
            {
                return false;
            }

            return clsWarehouseData.SetWarehouseInActive(this.WarehouseID ?? -1);
        }

        public clsWarehouseDTO MappingToDTO()
        {
            return new clsWarehouseDTO
            {
               WarehouseID = WarehouseID,
               WarehouseName = WarehouseName,
               Address = Address,
               IsMainWarehouse = IsMainWarehouse,
               IsActive = IsActive,
               CreatedByUserID = CreatedByUserInfo.UserID,
               CreatedAt = CreatedAt,
               UpdatedByUserID = UpdatedByUserInfo.UserID,
               UpdatedAt = UpdatedAt
            };
        }

        public void TrimAllStringFields()
        {
            WarehouseName = WarehouseName.Trim();
            Address = Address.Trim();
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(WarehouseName))
            {
                validationResult.AddError("إسم المنتج", "لا يمكن أن يكون إسم المخزن فارغا");
            }

            if (string.IsNullOrWhiteSpace(Address))
            {
                validationResult.AddError("العنوان", "لا يمكن أن يكون العنوان فارغا");
            }

            return validationResult;
        }

    }
}
