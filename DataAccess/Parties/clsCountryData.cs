using System;
using System.Data.SqlClient;
using DTOs.Parties;

namespace DataAccess.Parties
{
    public static class clsCountryData
    {
        public static clsCountryDTO FindCountryByID(byte countryID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_GetCountryByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CountryID", countryID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsCountryDTO countryDTO = null;

                            if (reader.Read())
                            {
                                countryDTO = new clsCountryDTO
                                {
                                    CountryID = countryID,
                                    CountryName = reader["CountryName"].ToString()
                                };
                            }

                            return countryDTO;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error find country by ID in database.", ex);
                    }
                }
            }
        }

    }
}
