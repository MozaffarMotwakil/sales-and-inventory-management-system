using System;
using System.Net;
using System.Security.Policy;
using DataAccess;
using DTOs;

namespace BusinessLogic
{
    public class clsOrganization : clsParty
    {
        public clsPerson ContactPerson { get; set; }

        public clsOrganization (string organizationName, byte countryID,
            string phone, string email, string address, clsPerson contactPerson)
        {
            this.PartyName = organizationName;
            this.PartyCategory = enPartyCategory.Organization;
            this.CountryInfo = clsCountry.Find(countryID);
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.ContactPerson = contactPerson;
        }

        private clsOrganization(clsOrganizationDTO organizationDTO)
        {
            this.PartyID = organizationDTO.PartyID;
            this.PartyName = organizationDTO.PartyName;
            this.PartyCategory = enPartyCategory.Organization;
            this.CountryInfo = clsCountry.Find(organizationDTO.CountryID);
            this.Phone = organizationDTO.Phone;
            this.Email = organizationDTO.Email;
            this.Address = organizationDTO.Address;
            this.ContactPerson = clsPerson.FindByPersonID(organizationDTO.ContactPersonID);
        }

        public static clsOrganization FindByPartyID(int partyID)
        {
            clsOrganizationDTO organizationDTO = clsOrganizationData.FindOrganizationByPartyID(partyID);
            return organizationDTO is null ? null : new clsOrganization(organizationDTO);
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
