using System;
using System.Data;
using DataAccess.Reports;

namespace BusinessLogic.Reports
{
    public class clsDailySummary
    {
        public int TodayPurchasesInvoiceCount { get; }
        public decimal TodayPurchases { get; }
        public decimal TodayPurchasesReturn { get; }
        public int TodaySalesInvoiceCount { get; }
        public decimal TodaySales { get; }
        public decimal TodaySalesReturn { get; }
        public decimal TodayNetPurchases { get; }
        public decimal TodayNetSales { get; }
        public decimal TodaySalesCost { get; }
        public decimal TodaySalesReturnCost { get; }
        public decimal TodayProfit { get; }
        public decimal TodayProfitRate { get; }

        public clsDailySummary()
        {
            DataTable dailySummary = clsReportData.GetDailySummary();

            if (dailySummary == null || dailySummary.Rows.Count == 0)
            {
                return;
            }

            DataRow row = dailySummary.Rows[0];

            TodayPurchasesInvoiceCount = (row["TodayPurchasesInvoiceCount"] != DBNull.Value) ? Convert.ToInt32(row["TodayPurchasesInvoiceCount"]) : 0;
            TodayPurchases = (row["TodayPurchases"] != DBNull.Value) ? Convert.ToDecimal(row["TodayPurchases"]) : 0m;
            TodayPurchasesReturn = (row["TodayPurchasesReturn"] != DBNull.Value) ? Convert.ToDecimal(row["TodayPurchasesReturn"]) : 0m;

            TodaySalesInvoiceCount = (row["TodaySalesInvoiceCount"] != DBNull.Value) ? Convert.ToInt32(row["TodaySalesInvoiceCount"]) : 0;
            TodaySales = (row["TodaySales"] != DBNull.Value) ? Convert.ToDecimal(row["TodaySales"]) : 0m;
            TodaySalesReturn = (row["TodaySalesReturn"] != DBNull.Value) ? Convert.ToDecimal(row["TodaySalesReturn"]) : 0m;

            TodayNetPurchases = (row["TodayNetPurchases"] != DBNull.Value) ? Convert.ToDecimal(row["TodayNetPurchases"]) : 0m;
            TodayNetSales = (row["TodayNetSales"] != DBNull.Value) ? Convert.ToDecimal(row["TodayNetSales"]) : 0m;

            TodaySalesCost = (row["TodaySalesCost"] != DBNull.Value) ? Convert.ToDecimal(row["TodaySalesCost"]) : 0m;
            TodaySalesReturnCost = (row["TodaySalesReturnCost"] != DBNull.Value) ? Convert.ToDecimal(row["TodaySalesReturnCost"]) : 0m;

            TodayProfit = (row["TodayProfit"] != DBNull.Value) ? Convert.ToDecimal(row["TodayProfit"]) : 0m;
            TodayProfitRate = (row["TodayProfitRate"] != DBNull.Value) ? Convert.ToDecimal(row["TodayProfitRate"]) : 0m;
        }

        public static clsDailySummary Refresh()
        {
            return new clsDailySummary();
        }

    }
}