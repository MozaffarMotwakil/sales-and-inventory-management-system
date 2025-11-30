using System;
using BusinessLogic.Invoices;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Inventory;

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
            issuePurchaseInvoiceForm.Show();
        }

        private void frmPurchasesList_Load(object sender, EventArgs e)
        {
            contextMenuStrip.Items.Clear();
            contextMenuStrip.Items.Add("إصدار فاتورة مرتجعات");
            contextMenuStrip.Items[0].Click += IssueReturnPurchaseInvoice_Click;
        }

        protected override object GetDataSource()
        {
            return clsInvoiceService.CreateInstance().GetAllPurchaseInvoice();
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

        protected override void LoadData()
        {
            base.LoadData();
            base.SearchHintMessage = "أدخل رقم الفاتورة أو إسم المورد";
            base.EntityName = "الفاتورة";
            base.EntityInfoControl = ctrInvoiceInfo;
        }

        protected override void SearchTextChanged(object sender, EventArgs e)
        {
            base.SearchTextChanged(sender, e);
            Filter = $"InvoiceNa LIKE '%{txtSearch.Text}%' OR SupplierName LIKE '%{txtSearch.Text}%'";
        }

        protected override void HandleEntityInfoDisplay(clsInvoice invoice)
        {
            ctrInvoiceInfo.Invoice = invoice;
        }

    }
}
