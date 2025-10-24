using System;
using BusinessLogic.Products;
using SIMS.WinForms.Inventory;

namespace SIMS.WinForms.Purchases
{
    public partial class frmPurchasesList : BasePurchasesForm
    {
        public frmPurchasesList()
        {
            InitializeComponent();
        }

        private void issuePurchaseInvoiceToolStripButton_Click(object sender, EventArgs e)
        {
            frmIssuePurchaseInvoice issuePurchaseInvoiceForm = new frmIssuePurchaseInvoice();
            issuePurchaseInvoiceForm.Show();
        }

        private void frmPurchasesList_Load(object sender, EventArgs e)
        {
            contextMenuStrip.Items.Clear();
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.SearchHintMessage = "أدخل رقم الفاتورة أو إسم المورد";
            base.EntityName = "الفاتورة";
        }

        protected override void SearchTextChanged(object sender, EventArgs e)
        {
            base.SearchTextChanged(sender, e);
            Filter = $"InvoiceNa LIKE '%{txtSearch.Text}%' OR SupplierName LIKE '%{txtSearch.Text}%'";
        }

    }
}
