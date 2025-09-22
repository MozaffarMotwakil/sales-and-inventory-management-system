using System;

namespace DTOs
{
    public class clsCountryDTO
    {
        public byte CountryID { get; set; }
        public string CountryName { get; set; }
        
        public clsCountryDTO() { }

        public clsCountryDTO(byte countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

    }
}
