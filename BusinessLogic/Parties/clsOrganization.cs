using BusinessLogic.Validation;
using DataAccess.Parties;
using DTOs.Parties;

namespace BusinessLogic.Parties
{
    public class clsOrganization : clsParty
    {
        public int? OrganizationID { get; }
        public clsPerson ContactPersonInfo { get; private set; }

        public clsOrganization (string organizationName, byte countryID,
            string phone, string email, string address, clsPerson contactPerson) :
            base(null, organizationName, enPartyCategory.Organization, countryID, phone, email, address)
        {
            this.OrganizationID = null;
            this.ContactPersonInfo = contactPerson;
        }

        private clsOrganization(clsOrganizationDTO organizationDTO) :
            base(organizationDTO.PartyID, organizationDTO.PartyName, enPartyCategory.Organization, organizationDTO.CountryID,
                organizationDTO.Phone, organizationDTO.Email, organizationDTO.Address)
        {
            this.OrganizationID = organizationDTO.OrganizationID;
            this.ContactPersonInfo = clsPerson.FindByPersonID(organizationDTO.ContactPersonID ?? -1);
        }

        public static clsOrganization FindByPartyID(int partyID)
        {
            if (partyID < 1)
            {
                return null;
            }

            clsOrganizationDTO organizationDTO = clsOrganizationData.FindOrganizationByPartyID(partyID);
            return organizationDTO is null ? null : new clsOrganization(organizationDTO);
        }

        public void ChangeOrganizaionInfo(clsOrganization newOrganizationInfo)
        {
            if (newOrganizationInfo is null)
            {
                return;
            }

            PartyName = newOrganizationInfo.PartyName;
            CountryInfo = newOrganizationInfo.CountryInfo;
            Phone = newOrganizationInfo.Phone;
            Email = newOrganizationInfo.Email;
            Address = newOrganizationInfo.Address;

            if (newOrganizationInfo.ContactPersonInfo != null)
            {
                if (ContactPersonInfo != null)
                {
                    // in case updating a contact person information.
                    ContactPersonInfo.ChangePersonInfo(newOrganizationInfo.ContactPersonInfo);
                }
                else
                {
                    // in case adding a new contact person.
                    ContactPersonInfo = newOrganizationInfo.ContactPersonInfo;
                }
            }
            else
            {
                RemoveContactPerson();
            }
        }

        public void RemoveContactPerson()
        {
            ContactPersonInfo.DeleteImage();
            ContactPersonInfo = null;
        }

        public override clsPartyDTO MappingToDTO()
        {
            return new clsOrganizationDTO(
                this.PartyID,
                this.PartyName.Trim(),
                (byte)this.PartyCategory,
                this.CountryInfo.CountryID,
                this.Phone.Trim(),
                this.Email.Trim(),
                this.Address.Trim(),
                this.OrganizationID,
                this.ContactPersonInfo?.PersonID,
                this.ContactPersonInfo?.PartyID,
                this.ContactPersonInfo?.PartyName.Trim(),
                this.ContactPersonInfo?.CountryInfo.CountryID,
                this.ContactPersonInfo?.Phone.Trim(),
                this.ContactPersonInfo?.Email.Trim(),
                this.ContactPersonInfo?.Address.Trim(),
                this.ContactPersonInfo?.NationalNa.Trim(),
                this.ContactPersonInfo?.BirthDate,
                (byte?)this.ContactPersonInfo?.Gender,
                this.ContactPersonInfo?.ImagePath
                );
        }

        public override clsValidationResult Validated()
        {
            clsValidationResult orginalPartyValidationResult = base.Validated();

            if (ContactPersonInfo != null)
            {
                clsValidationResult contactPersonValidationResult = ContactPersonInfo.Validated();

                orginalPartyValidationResult.IsValid &= contactPersonValidationResult.IsValid;

                foreach (var error in contactPersonValidationResult.Errors)
                {
                    orginalPartyValidationResult.AddError(error.FieldName, error.ErrorMessage);
                }
            }

            return orginalPartyValidationResult;
        }

    }
}
