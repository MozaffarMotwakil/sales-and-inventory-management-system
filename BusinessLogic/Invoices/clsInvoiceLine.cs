using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using BusinessLogic.Products;
using BusinessLogic.Validation;
using DataAccess.Invoices;
using DataAccess.Products;

namespace BusinessLogic.Invoices
{
    public class clsInvoiceLine
    {
        public int? LineID { get; set; }
        public int? InvoiceID { get; set; }
        public int ProductID { get; set; }
        public clsProduct ProductInfo => clsProductService.CreateInstance().Find(ProductID);
        public int UnitID { get; set; }
        public clsUnit UnitInfo => clsUnit.Find(UnitID);
        public decimal UnitPrice { get; set; }
        public int ConversionFactor { get; set; }
        public int Quantity { get; set; }
        public decimal DiscountRate { get; set; }
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
                    line.DiscountRate,
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

            if (lines != null)
            {
                foreach (DataRow row in lines.Rows)
                {
                    invoiceLines.Add(
                        new clsInvoiceLine
                        {
                            LineID = Convert.ToInt32(row["LineID"]),
                            InvoiceID = Convert.ToInt32(row["InvoiceID"]),
                            ProductID = Convert.ToInt32(row["ProductID"]),
                            UnitID = Convert.ToInt32(row["UnitID"]),
                            UnitPrice = Convert.ToDecimal(row["UnitPrice"]),
                            ConversionFactor = Convert.ToInt32(row["ConversionFactor"]),
                            Quantity = Convert.ToInt32(row["Quantity"]),
                            LineSubTotal = Convert.ToDecimal(row["LineSubTotal"]),
                            DiscountRate = Convert.ToDecimal(row["Discount"]),
                            TaxRate = Convert.ToDecimal(row["Tax"]),
                            LineGrandTotal = Convert.ToDecimal(row["LineGrandTotal"])
                        }
                    );
                }
            }

            return invoiceLines;
        }

        public static decimal CalculateSubTotal(decimal unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }

        public static decimal CalculateDiscountRate(decimal discountAmount, decimal subTotal)
        {
            return (discountAmount / subTotal) * 100;
        }

        public static decimal CalculateDiscountAmount(decimal discountRate, decimal subTotal)
        {
            return (discountRate / 100) * subTotal;
        }

        public static decimal CalculateTaxRate(decimal taxAmount, decimal discountAmount, decimal subTotal)
        {
            return (taxAmount / (subTotal - discountAmount)) * 100;
        }

        public static decimal CalculateTaxAmount(decimal taxRate, decimal discountAmount, decimal subTotal)
        {
            return (subTotal - discountAmount) * (taxRate / 100);
        }

        public static decimal CalculateGrandTotal(decimal subTotal, decimal discountRate, decimal taxRate)
        {
            return (subTotal - (subTotal * (discountRate / 100))) * (1 + taxRate / 100);
        }

        public int GetRemainingQuantity()
        {
            return clsInvoiceData.GetInvoiceLineRemainingQuantity(this.LineID ?? -1);
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

            if (DiscountRate < 0)
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

            decimal expectedFinalTotal = CalculateGrandTotal(LineSubTotal, DiscountRate, TaxRate);

            if (LineGrandTotal != expectedFinalTotal)
            {
                validationResult.AddError("الإجمالي النهائي", "الإجمالي النهائي المحسوب غير صحيح.");
            }

            if (DiscountRate > LineSubTotal)
            {
                validationResult.AddError("الخصم", "لا يمكن أن يتجاوز الخصم الممنوح القيمة الفرعية للسطر.");
            }

            return validationResult;
        }

    }
}
