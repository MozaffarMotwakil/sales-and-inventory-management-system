using System;

namespace DTOs.Parties
{
    public class clsPersonDTO : clsPartyDTO
    {
        public int? PersonID { get; set; }
        public string NationalNa { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string ImagePath { get; set; }

        public clsPersonDTO() { }

        public clsPersonDTO(int? partyID, int? personID, string partyName, byte partyCategoryID, byte countryID, 
            string phone, string email, string address, string nationalNa, 
            DateTime birthDate, bool gender, string imagePath)
        {
            PartyID = partyID;
            PersonID = personID;
            PartyName = partyName;
            PartyCategoryID = partyCategoryID;
            CountryID = countryID;
            Phone = phone;
            Email = email;
            Address = address;
            NationalNa = nationalNa;
            BirthDate = birthDate;
            Gender = gender;
            ImagePath = imagePath;
        }
    }
}
