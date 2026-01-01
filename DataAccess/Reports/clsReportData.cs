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

        public static DataTable GetBasicSalesReport()
        {
            return clsDataSettings.GetDataTable(
                "usp_Reports_GetBasicSalesReport"
                );
        }

        public static DataTable GetBasicPurchasesReport()
        {
            return clsDataSettings.GetDataTable(
                "usp_Reports_GetBasicPurchasesReport"
                );
        }

        public static DataTable GetTopCategorySalesForCurrentMonth()
        {
            return clsDataSettings.GetDataTable(
                "usp_Reports_GetTopCategorySales"
                );
        }
    }
}
