using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using SIMS.WinForms.Interfaces;
using SIMS.WinForms.Suppliers;
using SIMS.WinForms.Users;

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
                lblPaymentAmount.Text = _Invoice.PaymentAmount?.ToString("0.##") ?? "0";
                llPartyName.Text = _Invoice.GetPartyName();
                llCreatedByUser.Text = _Invoice.CreatedByUserInfo.UserName;
                lblSubtotal.Text = _Invoice.TotalSubTotal.ToString("0.##");
                lblDiscountTotal.Text = _Invoice.TotalDiscountAmount.ToString("0.##");
                lblTaxTotal.Text = _Invoice.TotalTaxAmount.ToString("0.##");
                lblGrandTotal.Text = _Invoice.GrandTotal.ToString("0.##");
                _SetInvoiceLinesToDGV(_Invoice.Lines);
            }
        }

        public ctrInvoiceInfo()
        {
            InitializeComponent();
            ShowPartyInfo = true;
        }

        private void ctrInvoiceInfo_Load(object sender, EventArgs e)
        {
            dgvInvoiceLines.CellToolTipTextNeeded += dgvInvoiceLines_CellToolTipTextNeeded;
        }

        private void dgvInvoiceLines_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            // 1. التأكد من أن الفاتورة ليست فارغة وأننا فوق سطر بيانات
            if (_Invoice == null || e.RowIndex < 0 || e.RowIndex >= _Invoice.Lines.Count)
            {
                return;
            }

            // 2. التحقق من نوع الفاتورة (مبيعات أو مرتجع مبيعات فقط)
            if (_Invoice.InvoiceType != enInvoiceType.Sales && _Invoice.InvoiceType != enInvoiceType.SalesReturn)
            {
                return;
            }

            var line = _Invoice.Lines[e.RowIndex];

            if (line == null)
            {
                return;
            }

            // ملاحظة: استبدل أسماء الأعمدة (col...) بالأسماء البرمجية لديك في المصمم 
            // أو استخدم رقم الفهرس (Index) بناءً على ترتيب الإضافة في دالة _SetInvoiceLinesToDGV

            // تلميح مبلغ الخصم (العمود رقم 7 في ترتيب الإضافة لديك)
            if (e.ColumnIndex == colDiscountAmount.Index && line.SaleDiscounts.Any())
            {
                var amountDiscounts = line.SaleDiscounts
                    .Where(d => d.DiscountValueType == clsDiscount.enValueType.Amount)
                    .Select(d => $"{d.DiscountName}: {d.DiscountValue:N2}");

                if (amountDiscounts.Any())
                    e.ToolTipText = "تفاصيل المبالغ المخصومة:" + Environment.NewLine + string.Join(Environment.NewLine, amountDiscounts);
            }

            // تلميح نسبة الخصم (العمود رقم 6 في ترتيب الإضافة لديك)
            else if (e.ColumnIndex == colDiscountRate.Index && line.SaleDiscounts.Any())
            {
                var percentDiscounts = line.SaleDiscounts
                    .Where(d => d.DiscountValueType == clsDiscount.enValueType.Percentage)
                    .Select(d => $"{d.DiscountName}: {d.DiscountValue}%");

                if (percentDiscounts.Any())
                    e.ToolTipText = "تفاصيل نسب الخصم:" + Environment.NewLine + string.Join(Environment.NewLine, percentDiscounts);
            }

            // تلميح الضرائب (الأعمدة رقم 8 و 9)
            else if ((e.ColumnIndex == colTaxAmount.Index || e.ColumnIndex == colTaxRate.Index) && line.SaleTaxes.Any())
            {
                var taxes = line.SaleTaxes
                    .Select(t => $"{t.TaxName}: {t.TaxRate}%");

                e.ToolTipText = "الضرائب المطبقة على هذا الصنف:" + Environment.NewLine + string.Join(Environment.NewLine, taxes);
            }
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

        private void llCreatedByUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            return;
        }

        private void _SetInvoiceLinesToDGV(List<clsInvoiceLine> invoiceLines)
        {
            dgvInvoiceLines.Rows.Clear();

            for (int i = 0; i < invoiceLines.Count; i++)
            {
                try
                {
                    dgvInvoiceLines.Rows.Add(
                        i + 1,
                        invoiceLines[i].ProductInfo.ProductName, 
                        invoiceLines[i].UnitInfo.UnitName,
                        invoiceLines[i].Quantity.GetValueOrDefault(),
                        invoiceLines[i].UnitPrice.GetValueOrDefault().ToString("0.##"),
                        invoiceLines[i].LineSubTotal.GetValueOrDefault().ToString("0.##"),
                        invoiceLines[i].DiscountRate.GetValueOrDefault().ToString("0.##") + "%",
                        invoiceLines[i].DiscountAmount.GetValueOrDefault().ToString("0.##"),
                        invoiceLines[i].TaxRate.GetValueOrDefault().ToString("0.##") + "%",
                        invoiceLines[i].TaxAmount.GetValueOrDefault().ToString("0.##"),
                        invoiceLines[i].LineGrandTotal.GetValueOrDefault().ToString("0.##")
                        );
                }
                catch { }
            }
        }


    }
}
