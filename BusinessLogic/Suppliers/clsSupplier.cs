using System;
using System.Data;
using System.IO;
using DataAccess.Suppliers;
using BusinessLogic.Users;
using BusinessLogic.Parties;
using BusinessLogic.Validation;
using DTOs.Suppliers;

namespace BusinessLogic.Suppliers
{
    public class clsSupplier
    {
        public class SupplierSavedEventArgs : EventArgs
        {
            public clsSupplier SavedSupplier { get; }
            public enMode OperationMode { get; }
            public DateTime Timestamp { get; }
            public int UserID { get; }

            public SupplierSavedEventArgs(clsSupplier savedSupplier)
            {
                SavedSupplier = savedSupplier;
                OperationMode = savedSupplier._Mode;
                Timestamp = DateTime.Now;
                UserID = clsAppSettings.CurrentUser.UserID;
            }
        }

        public static event EventHandler<SupplierSavedEventArgs> SupplierSaved;

        protected virtual void OnSupplierSaved(clsSupplier savedSupplier)
        {
            SupplierSaved?.Invoke(this, new SupplierSavedEventArgs(savedSupplier));
        }

        public static event Action SupplierDeleted;
        
        protected static void OnSupplierDeleted()
        {
            SupplierDeleted?.Invoke();
        }

        public int SupplierID { get; }
        public clsParty PartyInfo { get; }
        public string Notes { get; set; }
        public bool IsDeleted { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; private set; }
        public DateTime? UpdatedAt { get; }
        private enMode _Mode { get; set; }

        public clsSupplier(clsParty party, string notes)
        {
            this.SupplierID = -1;
            this.PartyInfo = party;
            this.Notes = notes;
            this.IsDeleted = false;
            this.CreatedByUserInfo = clsAppSettings.CurrentUser;
            this.UpdatedByUserInfo = clsAppSettings.CurrentUser;
            this._Mode = enMode.Add;
        }

        private clsSupplier(clsSupplierDTO supplierDTO)
        {
            SupplierID = supplierDTO.SupplierID;
            PartyInfo = supplierDTO.SupplierCategoryID == 1 ?
                clsPerson.FindByPartyID(supplierDTO.PartyID) :
                (clsParty)clsOrganization.FindByPartyID(supplierDTO.PartyID);
            Notes = supplierDTO.SupplierNotes;
            IsDeleted = supplierDTO.IsDeleted;
            CreatedByUserInfo = new clsUser(1);
            CreatedAt = supplierDTO.CreatedAt;
            UpdatedByUserInfo = new clsUser(1);
            UpdatedAt = supplierDTO.UpdatedAt;
            this._Mode = enMode.Update;
        }

        public static clsSupplier Find(int supplierID)
        {
            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByID(supplierID);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public static clsSupplier Find(string supplierName)
        {
            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByName(supplierName);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public static bool Delete(int supplierID)
        {
            string imagePath = string.Empty;
            clsSupplier supplier = Find(supplierID);

            if (supplier.PartyInfo is clsPerson person)
            {
                imagePath = person.ImagePath;
            }

            bool isDeleted = clsSupplierData.DeleteSupplier(supplierID);

            if (isDeleted)
            {
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }

                OnSupplierDeleted();
            }

            return isDeleted;
        }

        public static DataTable GetAllSuppliers()
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

        public clsValidationResult Save()
        {
            clsValidationResult result = this.Validated();

            if (!result.IsValid)
            {
                return result;
            }

            switch (this._Mode)
            {
                case enMode.Add:
                    return _ExecuteOperation(this.MappingToDTO(), this._Mode, result);
                case enMode.Update:
                    this.UpdatedByUserInfo = clsAppSettings.CurrentUser;
                    return _ExecuteOperation(this.MappingToDTO(), this._Mode, result);
                default:
                    result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                    return result;
            }
        }

        private clsValidationResult _ExecuteOperation(clsSupplierDTO supplierDTO, enMode mode, clsValidationResult validationResult)
        {
            _HandlePersonImageSaving();

            bool isSaved = mode is enMode.Add ?
                clsSupplierData.AddSupplier(this.MappingToDTO()) :
                clsSupplierData.UpdateSupplier(this.MappingToDTO());

            if (isSaved)
            {
                OnSupplierSaved(this);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }

        private void _HandlePersonImageSaving()
        {
            clsPerson person;

            if (this.PartyInfo.PartyCategory == clsParty.enPartyCategory.Person)
            {
                person = this.PartyInfo as clsPerson;
                person.SaveImage();
            }
            else
            {
                if (((clsOrganization)this.PartyInfo).ContactPersonInfo != null)
                {
                    person = ((clsOrganization)this.PartyInfo).ContactPersonInfo;
                    person.SaveImage();
                }
            }
        }

        public clsSupplierDTO MappingToDTO()
        {
            if (this.PartyInfo.PartyCategory == clsParty.enPartyCategory.Person)
            {
                return new clsSupplierDTO(
                    this.SupplierID,
                    this.PartyInfo.PartyName,
                    (byte)this.PartyInfo.PartyCategory,
                    this.PartyInfo.CountryInfo.CountryID,
                    this.PartyInfo.Phone,
                    this.PartyInfo.Email,
                    this.PartyInfo.Address,
                    ((clsPerson)this.PartyInfo).NationalNa,
                    ((clsPerson)this.PartyInfo).BirthDate,
                    (byte)((clsPerson)this.PartyInfo).Gender,
                    ((clsPerson)this.PartyInfo).ImagePath,
                    null, null, null, null, null, null, null, null, null,
                    this.Notes,
                    this.IsDeleted,
                    this.CreatedByUserInfo.UserID,
                    this.CreatedAt,
                    this.UpdatedByUserInfo?.UserID,
                    this.UpdatedAt,
                    this.PartyInfo.PartyID,
                    ((clsPerson)this.PartyInfo).PersonID,
                    null, null, null
                );
            }
            else
            {
                return new clsSupplierDTO(
                    this.SupplierID,
                    this.PartyInfo.PartyName,
                    (byte)this.PartyInfo.PartyCategory,
                    this.PartyInfo.CountryInfo.CountryID,
                    this.PartyInfo.Phone,
                    this.PartyInfo.Email,
                    this.PartyInfo.Address,
                    null, null, null, null,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.PartyName,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.CountryInfo?.CountryID,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.Phone,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.Email,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.NationalNa,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.Address,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.BirthDate,
                    (byte?)((clsOrganization)this.PartyInfo).ContactPersonInfo?.Gender,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.ImagePath,
                    this.Notes,
                    this.IsDeleted,
                    this.CreatedByUserInfo.UserID,
                    this.CreatedAt,
                    this.UpdatedByUserInfo?.UserID,
                    this.UpdatedAt,
                    this.PartyInfo.PartyID,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.PersonID,
                    ((clsOrganization)this.PartyInfo).OrganizationID,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.PersonID,
                    ((clsOrganization)this.PartyInfo).ContactPersonInfo?.PartyID
                );
            }
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (PartyInfo is null)
            {
                validationResult.AddError("الكيان الأساسي", "لا يمكن أن يكون الكيان الأساسي بدون مرجع");
            }
            else
            {
                validationResult = PartyInfo.Validated();
            }

            return validationResult;
        }

    }
}