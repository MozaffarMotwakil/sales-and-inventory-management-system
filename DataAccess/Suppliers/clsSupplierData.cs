using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Suppliers;

namespace DataAccess.Suppliers
{
    public static class clsSupplierData
    {
        public static clsSupplierDTO FindSupplierByID(int supplierID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_GetSupplierByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SupplierID", supplierID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsSupplierDTO supplierDTO = null;

                            if (reader.Read())
                            {
                                supplierDTO = new clsSupplierDTO
                                {
                                    SupplierID = supplierID,
                                    PartyID = Convert.ToInt32(reader["PartyID"]),
                                    SupplierCategoryID = Convert.ToByte(reader["PartyCategoryID"]),
                                    SupplierNotes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : string.Empty,
                                    IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                                };

                                supplierDTO.UpdatedByUserID = reader["UpdatedByUserID"] == DBNull.Value ?
                                    supplierDTO.UpdatedByUserID = null :
                                    Convert.ToInt32(reader["UpdatedByUserID"]);

                                supplierDTO.UpdatedAt = reader["UpdatedAt"] == DBNull.Value ?
                                    supplierDTO.UpdatedAt = null :
                                    Convert.ToDateTime(reader["UpdatedAt"]);
                            }

                            return supplierDTO;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException($"Error find supplier by ID.", ex);
                    }
                }
            }
        }

        public static clsSupplierDTO FindSupplierByName(string supplierName)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_GetSupplierByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SupplierName", supplierName);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsSupplierDTO supplierDTO = null;

                            if (reader.Read())
                            {
                                supplierDTO = new clsSupplierDTO
                                {
                                    SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                    PartyID = Convert.ToInt32(reader["PartyID"]),
                                    SupplierCategoryID = Convert.ToByte(reader["PartyCategoryID"]),
                                    SupplierNotes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : string.Empty,
                                    IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                                };

                                supplierDTO.UpdatedByUserID = reader["UpdatedByUserID"] == DBNull.Value ?
                                    supplierDTO.UpdatedByUserID = null :
                                    Convert.ToInt32(reader["UpdatedByUserID"]);

                                supplierDTO.UpdatedAt = reader["UpdatedAt"] == DBNull.Value ?
                                    supplierDTO.UpdatedAt = null :
                                    Convert.ToDateTime(reader["UpdatedAt"]);
                            }

                            return supplierDTO;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException($"Error find supplier by name.", ex);
                    }
                }
            }
        }

        public static DataTable GetAllSuppliers()
        {
            return clsDataSettings.GetDataTable("usp_GetAllSuppliers", "Error get all suppliers.");
        }

        public static DataTable GetAllSupplierNames()
        {
            return clsDataSettings.GetDataTable("usp_GetAllSupplierNames", "Error get all supplier names.");
        }

        public static bool AddSupplier(clsSupplierDTO supplierDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_InsertSupplier", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SupplierName", supplierDTO.SupplierName);
                    command.Parameters.AddWithValue("@SupplierCategoryID", supplierDTO.SupplierCategoryID);
                    command.Parameters.AddWithValue("@SupplierCountryID", supplierDTO.SupplierCountryID);
                    command.Parameters.AddWithValue("@SupplierPhone", supplierDTO.SupplierPhone);
                    command.Parameters.AddWithValue("@SupplierEmail", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierEmail));
                    command.Parameters.AddWithValue("@SupplierAddress", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierAddress));

                    // 2. Original Party is a person.
                    command.Parameters.AddWithValue("@SupplierNationalNa", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierNationalNa));
                    command.Parameters.AddWithValue("@SupplierBirthDate", clsDataSettings.GetDBNullIfNull(supplierDTO.SupplierBirthDate));
                    command.Parameters.AddWithValue("@SupplierGender", clsDataSettings.GetDBNullIfNull(supplierDTO.SupplierGender));
                    command.Parameters.AddWithValue("@SupplierImagePath", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierImagePath));

                    // 3. Contact Person details when original party is an organization.
                    command.Parameters.AddWithValue("@ContactPersonName", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonName));
                    command.Parameters.AddWithValue("@ContactPersonCountryID", clsDataSettings.GetDBNullIfNull(supplierDTO.ContactPersonCountryID));
                    command.Parameters.AddWithValue("@ContactPersonPhone", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonPhone));
                    command.Parameters.AddWithValue("@ContactPersonEmail", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonEmail));
                    command.Parameters.AddWithValue("@ContactPersonAddress", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonAddress));
                    command.Parameters.AddWithValue("@ContactPersonNationalNa", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonNationalNa));
                    command.Parameters.AddWithValue("@ContactPersonBirthDate", clsDataSettings.GetDBNullIfNull(supplierDTO.ContactPersonBirthDate));
                    command.Parameters.AddWithValue("@ContactPersonGender", clsDataSettings.GetDBNullIfNull(supplierDTO.ContactPersonGender));
                    command.Parameters.AddWithValue("@ContactPersonImagePath", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonImagePath));

                    // 4. Supplier specific
                    command.Parameters.AddWithValue("@SupplierNotes", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierNotes));
                    command.Parameters.AddWithValue("@CreatedByUserID", clsDataSettings.GetDBNullIfNull(supplierDTO.CreatedByUserID));

                    // 5. Output Parameters
                    SqlParameter paramSupplierID = command.Parameters.Add("@SupplierID", SqlDbType.Int);
                    paramSupplierID.Direction = ParameterDirection.Output;
                    SqlParameter paramPartyID = command.Parameters.Add("@PartyID", SqlDbType.Int);
                    paramPartyID.Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            supplierDTO.SupplierID = (int)paramSupplierID.Value;
                            supplierDTO.PartyID = (int)paramPartyID.Value;
                        }

                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding supplier to database.", ex);
                    }
                }
            }
        }

        public static bool UpdateSupplier(clsSupplierDTO supplierDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_UpdateSupplier", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Original Party
                    command.Parameters.AddWithValue("SupplierID", supplierDTO.SupplierID);
                    command.Parameters.AddWithValue("@SupplierName", supplierDTO.SupplierName);
                    command.Parameters.AddWithValue("@SupplierCountryID", supplierDTO.SupplierCountryID);
                    command.Parameters.AddWithValue("@SupplierPhone", supplierDTO.SupplierPhone);
                    command.Parameters.AddWithValue("@SupplierEmail", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierEmail));
                    command.Parameters.AddWithValue("@SupplierAddress", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierAddress));

                    // 2. Original Party is a person.
                    command.Parameters.AddWithValue("@SupplierNationalNa", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierNationalNa));
                    command.Parameters.AddWithValue("@SupplierBirthDate", clsDataSettings.GetDBNullIfNull(supplierDTO.SupplierBirthDate));
                    command.Parameters.AddWithValue("@SupplierGender", clsDataSettings.GetDBNullIfNull(supplierDTO.SupplierGender));
                    command.Parameters.AddWithValue("@SupplierImagePath", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierImagePath));

                    // 3. Contact Person details when original party is an organization.
                    command.Parameters.AddWithValue("@ContactPersonName", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonName));
                    command.Parameters.AddWithValue("@ContactPersonCountryID", clsDataSettings.GetDBNullIfNull(supplierDTO.ContactPersonCountryID));
                    command.Parameters.AddWithValue("@ContactPersonPhone", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonPhone));
                    command.Parameters.AddWithValue("@ContactPersonEmail", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonEmail));
                    command.Parameters.AddWithValue("@ContactPersonAddress", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonAddress));
                    command.Parameters.AddWithValue("@ContactPersonNationalNa", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonNationalNa));
                    command.Parameters.AddWithValue("@ContactPersonBirthDate", clsDataSettings.GetDBNullIfNull(supplierDTO.ContactPersonBirthDate));
                    command.Parameters.AddWithValue("@ContactPersonGender", clsDataSettings.GetDBNullIfNull(supplierDTO.ContactPersonGender));
                    command.Parameters.AddWithValue("@ContactPersonImagePath", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.ContactPersonImagePath));

                    // 4. Supplier specific
                    command.Parameters.AddWithValue("@SupplierNotes", clsDataSettings.GetDBNullIfNullOrEmpty(supplierDTO.SupplierNotes));
                    command.Parameters.AddWithValue("@UpdatedByUserID", clsDataSettings.GetDBNullIfNull(supplierDTO.CreatedByUserID));

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
            return clsDataSettings.DeleteRecord("usp_DeleteSupplier", "@SupplierID", supplierID, "Error delete a supplier.");
        }

    }
}
