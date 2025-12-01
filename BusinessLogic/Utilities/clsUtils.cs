using System;
using System.Data;
using System.Linq;

namespace BusinessLogic.Utilities
{
    public static class clsUtils
    {
        public static string[] GetColumnStringArray(DataTable dataTable, string columnName)
        {
            return dataTable
                .Rows
                .Cast<DataRow>()
                .Select(row => Convert.ToString(row[columnName]))
                .ToArray();
        }
    }
}
