using System;
using System.Data;

namespace DTOs.Invoices
{
    public class clsInvoiceDTO
    {
        public int? InvoiceID { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public byte InvoiceTypeID { get; set; }   
        public byte InvoiceStatusID { get; set; } 
        public int? PartyID { get; set; } 
        public DataTable Lines { get; set; }
        public decimal TotalSubTotal { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public byte? PaymentMethodID { get; set; }
        public decimal? PaymentAmount { get; set; } 
        public int? OriginalInvoiceID { get; set; } 
        public int WarehouseID { get; set; } 
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
