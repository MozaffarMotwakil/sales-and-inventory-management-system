using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Warehouses;

namespace DataAccess.Warehouses
{
    public class clsInventoryData
    {
        public static clsInventoryDTO FindInventoryByID(int inventoryID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Inventories_FindByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InventoryID", inventoryID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsInventoryDTO inventoryDTO = null;

                            if (reader.Read())
                            {
                                inventoryDTO = new clsInventoryDTO
                                {
                                    InventoryID = inventoryID,
                                    WarehouseID = Convert.ToInt32(reader["WarehouseID"]),
                                    ProductID = Convert.ToInt32(reader["ProductID"]),
                                    UnitID = Convert.ToInt32(reader["UnitID"]),
                                    ReorderQuantity = Convert.ToInt32(reader["ReorderQuantity"]),
                                };
                            }

                            return inventoryDTO;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool UpdateReorderQuantity(int inventoryID, int newReorderQuantity)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Inventories_UpdateReorderQuantity", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InventoryID", inventoryID);
                    command.Parameters.AddWithValue("@NewReorderQuantity", newReorderQuantity);

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

        public static int GetInventoryQuantity(int warehouseID, int productID, int unitID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Inventories_GetInventory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("WarehouseID", warehouseID);
                    command.Parameters.AddWithValue("ProductID", productID);
                    command.Parameters.AddWithValue("UnitID", unitID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            return reader[0] == DBNull.Value ? 0 : Convert.ToInt32(reader[0]);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static DataTable GetAllInventories()
        {
            return clsDataSettings.GetDataTable(
                "usp_Inventories_GetAllInventories"
                );
        }

        public static DataTable GetAllInventoryTransactions()
        {
            return clsDataSettings.GetDataTable(
                "usp_Inventories_GetAllStockTransactions"
                );
        }

    }
}
