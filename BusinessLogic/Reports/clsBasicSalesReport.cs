using System;
using System.Data;
using DataAccess.Reports;

namespace BusinessLogic.Reports
{
    public class clsBasicSalesReport : clsReport
    {
        public decimal GrossSalesAmount { get; set; }
        public decimal TotalDiscounts { get; set; }
        public decimal DiscountsRate { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal NetSales { get; set; }
        public decimal TotalReturns { get; set; }
        public decimal ReturnsRate { get; set; }
        public decimal FinalNetRevenue { get; set; }
        public decimal COGS { get; set; }
        public decimal TotalProfit { get; set; }
        public decimal ProfitRate { get; set; }

        public decimal CashAmount { get; set; }
        public decimal CashRate { get; set; }
        public decimal BankTransferAmount { get; set; }
        public decimal BankTransferRate { get; set; }

        public int TotalInvoicesCount { get; set; }
        public decimal InvoiceAmountAvg { get; set; }
        public decimal InvoiceProductCountAvg { get; set; }
        public decimal InvoiceCountAvg { get; set; }

        public clsBasicSalesReport(DateTime dateFrom, DateTime dateTo)
        {
            ReportName = "تقرير المبيعات الشامل";
            DateFrom = dateFrom;
            DateTo = dateTo;

            DataTable basicSalesReport = clsReportData.GetBasicSalesReport(dateFrom, dateTo);

            if (basicSalesReport == null || basicSalesReport.Rows.Count == 0)
            {
                return;
            }

            DataRow row = basicSalesReport.Rows[0];

            TotalInvoicesCount = (row["TotalInvoicesCount"] != DBNull.Value) ? Convert.ToInt32(row["TotalInvoicesCount"]) : 0;
            GrossSalesAmount = (row["GrossSalesAmount"] != DBNull.Value) ? Convert.ToDecimal(row["GrossSalesAmount"]) : 0m;
            TotalDiscounts = (row["TotalDiscounts"] != DBNull.Value) ? Convert.ToDecimal(row["TotalDiscounts"]) : 0m;
            DiscountsRate = (row["DiscountsRate"] != DBNull.Value) ? Convert.ToDecimal(row["DiscountsRate"]) : 0m;
            TotalTaxes = (row["TotalTaxes"] != DBNull.Value) ? Convert.ToDecimal(row["TotalTaxes"]) : 0m;
            NetSales = (row["NetSales"] != DBNull.Value) ? Convert.ToDecimal(row["NetSales"]) : 0m;

            TotalReturns = (row["TotalReturns"] != DBNull.Value) ? Convert.ToDecimal(row["TotalReturns"]) : 0m;
            ReturnsRate = (row["ReturnsRate"] != DBNull.Value) ? Convert.ToDecimal(row["ReturnsRate"]) : 0m;
            FinalNetRevenue = (row["FinalNetRevenue"] != DBNull.Value) ? Convert.ToDecimal(row["FinalNetRevenue"]) : 0m;

            InvoiceAmountAvg = (row["InvoiceAmountAvg"] != DBNull.Value) ? Convert.ToDecimal(row["InvoiceAmountAvg"]) : 0m;
            InvoiceProductCountAvg = (row["InvoiceProductCountAvg"] != DBNull.Value) ? Convert.ToDecimal(row["InvoiceProductCountAvg"]) : 0m;

            CashAmount = (row["CashAmount"] != DBNull.Value) ? Convert.ToDecimal(row["CashAmount"]) : 0m;
            CashRate = (row["CashRate"] != DBNull.Value) ? Convert.ToDecimal(row["CashRate"]) : 0m;
            BankTransferAmount = (row["BankTransferAmount"] != DBNull.Value) ? Convert.ToDecimal(row["BankTransferAmount"]) : 0m;
            BankTransferRate = (row["BankTransferRate"] != DBNull.Value) ? Convert.ToDecimal(row["BankTransferRate"]) : 0m;

            COGS = (row["COGS"] != DBNull.Value) ? Convert.ToDecimal(row["COGS"]) : 0m;
            TotalProfit = (row["TotalProfit"] != DBNull.Value) ? Convert.ToDecimal(row["TotalProfit"]) : 0m;
            ProfitRate = (row["ProfitRate"] != DBNull.Value) ? Convert.ToDecimal(row["ProfitRate"]) : 0m;
            InvoiceCountAvg = (row["InvoiceCountAvg"] != DBNull.Value) ? Convert.ToDecimal(row["InvoiceCountAvg"]) : 0m;
        }

    }
}
