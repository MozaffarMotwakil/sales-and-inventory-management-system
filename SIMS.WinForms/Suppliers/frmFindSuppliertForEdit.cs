using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmFindSuppliertForEdit : Form
    {
        public frmFindSuppliertForEdit()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //frmAddEditSupplier editSupplier = new frmAddEditSupplier();
            //editSupplier.FormMode = enMode.Edit;
            //editSupplier.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
