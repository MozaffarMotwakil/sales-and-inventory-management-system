using System;
using DataAccess;
using DTOs;

namespace BusinessLogic
{
    public class clsSupplier
    {
        public int SupplierID { get; }
        public clsParty PartyInfo { get; }
        public string Notes { get; set; }
        public bool IsDeleted { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; }
        public DateTime UpdatedAt { get; }
        private enMode _Mode { get; set; }

        public clsSupplier(clsParty party, string notes)
        {
            this.PartyInfo = party;
            this.Notes = notes;
            this.IsDeleted = false;
            this.CreatedByUserInfo = clsAppSettings.CurrentUser;
            this._Mode = enMode.Add;
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
                        case clsParty.enPartyCatigory.Person:
                            isSaved = clsSupplierData.AddSupplier(
                                this.PartyInfo.MappingToDTO(), this.MappingToDTO()
                                );

                            if (!isSaved)
                            {
                                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                            }

                            return result;
                        case clsParty.enPartyCatigory.Organization:
                            isSaved = clsSupplierData.AddSupplier(
                                this.PartyInfo.MappingToDTO(), this.MappingToDTO(),
                                (clsPersonDTO)((clsOrganization)PartyInfo).ContactPerson?.MappingToDTO()
                                );

                            if (!isSaved)
                            {
                                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
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
                this.Notes,
                this.IsDeleted,
                this.CreatedByUserInfo.UserID,
                this.CreatedAt,
                this.UpdatedByUserInfo?.UserID ?? 0,
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
