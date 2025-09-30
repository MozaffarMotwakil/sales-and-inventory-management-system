using DataAccess.Parties;
using DTOs.Parties;

namespace BusinessLogic.Parties
{
    public class clsCountry
    {
        public byte CountryID { get; }
        public string CountryName { get; }

        public const int DEFAULT_COUNTRY_ID = 164;

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
