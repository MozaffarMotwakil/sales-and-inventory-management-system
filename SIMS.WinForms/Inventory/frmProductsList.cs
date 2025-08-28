using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Inventory
{
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProduct addProduct = new frmAddEditProduct();
            addProduct.FormMode = enMode.Add;
            addProduct.ShowDialog();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            frmFindProductForEdit productForEdit = new frmFindProductForEdit();
            productForEdit.ShowDialog();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            frmFindProductForDelete productForDelete = new frmFindProductForDelete();
            productForDelete.ShowDialog();
        }

        private void btnReceiveGoods_Click(object sender, EventArgs e)
        {
            frmReceiveNewGoods receiveNewGoods = new frmReceiveNewGoods();
            receiveNewGoods.ShowDialog();
        }

    }
}
