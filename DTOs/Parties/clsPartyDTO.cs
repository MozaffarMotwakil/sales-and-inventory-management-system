using System;

namespace DTOs.Parties
{
    public class clsPartyDTO
    {
        public int? PartyID { get; set; }
        public string PartyName { get; set; }
        public byte PartyCategoryID { get; set; }
        public byte CountryID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public clsPartyDTO() { }

        public clsPartyDTO (int? partyID, string partyName, byte partyCatigoryID, byte countryID, string phone, string email, string address)
        {
            PartyID = partyID;
            PartyName = partyName;
            PartyCategoryID = partyCatigoryID;
            CountryID = countryID;
            Phone = phone;
            Email = email;
            Address = address;
        }

    }
}
