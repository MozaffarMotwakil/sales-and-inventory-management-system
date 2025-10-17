using System;

namespace DTOs.Invoices
{
    public class clsInvoiceLineDTO
    {
        public int? InvoiceID { get; set; }
        public int ProductID { get; set; }
        public int UnitID { get; set; }
        public decimal UnitPrice { get; set; }
        public int ConversionFactor { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal LineSubTotal { get; set; } 
        public decimal FinalLineTotal { get; set; }

        public clsInvoiceLineDTO() { }

        public clsInvoiceLineDTO(int? invoiceID, int productID, int unitID, decimal unitPrice, int conversionFactor,
            int quantity, decimal discount, decimal tax, decimal lineSubTotal, decimal finalLineTotal)
        {
            InvoiceID = invoiceID;
            ProductID = productID;
            UnitID = unitID;
            UnitPrice = unitPrice;
            ConversionFactor = conversionFactor;
            Quantity = quantity;
            Discount = discount;
            Tax = tax;
            LineSubTotal = lineSubTotal;
            FinalLineTotal = finalLineTotal;
        }
    }
}
