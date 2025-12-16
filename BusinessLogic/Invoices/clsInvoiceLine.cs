using System;
using System.Collections.Generic;
using System.Data;
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
        public int? ProductID { get; set; }
        public clsProduct ProductInfo => clsProductService.CreateInstance().Find(ProductID.GetValueOrDefault());
        public int? UnitID { get; set; }
        public clsUnit UnitInfo => clsUnit.Find(UnitID.GetValueOrDefault());
        public decimal? UnitPrice { get; set; }
        public int? ConversionFactor { get; set; }
        public int? Quantity { get; set; }

        private decimal? _DiscountRate;
        public decimal? DiscountRate
        {
            get => _DiscountRate;
            set
            {
                _DiscountRate = value;
                _DiscountAmount = (DiscountRate / 100) * LineSubTotal;
                _TaxAmount = (LineSubTotal - DiscountAmount) * (TaxRate / 100);
                _TaxRate = CalculateTaxRate();
            }
        }

        private decimal? _DiscountAmount;
        public decimal? DiscountAmount
        {
            get => _DiscountAmount;
            set
            {
                _DiscountAmount = value;
                DiscountRate = (DiscountAmount / LineSubTotal) * 100;
                _TaxAmount = (LineSubTotal - DiscountAmount) * (TaxRate / 100);
                _TaxRate = CalculateTaxRate();
            }
        }

        private decimal? _TaxRate;
        public decimal? TaxRate
        {
            get => _TaxRate;
            set
            {
                _TaxRate = value;
                _TaxAmount = (LineSubTotal - DiscountAmount) * (TaxRate / 100);
            }
        }

        private decimal? _TaxAmount;
        public decimal? TaxAmount
        {
            get => _TaxAmount;
            set
            {
                _TaxAmount = value;
                _TaxRate = CalculateTaxRate();
            }
        }

        private decimal? _LineSubTotal;
        public decimal? LineSubTotal
        {
            get => UnitPrice * Quantity;
            set
            {
                _LineSubTotal = value;
            }
        }

        private decimal? _LineGrandTotal;
        public decimal? LineGrandTotal
        {
            get => LineSubTotal - DiscountAmount + TaxAmount;
            set
            {
                _LineGrandTotal = value;
            }
        }

        public bool IsNewRow => ProductID == null || UnitID == null || UnitPrice == null ||
            Quantity == null || LineSubTotal == null || LineGrandTotal == null;

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
                            DiscountRate = Convert.ToDecimal(row["DiscountRate"]),
                            TaxRate = Convert.ToDecimal(row["TaxRate"]),
                            LineGrandTotal = Convert.ToDecimal(row["LineGrandTotal"])
                        }
                    );
                }
            }

            return invoiceLines;
        }

        public decimal? CalculateTaxRate()
        {
            return (TaxAmount / (LineSubTotal - DiscountAmount)) * 100;
        }

        public int GetRemainingQuantity()
        {
            return clsInvoiceData.GetInvoiceLineRemainingQuantity(this.LineID ?? -1);
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (!clsProductService.IsProductExists(ProductID.GetValueOrDefault()))
            {
                validationResult.AddError("المنتج", "لم يتم العثور على المنتج المختار ");
            }

            if (ProductInfo != null && !ProductInfo.IsActive)
            {
                validationResult.AddError("المنتج", $"المنتج \"{ProductInfo.ProductName}\" غير نشط");
            }

            if (!clsProductUnitData.IsUnitExists(UnitID.GetValueOrDefault()))
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


            if (DiscountAmount > LineSubTotal)
            {
                validationResult.AddError("الخصم", "لا يمكن أن يكون مبلغ الخصم أكبر من أو يساوي الإجمالي الفرعي.");
            }

            if (TaxRate < 0)
            {
                validationResult.AddError("الضريبة", "لا يمكن أن تكون قيمة الضريبة سالبة.");
            }

            if (LineSubTotal != (UnitPrice * Quantity))
            {
                validationResult.AddError("الإجمالي الفرعي", "الإجمالي الفرعي المحسوب غير صحيح بناءً على السعر والكمية.");
            }

            if (LineGrandTotal != (LineSubTotal - DiscountAmount + TaxAmount))
            {
                validationResult.AddError("الإجمالي النهائي", "الإجمالي النهائي المحسوب غير صحيح.");
            }

            return validationResult;
        }

    }
}
