using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Inventory
{
    public partial class frmAddEditProduct : Form
    {
        public enMode FormMode;

        public frmAddEditProduct()
        {
            InitializeComponent();
            FormMode = enMode.Add;
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            if (FormMode == enMode.Add)
            {
                this.Text = "Add Product";
            }
            else
            {
                this.Text = "Edit Product";
            }
        }

    }
}
