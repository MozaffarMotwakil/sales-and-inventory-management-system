using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Products;

namespace DataAccess.Products
{
    public static class clsTaxData
    {
        public static clsTaxDTO FindTaxByID(int taxID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Taxes_FindByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TaxID", taxID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsTaxDTO taxDTO = null;

                            if (reader.Read())
                            {
                                taxDTO = new clsTaxDTO
                                {
                                    TaxID = Convert.ToInt32(reader["TaxID"]),
                                    TaxName = Convert.ToString(reader["TaxName"]),
                                    TaxRate = Convert.ToDecimal(reader["TaxRate"]),
                                    Description = Convert.ToString(reader["Description"] == DBNull.Value ? null : reader["Description"]),
                                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                    UpdatedByUserID = reader["UpdatedByUserID"] == DBNull.Value ?
                                        (int?)null :
                                        (int)reader["UpdatedByUserID"],

                                    UpdatedAt = reader["UpdatedAt"] == DBNull.Value ?
                                        (DateTime?)null :
                                        (DateTime)reader["UpdatedAt"]
                                };
                            }

                            return taxDTO;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool AddTax(clsTaxDTO taxDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Taxes_InsertTax", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TaxName", taxDTO.TaxName);
                    command.Parameters.AddWithValue("@TaxRate", taxDTO.TaxRate);
                    command.Parameters.AddWithValue("@Description",  clsDataSettings.GetDBNullIfNullOrEmpty(taxDTO.Description));
                    command.Parameters.AddWithValue("@CreatedByUserID", taxDTO.CreatedByUserID);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool UpdateTax(clsTaxDTO taxDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Taxes_UpdateTax", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TaxID", taxDTO.TaxID);
                    command.Parameters.AddWithValue("@TaxName", taxDTO.TaxName);
                    command.Parameters.AddWithValue("@TaxRate", taxDTO.TaxRate);
                    command.Parameters.AddWithValue("@Description", clsDataSettings.GetDBNullIfNullOrEmpty(taxDTO.Description));
                    command.Parameters.AddWithValue("@UpdatedByUserID", taxDTO.UpdatedByUserID);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool DeleteTax(int taxID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Taxes_DeleteTax",
                "@TaxID",
                taxID
                );
        }


        public static bool SaveTaxItems(int taxID, int linkedByUserID, DataTable items)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Taxes_SaveTaxItems", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TaxID", taxID);
                    command.Parameters.AddWithValue("@LinkedByUserID", linkedByUserID);

                    SqlParameter parameter = command.Parameters.AddWithValue("@Items", items);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "TaxLinkType";

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static DataTable GetAllTaxs()
        {
            return clsDataSettings.GetDataTable(
                "usp_Taxes_GetAllTaxes"
                );
        }

        public static DataTable GetTaxItems(int taxID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Taxes_GetTaxItemsByTaxID",
                "@TaxID",
                taxID
                );
        }

        public static DataTable GetTaxItemsForProduct(int productID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Taxes_GetTaxItemsByProductID",
                "@ProductID",
                productID
                );
        }

        public static bool IsTaxExistsByName(string taxName)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Taxes_IsExistsByName",
                "@TaxName",
                taxName
                );
        }

        public static bool SetActive(int taxID, int updatedByUserID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Taxes_SetActive",
                "@TaxID",
                "@UpdatedByUserID",
                taxID,
                updatedByUserID
                );
        }

        public static bool SetInActive(int taxID, int updatedByUserID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Taxes_SetInActive",
                "@TaxID",
                "@UpdatedByUserID",
                taxID,
                updatedByUserID
                );
        }

    }
}
