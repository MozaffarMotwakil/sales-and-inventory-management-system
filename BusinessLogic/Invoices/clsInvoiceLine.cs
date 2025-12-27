using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BusinessLogic.Discounts;
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
                    _UnitPrice = null;
                    ConversionFactor = null;
                    _Quantity = null;
                    _UnitPrice = null;
                    _FinalUnitPrice = null;
                    _LineSubTotal = null;
                    _DiscountRate = null;
                    _DiscountAmount = null;
                    SaleDiscounts.Clear();
                    _TaxRate = null;
                    _TaxAmount = null;
                    SaleTaxes.Clear();
                    _LineGrandTotal = null;
                }

                _ProductID = value;
            }
        }
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
                    _UnitPrice = null;
                    ConversionFactor = null;
                    _Quantity = null;
                    _UnitPrice = null;
                    _FinalUnitPrice = null;
                    _LineSubTotal = null;
                    _DiscountRate = null;
                    _DiscountAmount = null;
                    SaleDiscounts.Clear();
                    _TaxRate = null;
                    _TaxAmount = null;
                    SaleTaxes.Clear();
                    _LineGrandTotal = null;
                }

                _UnitID = value;

                clsProduct product = ProductInfo;

                if (product == null)
                {
                    return;
                }

                if (UnitID == product.MainUnitInfo.UnitID)
                {
                    if (BaseInvoiceType == enInvoiceType.Sales)
                    {
                        UnitPrice = product.SellingPrice;
                    }

                    ConversionFactor = 1;
                }
                else
                {
                    clsProductUnitConversion alternativeUnit = product.UnitConversions.FirstOrDefault(unit => unit.AlternativeUnitID == UnitID);

                    if (alternativeUnit != null)
                    {
                        if (BaseInvoiceType == enInvoiceType.Sales)
                        {
                            UnitPrice = alternativeUnit.SellingPrice;
                        }

                        ConversionFactor = alternativeUnit.ConversionFactor;
                    }
                }
            }
        }
        public decimal? UnitPrice
        {
            get => _UnitPrice;
            set
            {
                if (value.HasValue)
                {
                    _UnitPrice = Math.Round(value.Value, 2);
                }
                else
                {
                    _UnitPrice = value;
                }
            }
        }
        public decimal? FinalUnitPrice
        {
            get
            {
                return LineGrandTotal.HasValue && Quantity.HasValue ?
                    Math.Round(LineGrandTotal.Value / Quantity.Value, 2) :
                    (decimal?)null;
            }
            private set
            {
                if (value.HasValue)
                {
                    _FinalUnitPrice = Math.Round(value.Value, 2);
                }
                else
                {
                    _FinalUnitPrice = value;
                }
            }
        }
        public int? ConversionFactor { get; set; }
        public int? Quantity
        {
            get => _Quantity;
            set
            {
                if (!ProductID.HasValue || !UnitID.HasValue)
                {
                    return;
                }

                _Quantity = value;

                if (BaseInvoiceType == enInvoiceType.Sales)
                {
                    clsProduct product = ProductInfo;

                    if (product == null)
                    {
                        return;
                    }

                    // Discounts
                    SaleDiscounts.Clear();
                    SaleDiscounts
                    .AddRange(
                        product
                        .DiscountItems
                            .Where(
                                discountItem =>
                                discountItem.UnitID == UnitID.GetValueOrDefault() && discountItem.DiscountInfo.IsActive &&
                                discountItem.DiscountInfo.IsValid && Quantity.GetValueOrDefault() >= discountItem.DiscountInfo.MinimumQuantity
                            )
                            .Select(discountItem => discountItem.DiscountInfo)
                    );

                    _DiscountRate = GetSumOfDiscountsValue(product, clsDiscount.enValueType.Percentage);
                    _DiscountAmount = GetSumOfDiscountsValue(product, clsDiscount.enValueType.Amount);

                    // Taxes
                    SaleTaxes.Clear();
                    SaleTaxes
                    .AddRange(
                        product
                        .TaxItems
                            .Where(
                                taxItem =>
                                taxItem.TaxInfo.IsActive
                            )
                            .Select(taxItem => taxItem.TaxInfo)
                    );

                    _TaxRate = Math.Round(product.TaxItems
                        .Where(
                            taxItem =>
                            taxItem.TaxInfo.IsActive
                        )
                        .Sum(taxItem => taxItem.TaxInfo.TaxRate), 2);

                    _TaxAmount = CalculateFinalTaxAmount();
                }
            }
        }
        public decimal? DiscountRate
        {
            get => _DiscountRate;
            set
            {
                if (BaseInvoiceType == enInvoiceType.Purchase)
                {
                    _DiscountRate = value.HasValue ?
                        Math.Round(value.Value, 2) :
                        (decimal?)null;

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
                if (BaseInvoiceType == enInvoiceType.Purchase)
                {
                    _DiscountAmount = value.HasValue ?
                        Math.Round(value.Value, 2) :
                        (decimal?)null;

                    _DiscountRate = CalculateDiscountRate();
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
                if (BaseInvoiceType == enInvoiceType.Purchase)
                {
                    _TaxRate = value.HasValue ?
                        Math.Round(value.Value, 2) :
                        (decimal?)null;

                    _TaxAmount = CalculateTaxAmount();
                }
            }
        }
        public decimal? TaxAmount
        {
            get => _TaxAmount;
            set
            {
                if (BaseInvoiceType == enInvoiceType.Purchase)
                {
                    _TaxAmount = value.HasValue ?
                        Math.Round(value.Value, 2) :
                        (decimal?)null;

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
                if (BaseInvoiceType == enInvoiceType.Purchase)
                {
                    return LineSubTotal - DiscountAmount + TaxAmount;
                }
                else if (BaseInvoiceType == enInvoiceType.Sales)
                {
                    return LineSubTotal - CalculateFinalDiscountAmount() + TaxAmount;
                }
                else
                {
                    return LineSubTotal;
                }
            }
            set
            {
                _LineGrandTotal = value;
            }
        }
        public enInvoiceType BaseInvoiceType { get; set; }
        public bool IsNewRow 
        {
            get
            {
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.Sales)
                {
                    return ProductID == null || UnitID == null || UnitPrice == null || Quantity == null ||
                        DiscountRate == null || DiscountAmount == null || TaxRate == null || TaxAmount == null ||
                        LineSubTotal == null || LineGrandTotal == null;
                }
                else
                {
                    return ProductID == null || UnitID == null || UnitPrice == null ||
                        Quantity == null || LineSubTotal == null || LineGrandTotal == null;
                }
            }
        }
        public clsProduct ProductInfo => clsProductService.CreateInstance().Find(ProductID.GetValueOrDefault());
        public clsUnit UnitInfo => clsUnit.Find(UnitID.GetValueOrDefault());
        public List<clsDiscount> SaleDiscounts { get; set; }
        public List<clsTax> SaleTaxes { get; set; }

        private int? _ProductID;
        private int? _UnitID;
        private int? _Quantity;
        private decimal? _UnitPrice;
        private decimal? _FinalUnitPrice;
        private decimal? _DiscountRate;
        private decimal? _DiscountAmount;
        private decimal? _TaxRate;
        private decimal? _TaxAmount;
        private decimal? _LineSubTotal;
        private decimal? _LineGrandTotal;

        public clsInvoiceLine()
        {
            SaleDiscounts = new List<clsDiscount>();
            SaleTaxes = new List<clsTax>();
        }

        public static DataTable ConvertInvoiceLinesListToDataTable(List<clsInvoiceLine> lines)
        {
            DataTable invoiceLines = new DataTable();

            invoiceLines.Columns.Add("ProductID", typeof(int));
            invoiceLines.Columns.Add("UnitID", typeof(int));
            invoiceLines.Columns.Add("UnitPrice", typeof(decimal));
            invoiceLines.Columns.Add("ConversionFactor", typeof(decimal));
            invoiceLines.Columns.Add("Quantity", typeof(short));
            invoiceLines.Columns.Add("DiscountRate", typeof(decimal));
            invoiceLines.Columns.Add("DiscountAmount", typeof(decimal));
            invoiceLines.Columns.Add("TaxRate", typeof(decimal));
            invoiceLines.Columns.Add("TaxAmount", typeof(decimal));
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
                    line.DiscountAmount,
                    line.TaxRate,
                    line.TaxAmount,
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
                            _ProductID = Convert.ToInt32(row["ProductID"]),
                            _UnitID = Convert.ToInt32(row["UnitID"]),
                            _UnitPrice = Convert.ToDecimal(row["UnitPrice"]),
                            ConversionFactor = Convert.ToInt32(row["ConversionFactor"]),
                            _Quantity = Convert.ToInt32(row["Quantity"]),
                            _DiscountRate = row["DiscountRate"] != DBNull.Value ? 
                                Convert.ToDecimal(row["DiscountRate"]) :
                                (decimal?)null,
                            _DiscountAmount = row["DiscountAmount"] != DBNull.Value ?
                                Convert.ToDecimal(row["DiscountAmount"]) :
                                (decimal?)null,
                            SaleDiscounts = clsInvoiceData.GetDiscountsForSaleLine(Convert.ToInt32(row["LineID"]))
                                .AsEnumerable()
                                .Select(discountRow =>
                                {
                                    int discountID = Convert.ToInt32(discountRow["DiscountID"]);

                                    clsDiscount discountItem = clsDiscountService.CreateInstance().Find(discountID);

                                    if (discountItem != null)
                                    {
                                        discountItem.DiscountValue = Convert.ToDecimal(discountRow["DiscountValue"]); ;
                                        discountItem.DiscountValueType = (clsDiscount.enValueType)(Convert.ToBoolean(discountRow["DiscountValueType"]) ? 1 : 0);
                                        discountItem.MinimumQuantity = Convert.ToInt32(discountRow["MinimumQuantity"]);
                                    }

                                    return discountItem;
                                })
                                .Where(discount => discount != null)
                                .ToList(),
                            _TaxRate = row["TaxRate"] != DBNull.Value ?
                                Convert.ToDecimal(row["TaxRate"]) : 
                                (decimal?)null,
                            _TaxAmount = row["TaxAmount"] != DBNull.Value ?
                                Convert.ToDecimal(row["TaxAmount"]) :
                                (decimal?)null,
                            SaleTaxes = clsInvoiceData.GetTaxesForSaleLine(Convert.ToInt32(row["LineID"]))
                                .AsEnumerable()
                                .Select(taxRow =>
                                {
                                    int taxID = Convert.ToInt32(taxRow["TaxID"]);

                                    clsTax taxItem = clsTaxService.CreateInstance().Find(taxID);

                                    if (taxItem != null)
                                    {
                                        taxItem.TaxRate = Convert.ToDecimal(taxRow["TaxRate"]); ;
                                    }

                                    return taxItem;
                                })
                                .Where(taxItem => taxItem != null)
                                .ToList(),
                            _LineSubTotal = Convert.ToDecimal(row["LineSubTotal"]),
                            _LineGrandTotal = Convert.ToDecimal(row["LineGrandTotal"])
                        }
                    );
                }
            }

            return invoiceLines;
        }

        public decimal? CalculateTaxRate()
        {
            return TaxAmount.HasValue && LineSubTotal.HasValue && DiscountAmount.HasValue ?
                Math.Round((TaxAmount / (LineSubTotal - DiscountAmount)).Value * 100, 2) :
                (decimal?)null;
        }

        public decimal? CalculateDiscountRate()
        {
            return DiscountAmount.HasValue && LineSubTotal.HasValue ?
                Math.Round((DiscountAmount / LineSubTotal).Value * 100, 2) :
                (decimal?)null;
        }

        public decimal? CalculateTaxAmount()
        {
            return LineSubTotal.HasValue && DiscountAmount.HasValue && TaxRate.HasValue ?
                Math.Round(((LineSubTotal - DiscountAmount) * (TaxRate / 100)).Value, 2) :
                (decimal?)null;
        }

        public decimal? CalculateFinalTaxAmount()
        {
            return LineSubTotal.HasValue && TaxRate.HasValue ?
                Math.Round(((LineSubTotal - CalculateFinalDiscountAmount()) * (TaxRate / 100)).Value, 2) :
                (decimal?)null;
        }

        public decimal? CalculateDiscountAmount()
        {
            return DiscountRate.HasValue && LineSubTotal.HasValue ?
                Math.Round(((DiscountRate / 100) * LineSubTotal).Value, 2) :
                (decimal?)null;
        }

        public decimal? CalculateFinalDiscountAmount()
        {
            return DiscountAmount.HasValue && DiscountRate.HasValue && LineSubTotal.HasValue ?
                Math.Round((CalculateDiscountAmount() + DiscountAmount).Value, 2) :
                (decimal?)null;
        }

        public decimal? GetSumOfDiscountsValue(clsProduct product, clsDiscount.enValueType valueType)
        {
            if (Quantity == null)
            {
                return null;
            }

            return Math.Round(product.DiscountItems
                .Where(
                    discountItem =>
                    discountItem.UnitID == UnitID.GetValueOrDefault() && discountItem.DiscountInfo.IsActive &&
                    discountItem.DiscountInfo.IsValid && Quantity.GetValueOrDefault() >= discountItem.DiscountInfo.MinimumQuantity &&
                    discountItem.DiscountInfo.DiscountValueType == valueType
                )
                .Sum(discountItem => discountItem.DiscountInfo.DiscountValue), 2);
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

            if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.Sales)
            {
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
            }
            else
            {
                if (DiscountRate.HasValue || DiscountAmount.HasValue || TaxRate.HasValue || TaxAmount.HasValue)
                {
                    validationResult.AddError("الخصومات والضرائب", "لا يجب أن تحتوي فاتورة المرتجعات على خصومات أو ضرائب.");
                }
            }

            return validationResult;
        }

    }
}
