using System;

namespace BusinessLogic
{
    public class clsOrganization : clsParty
    {
        public clsPerson ContactPerson { get; set; }

        public clsOrganization (string organizationName, byte countryID,
            string phone, string email, string address, clsPerson contactPerson)
        {
            this.PartyName = organizationName;
            this.PartyCategory = enPartyCatigory.Organization;
            this.CountryID = countryID;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.ContactPerson = contactPerson;
        }

        public override clsValidationResult Validated()
        {
            clsValidationResult orginalPartyValidationResult = base.Validated();

            if (ContactPerson != null)
            {
                clsValidationResult contactPersonValidationResult = ContactPerson.Validated();

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
