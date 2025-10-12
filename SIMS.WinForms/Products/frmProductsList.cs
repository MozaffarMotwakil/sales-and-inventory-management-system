using System;
using System.Windows.Forms;
using BusinessLogic.Products;

namespace SIMS.WinForms.Products
{
    public partial class frmProductsList : BaseProductsForm
    {
        public frmProductsList()
        {
            InitializeComponent();
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;
            cbCategory.Items.AddRange(clsCategory.GetCategoryNames());
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.SearchHintMessage = "أدخل إسم المنتج أو الباركود الخاص بالمنتج";
            base.EntityName = "المنتج";
            base.EntityInfoControl = ctrProductInfo;
        }

        protected override void SearchTextChanged(object sender, EventArgs e)
        {
            base.SearchTextChanged(sender, e);

            if (cbCategory.SelectedIndex == 0)
            {
                Filter = $"ProductName LIKE '%{txtSearch.Text}%' OR Barcode LIKE '%{txtSearch.Text}%'";
            }
            else
            {
                Filter = $"(ProductName LIKE '%{txtSearch.Text}%' OR Barcode LIKE '%{txtSearch.Text}%') AND CategoryName = '{cbCategory.SelectedItem}'";
            }
        }

        private void cbCatigory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;

            if (cbCategory.SelectedIndex != 0)
            {
                Filter = $"CategoryName LIKE '%{cbCategory.Text}%'";
            }
            else
            {
                Filter = string.Empty;
            }

            base.ApplySearchFilter();
        }

        private void cbCatigory_Leave(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == -1)
            {
                cbCategory.SelectedIndex = 0;
            }
        }

        private void addProducrToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditProduct addProduct = new frmAddEditProduct();
            addProduct.ShowDialog();
        }

        protected override Form CreateEditForm(clsProduct product)
        {
            return new frmAddEditProduct(product);
        }

        protected override void HandleEntityInfoDisplay(clsProduct product)
        { 
            ctrProductInfo.Product = product;
        }

    }
}
