using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using BusinessLogic.Interfaces;
using BusinessLogic.Utilities;
using BusinessLogic.Validation;
using DataAccess.Warehouses;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsWarehouseService : IEntityListManager<clsWarehouse>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsWarehouseService _Instance;

        private clsWarehouseService() { }

        public static clsWarehouseService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsWarehouseService();
            }

            return _Instance;
        }

        private void OnWarehouseSaved(int warehouseID, string warehouseName, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(warehouseID, warehouseName, mode));
        }

        private void OnWarehouseDeleted(int warehouseID, string warehouseName)
        {
            EntityDeleted?.Invoke(this, new EntityDeletedEventArgs(warehouseID, warehouseName));
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

            try
            {
                if (clsWarehouseData.DeleteWarehouse(warehouseID))
                {
                    OnWarehouseDeleted(warehouseID, warehouse.WarehouseName);
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
            return clsWarehouseData.GetAllWarehouses();
        }

        public static DataTable GetWarehousesList()
        {
            return clsWarehouseData.GetWarehousesList();
        }

        public static string[] GetWarehouseNames()
        {
            return clsUtils.GetColumnStringArray(
                clsWarehouseData.GetWarehousesList(), 
                "WarehouseName"
                );
        }

        public bool MarkAsActive(clsWarehouse warehouse)
        {
            if (warehouse.IsActive)
            {
                return true;
            }

            if (warehouse.Mode == enMode.Update && clsWarehouseData.SetWarehouseActive(warehouse.WarehouseID ?? -1))
            {
                OnWarehouseSaved(warehouse.WarehouseID ?? -1, warehouse.WarehouseName, enMode.Update);
                return true;
            }

            return false;
        }

        public bool MarkAsInActive(clsWarehouse warehouse)
        {
            if (!warehouse.IsActive)
            {
                return true;
            }

            if (warehouse.Mode == enMode.Update && clsWarehouseData.SetWarehouseInActive(warehouse.WarehouseID ?? -1))
            {
                OnWarehouseSaved(warehouse.WarehouseID ?? -1, warehouse.WarehouseName, enMode.Update);
                return true;
            }

            return false;
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
                warehouseDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
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
