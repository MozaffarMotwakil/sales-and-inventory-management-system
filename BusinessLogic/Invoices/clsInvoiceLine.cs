using System.Collections.Generic;
using System.Data;
using BusinessLogic.Products;
using BusinessLogic.Validation;
using DataAccess.Products;

namespace BusinessLogic.Invoices
{
    public class clsInvoiceLine
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

        public static DataTable CreateInvoiceLinesDataTable(List<clsInvoiceLine> lines)
        {
            DataTable invoiceLines = new DataTable();

            invoiceLines.Columns.Add("ProductID", typeof(int));
            invoiceLines.Columns.Add("UnitID", typeof(int));
            invoiceLines.Columns.Add("UnitPrice", typeof(decimal));
            invoiceLines.Columns.Add("ConversionFactor", typeof(decimal));
            invoiceLines.Columns.Add("Quantity", typeof(short));
            invoiceLines.Columns.Add("Discount", typeof(decimal));
            invoiceLines.Columns.Add("Tax", typeof(decimal));
            invoiceLines.Columns.Add("LineSubTotal", typeof(decimal));
            invoiceLines.Columns.Add("FinalLineTotal", typeof(decimal));

            foreach (var line in lines)
            {
                invoiceLines.Rows.Add(
                    line.ProductID,
                    line.UnitID,
                    line.UnitPrice,
                    line.ConversionFactor,
                    (short)line.Quantity,
                    line.Discount,
                    line.Tax,
                    line.LineSubTotal,
                    line.FinalLineTotal
                );
            }

            return invoiceLines;
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (!clsProductService.IsProductExists(ProductID))
            {
                validationResult.AddError("المنتج", "لم يتم العثور على المنتج المختار ");
            }

            if (clsProductUnitData.IsUnitExists(UnitID))
            {
                validationResult.AddError("وحدة القياس", "لم يتم العثور على وحدة القياس المختارة");
            }

            if (Quantity <= 0)
            {
                validationResult.AddError("الكمية", "يجب أن تكون الكمية أكبر من صفر.");
            }

            if (ConversionFactor <= 0)
            {
                validationResult.AddError("عامل التحويل", "يجب أن يكون عامل التحويل أكبر من صفر.");
            }

            if (UnitPrice < 0)
            {
                validationResult.AddError("سعر الوحدة", "لا يمكن أن يكون سعر الوحدة عدد سالب");
            }

            if (Discount < 0)
            {
                validationResult.AddError("الخصم", "لا يمكن أن تكون قيمة الخصم سالبة.");
            }

            if (Tax < 0)
            {
                validationResult.AddError("الضريبة", "لا يمكن أن تكون قيمة الضريبة سالبة.");
            }

            decimal expectedSubTotal = UnitPrice * Quantity;

            if (LineSubTotal != expectedSubTotal)
            {
                validationResult.AddError("الإجمالي الفرعي", "الإجمالي الفرعي المحسوب غير صحيح بناءً على السعر والكمية.");
            }

            decimal expectedFinalTotal = LineSubTotal - Discount + Tax;

            if (FinalLineTotal != expectedFinalTotal)
            {
                validationResult.AddError("الإجمالي النهائي", "الإجمالي النهائي المحسوب غير صحيح بناءً على المعادلة (SubTotal - Discount + Tax).");
            }

            if (Discount > LineSubTotal)
            {
                validationResult.AddError("الخصم", "لا يمكن أن يتجاوز الخصم الممنوح القيمة الفرعية للسطر.");
            }

            return validationResult;
        }

    }
}
