using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Interfaces;
using BusinessLogic.Validation;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsTaxService : IEntityListManager<clsTax>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsTaxService _Instance;

        private clsTaxService() { }

        public static clsTaxService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsTaxService();
            }

            return _Instance;
        }

        private void OnTaxSaved(int taxID, string taxName, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(taxID, taxName, mode));
        }

        private void OnTaxDeleted(int taxID, string taxName)
        {
            EntityDeleted?.Invoke(this, new EntityDeletedEventArgs(taxID, taxName));
        }

        public bool MarkAsActive(clsTax tax)
        {
            if (tax.IsActive)
            {
                return true;
            }

            if (tax.Mode == enMode.Update && clsTaxData.SetActive(tax.TaxID ?? -1, clsAppSettings.CurrentUser.UserID))
            {
                OnTaxSaved(tax.TaxID ?? -1, tax.TaxName, enMode.Update);
                return true;
            }

            return false;
        }

        public bool MarkAsInActive(clsTax tax)
        {
            if (!tax.IsActive)
            {
                return true;
            }

            if (tax.Mode == enMode.Update && clsTaxData.SetInActive(tax.TaxID ?? -1, clsAppSettings.CurrentUser.UserID))
            {
                OnTaxSaved(tax.TaxID ?? -1, tax.TaxName, enMode.Update);
                return true;
            }

            return false;
        }

        public clsTax Find(int taxID)
        {
            if (taxID < 1)
            {
                return null;
            }

            clsTaxDTO taxDTO = clsTaxData.FindTaxByID(taxID);
            return taxDTO is null ? null : new clsTax(taxDTO);
        }

        public bool Delete(int taxID)
        {
            if (taxID < 1)
            {
                return false;
            }

            clsTax tax = Find(taxID);

            try
            {
                if (clsTaxData.DeleteTax(taxID))
                {
                    OnTaxDeleted(taxID, tax.TaxName);
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
            return clsTaxData.GetAllTaxs();
        }

        public bool SaveTaxItems(clsTax tax, int linkedByUserID, List<clsTaxItem> taxItems)
        {
            if (clsTaxData.SaveTaxItems(
                tax.TaxID ?? -1,
                linkedByUserID,
                clsTaxItem.ConvertTaxItemsListToTable(taxItems)
                ))
            {
                OnTaxSaved(tax.TaxID ?? -1, tax.TaxName, enMode.Add);
                return true;
            }

            return false;
        }

        public static bool IsTaxExistsByName(string TaxName)
        {
            return clsTaxData.IsTaxExistsByName(TaxName);
        }

        public clsValidationResult Validated(clsTax Tax)
        {
            clsValidationResult validationResult = Tax.Validated();
            clsTax currentProductInDB = Find(Tax.TaxID ?? -1);

            if ((Tax.Mode == enMode.Update && currentProductInDB.TaxName != Tax.TaxName && IsTaxExistsByName(Tax.TaxName)) ||
                (Tax.Mode == enMode.Add && IsTaxExistsByName(Tax.TaxName)))
            {
                validationResult.AddError("إسم الضريبة", "الضريبة موجود بالفعل");
            }

            return validationResult;
        }

        public clsValidationResult Save(clsTax tax)
        {
            clsValidationResult validationResult = Validated(tax);

            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            return _ExecuteSaving(tax.MappingToDTO(), tax.Mode, validationResult);
        }

        private clsValidationResult _ExecuteSaving(clsTaxDTO taxDTO, enMode mode, clsValidationResult validationResult)
        {
            if (mode is enMode.Add)
            {
                taxDTO.CreatedByUserID = clsAppSettings.CurrentUser.UserID;
            }
            else
            {
                taxDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
            }

            bool isSaved = mode is enMode.Add ?
                clsTaxData.AddTax(taxDTO) :
                clsTaxData.UpdateTax(taxDTO);

            if (isSaved)
            {
                OnTaxSaved(taxDTO.TaxID ?? -1, taxDTO.TaxName, mode);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }
    }
}
