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
                    UnitPrice = null;
                    ConversionFactor = null;
                    Quantity = null;
                    UnitPrice = null;
                    FinalUnitPrice = null;
                    LineSubTotal = null;
                    DiscountRate = null;
                    DiscountAmount = null;
                    SaleDiscounts.Clear();
                    TaxRate = null;
                    TaxAmount = null;
                    SaleTaxes.Clear();
                    LineGrandTotal = null;
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
                    UnitPrice = null;
                    ConversionFactor = null;
                    Quantity = null;
                    UnitPrice = null;
                    FinalUnitPrice = null;
                    LineSubTotal = null;
                    DiscountRate = null;
                    DiscountAmount = null;
                    SaleDiscounts.Clear();
                    TaxRate = null;
                    TaxAmount = null;
                    SaleTaxes.Clear();
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
                _Quantity = value;

                if (BaseInvoiceType == enInvoiceType.Sales || BaseInvoiceType == enInvoiceType.SalesReturn)
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
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.PurchaseReturn)
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
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.PurchaseReturn)
                {
                    _DiscountAmount = value.HasValue ?
                        Math.Round(value.Value, 2) :
                        (decimal?)null;

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
                if (BaseInvoiceType == enInvoiceType.Purchase || BaseInvoiceType == enInvoiceType.PurchaseReturn)
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
                            DiscountRate = Convert.ToDecimal(row["DiscountRate"]),
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
                            TaxRate = Convert.ToDecimal(row["TaxRate"]),
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
                            LineSubTotal = Convert.ToDecimal(row["LineSubTotal"]),
                            LineGrandTotal = Convert.ToDecimal(row["LineGrandTotal"])
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
            return DiscountAmount.HasValue ?
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

            return validationResult;
        }

    }
}
