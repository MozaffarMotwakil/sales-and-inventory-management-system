using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Interfaces;
using BusinessLogic.Utilities;
using BusinessLogic.Validation;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsUnitService : IEntityListManager<clsUnit>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsUnitService _Instance;

        private clsUnitService() { }

        public static clsUnitService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsUnitService();
            }

            return _Instance;
        }

        private void OnUnitSaved(int unitID, string unitName, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(unitID, unitName, mode));
        }

        private void OnUnitDeleted(int unitID, string unitName)
        {
            EntityDeleted?.Invoke(this, new EntityDeletedEventArgs(unitID, unitName));
        }

        public clsUnit Find(int unitID)
        {
            clsUnitDTO unitDTO = clsUnitData.FindUnitByID(unitID);
            return unitDTO is null ? null : new clsUnit(unitDTO);
        }

        public bool Delete(int unitID)
        {
            if (unitID < 1)
            {
                return false;
            }

            clsUnit Unit = Find(unitID);

            try
            {
                if (clsUnitData.DeleteUnit(unitID))
                {
                    OnUnitDeleted(unitID, Unit.UnitName);
                    return true;
                }
            }
            catch (SqlException ex) when (ex.Number >= 50000)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception(clsAppSettings.ErrorToConnectionFormDB, ex);
            }

            return false;
        }

        public DataTable GetAll()
        {
            return clsUnitData.GetAllUnits();
        }

        public static bool IsUnitExists(int UnitID)
        {
            return clsUnitData.IsUnitExists(UnitID);
        }

        public static bool IsUnitExists(string UnitName)
        {
            return clsUnitData.IsUnitExists(UnitName);
        }

        public static DataTable GetUnitsList()
        {
            return clsUnitData.GetUnitsList();
        }

        public static string[] GetAllUnitNames()
        {
            return clsUtils.GetColumnStringArray(
                clsUnitData.GetUnitsList(),
                "UnitName"
                );
        }

        public clsValidationResult Validated(clsUnit Unit)
        {
            clsValidationResult validationResult = Unit.Validated();
            clsUnit currentUnitInDB = Find(Unit.UnitID.GetValueOrDefault());

            if ((Unit.Mode == enMode.Update && currentUnitInDB.UnitName != Unit.UnitName && IsUnitExists(Unit.UnitName)) ||
                (Unit.Mode == enMode.Add && IsUnitExists(Unit.UnitName)))
            {
                validationResult.AddError("إسم الوحدة", "الوحدة موجودة بالفعل");
            }

            return validationResult;
        }

        public clsValidationResult Save(clsUnit Unit)
        {
            clsValidationResult validationResult = Validated(Unit);

            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            return _ExecuteSaving(Unit.MappingToDTO(), Unit.Mode, validationResult);
        }

        private clsValidationResult _ExecuteSaving(clsUnitDTO UnitDTO, enMode mode, clsValidationResult validationResult)
        {
            if (mode is enMode.Add)
            {
                UnitDTO.CreatedByUserID = clsAppSettings.CurrentUser.UserID;
            }
            else
            {
                UnitDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
            }

            bool isSaved = mode is enMode.Add ?
                clsUnitData.AddUnit(UnitDTO) :
                clsUnitData.UpdateUnit(UnitDTO);

            if (isSaved)
            {
                OnUnitSaved(UnitDTO.UnitID.GetValueOrDefault(), UnitDTO.UnitName, mode);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }

    }
}
