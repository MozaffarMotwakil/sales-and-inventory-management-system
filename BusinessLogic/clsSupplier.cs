using System;
using System.Data;
using DataAccess;
using DTOs;

namespace BusinessLogic
{
    public class clsSupplier
    {
        public class SupplierSavedEventArgs : EventArgs
        {
            public clsSupplier SavedSupplier { get; }
            public DateTime Timestamp { get; }
            public int UserID { get; }

            public SupplierSavedEventArgs(clsSupplier savedSupplier)
            {
                SavedSupplier = savedSupplier;
                Timestamp = DateTime.Now;
                UserID = clsAppSettings.CurrentUser.UserID;
            }
        }

        public static event EventHandler<SupplierSavedEventArgs> SupplierSaved;

        protected virtual void OnSupplierSaved(clsSupplier savedSupplier)
        {
            SupplierSaved?.Invoke(this, new SupplierSavedEventArgs(savedSupplier));
        }

        public int SupplierID { get; }
        public clsParty PartyInfo { get; }
        public string Notes { get; set; }
        public bool IsDeleted { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; }
        public DateTime? UpdatedAt { get; }
        private enMode _Mode { get; set; }

        public clsSupplier(clsParty party, string notes)
        {
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
            PartyInfo = supplierDTO.PartyCategoryID == 1 ?
                clsPerson.FindByPartyID(supplierDTO.PartyID) :
                (clsParty)clsOrganization.FindByPartyID(supplierDTO.PartyID);
            Notes = supplierDTO.Notes;
            IsDeleted = supplierDTO.IsDeleted;
            CreatedByUserInfo = new clsUser(1);
            CreatedAt = supplierDTO.CreatedAt;
            UpdatedByUserInfo = supplierDTO.UpdatedByUserID != null ?
                new clsUser(1) :
                null;
            UpdatedAt = supplierDTO.UpdatedAt;
        }

        public static clsSupplier Find(int supplierID)
        {
            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByID(supplierID);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public static DataTable GetAllSuppliers()
        {
            return clsSupplierData.GetAllSuppliers();
        }

        public clsValidationResult Save()
        {
            clsValidationResult result = this.Validated();

            if (!result.IsValid)
            {
                return result;
            }

            bool isSaved;

            switch (this._Mode)
            {
                case enMode.Add:
                    switch (this.PartyInfo.PartyCategory)
                    {
                        case clsParty.enPartyCategory.Person:
                            clsPerson person = this.PartyInfo as clsPerson;
                            person.SaveImage();

                            isSaved = clsSupplierData.AddSupplier(
                                this.PartyInfo.MappingToDTO(), this.MappingToDTO()
                                );

                            if (!isSaved)
                            {
                                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                                person.DeleteImage();
                            }
                            else
                            {
                                OnSupplierSaved(this);
                            }

                            return result;
                        case clsParty.enPartyCategory.Organization:
                            isSaved = clsSupplierData.AddSupplier(
                                this.PartyInfo.MappingToDTO(), this.MappingToDTO(),
                                (clsPersonDTO)((clsOrganization)PartyInfo).ContactPerson?.MappingToDTO()
                                );

                            if (!isSaved)
                            {
                                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                            }
                            else
                            {
                                OnSupplierSaved(this);
                            }

                            return result;
                        default:
                            return result;
                    }
                case enMode.Update:
                    return result;
                default:
                    return result;
            }
        }

        public clsSupplierDTO MappingToDTO()
        {
            return new clsSupplierDTO(
                this.SupplierID,
                this.PartyInfo.PartyID,
                (byte)this.PartyInfo.PartyCategory,
                this.Notes,
                this.IsDeleted,
                this.CreatedByUserInfo.UserID,
                this.CreatedAt,
                this.UpdatedByUserInfo?.UserID,
                this.UpdatedAt
                );
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult;

            if (PartyInfo is null)
            {
                validationResult = new clsValidationResult();
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
