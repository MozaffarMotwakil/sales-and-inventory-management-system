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
            clsUnitDTO unitDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetProductUnitByID", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@UnitID", UnitID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            unitDTO = new clsUnitDTO
                            {
                                UnitID = UnitID,
                                UnitName = Convert.ToString(reader["UnitName"]),
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error find product unit by ID.", ex);
                }
            }

            return unitDTO;
        }

        public static DataTable GetAllProductUnitNames()
        {
            DataTable productUnits = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetAllProductUnits", connection)
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
                            productUnits = new DataTable();
                            productUnits.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error get all product unit names.", ex);
                }
            }

            return productUnits;
        }
    }
}
