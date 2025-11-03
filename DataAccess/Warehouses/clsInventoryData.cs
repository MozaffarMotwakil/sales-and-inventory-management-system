using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Warehouses
{
    public class clsInventoryData
    {
        public static int GetInventoryQuantity(int warehouseID, int productID, int unitID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Inventories_GetInventory", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
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

    }
}
