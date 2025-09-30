using System;

namespace DTOs.Parties
{
    public class clsOrganizationDTO : clsPartyDTO
    {
        public int? OrganizationID { get; set; }
        public int? ContactPersonID { get; set; }
        public int? ContactPersonPartyID { get; set; }
        public string ContactPersonName { get; set; }
        public byte? ContactPersonCountryID { get; set; }
        public string ContactPersonPhone { get; set; }
        public string ContactPersonEmail { get; set; }
        public string ContactPersonAddress { get; set; }
        public string ContactPersonNationalNa { get; set; }
        public DateTime? ContactPersonBirthDate { get; set; }
        public byte? ContactPersonGender { get; set; }
        public string ContactPersonImagePath { get; set; }

        public clsOrganizationDTO() { }

        public clsOrganizationDTO(int? partyID, string organizationName, byte partyCategoryID, byte countryID,
            string phone, string email, string address, int? organizationID, int? contactPersonID, int? contactPersonPartyID,
            string contactPersonName, byte? contactPersonCountryID, string contactPersonPhone, string contactPersonEmail,
            string contactPersonAddress, string contactPersonNationalNa, DateTime? contactPersonBirthDate, 
            byte? contactPersonGender, string contactPersonImagePath) :
            base(partyID, organizationName, partyCategoryID, countryID, phone, email, address)
        {
            OrganizationID = organizationID;
            ContactPersonID = contactPersonID;
            ContactPersonPartyID = contactPersonPartyID;
            ContactPersonName = contactPersonName;
            ContactPersonCountryID = contactPersonCountryID;
            ContactPersonPhone = contactPersonPhone;
            ContactPersonEmail = contactPersonEmail;
            ContactPersonAddress = contactPersonAddress;
            ContactPersonNationalNa = contactPersonNationalNa;
            ContactPersonBirthDate = contactPersonBirthDate;
            ContactPersonGender = contactPersonGender;
            ContactPersonImagePath = contactPersonImagePath;
        }

    }
}