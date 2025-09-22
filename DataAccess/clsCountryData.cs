using System;
using System.Data.SqlClient;
using DTOs;

namespace DataAccess
{
    public static class clsCountryData
    {
        public static clsCountryDTO FindCountryByID(byte countryID)
        {
            clsCountryDTO countryDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                string query = @"SELECT *
                                FROM Countries
                                WHERE CountryID = @CountryID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CountryID", countryID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            countryDTO = new clsCountryDTO();

                            countryDTO.CountryID = countryID;
                            countryDTO.CountryName = reader["CountryName"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error find country by ID in database.", ex);
                }
            }

            return countryDTO;
        }

    }
}
