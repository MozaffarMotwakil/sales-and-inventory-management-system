using System;
using DataAccess;
using DTOs;

namespace BusinessLogic
{
    public class clsCountry
    {
        public byte CountryID { get; set; }
        public string CountryName { get; set; }

        private clsCountry(clsCountryDTO countryDTO)
        {
            CountryID = countryDTO.CountryID;
            CountryName = countryDTO.CountryName;
        }

        public static clsCountry Find(byte countryID)
        {
            clsCountryDTO countryDTO = clsCountryData.FindCountryByID(countryID);
            return countryDTO is null ? null : new clsCountry(countryDTO);
        }

    }
}
