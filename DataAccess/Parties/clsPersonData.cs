using System;
using System.Data.SqlClient;
using DTOs.Parties;

namespace DataAccess.Parties
{
    public static class clsPersonData
    {
        public static clsPersonDTO FindPersonByPartyID(int partyID)
        {
            return FindPerson(
                "usp_GetPersonByPartyID",
                "@PartyID",
                partyID,
                "Error find person by party ID."
                );
        }

        public static clsPersonDTO FindPersonByPersonID(int personID)
        {
            return FindPerson(
                "usp_GetPersonByPersonID", 
                "@PersonID",
                personID,
                "Error find person by person ID."
                );
        }

        public static bool IsNationalNaExists(string nationalNa)
        {
            return clsDataSettings.IsExists(
                "usp_IsNationalNaExists",
                "@NationalNa",
                nationalNa,
                "Error checking NationalNa existence."
                );
        }

        private static clsPersonDTO FindPerson<T>(string storedProcedureName, string parameterName, T parameterValue, string exceptionMessage)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(parameterName, parameterValue);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsPersonDTO personDTO = null;

                            if (reader.Read())
                            {
                                personDTO = new clsPersonDTO
                                {
                                    PartyID = Convert.ToInt32(reader["PartyID"]),
                                    PersonID = Convert.ToInt32(reader["PersonID"]),
                                    PartyName = reader["PartyName"].ToString(),
                                    PartyCategoryID = Convert.ToByte(reader["PartyCategoryID"]),
                                    CountryID = Convert.ToByte(reader["CountryID"]),
                                    Phone = reader["Phone"].ToString(),
                                    Email = (reader["Email"] != DBNull.Value) ? reader["Email"].ToString() : string.Empty,
                                    Address = (reader["Address"] != DBNull.Value) ? reader["Address"].ToString() : string.Empty,
                                    NationalNa = (reader["NationalNa"] != DBNull.Value) ? reader["NationalNa"].ToString() : string.Empty,
                                    BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                    Gender = Convert.ToByte((reader["Gender"])),
                                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? reader["ImagePath"].ToString() : string.Empty
                                };
                            }

                            return personDTO;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException(exceptionMessage, ex);
                    }
                }
            }
        }

    }
}
