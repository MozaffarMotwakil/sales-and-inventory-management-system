using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using SIMS.WinForms.Suppliers;
using SIMS.WinForms.Users;

namespace SIMS.WinForms.Invoices
{
    public partial class ctrInvoiceInfo : UserControl
    {
        public bool ShowPartyInfo;

        private clsInvoice _Invoice;
        public clsInvoice Invoice 
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
                lblPaymentAmount.Text = _Invoice.PaymentAmount?.ToString("0.##");
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
            frmShowUserInfo userInfo = new frmShowUserInfo();
            userInfo.ShowDialog();
        }

        private void _SetInvoiceLinesToDGV(List<clsInvoiceLine> invoiceLines)
        {
            dgvPurchasedProducts.Rows.Clear();

            for (int i = 0; i < invoiceLines.Count; i++)
            {
                try
                {
                    dgvPurchasedProducts.Rows.Add(
                        i + 1,
                        invoiceLines[i].ProductInfo.ProductName, 
                        invoiceLines[i].UnitInfo.UnitName,
                        invoiceLines[i].Quantity,
                        invoiceLines[i].UnitPrice.ToString("0.##"),
                        invoiceLines[i].LineSubTotal.ToString("0.##"),
                        invoiceLines[i].DiscountRate.ToString("0.##") + "%",
                        invoiceLines[i].CalculateDiscountAmount().ToString("0.##"),
                        invoiceLines[i].TaxRate.ToString("0.##") + "%",
                        invoiceLines[i].CalculateTaxAmount().ToString("0.##"),
                        invoiceLines[i].LineGrandTotal.ToString("0.##")
                        );
                }
                catch { }
            }
        }

    }
}
