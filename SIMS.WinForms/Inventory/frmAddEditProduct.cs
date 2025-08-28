using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS.WinForms.Inventory
{
    public enum enMode { Add, Edit };

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
