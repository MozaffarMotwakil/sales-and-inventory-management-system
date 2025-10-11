using System;
using System.Data;
using BusinessLogic.Interfaces;
using BusinessLogic.Validation;
using DataAccess.Warehouses;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsWarehouseService : IEntityListManager<clsWarehouse>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private void OnWarehouseSaved(int warehouseID, string warehouseName, enMode mode)
        {
            EntitySaved?.Invoke(null, new EntitySavedEventArgs(warehouseID, warehouseName, mode));
        }

        private void OnWarehouseDeleted(int warehouseID, string warehouseName)
        {
            EntityDeleted?.Invoke(null, new EntityDeletedEventArgs(warehouseID, warehouseName));
        }

        public clsWarehouse Find(int warehouseID)
        {
            if (warehouseID < 1)
            {
                return null;
            }

            clsWarehouseDTO WarehouseDTO = clsWarehouseData.FindWarehouseByID(warehouseID);
            return WarehouseDTO is null ? null : new clsWarehouse(WarehouseDTO);
        }

        public bool Delete(int warehouseID)
        {
            if (warehouseID < 1)
            {
                return false;
            }

            clsWarehouse warehouse = Find(warehouseID);

            if (clsWarehouseData.DeleteWarehouse(warehouseID))
            {
                OnWarehouseDeleted(warehouseID, warehouse.WarehouseName);
                return true;
            }

            return false;
        }

        public DataTable GetAll()
        {
            return clsWarehouseData.GetAllWarehouses();
        }

        public static bool IsWarehouseNameExists(string warehouseName)
        {
            return clsWarehouseData.IsWarehouseNameExists(warehouseName);
        }

        public clsValidationResult Validated(clsWarehouse warehouse)
        {
            clsValidationResult validationResult = warehouse.Validated();

            clsWarehouse currentWarehouseInDB = Find(warehouse.WarehouseID ?? -1);

            if ((warehouse.Mode == enMode.Update && currentWarehouseInDB.WarehouseName != warehouse.WarehouseName && IsWarehouseNameExists(warehouse.WarehouseName)) ||
                (warehouse.Mode == enMode.Add && IsWarehouseNameExists(warehouse.WarehouseName)))
            {
                validationResult.AddError("إسم المخزن", "المخزن موجود بالفعل");
            }

            return validationResult; 
        }


        public clsValidationResult Save(clsWarehouse warehouse)
        {
            clsValidationResult validationResult = Validated(warehouse);

            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            return _ExecuteSaving(warehouse.MappingToDTO(), warehouse.Mode, validationResult);
        }

        private clsValidationResult _ExecuteSaving(clsWarehouseDTO warehouseDTO, enMode mode, clsValidationResult validationResult)
        {
            if (mode is enMode.Add)
            {
                warehouseDTO.CreatedByUserID = clsAppSettings.CurrentUser.UserID;
            }
            else
            {
                if (warehouseDTO.UpdatedByUserID == null)
                {
                    warehouseDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
                }
            }

            bool isSaved = mode is enMode.Add ?
                clsWarehouseData.AddWarehouse(warehouseDTO) :
                clsWarehouseData.UpdateWarehouse(warehouseDTO);

            if (isSaved)
            {
                OnWarehouseSaved(warehouseDTO.WarehouseID ?? -1, warehouseDTO.WarehouseName, mode);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }

    }
}
