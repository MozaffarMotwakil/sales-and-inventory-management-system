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
            this.ContactPersonInfo = clsPerson.FindByPersonID(organizationDTO.ContactPersonID);
        }

        public static clsOrganization FindByPartyID(int partyID)
        {
            clsOrganizationDTO organizationDTO = clsOrganizationData.FindOrganizationByPartyID(partyID);
            return organizationDTO is null ? null : new clsOrganization(organizationDTO);
        }

        public void ChangeContactPersonInfo(clsPerson newContactPersonInfo)
        {
            if (newContactPersonInfo is null)
            {
                return;
            }

            ContactPersonInfo.PartyName = newContactPersonInfo.PartyName;
            ContactPersonInfo.CountryInfo.CountryID = newContactPersonInfo.CountryInfo.CountryID;
            ContactPersonInfo.CountryInfo.CountryName = newContactPersonInfo.CountryInfo.CountryName;
            ContactPersonInfo.Phone = newContactPersonInfo.Phone;
            ContactPersonInfo.Email = newContactPersonInfo.Email;
            ContactPersonInfo.Address = newContactPersonInfo.Address;
            ContactPersonInfo.NationalNa = newContactPersonInfo.NationalNa;
            ContactPersonInfo.BirthDate = newContactPersonInfo.BirthDate;
            ContactPersonInfo.Gender = newContactPersonInfo.Gender;
            ContactPersonInfo.ImagePath = newContactPersonInfo.ImagePath;
        }

        public void RemoveContactPerson()
        {
            ContactPersonInfo = null;
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
