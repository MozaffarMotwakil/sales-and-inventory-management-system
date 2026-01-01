using System;

namespace BusinessLogic.Reports
{
    public class clsSalesReport
    {
        public DateTime CurrentDate => DateTime.Now;
        public int CurrentYear => DateTime.Now.Year;
        public DateTime DateFrom {  get; set; }
        public DateTime DateTo {  get; set; }
        public string EmployeeName {  get; set; }
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

        public clsSalesReport(DateTime dateFrom, DateTime dateTo)
        {

        }

    }
}
