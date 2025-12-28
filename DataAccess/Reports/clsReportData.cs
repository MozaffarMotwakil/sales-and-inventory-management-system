using System;
using System.Data;

namespace DataAccess.Reports
{
    public static class clsReportData
    {
        public static DataTable GetDailySummary()
        {
            return clsDataSettings.GetDataTable(
                "usp_Reports_GetDailySummary"
                );
        }
    }
}
