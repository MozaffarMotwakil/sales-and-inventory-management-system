using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Warehouses;

namespace DataAccess.Warehouses
{
    public static class clsWarehouseData
    {
        public static clsWarehouseDTO FindWarehouseByID(int WarehouseID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Warehouses_GetWarehouseByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@WarehouseID", WarehouseID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsWarehouseDTO warehouseDTO = null;

                            if (reader.Read())
                            {
                                warehouseDTO = new clsWarehouseDTO
                                {
                                    WarehouseID = WarehouseID,
                                    WarehouseName = Convert.ToString(reader["WarehouseName"]),
                                    Address = Convert.ToString(reader["Address"]),
                                    TypeID = Convert.ToInt32(reader["TypeID"]),
                                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                                };

                                warehouseDTO.UpdatedByUserID = reader["UpdatedByUserID"] == DBNull.Value ?
                                    (int?)null :
                                    (int)reader["UpdatedByUserID"];

                                warehouseDTO.UpdatedAt = reader["UpdatedAt"] == DBNull.Value ?
                                    (DateTime?)null :
                                    (DateTime)reader["UpdatedAt"];
                            }

                            return warehouseDTO;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException($"Error find warehouse by ID.", ex);
                    }
                }
            }
        }

        public static bool AddWarehouse(clsWarehouseDTO warehouseDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Warehouses_AddNew", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@WarehouseName", warehouseDTO.WarehouseName);
                    command.Parameters.AddWithValue("@Address", clsDataSettings.GetDBNullIfNullOrEmpty(warehouseDTO.Address));
                    command.Parameters.AddWithValue("@TypeID", warehouseDTO.TypeID);
                    command.Parameters.AddWithValue("@IsActive", warehouseDTO.IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", warehouseDTO.CreatedByUserID);

                    SqlParameter paramWarehouseID = command.Parameters.Add("@NewWarehouseID", SqlDbType.Int);
                    paramWarehouseID.Direction = ParameterDirection.Output;

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (int.TryParse(returnValueParam.Value.ToString(), out int returnValue) && returnValue == 1)
                        {
                            warehouseDTO.WarehouseID = (int)paramWarehouseID.Value;
                            return true;
                        }

                        return false;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding warehouse to database.", ex);
                    }
                }
            }
        }

        public static bool UpdateWarehouse(clsWarehouseDTO warehouseDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Warehouses_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@WarehouseID", warehouseDTO.WarehouseID);
                    command.Parameters.AddWithValue("@WarehouseName", warehouseDTO.WarehouseName);
                    command.Parameters.AddWithValue("@Address", clsDataSettings.GetDBNullIfNullOrEmpty(warehouseDTO.Address));
                    command.Parameters.AddWithValue("@TypeID", warehouseDTO.TypeID);
                    command.Parameters.AddWithValue("@IsActive", warehouseDTO.IsActive);
                    command.Parameters.AddWithValue("@UpdatedByUserID", warehouseDTO.UpdatedByUserID);

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
                    catch (Exception ex)
                    {
                        throw new Exception("Error updating warehouse to database.", ex);
                    }
                }
            }
        }

        public static bool DeleteWarehouse(int warehouseID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Warehouses_Delete",
                "@WarehouseID",
                warehouseID
                );
        }

        public static DataTable GetAllWarehouses()
        {
            return clsDataSettings.GetDataTable(
                "usp_Warehouses_GetAll"
                );
        }

        public static DataTable GetAllWarehouseNames()
        {
            return clsDataSettings.GetDataTable(
                "usp_Warehouses_GetAllWarehouseNames"
                );
        }

        public static bool IsWarehouseNameExists(string warehouseName)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Warehouses_IsWarehouseNameExists",
                "@WarehouseName",
                warehouseName
                );
        }

        public static bool SetWarehouseActive(int  warehouseID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Warehouses_SetActive",
                "@WarehouseID",
                warehouseID
                );
        }

        public static bool SetWarehouseInActive(int warehouseID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Warehouses_SetInActive",
                "@WarehouseID",
                warehouseID
                );
        }

        public static DataRow GetBasicInfo(int warehouseID)
        {
            return clsDataSettings.GetDataRow(
                "usp_Warehouses_GetBasicInfo",
                "@WarehouseID",
                warehouseID
                );
        }

        public static DataRow GetInventorySummary(int warehouseID)
        {
            return clsDataSettings.GetDataRow(
                "usp_Warehouses_GetInventorySummary",
                "@WarehouseID",
                warehouseID
                );
        }

        public static DataRow GetFinancialSummary(int warehouseID)
        {
            return clsDataSettings.GetDataRow(
                "usp_Warehouses_GetFinancialSummary",
                "@WarehouseID",
                warehouseID
                );
        }

        public static DataRow GetKPIsSummary(int warehouseID)
        {
            return clsDataSettings.GetDataRow(
                "usp_Warehouses_GetKPIsSummary",
                "@WarehouseID",
                warehouseID
                );
        }

    }
}
