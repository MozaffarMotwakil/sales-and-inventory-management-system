using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Interfaces;
using BusinessLogic.Parties;
using BusinessLogic.Validation;
using DataAccess.Suppliers;
using DTOs.Suppliers;

namespace BusinessLogic.Suppliers
{
    public class clsSupplierService : IEntityListManager<clsSupplier>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsSupplierService _Instance;

        private clsSupplierService() { }

        public static clsSupplierService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsSupplierService();
            }

            return _Instance;
        }

        private void OnSupplierSaved(int productID, string productName, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(productID, productName, mode));
        }

        private void OnSupplierDeleted(int productID, string productName)
        {
            EntityDeleted?.Invoke(this, new EntityDeletedEventArgs(productID, productName));
        }

        public static bool IsSupplierExistsByPartyID(int partyID)
        {
            return clsSupplierData.IsSupplierExistsByPartyID(partyID);
        }

        public clsSupplier Find(int supplierID)
        {
            if (supplierID < 1)
            {
                return null;
            }

            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByID(supplierID);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public clsSupplier FindByPartyID(int partyID)
        {
            if (partyID < 1)
            {
                return null;
            }

            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByPartyID(partyID);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public clsSupplier Find(string supplierName)
        {
            if (string.IsNullOrWhiteSpace(supplierName))
            {
                return null;
            }

            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByName(supplierName);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public bool Delete(int supplierID)
        {
            if (supplierID < 1)
            {
                return false;
            }

            clsSupplier supplier = Find(supplierID);

            try
            {
                if (clsSupplierData.DeleteSupplier(supplierID))
                {
                    if (supplier.PartyInfo is clsPerson person)
                    {
                        person.DeleteImage();
                    }
                    else if (supplier.PartyInfo is clsOrganization organization)
                    {
                        organization.ContactPersonInfo?.DeleteImage();
                    }

                    OnSupplierDeleted(supplier.SupplierID ?? -1, supplier.PartyInfo.PartyName);
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
            return clsSupplierData.GetAllSuppliers();
        }

        public static string[] GetAllSupplierNames()
        {
            DataTable table = clsSupplierData.GetAllSupplierNames();
            string[] supplierNames = new string[table.Rows.Count];

            for (int i = 0; i < supplierNames.Length; i++)
            {
                supplierNames[i] = table.Rows[i][0].ToString();
            }

            return supplierNames;
        }

        public clsValidationResult Save(clsSupplier supplier)
        {
            clsValidationResult result = supplier.Validated();

            if (!result.IsValid)
            {
                return result;
            }

            _HandlePersonImageSaving(supplier);

            return _ExecuteSaving(supplier.MappingToDTO(), supplier.Mode, result);
        }

        private clsValidationResult _ExecuteSaving(clsSupplierDTO supplierDTO, enMode mode, clsValidationResult validationResult)
        {
            if (mode is enMode.Add)
            {
                supplierDTO.CreatedByUserID = clsAppSettings.CurrentUser.UserID;
            }
            else
            {
                supplierDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
            }

            bool isSaved = mode is enMode.Add ?
                clsSupplierData.AddSupplier(supplierDTO) :
                clsSupplierData.UpdateSupplier(supplierDTO);

            if (isSaved)
            {
                OnSupplierSaved(supplierDTO.SupplierID ?? -1, supplierDTO.SupplierName, mode);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }

        private void _HandlePersonImageSaving(clsSupplier supplier)
        {
            if (supplier.PartyInfo is clsPerson person)
            {
                person.SaveImage();
            }
            else
            {
                ((clsOrganization)supplier.PartyInfo).ContactPersonInfo?.SaveImage();
            }
        }

    }
}
