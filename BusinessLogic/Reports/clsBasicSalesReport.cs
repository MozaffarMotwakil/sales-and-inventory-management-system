using System;
using System.Data;
using DataAccess.Reports;

namespace BusinessLogic.Reports
{
    public class clsBasicSalesReport
    {
        public DateTime CurrentDate => DateTime.Now;
        public int CurrentYear => DateTime.Now.Year;
        public string EmployeeName {  get; set; }
        public DateTime DateFrom {  get; set; }
        public DateTime DateTo {  get; set; }
        public int TotalInvoicesCount { get; set; }
        public decimal GrossSalesAmount { get; set; }
        public decimal TotalDiscounts { get; set; }
        public decimal DiscountsRate { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal NetSales { get; set; }
        public decimal TotalReturns { get; set; }
        public decimal ReturnsRate { get; set; }
        public decimal FinalNetRevenue { get; set; }
        public decimal InvoiceAmountAvg { get; set; }
        public decimal InvoiceProductCountAvg { get; set; }
        public decimal CashAmount { get; set; }
        public decimal CashRate { get; set; }
        public decimal BankTransferAmount { get; set; }
        public decimal BankTransferRate { get; set; }

        public clsBasicSalesReport(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
            EmployeeName = "مظفر متوكل خضر سلمان";

            DataTable basicSalesReport = clsReportData.GetBasicSalesReport();

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
        }

    }
}
