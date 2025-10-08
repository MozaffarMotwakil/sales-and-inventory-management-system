using System;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public static class clsDataSettings
    {
        public static string ConnectionString = "Server=.; Database=ERP_ALWAHA; User Id=sa; Password=sa123456";

        public static object GetDBNullIfNullOrEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? DBNull.Value : (object)value;
        }

        public static object GetDBNullIfNull(object value)
        {
            return value ?? DBNull.Value;
        }

        public static DataTable GetDataTable(string storedProcedureName, string exceptionMessage)
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
                            DataTable records = null;

                            if (reader.HasRows)
                            {
                                records = new DataTable();
                                records.Load(reader);
                            }

                            return records;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException(exceptionMessage, ex);
                    }
                }
            }
        }

        public static bool DeleteRecord(string storedProcedureName, string parameterName, int supplierID, string exceptionMessage)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(parameterName, supplierID);

                    try
                    {
                        connection.Open();

                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException(exceptionMessage, ex);
                    }
                }
            }
        }

    }
}
