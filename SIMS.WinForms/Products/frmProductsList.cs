using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Products
{
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            lblSearchHintText.Text = "أدخل إسم المنتج أو الباركود الخاص بالمنتج";
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

        private void addProducrToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditProduct addProduct = new frmAddEditProduct();
            addProduct.FormMode = enMode.Add;
            addProduct.ShowDialog();
        }

    }
}
