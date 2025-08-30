using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmAddEditSupplier : Form
    {
        public enMode FormMode;

        public frmAddEditSupplier()
        {
            InitializeComponent();
        }

        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            if (FormMode == enMode.Add)
            {
                this.Text = lblFormTitle.Text = "Add New Supplier";
            }
            else
            {
                this.Text = lblFormTitle.Text = "Edit Supplier";
            }
        }

    }
}
