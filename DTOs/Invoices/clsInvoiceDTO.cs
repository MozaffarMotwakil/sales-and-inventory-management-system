using System;
using System.Data;

namespace DTOs.Invoices
{
    public class clsInvoiceDTO
    {
        public int? InvoiceID { get; set; }
        public string InvoiceNa { get; set; }
        public DateTime InvoiceDate { get; set; }
        public byte InvoiceTypeID { get; set; }   
        public byte InvoiceStatusID { get; set; } 
        public int PartyID { get; set; }
        public int CreatedByUserID { get; set; }
        public int? OriginalInvoiceID { get; set; }
        public decimal TotalSubTotal { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public int? PaymentMethodID { get; set; }
        public decimal? CashPaidAmount { get; set; } 
        public DataTable Lines { get; set; }

        public clsInvoiceDTO() { }

        public clsInvoiceDTO(int? invoiceID, string invoiceNa, DateTime invoiceDate, byte invoiceTypeID,
            byte invoiceStatusID, int partyID, int createdByUserID, int? originalInvoiceID, decimal totalSubTotal, 
            decimal totalDiscountAmount, decimal totalTaxAmount, decimal grandTotal, int? paymentMethodID, 
            decimal cashPaidAmount, DataTable lines)
        {
            InvoiceID = invoiceID;
            InvoiceNa = invoiceNa;
            InvoiceDate = invoiceDate;
            InvoiceTypeID = invoiceTypeID;
            InvoiceStatusID = invoiceStatusID;
            PartyID = partyID;
            CreatedByUserID = createdByUserID;
            OriginalInvoiceID = originalInvoiceID;
            TotalSubTotal = totalSubTotal;
            TotalDiscountAmount = totalDiscountAmount;
            TotalTaxAmount = totalTaxAmount;
            GrandTotal = grandTotal;
            PaymentMethodID = paymentMethodID;
            CashPaidAmount = cashPaidAmount;
            Lines = lines;
        }

    }
}
