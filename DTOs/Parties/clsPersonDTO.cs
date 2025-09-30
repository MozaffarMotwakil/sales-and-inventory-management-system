using System;

namespace DTOs.Parties
{
    public class clsPersonDTO : clsPartyDTO
    {
        public int? PersonID { get; set; }
        public string NationalNa { get; set; }
        public DateTime BirthDate { get; set; }
        public byte? Gender { get; set; }
        public string ImagePath { get; set; }

        public clsPersonDTO() { }

        public clsPersonDTO(int? partyID, string personName, byte partyCategoryID, byte countryID, 
            string phone, string email, string address, int? personID, string nationalNa, DateTime birthDate, byte? gender, string imagePath) :
            base(partyID, personName, partyCategoryID, countryID, phone, email, address)
        {
            PersonID = personID;
            NationalNa = nationalNa;
            BirthDate = birthDate;
            Gender = gender;
            ImagePath = imagePath;
        }

    }
}
