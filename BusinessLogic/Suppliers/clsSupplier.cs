using System;
using BusinessLogic.Users;
using BusinessLogic.Parties;
using BusinessLogic.Validation;
using DTOs.Suppliers;
using static BusinessLogic.Parties.clsParty;

namespace BusinessLogic.Suppliers
{
    public class clsSupplier
    {
        public int? SupplierID { get; private set; }
        public clsParty PartyInfo { get; }
        public string Notes { get; set; }
        public bool IsDeleted { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; private set; }
        public DateTime? UpdatedAt { get; }
        public enMode Mode { get; }

        public clsSupplier(clsParty party, string notes)
        {
            this.SupplierID = null;
            this.PartyInfo = party;
            this.Notes = notes;
            this.IsDeleted = false;
            this.CreatedByUserInfo = clsAppSettings.CurrentUser;
            this.Mode = enMode.Add;
        }

        internal clsSupplier(clsSupplierDTO supplierDTO)
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
            UpdatedByUserInfo = supplierDTO.UpdatedByUserID is null ?
                clsAppSettings.CurrentUser :
                clsUser.Find(supplierDTO.UpdatedByUserID ?? -1); 
            UpdatedAt = supplierDTO.UpdatedAt;
            this.Mode = enMode.Update;
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