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
    public partial class frmFindProductForEdit : Form
    {
        public frmFindProductForEdit()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditProduct editProduct = new frmAddEditProduct();
            editProduct.FormMode = enMode.Edit;
            editProduct.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
