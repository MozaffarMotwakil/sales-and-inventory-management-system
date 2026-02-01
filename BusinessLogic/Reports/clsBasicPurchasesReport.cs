using System;
using System.Data;
using DataAccess.Reports;

namespace BusinessLogic.Reports
{
    public class clsBasicPurchasesReport : clsReport
    {
        public decimal GrossPurchasesAmount { get; }
        public decimal TotalDiscounts { get; }
        public decimal DiscountsRate { get; }
        public decimal TotalTaxes { get; }
        public decimal NetPurchases { get; }
        public decimal TotalReturns { get; }
        public decimal ReturnsRate { get; }
        public decimal FinalNetCost { get; }

        public decimal CashAmount { get; }
        public decimal CashRate { get; }
        public decimal BankTransferAmount { get; }
        public decimal BankTransferRate { get; }

        public int TotalInvoicesCount { get; }
        public decimal InvoiceAmountAvg { get; }
        public decimal InvoiceProductCountAvg { get; }
        public decimal InvoiceCountAvg { get; }

        public clsBasicPurchasesReport(DateTime dateFrom, DateTime dateTo)
        {
            ReportName = "تقرير المبيعات الشامل";
            DateFrom = dateFrom;
            DateTo = dateTo;

            DataTable basicPurchasesReport = clsReportData.GetBasicPurchasesReport(dateFrom, dateTo);

            if (basicPurchasesReport == null || basicPurchasesReport.Rows.Count == 0)
            {
                return;
            }

            DataRow row = basicPurchasesReport.Rows[0];

            TotalInvoicesCount = (row["TotalInvoicesCount"] != DBNull.Value) ? Convert.ToInt32(row["TotalInvoicesCount"]) : 0;
            GrossPurchasesAmount = (row["GrossPurchasesAmount"] != DBNull.Value) ? Convert.ToDecimal(row["GrossPurchasesAmount"]) : 0m;
            TotalDiscounts = (row["TotalDiscounts"] != DBNull.Value) ? Convert.ToDecimal(row["TotalDiscounts"]) : 0m;
            DiscountsRate = (row["DiscountsRate"] != DBNull.Value) ? Convert.ToDecimal(row["DiscountsRate"]) : 0m;
            TotalTaxes = (row["TotalTaxes"] != DBNull.Value) ? Convert.ToDecimal(row["TotalTaxes"]) : 0m;
            NetPurchases = (row["NetPurchases"] != DBNull.Value) ? Convert.ToDecimal(row["NetPurchases"]) : 0m;

            TotalReturns = (row["TotalReturns"] != DBNull.Value) ? Convert.ToDecimal(row["TotalReturns"]) : 0m;
            ReturnsRate = (row["ReturnsRate"] != DBNull.Value) ? Convert.ToDecimal(row["ReturnsRate"]) : 0m;
            FinalNetCost = (row["FinalNetCost"] != DBNull.Value) ? Convert.ToDecimal(row["FinalNetCost"]) : 0m;

            InvoiceAmountAvg = (row["InvoiceAmountAvg"] != DBNull.Value) ? Convert.ToDecimal(row["InvoiceAmountAvg"]) : 0m;
            InvoiceProductCountAvg = (row["InvoiceProductCountAvg"] != DBNull.Value) ? Convert.ToDecimal(row["InvoiceProductCountAvg"]) : 0m;

            CashAmount = (row["CashAmount"] != DBNull.Value) ? Convert.ToDecimal(row["CashAmount"]) : 0m;
            CashRate = (row["CashRate"] != DBNull.Value) ? Convert.ToDecimal(row["CashRate"]) : 0m;
            BankTransferAmount = (row["BankTransferAmount"] != DBNull.Value) ? Convert.ToDecimal(row["BankTransferAmount"]) : 0m;
            BankTransferRate = (row["BankTransferRate"] != DBNull.Value) ? Convert.ToDecimal(row["BankTransferRate"]) : 0m;

            InvoiceCountAvg = (row["InvoiceCountAvg"] != DBNull.Value) ? Convert.ToDecimal(row["InvoiceCountAvg"]) : 0m;
        }
    }
}
