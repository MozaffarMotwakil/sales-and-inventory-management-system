using System;

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

    }
}
