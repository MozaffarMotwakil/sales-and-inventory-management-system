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
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Products_GetProductCategoryByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryID", categoryID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsCategoryDTO categoryDTO = null;

                            if (reader.Read())
                            {
                                categoryDTO = new clsCategoryDTO
                                {
                                    CategoryID = categoryID,
                                    CategoryName = Convert.ToString(reader["CategoryName"]),
                                };
                            }

                            return categoryDTO;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException($"Error find product category by ID.", ex);
                    }
                }
            }
        }

        public static DataTable GetCategoriesList()
        {
            return clsDataSettings.GetDataTable(
                "usp_Products_GetCategoriesList"
                );
        }

    }
}
