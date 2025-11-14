using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccess
{
    public static class clsDataSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString;

        public static object GetDBNullIfNullOrEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? DBNull.Value : (object)value;
        }

        public static object GetDBNullIfNull(object value)
        {
            return value ?? DBNull.Value;
        }

        public static DataRow GetDataRow(string storedProcedureName)
        {
            DataTable dataTable = GetDataTable(storedProcedureName);

            return dataTable.Rows.Count != 0 ?
                dataTable.Rows[0] :
                null;
        }

        public static DataRow GetDataRow<T>(string storedProcedureName, string parameterName, T parameterValue)
        {
            DataTable dataTable = GetDataTable(storedProcedureName, parameterName, parameterValue);

            return dataTable.Rows.Count != 0 ?
                dataTable.Rows[0] :
                null;
        }

        public static DataTable GetDataTable(string storedProcedureName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable records = new DataTable();

                            if (reader.HasRows)
                            {
                                records.Load(reader);
                            }

                            return records;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static DataTable GetDataTable<T>(string storedProcedureName, string parameterName, T parameterValue)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(parameterName, parameterValue);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable records = new DataTable();

                            if (reader.HasRows)
                            {
                                records.Load(reader);
                            }

                            return records;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static object GetSingleValue<T>(string storedProcedureName, string parameterName, T parameterValue)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(parameterName, parameterValue);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            return reader[0] == DBNull.Value ? null : reader[0];
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static object GetSingleValue(string storedProcedureName)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            return reader[0] == DBNull.Value ? null : reader[0];
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool ExecuteSimpleSP<T>(string storedProcedureName, string parameterName, T parameterValue)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(parameterName, parameterValue);

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

    }
}
