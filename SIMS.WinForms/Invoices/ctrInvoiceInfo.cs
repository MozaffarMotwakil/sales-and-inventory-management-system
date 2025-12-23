using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using SIMS.WinForms.Interfaces;
using SIMS.WinForms.Suppliers;

namespace SIMS.WinForms.Invoices
{
    public partial class ctrInvoiceInfo : UserControl, IEntityView<clsInvoice>
    {
        public bool ShowPartyInfo;

        private clsInvoice _Invoice;
        public clsInvoice Entity 
        {
            get
            {
                return _Invoice;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                _Invoice = value;
                lblInvoiceNo.Text = _Invoice.InvoiceNo;
                lblIssuedDate.Text = _Invoice.InvoiceDate.ToString("dd/MM/yyyy");
                lblWarehouse.Text = _Invoice.WarehouseInfo.WarehouseName;
                lblInvoiceType.Text = _Invoice.GetInvoiceTypeName();
                lblInvoiceStatus.Text = _Invoice.GetInvoiceStatusName();
                lblPaymentMethod.Text = _Invoice.GetPaymentMethodName();
                lblPaymentAmount.Text = _Invoice.PaymentAmount?.ToString() ?? "0";
                llPartyName.Text = _Invoice.GetPartyName();
                llCreatedByUser.Text = _Invoice.CreatedByUserInfo.UserName;
                lblSubtotal.Text = _Invoice.TotalSubTotal.ToString();
                lblDiscountTotal.Text = _Invoice.TotalDiscountAmount.ToString();
                lblTaxTotal.Text = _Invoice.TotalTaxAmount.ToString();
                lblGrandTotal.Text = _Invoice.GrandTotal.ToString();
                _SetInvoiceLinesToDGV(_Invoice.Lines);
            }
        }

        public ctrInvoiceInfo()
        {
            InitializeComponent();
            ShowPartyInfo = true;
        }

        private void llPartyName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!ShowPartyInfo)
            {
                return;
            }

            if (_Invoice is clsPurchaseInvoice purchaseInvoice && purchaseInvoice.Supplier != null)
            {
                frmShowSupplierInfo supplierInfo = new frmShowSupplierInfo(purchaseInvoice.Supplier);
                supplierInfo.ShowDialog();
            }
            else if (_Invoice is clsPurchaseReturnInvoice purchaseReturnInvoice && purchaseReturnInvoice?.OriginalInvoiceInfo?.Supplier != null)
            {
                frmShowSupplierInfo supplierInfo = new frmShowSupplierInfo(purchaseReturnInvoice?.OriginalInvoiceInfo?.Supplier);
                supplierInfo.ShowDialog();
            }
        }

        private void llCreatedByUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        
        private void _SetInvoiceLinesToDGV(List<clsInvoiceLine> invoiceLines)
        {
            dgvInvoiceLines.Rows.Clear();

            for (int i = 0; i < invoiceLines.Count; i++)
            {
                var line = invoiceLines[i];
                if (line == null) continue;

                try
                {
                    int rowIndex = dgvInvoiceLines.Rows.Add(
                        i + 1,
                        line.ProductInfo.ProductName,
                        line.UnitInfo.UnitName,
                        line.Quantity.GetValueOrDefault(),
                        line.UnitPrice.GetValueOrDefault().ToString(),
                        line.LineSubTotal.GetValueOrDefault().ToString(),
                        line.DiscountRate.GetValueOrDefault().ToString() + "%",
                        line.DiscountAmount.GetValueOrDefault().ToString(),
                        line.TaxRate.GetValueOrDefault().ToString() + "%",
                        line.TaxAmount.GetValueOrDefault().ToString(),
                        line.LineGrandTotal.GetValueOrDefault().ToString()
                    );

                    var row = dgvInvoiceLines.Rows[rowIndex];

                    if (_Invoice.InvoiceType == enInvoiceType.Sales || _Invoice.InvoiceType == enInvoiceType.SalesReturn)
                    {
                        // --- تلميح مبلغ الخصم ---
                        if (line.SaleDiscounts != null && line.SaleDiscounts.Any())
                        {
                            var amountDiscounts = line.SaleDiscounts
                                .Where(d => d.DiscountValueType == clsDiscount.enValueType.Amount)
                                .Select(d => $"{d.DiscountName}: {d.DiscountValue:N2}").ToList();

                            if (amountDiscounts.Any())
                            {
                                row.Cells[colDiscountAmount.Index].ToolTipText = "تفاصيل المبالغ المخصومة:" +
                                    Environment.NewLine + string.Join(Environment.NewLine, amountDiscounts);
                            }

                            // --- تلميح نسبة الخصم ---
                            var percentDiscounts = line.SaleDiscounts
                                .Where(d => d.DiscountValueType == clsDiscount.enValueType.Percentage)
                                .Select(d => $"{d.DiscountName}: {d.DiscountValue}%").ToList();

                            if (percentDiscounts.Any())
                            {
                                row.Cells[colDiscountRate.Index].ToolTipText = "تفاصيل نسب الخصم:" +
                                    Environment.NewLine + string.Join(Environment.NewLine, percentDiscounts);
                            }
                        }

                        // --- تلميح الضرائب ---
                        if (line.SaleTaxes != null && line.SaleTaxes.Any())
                        {
                            var taxes = line.SaleTaxes.Select(t => $"{t.TaxName}: {t.TaxRate}%");
                            string taxToolTip = "الضرائب المطبقة على هذا الصنف:" +
                                               Environment.NewLine + string.Join(Environment.NewLine, taxes);

                            row.Cells[colTaxAmount.Index].ToolTipText = taxToolTip;
                            row.Cells[colTaxRate.Index].ToolTipText = taxToolTip;
                        }
                    }
                }
                catch { }
            }
        }


    }
}
