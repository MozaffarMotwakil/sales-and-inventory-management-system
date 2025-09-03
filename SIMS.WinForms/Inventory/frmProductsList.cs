using System;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIMS.WinForms.Inventory
{
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            lblSearchHintText.Text = "Enter Product Name or Barcode or Supplier";
            cbCatigory.SelectedItem = "All Catigories";
        }

        private void frmProductsList_Activated(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);
        }

        private void pictureBoxAndSearchHintText_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
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
