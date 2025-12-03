using System;
using System.ComponentModel;
using BusinessLogic.Invoices;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Inventory;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Purchases
{
    public partial class frmPurchasesList : BasePurchasesForm
    {
        public frmPurchasesList()
        {
            InitializeComponent();
            frmMainForm.CreateInstance().lblCurrentFormName.Text = this.Text;
        }

        private void issuePurchaseInvoiceToolStripButton_Click(object sender, EventArgs e)
        {
            frmIssuePurchaseInvoice issuePurchaseInvoiceForm = new frmIssuePurchaseInvoice();
            issuePurchaseInvoiceForm.ShowDialog();
        }

        private void frmPurchasesList_Load(object sender, EventArgs e)
        {
            contextMenuStrip.Items.Clear();
            contextMenuStrip.Items.Add("إصدار فاتورة مرتجعات");
            contextMenuStrip.Items[0].Image = Resources.Invoice_32;
            contextMenuStrip.Items[0].ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            contextMenuStrip.Items[0].Click += IssueReturnPurchaseInvoice_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            base.EntityName = "الفاتورة";
            base.EntityInfoControl = ctrInvoiceInfo;
            base.AllowDeleteRecord = false;
        }

        protected override object GetDataSource()
        {
            return clsInvoiceService.CreateInstance().GetAllPurchaseInvoices();
        }

        private void IssueReturnPurchaseInvoice_Click(object sender, EventArgs e)
        {
            clsInvoice invoice = clsInvoiceService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

            if (invoice == null)
            {
                clsFormMessages.ShowError($"لم يتم العثور على الفاتورة");
                return;
            }

            frmIssuePurchaseReturnInvoice returnPurchaseInvoice = new frmIssuePurchaseReturnInvoice(invoice as clsPurchaseInvoice);
            returnPurchaseInvoice.ShowDialog();
        }

        protected override void SearchTextChanged(object sender, EventArgs e)
        {
            base.SearchTextChanged(sender, e);
            Filter = $"InvoiceNa LIKE '%{txtSearch.Text}%' OR SupplierName LIKE '%{txtSearch.Text}%'";
        }

        protected override void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            base.contextMenuStrip_Opening(sender, e);
            e.Cancel = (SelectedEntity.InvoiceType != enInvoiceType.Purchase);
        }

    }
}
