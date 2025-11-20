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
                                    ResponsibleEmployeeID = Convert.ToInt32(reader["ResponsibleEmployeeID"]),
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
                    catch
                    {
                        throw;
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
                    command.Parameters.AddWithValue("@ResponsibleEmployeeID", warehouseDTO.ResponsibleEmployeeID);
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
                    catch
                    {
                        throw;
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
                    command.Parameters.AddWithValue("@ResponsibleEmployeeID", warehouseDTO.ResponsibleEmployeeID);
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
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool PerformStockTransferOperation(clsTransferOperationDTO transferOperationDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Inventories_PerformStockTransferOperation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SourceWarehouseID", transferOperationDTO.SourceWarehouseID);
                    command.Parameters.AddWithValue("@DestinationWarehouseID", transferOperationDTO.DestinationWarehouseID);
                    command.Parameters.AddWithValue("@ResponsibleEmployeeID", transferOperationDTO.ResponsibleEmployeeID);
                    command.Parameters.AddWithValue("@TransferOperationDateTime", transferOperationDTO.TransferOperationDateTime);
                    command.Parameters.AddWithValue("@CreatedByUserID", transferOperationDTO.CreatedByUserID);

                    SqlParameter tvpParam = command.Parameters.AddWithValue("@TransferedInventories", transferOperationDTO.TransferedInventories);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "TransferedInventoryType";

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

        public static clsTransferOperationDTO FindStockTransferOperation(int transferOperationID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Inventories_GetStockTransferOperationByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransferOperationID", transferOperationID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsTransferOperationDTO transferOperationDTO = null;

                            if (reader.Read())
                            {
                                transferOperationDTO = new clsTransferOperationDTO
                                {
                                    TransferOperationID = Convert.ToInt32(reader["TransferOperationID"]),
                                    SourceWarehouseID = Convert.ToInt32(reader["SourceWarehouseID"]),
                                    DestinationWarehouseID = Convert.ToInt32(reader["DestianationWarehouseID"]),
                                    ResponsibleEmployeeID = Convert.ToInt32(reader["ResponsibleEmployeeID"]),
                                    TransferOperationDateTime = Convert.ToDateTime(reader["TransferOperationDateTime"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                };

                                if (reader.NextResult())
                                {
                                    if (reader.HasRows)
                                    {
                                        DataTable transferedInventories = new DataTable();
                                        transferedInventories.Load(reader);
                                        transferOperationDTO.TransferedInventories = transferedInventories;
                                    }
                                }
                            }

                            return transferOperationDTO;
                        }
                    }
                    catch
                    {
                        throw;
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

        public static DataTable GetAvailableInventoryIDsForWarehouse(int warehouseID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Inventories_GetAvailableInventoryIDsForWarehouse",
                "@WarehouseID",
                warehouseID
                );
        }
        
        public static DataTable GetWarehousesList()
        {
            return clsDataSettings.GetDataTable(
                "usp_Warehouses_GetWarehousesList"
                );
        }

        public static DataTable GetAllTransferOperations()
        {
            return clsDataSettings.GetDataTable(
                "usp_Warehouses_GetAllTransferOperations"
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

        public static DateTime GetFirstTransferOperationDate()
        {
            return Convert.ToDateTime(
                clsDataSettings.GetSingleValue("usp_Inventories_GetFirstTransferOperationDate")
                );
        }

    }
}
