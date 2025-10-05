using System;
using System.Data;
using DataAccess.Suppliers;
using BusinessLogic.Users;
using BusinessLogic.Parties;
using BusinessLogic.Validation;
using DTOs.Suppliers;
using static BusinessLogic.Parties.clsParty;

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

        public class SupplierDeletedEventArgs : EventArgs
        {
            public int? SupplierID { get; }
            public string SupplierName { get; }
            public DateTime Timestamp { get; }
            public int UserID { get; }

            public SupplierDeletedEventArgs(clsSupplier deletedSupplier)
            {
                SupplierID = deletedSupplier.SupplierID;
                SupplierName = deletedSupplier.PartyInfo.PartyName;
                Timestamp = DateTime.Now;
                UserID = clsAppSettings.CurrentUser.UserID;
            }
        }

        public static event EventHandler<SupplierDeletedEventArgs> SupplierDeleted;
        
        protected static void OnSupplierDeleted(clsSupplier deletedSupplier)
        {
            SupplierDeleted?.Invoke(null, new SupplierDeletedEventArgs(deletedSupplier));
        }

        public int? SupplierID { get; private set; }
        public clsParty PartyInfo { get; }
        public string Notes { get; set; }
        public bool IsDeleted { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; private set; }
        public DateTime? UpdatedAt { get; }
        private enMode _Mode { get; set; }

        public clsSupplier(clsParty party, string notes)
        {
            this.SupplierID = null;
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
            PartyInfo = clsPartyFactory.GetFromDB(
                supplierDTO.PartyID ?? -1,
                (enPartyCategory)supplierDTO.SupplierCategoryID
                );
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
            if (supplierID < 1)
            {
                return null;
            }

            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByID(supplierID);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public static clsSupplier Find(string supplierName)
        {
            if (string.IsNullOrWhiteSpace(supplierName))
            {
                return null;
            }

            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByName(supplierName);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public static bool Delete(int supplierID)
        {
            if (supplierID < 1)
            {
                return false;
            }

            clsSupplier supplier = Find(supplierID);

            bool isDeleted = clsSupplierData.DeleteSupplier(supplierID);

            if (isDeleted)
            {
                if (supplier.PartyInfo is clsPerson person)
                {
                    person.DeleteImage();
                }
                else if (supplier.PartyInfo is clsOrganization organization)
                {
                    organization.ContactPersonInfo?.DeleteImage();
                }

                OnSupplierDeleted(supplier);
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

        public void ChangeInfo(clsParty partyInfo, string notes)
        {
            switch (this.PartyInfo.PartyCategory)
            {
                case clsParty.enPartyCategory.Person:
                    ((clsPerson)this.PartyInfo).ChangePersonInfo((clsPerson)partyInfo);
                    break;
                case clsParty.enPartyCategory.Organization:
                    ((clsOrganization)this.PartyInfo).ChangeOrganizaionInfo((clsOrganization)partyInfo);
                    break;
            }

            this.Notes = notes;
        }

        public clsValidationResult Save()
        {
            clsValidationResult result = this.Validated();

            if (!result.IsValid)
            {
                return result;
            }

            if (this._Mode is enMode.Update)
            {
                this.UpdatedByUserInfo = clsAppSettings.CurrentUser;
            }

            return _ExecuteSaving(this.MappingToDTO(), this._Mode, result);
        }

        private clsValidationResult _ExecuteSaving(clsSupplierDTO supplierDTO, enMode mode, clsValidationResult validationResult)
        {
            _HandlePersonImageSaving();

            bool isSaved = mode is enMode.Add ?
                clsSupplierData.AddSupplier(supplierDTO) :
                clsSupplierData.UpdateSupplier(supplierDTO);

            if (isSaved)
            {
                if (this._Mode is enMode.Add)
                {
                    this.SupplierID = supplierDTO.SupplierID;
                }

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
            return new clsSupplierDTO(
                this.PartyInfo.MappingToDTO(),
                this.SupplierID,
                this.Notes.Trim(),
                this.IsDeleted,
                this.CreatedByUserInfo.UserID,
                this.CreatedAt,
                this.UpdatedByUserInfo?.UserID,
                this.UpdatedAt
                );
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