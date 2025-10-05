using System;
using System.Data.SqlClient;
using System.Data;
using DTOs.Products;

namespace DataAccess.Products
{
    public static class clsProductCategoryData
    {
        public static clsCategoryDTO FindProductCategoryByID(int categoryID)
        {
            clsCategoryDTO categoryDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetProductCategoryByID", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@CategoryID", categoryID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoryDTO = new clsCategoryDTO
                            {
                                CategoryID = categoryID,
                                CategoryName = Convert.ToString(reader["CategoryName"]),
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error find product category by ID.", ex);
                }
            }

            return categoryDTO;
        }

        public static DataTable GetAllProductCategoryNames()
        {
            DataTable productCategories = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetAllProductCategories", connection)
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
                            productCategories = new DataTable();
                            productCategories.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error get all product category names.", ex);
                }
            }

            return productCategories;
        }
    }
}
