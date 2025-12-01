using System;
using System.Data.SqlClient;
using System.Data;
using DTOs.Products;

namespace DataAccess.Products
{
    public class clsProductUnitData
    {
        public static clsUnitDTO FindProductUnitByID(int UnitID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_GetProductUnitByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UnitID", UnitID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsUnitDTO unitDTO = null;

                            if (reader.Read())
                            {
                                unitDTO = new clsUnitDTO
                                {
                                    UnitID = UnitID,
                                    UnitName = Convert.ToString(reader["UnitName"]),
                                };
                            }

                            return unitDTO;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException($"Error find product unit by ID.", ex);
                    }
                }
            }
        }

        public static DataTable GetUnitsList()
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetUnitsList"
                );
        }

        public static DataTable GetAllUnitsByProductID(int productID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetAllUnitsByProductID",
                "@ProductID",
                productID
                );
        }

        public static bool IsUnitExists(int unitID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Products_IsProductUnitExistsByID",
                "@UnitID",
                unitID
                );
        }

    }
}
