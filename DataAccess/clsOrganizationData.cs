using System;
using DTOs;
using System.Data.SqlClient;

namespace DataAccess
{
    public static class clsOrganizationData
    {
        public static clsOrganizationDTO FindOrganizationByPartyID(int partyID)
        {
            clsOrganizationDTO organizationDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetOrganizationByPartyID", connection)
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
                            organizationDTO = new clsOrganizationDTO
                            {
                                PartyID = partyID,
                                PartyName = reader["PartyName"].ToString(),
                                PartyCategoryID = Convert.ToByte(reader["PartyCategoryID"]),
                                CountryID = Convert.ToByte(reader["CountryID"]),
                                Phone = reader["Phone"].ToString(),
                                Email = (reader["Email"] != DBNull.Value) ? reader["Email"].ToString() : string.Empty,
                                Address = (reader["Address"] != DBNull.Value) ? reader["Address"].ToString() : string.Empty,
                                ContactPersonID = (reader["ContactPersonID"] != DBNull.Value) ? Convert.ToInt32(reader["ContactPersonID"]) : -1
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error find organization by party ID.", ex);
                }
            }

            return organizationDTO;
        }

    }
}
