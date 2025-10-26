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
        public clsProduct ProductInfo => clsProductService.CreateInstance().Find(ProductID);
        public int UnitID { get; set; }
        public clsUnit UnitInfo => clsUnit.Find(UnitID);
        public decimal UnitPrice { get; set; }
        public int ConversionFactor { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal LineSubTotal { get; set; }
        public decimal LineGrandTotal { get; set; }

        public static DataTable ConvertInvoiceLinesListToDataTable(List<clsInvoiceLine> lines)
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
                    line.TaxRate,
                    line.LineSubTotal,
                    line.LineGrandTotal
                );
            }

            return invoiceLines;
        }

        public static List<clsInvoiceLine> ConvertInvoiceLinesDataTableToList(DataTable lines)
        {
            List<clsInvoiceLine> invoiceLines = new List<clsInvoiceLine>();

            // To prevent NullReferenceException if the list is null.
            if (lines is null)
            {
                return invoiceLines;
            }

            foreach (DataRow row in lines.Rows)
            {
                invoiceLines.Add(
                    new clsInvoiceLine
                    {
                        InvoiceID = int.Parse(row["InvoiceID"].ToString()),
                        ProductID = int.Parse(row["ProductID"].ToString()),
                        UnitID = int.Parse(row["UnitID"].ToString()),
                        UnitPrice = decimal.Parse(row["UnitPrice"].ToString()),
                        ConversionFactor = int.Parse(row["ConversionFactor"].ToString()),
                        Quantity = int.Parse(row["Quantity"].ToString()),
                        LineSubTotal = decimal.Parse(row["LineSubTotal"].ToString()),
                        Discount = decimal.Parse(row["Discount"].ToString()),
                        TaxRate = decimal.Parse(row["Tax"].ToString()),
                        LineGrandTotal = decimal.Parse(row["LineGrandTotal"].ToString())
                    }
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

            if (!clsProductUnitData.IsUnitExists(UnitID))
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

            if (TaxRate < 0)
            {
                validationResult.AddError("الضريبة", "لا يمكن أن تكون قيمة الضريبة سالبة.");
            }

            decimal expectedSubTotal = UnitPrice * Quantity;

            if (LineSubTotal != expectedSubTotal)
            {
                validationResult.AddError("الإجمالي الفرعي", "الإجمالي الفرعي المحسوب غير صحيح بناءً على السعر والكمية.");
            }

            decimal expectedFinalTotal = (LineSubTotal - Discount) * + (1 + TaxRate / 100);

            if (LineGrandTotal != expectedFinalTotal)
            {
                validationResult.AddError("الإجمالي النهائي", "الإجمالي النهائي المحسوب غير صحيح.");
            }

            if (Discount > LineSubTotal)
            {
                validationResult.AddError("الخصم", "لا يمكن أن يتجاوز الخصم الممنوح القيمة الفرعية للسطر.");
            }

            return validationResult;
        }

    }
}
