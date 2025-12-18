using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public int? ProductID
        {
            get => _ProductID;
            set
            {
                if (_ProductID.GetValueOrDefault() != value.GetValueOrDefault())
                {
                    _UnitID = null;
                    UnitPrice = null;
                    ConversionFactor = null;
                    Quantity = null;
                    UnitPrice = null;
                    LineSubTotal = null;
                    DiscountRate = null;
                    DiscountAmount = null;
                    TaxRate = null;
                    TaxAmount = null;
                    LineGrandTotal = null;
                }
                
                _ProductID = value;
            }
        }
        public clsProduct ProductInfo => clsProductService.CreateInstance().Find(ProductID.GetValueOrDefault());
        public int? UnitID
        {
            get => _UnitID;
            set
            {
                if (ProductID == null)
                {
                    return;
                }

                if (_UnitID.GetValueOrDefault() != value.GetValueOrDefault())
                {
                    UnitPrice = null;
                    ConversionFactor = null;
                    Quantity = null;
                    UnitPrice = null;
                    LineSubTotal = null;
                    DiscountRate = null;
                    DiscountAmount = null;
                    TaxRate = null;
                    TaxAmount = null;
                    LineGrandTotal = null;
                }

                _UnitID = value;

                if (BaseInvoiceType == enInvoiceType.Sales || BaseInvoiceType == enInvoiceType.SalesReturn)
                {
                    clsProduct product = ProductInfo;

                    if (product == null)
                    {
                        return;
                    }

                    if (UnitID == product.MainUnitInfo.UnitID)
                    {
                        UnitPrice = product.SellingPrice;
                        ConversionFactor = 1;
                    }
                    else
                    {
                        clsProductUnitConversion alternativeUnit = product.UnitConversions.FirstOrDefault(unit => unit.AlternativeUnitID == UnitID);

                        if (alternativeUnit != null)
                        {
                            UnitPrice = alternativeUnit.SellingPrice;
                            ConversionFactor = alternativeUnit.ConversionFactor;
                        }
                    }

                    _TaxRate = 0;
                    _TaxAmount = 0;
                }
            }
        }
        public clsUnit UnitInfo => clsUnit.Find(UnitID.GetValueOrDefault());
        public decimal? UnitPrice { get; set; }
        public int? ConversionFactor { get; set; }
        public int? Quantity
        {
            get => _Quantity;
            set
            {
                _Quantity = value;

                if (BaseInvoiceType == enInvoiceType.Sales || BaseInvoiceType == enInvoiceType.SalesReturn)
                {
                    clsProduct product = ProductInfo;

                    if (product == null)
                    {
                        return;
                    }

                    _DiscountRate = GetSumOfDiscountsValue(product, clsDiscount.enValueType.Percentage);
                    _DiscountAmount = GetSumOfDiscountsValue(product, clsDiscount.enValueType.Amount);
                }
            }
        }
        public decimal? DiscountRate
        {
            get => _DiscountRate;
            set
            {
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.PurchaseReturn)
                {
                    _DiscountRate = value;
                    _DiscountAmount = CalculateDiscountAmount();
                    _TaxAmount = CalculateTaxAmount();
                    _TaxRate = CalculateTaxRate();
                }
            }
        }
        public decimal? DiscountAmount
        {
            get => _DiscountAmount;
            set
            {
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.PurchaseReturn)
                {
                    _DiscountAmount = value;
                    DiscountRate = CalculateDiscountRate();
                    _TaxAmount = CalculateTaxAmount();
                    _TaxRate = CalculateTaxRate();
                }
            }
        }
        public decimal? TaxRate
        {
            get => _TaxRate;
            set
            {
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.PurchaseReturn)
                {
                    _TaxRate = value;
                    _TaxAmount = (LineSubTotal - DiscountAmount) * (TaxRate / 100);
                }
            }
        }
        public decimal? TaxAmount
        {
            get => _TaxAmount;
            set
            {
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.PurchaseReturn)
                {
                    _TaxAmount = value;
                    _TaxRate = CalculateTaxRate();
                }
            }
        }
        public decimal? LineSubTotal
        {
            get => UnitPrice * Quantity;
            set
            {
                _LineSubTotal = value;
            }
        }
        public decimal? LineGrandTotal
        {
            get
            {
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.PurchaseReturn)
                {
                    return LineSubTotal - DiscountAmount + TaxAmount;
                }
                else
                {
                    return LineSubTotal - CalculateFinalDiscountAmount() + TaxAmount;
                }
            }
            set
            {
                _LineGrandTotal = value;
            }
        }
        public enInvoiceType BaseInvoiceType { get; set; }
        public bool IsNewRow => ProductID == null || UnitID == null || UnitPrice == null ||
            Quantity == null || LineSubTotal == null || LineGrandTotal == null;

        private int? _ProductID;
        private int? _UnitID;
        private int? _Quantity;
        private decimal? _DiscountRate;
        private decimal? _DiscountAmount;
        private decimal? _TaxRate;
        private decimal? _TaxAmount;
        private decimal? _LineSubTotal;
        private decimal? _LineGrandTotal;

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

        public static List<clsInvoiceLine> ConvertInvoiceLinesDataTableToList(DataTable lines, enInvoiceType invoiceType)
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
                            BaseInvoiceType = invoiceType,
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

        public decimal? CalculateDiscountRate()
        {
            return (DiscountAmount / LineSubTotal) * 100;
        }

        public decimal? CalculateTaxAmount()
        {
            return (LineSubTotal - DiscountAmount) * (TaxRate / 100);
        }

        public decimal? CalculateDiscountAmount()
        {
            return (DiscountRate / 100) * LineSubTotal;
        }

        public decimal? CalculateFinalDiscountAmount()
        {
            return CalculateDiscountAmount() + DiscountAmount;
        }

        public decimal? GetSumOfDiscountsValue(clsProduct product, clsDiscount.enValueType valueType)
        {
            if (Quantity == null)
            {
                return null;
            }

            return product.DiscountItems
                .Where(
                    discountItem =>
                    discountItem.UnitID == _UnitID && discountItem.DiscountInfo.IsActive && discountItem.DiscountInfo.IsValid &&
                    Quantity.GetValueOrDefault() >= discountItem.DiscountInfo.MinimumQuantity &&
                    discountItem.DiscountInfo.DiscountValueType == valueType
                    )
                .Sum(d => d.DiscountInfo.DiscountValue);
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
