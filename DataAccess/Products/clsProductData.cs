using System;
using System.Data.SqlClient;
using System.Data;
using DTOs.Products;
using System.Globalization;

namespace DataAccess.Products
{
    public static class clsProductData
    {
        public static clsProductDTO FindProductByID(int productID)
        {
            clsProductDTO productDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetProductByID", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@ProductID", productID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            productDTO = new clsProductDTO
                            {
                                ProductID = productID,
                                ProductName = Convert.ToString(reader["ProductName"]),
                                Barcode = Convert.ToString(reader["Barcode"]),
                                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                MainUnitID = Convert.ToInt32(reader["MainUnitID"]),
                                MainSupplierID = reader["MainSupplierID"] == DBNull.Value ? null : (int?)(reader["MainSupplierID"]),
                                SellingPrice = Convert.ToSingle(reader["SellingPrice"]),
                                Description = (reader["Description"] != DBNull.Value) ? reader["Description"].ToString() : string.Empty,
                                ImagePath = (reader["ImagePath"] != DBNull.Value) ? reader["ImagePath"].ToString() : string.Empty,
                                IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                            };

                            productDTO.UpdatedByUserID = reader["UpdatedByUserID"] == DBNull.Value ?
                                productDTO.UpdatedByUserID = null :
                                Convert.ToInt32(reader["UpdatedByUserID"]);

                            productDTO.UpdatedAt = reader["UpdatedAt"] == DBNull.Value ?
                                productDTO.UpdatedAt = null :
                                Convert.ToDateTime(reader["UpdatedAt"]);

                            if (reader.NextResult())
                            {
                                if (reader.HasRows)
                                {
                                    DataTable alternativeUnits = new DataTable();
                                    alternativeUnits.Load(reader);
                                    productDTO.UnitConversions = alternativeUnits;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error find product by ID.", ex);
                }
            }

            return productDTO;
        }

        public static DataTable GetAllProducts()
        {
            DataTable products = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetAllProducts", connection)
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
                            products = new DataTable();
                            products.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error get all products.", ex);
                }
            }

            return products;
        }

        public static bool AddProduct(clsProductDTO productDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_InsertProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProductName", productDTO.ProductName);
                    command.Parameters.AddWithValue("@Barcode", productDTO.Barcode);
                    command.Parameters.AddWithValue("@CategoryID", productDTO.CategoryID);
                    command.Parameters.AddWithValue("@MainUnitID", productDTO.MainUnitID);
                    command.Parameters.AddWithValue("@MainSupplierID", clsDataSettings.GetDBNullIfNull(productDTO.MainSupplierID));
                    command.Parameters.AddWithValue("@SellingPrice", productDTO.SellingPrice);
                    command.Parameters.AddWithValue("@Description", clsDataSettings.GetDBNullIfNullOrEmpty(productDTO.Description));
                    command.Parameters.AddWithValue("@ImagePath", clsDataSettings.GetDBNullIfNullOrEmpty(productDTO.ImagePath));
                    command.Parameters.AddWithValue("@CreatedByUserID", productDTO.CreatedByUserID);
                    
                    SqlParameter parameter = command.Parameters.AddWithValue("@UnitConversions", productDTO.UnitConversions);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "tvp_ProductUnitConversionsType";

                    SqlParameter paramProductID = command.Parameters.Add("@ProductID", SqlDbType.Int);
                    paramProductID.Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            productDTO.ProductID = (int)paramProductID.Value;
                        }

                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding product to database.", ex);
                    }
                }
            }
        }

        public static bool UpdateProduct(clsProductDTO productDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_UpdateProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProductID", productDTO.ProductID);
                    command.Parameters.AddWithValue("@ProductName", productDTO.ProductName);
                    command.Parameters.AddWithValue("@Barcode", productDTO.Barcode);
                    command.Parameters.AddWithValue("@CategoryID", productDTO.CategoryID);
                    command.Parameters.AddWithValue("@MainUnitID", productDTO.MainUnitID);
                    command.Parameters.AddWithValue("@MainSupplierID", clsDataSettings.GetDBNullIfNull(productDTO.MainSupplierID));
                    command.Parameters.AddWithValue("@SellingPrice", productDTO.SellingPrice);
                    command.Parameters.AddWithValue("@Description", clsDataSettings.GetDBNullIfNullOrEmpty(productDTO.Description));
                    command.Parameters.AddWithValue("@ImagePath", clsDataSettings.GetDBNullIfNullOrEmpty(productDTO.ImagePath));
                    command.Parameters.AddWithValue("@UpdatedByUserID", productDTO.CreatedByUserID);

                    SqlParameter parameter = command.Parameters.AddWithValue("@UnitConversions", productDTO.UnitConversions);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "tvp_ProductUnitConversionsType";

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error updating Product to database.", ex);
                    }
                }
            }
        }

        public static bool DeleteProduct(int productID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                string query = @"usp_DeleteProduct";

                SqlCommand command = new SqlCommand(query, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@ProductID", productID);

                try
                {
                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error delete a product.", ex);
                }
            }
        }

        public static string GetProductName(int productID)
        {
            string productName = null;

            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_GetProductName", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@ProductID", productID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            productName = Convert.ToString(reader["ProductName"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error get product name.", ex);
                }
            }

            return productName;
        }

        public static bool IsBarcodeExists(string barcode)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_IsBarcodeExists", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@Barcode", barcode);

                SqlParameter returnValueParam = new SqlParameter();
                returnValueParam.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValueParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    return (int)returnValueParam.Value == 1;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error checking barcode existence.", ex);
                }
            }
        }

        public static bool IsProductNameExists(string productName)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("usp_IsProductNameExists", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@ProductName", productName);

                SqlParameter returnValueParam = new SqlParameter();
                returnValueParam.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValueParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    return (int)returnValueParam.Value == 1;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Error checking product name existence.", ex);
                }
            }
        }

    }
}
