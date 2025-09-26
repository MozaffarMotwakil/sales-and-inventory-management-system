using System;
using System.Data.SqlClient;
using DTOs;

namespace DataAccess
{
    public static class clsPersonData
    {
        public static clsPersonDTO FindPersonByPartyID(int partyID)
        {
            clsPersonDTO personDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetPersonByPartyID", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@PartyID", partyID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personDTO = new clsPersonDTO
                            {
                                PartyID = partyID,
                                PartyName = reader["PartyName"].ToString(),
                                PartyCategoryID = Convert.ToByte(reader["PartyCategoryID"]),
                                CountryID = Convert.ToByte(reader["CountryID"]),
                                Phone = reader["Phone"].ToString(),
                                Email = (reader["Email"] != DBNull.Value) ? reader["Email"].ToString() : string.Empty,
                                Address = (reader["Address"] != DBNull.Value) ? reader["Address"].ToString() : string.Empty,
                                NationalNa = (reader["NationalNa"] != DBNull.Value) ? reader["NationalNa"].ToString() : string.Empty,
                                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                Gender = Convert.ToByte((reader["Gender"])) == 1,
                                ImagePath = (reader["ImagePath"] != DBNull.Value) ? reader["ImagePath"].ToString() : string.Empty
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error find person by party ID.", ex);
                }
            }

            return personDTO;
        }

        public static clsPersonDTO FindPersonByPersonID(int personID)
        {
            clsPersonDTO personDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetPersonByPersonID", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@PersonID", personID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personDTO = new clsPersonDTO
                            {
                                PartyID = personID,
                                PartyName = reader["PartyName"].ToString(),
                                PartyCategoryID = Convert.ToByte(reader["PartyCategoryID"]),
                                CountryID = Convert.ToByte(reader["CountryID"]),
                                Phone = reader["Phone"].ToString(),
                                Email = (reader["Email"] != DBNull.Value) ? reader["Email"].ToString() : string.Empty,
                                Address = (reader["Address"] != DBNull.Value) ? reader["Address"].ToString() : string.Empty,
                                NationalNa = (reader["NationalNa"] != DBNull.Value) ? reader["NationalNa"].ToString() : string.Empty,
                                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                Gender = Convert.ToByte((reader["Gender"])) == 1,
                                ImagePath = (reader["ImagePath"] != DBNull.Value) ? reader["ImagePath"].ToString() : string.Empty
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error find person by party ID.", ex);
                }
            }

            return personDTO;
        }

    }
}
