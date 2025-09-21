using System;

namespace DTOs
{
    public class clsPersonDTO : clsPartyDTO
    {
        public string NationalNa { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string ImagePath { get; set; }

        public clsPersonDTO() { }

        public clsPersonDTO(int partyID, string partyName, byte partyCategoryID, byte countryID, 
            string phone, string email, string address, string nationalNa, 
            DateTime birthDate, bool gender, string imagePath)
        {
            PartyID = partyID;
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
