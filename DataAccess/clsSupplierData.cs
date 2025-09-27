using System;
using System.Data;
using System.Data.SqlClient;
using DTOs;

namespace DataAccess
{
    public static class clsSupplierData
    {
        public static clsSupplierDTO FindSupplierByID(int supplierID)
        {
            clsSupplierDTO supplierDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetSupplierByID", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@SupplierID", supplierID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            supplierDTO = new clsSupplierDTO
                            {
                                SupplierID = supplierID,
                                PartyID = Convert.ToInt32(reader["PartyID"]),
                                PartyCategoryID = Convert.ToByte(reader["PartyCategoryID"]),
                                Notes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : string.Empty,
                                IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                            };

                            if (reader["UpdatedByUserID"] == DBNull.Value)
                            {
                                supplierDTO.UpdatedByUserID = null;
                            }
                            else
                            {
                                supplierDTO.UpdatedByUserID = Convert.ToInt32(reader["UpdatedByUserID"]);
                            }

                            if (reader["UpdatedAt"] == DBNull.Value)
                            {
                                supplierDTO.UpdatedAt = null;
                            }
                            else
                            {
                                supplierDTO.UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error find supplier by ID.", ex);
                }
            }

            return supplierDTO;
        }

        public static clsSupplierDTO FindSupplierByName(string supplierName)
        {
            clsSupplierDTO supplierDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetSupplierByName", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@SupplierName", supplierName);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            supplierDTO = new clsSupplierDTO
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                PartyID = Convert.ToInt32(reader["PartyID"]),
                                PartyCategoryID = Convert.ToByte(reader["PartyCategoryID"]),
                                Notes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : string.Empty,
                                IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                            };

                            if (reader["UpdatedByUserID"] == DBNull.Value)
                            {
                                supplierDTO.UpdatedByUserID = null;
                            }
                            else
                            {
                                supplierDTO.UpdatedByUserID = Convert.ToInt32(reader["UpdatedByUserID"]);
                            }

                            if (reader["UpdatedAt"] == DBNull.Value)
                            {
                                supplierDTO.UpdatedAt = null;
                            }
                            else
                            {
                                supplierDTO.UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error find supplier by name.", ex);
                }
            }

            return supplierDTO;
        }

        public static DataTable GetAllSuppliers()
        {
            DataTable suppliers = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM vw_SuppliersDetails ORDER BY SupplierID DESC", connection);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            suppliers = new DataTable();
                            suppliers.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error get all suppliers.", ex);
                }
            }

            return suppliers;
        }

        public static DataTable GetAllSupplierNames()
        {
            DataTable suppliers = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetAllSupplierNames", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            suppliers = new DataTable();
                            suppliers.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error get all supplier names.", ex);
                }
            }

            return suppliers;
        }

        public static bool AddSupplier(clsPartyDTO originalPartyDTO, clsSupplierDTO supplierDTO, clsPersonDTO contactPersonDTO = null)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_InsertSupplier", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Original Party
                    command.Parameters.AddWithValue("SupplierName", originalPartyDTO.PartyName);
                    command.Parameters.AddWithValue("SupplierCategoryID", originalPartyDTO.PartyCategoryID);
                    command.Parameters.AddWithValue("SupplierCountryID", originalPartyDTO.CountryID);
                    command.Parameters.AddWithValue("SupplierPhone", originalPartyDTO.Phone);
                    command.Parameters.AddWithValue("SupplierEmail",
                        string.IsNullOrWhiteSpace(originalPartyDTO.Email) ? DBNull.Value : (object)originalPartyDTO.Email);
                    command.Parameters.AddWithValue("@SupplierAddress", 
                        string.IsNullOrWhiteSpace(originalPartyDTO.Address) ? DBNull.Value : (object)originalPartyDTO.Address);

                    // Original Party is a person. 
                    clsPersonDTO orginalPersonDTO = originalPartyDTO as clsPersonDTO;
                    command.Parameters.AddWithValue("@SupplierNationalNa",
                        string.IsNullOrWhiteSpace(orginalPersonDTO?.NationalNa) ? DBNull.Value : (object)orginalPersonDTO?.NationalNa);
                    command.Parameters.AddWithValue("@SupplierBirthDate", (object)orginalPersonDTO?.BirthDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SupplierGender", (object)orginalPersonDTO?.Gender ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SupplierImagePath",
                        string.IsNullOrWhiteSpace(orginalPersonDTO?.ImagePath) ? DBNull.Value : (object)orginalPersonDTO?.ImagePath);

                    // Contact Person details when original party is a organization.
                    command.Parameters.AddWithValue("@ContactPersonName", (object)contactPersonDTO?.PartyName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonCountryID", (object)contactPersonDTO?.CountryID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonPhone", (object)contactPersonDTO?.Phone ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonEmail", 
                        string.IsNullOrWhiteSpace(contactPersonDTO?.Email) ? DBNull.Value : (object)contactPersonDTO?.Email);
                    command.Parameters.AddWithValue("@ContactPersonAddress", 
                        string.IsNullOrWhiteSpace(contactPersonDTO?.Address) ? DBNull.Value : (object)contactPersonDTO?.Address);
                    command.Parameters.AddWithValue("@ContactPersonNationalNa",
                        string.IsNullOrWhiteSpace(contactPersonDTO?.NationalNa) ? DBNull.Value : (object)contactPersonDTO?.NationalNa);
                    command.Parameters.AddWithValue("@ContactPersonBirthDate", (object)contactPersonDTO?.BirthDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonGender", (object)contactPersonDTO?.Gender ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonImagePath",
                        string.IsNullOrWhiteSpace(contactPersonDTO?.ImagePath) ? DBNull.Value : (object)contactPersonDTO?.ImagePath);

                    // Supplier
                    command.Parameters.AddWithValue("@SupplierNotes",
                        string.IsNullOrWhiteSpace(supplierDTO?.Notes) ? DBNull.Value : (object)supplierDTO?.Notes);
                    command.Parameters.AddWithValue("@CreatedByUserID", supplierDTO.CreatedByUserID);

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding supplier to database.", ex);
                    }
                }
            }
        }

        public static bool UpdateSupplier(clsPartyDTO originalPartyDTO, clsSupplierDTO supplierDTO, clsPersonDTO contactPersonDTO = null)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_UpdateSupplier", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Original Party
                    command.Parameters.AddWithValue("SupplierID", supplierDTO.SupplierID);
                    command.Parameters.AddWithValue("SupplierName", originalPartyDTO.PartyName);
                    command.Parameters.AddWithValue("SupplierCountryID", originalPartyDTO.CountryID);
                    command.Parameters.AddWithValue("SupplierPhone", originalPartyDTO.Phone);
                    command.Parameters.AddWithValue("SupplierEmail",
                        string.IsNullOrWhiteSpace(originalPartyDTO.Email) ? DBNull.Value : (object)originalPartyDTO.Email);
                    command.Parameters.AddWithValue("@SupplierAddress",
                        string.IsNullOrWhiteSpace(originalPartyDTO.Address) ? DBNull.Value : (object)originalPartyDTO.Address);

                    // Original Party is a person. 
                    clsPersonDTO orginalPersonDTO = originalPartyDTO as clsPersonDTO;
                    command.Parameters.AddWithValue("@SupplierNationalNa",
                        string.IsNullOrWhiteSpace(orginalPersonDTO?.NationalNa) ? DBNull.Value : (object)orginalPersonDTO?.NationalNa);
                    command.Parameters.AddWithValue("@SupplierBirthDate", (object)orginalPersonDTO?.BirthDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SupplierGender", (object)orginalPersonDTO?.Gender ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SupplierImagePath",
                        string.IsNullOrWhiteSpace(orginalPersonDTO?.ImagePath) ? DBNull.Value : (object)orginalPersonDTO?.ImagePath);

                    // Contact Person details when original party is a organization.
                    command.Parameters.AddWithValue("@ContactPersonName", (object)contactPersonDTO?.PartyName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonCountryID", (object)contactPersonDTO?.CountryID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonPhone", (object)contactPersonDTO?.Phone ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonEmail",
                        string.IsNullOrWhiteSpace(contactPersonDTO?.Email) ? DBNull.Value : (object)contactPersonDTO?.Email);
                    command.Parameters.AddWithValue("@ContactPersonAddress",
                        string.IsNullOrWhiteSpace(contactPersonDTO?.Address) ? DBNull.Value : (object)contactPersonDTO?.Address);
                    command.Parameters.AddWithValue("@ContactPersonNationalNa",
                        string.IsNullOrWhiteSpace(contactPersonDTO?.NationalNa) ? DBNull.Value : (object)contactPersonDTO?.NationalNa);
                    command.Parameters.AddWithValue("@ContactPersonBirthDate", (object)contactPersonDTO?.BirthDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonGender", (object)contactPersonDTO?.Gender ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonImagePath",
                        string.IsNullOrWhiteSpace(contactPersonDTO?.ImagePath) ? DBNull.Value : (object)contactPersonDTO?.ImagePath);

                    // Supplier
                    command.Parameters.AddWithValue("@SupplierNotes",
                        string.IsNullOrWhiteSpace(supplierDTO?.Notes) ? DBNull.Value : (object)supplierDTO?.Notes);
                    command.Parameters.AddWithValue("@UpdatedByUserID", supplierDTO.UpdatedByUserID);

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error updating supplier to database.", ex);
                    }
                }
            }
        }

        public static bool DeleteSupplier(int supplierID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                string query = @"usp_DeleteSupplier";

                SqlCommand command = new SqlCommand(query, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@SupplierID", supplierID);

                try
                {
                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error delete a supplier.", ex);
                }
            }
        }

    }
}
