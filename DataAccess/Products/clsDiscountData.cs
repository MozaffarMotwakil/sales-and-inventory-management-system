using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Products;

namespace DataAccess.Products
{
    public static class clsDiscountData
    {
        public static clsDiscountDTO FindDiscountByID(int discountID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_FindDiscountByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DiscountID", discountID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsDiscountDTO discountDTO = null;

                            if (reader.Read())
                            {
                                discountDTO = new clsDiscountDTO
                                {
                                    DiscountID = Convert.ToInt32(reader["DiscountID"]),
                                    DiscountName = Convert.ToString(reader["DiscountName"]),
                                    DiscountValue = Convert.ToDecimal(reader["DiscountValue"]),
                                    DiscountValueType = Convert.ToBoolean(reader["DiscountValueType"]),
                                    MinimumQuantity = Convert.ToInt32(reader["MinimumQuantity"]),
                                    StartDate = Convert.ToDateTime(reader["StartDate"]),
                                    EndDate = Convert.ToDateTime(reader["EndDate"]),
                                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                                };

                                discountDTO.UpdatedByUserID = reader["UpdatedByUserID"] == DBNull.Value ?
                                    (int?)null :
                                    (int)reader["UpdatedByUserID"];

                                discountDTO.UpdatedAt = reader["UpdatedAt"] == DBNull.Value ?
                                    (DateTime?)null :
                                    (DateTime)reader["UpdatedAt"];
                            }

                            return discountDTO;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool AddDiscount(clsDiscountDTO discountDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_InsertDiscount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@DiscountID", discountDTO.DiscountID);
                    command.Parameters.AddWithValue("@DiscountName", discountDTO.DiscountName);
                    command.Parameters.AddWithValue("@DiscountValue", discountDTO.DiscountValue);
                    command.Parameters.AddWithValue("@DiscountValueType", discountDTO.DiscountValueType);
                    command.Parameters.AddWithValue("@MinimumQuantity", discountDTO.MinimumQuantity);
                    command.Parameters.AddWithValue("@StartDate", discountDTO.StartDate);
                    command.Parameters.AddWithValue("@EndDate", discountDTO.EndDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", discountDTO.CreatedByUserID);

                    SqlParameter paramDiscountID = command.Parameters.Add("@DiscountID", SqlDbType.Int);
                    paramDiscountID.Direction = ParameterDirection.Output;

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);


                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (paramDiscountID != null)
                        {
                            discountDTO.DiscountID = Convert.ToInt32(paramDiscountID.Value);
                        }

                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool UpdateDiscount(clsDiscountDTO discountDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_UpdateDiscount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@DiscountID", discountDTO.DiscountID);
                    command.Parameters.AddWithValue("@DiscountName", discountDTO.DiscountName);
                    command.Parameters.AddWithValue("@DiscountValue", discountDTO.DiscountValue);
                    command.Parameters.AddWithValue("@DiscountValueType", discountDTO.DiscountValueType);
                    command.Parameters.AddWithValue("@MinimumQuantity", discountDTO.MinimumQuantity);
                    command.Parameters.AddWithValue("@StartDate", discountDTO.StartDate);
                    command.Parameters.AddWithValue("@EndDate", discountDTO.EndDate);
                    command.Parameters.AddWithValue("@UpdatedByUserID", discountDTO.UpdatedByUserID);

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

        public static bool DeleteDiscount(int discountID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_DeleteDiscount",
                "@DiscountID",
                discountID
                );
        }

        public static DataTable GetAllDiscounts()
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetAllDiscounts"
                );
        }

        public static bool IsDiscountExistsByName(string discountName)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_IsDiscountExistsByName",
                "@DiscountName",
                discountName
                );
        }

        public static bool SetActive(int discountID, int updatedByUserID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_SetDiscountActive",
                "@DiscountID",
                "@UpdatedByUserID",
                discountID,
                updatedByUserID
                );
        }

        public static bool SetInActive(int discountID, int updatedByUserID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_SetDiscountInActive",
                "@DiscountID",
                "@UpdatedByUserID",
                discountID,
                updatedByUserID
                );
        }

    }
}
