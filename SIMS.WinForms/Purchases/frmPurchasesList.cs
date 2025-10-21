using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS.WinForms.Inventory;

namespace SIMS.WinForms.Purchases
{
    public partial class frmPurchasesList : BasePurchasesForm
    {
        frmIssuePurchaseInvoice IssuePurchaseInvoiceForm;
        public frmPurchasesList()
        {
            InitializeComponent();
        }

        private void issuePurchaseInvoiceToolStripButton_Click(object sender, EventArgs e)
        {
                IssuePurchaseInvoiceForm = new frmIssuePurchaseInvoice();
                IssuePurchaseInvoiceForm.Show();
        }

    }
}
