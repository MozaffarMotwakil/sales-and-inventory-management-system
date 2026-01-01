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

        public static DataTable GetBasicSalesReport(DateTime dateFrom, DateTime dateTo)
        {
            return clsDataSettings.GetDataTable(
                "usp_Reports_GetBasicSalesReport",
                "@DateFrom",
                dateFrom,
                "@DateTo",
                dateTo
                );
        }

        public static DataTable GetBasicPurchasesReport(DateTime dateFrom, DateTime dateTo)
        {
            return clsDataSettings.GetDataTable(
                "usp_Reports_GetBasicPurchasesReport",
                "@DateFrom",
                dateFrom,
                "@DateTo",
                dateTo
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
