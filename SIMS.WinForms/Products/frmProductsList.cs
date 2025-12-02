using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Products;

namespace SIMS.WinForms.Products
{
    public partial class frmProductsList : BaseProductsForm
    {
        public frmProductsList()
        {
            InitializeComponent();
            frmMainForm.CreateInstance().lblCurrentFormName.Text = this.Text;
        }

        private void frmProductsList_Load(object sender, EventArgs e)
        {
            cbProductActivity.SelectedIndex = 0;
            cbCategory.SelectedIndex = 0;
            cbCategory.Items.AddRange(clsCategory.GetCategoryNames());
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.EntityName = "المنتج";
            base.IsEntitySupportActivityStatus = true;
            base.EntityInfoControl = ctrProductInfo;
        }

        protected override bool GetEntityActivityStatus()
        {
            return GetSelectedEntity().IsActive;
        }

        protected override bool MarkRecordAsActive()
        {
            return GetSelectedEntity().MarkAsActive();
        }

        protected override bool MarkRecordAsInActive()
        {
            return GetSelectedEntity().MarkAsInActive();
        }

        private void cbCatigory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ApplySearchFilter();
        }

        private void cbProductActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ApplySearchFilter();
        }

        protected override void ApplySearchFilter()
        {
            List<string> filters = new List<string>();

            if (cbCategory.SelectedIndex > 0)
            {
                filters.Add($"CategoryName = '{cbCategory.SelectedItem}'");
            }

            if (cbProductActivity.SelectedIndex == 1)
            {
                filters.Add("IsActive = 1");
            }
            else if (cbProductActivity.SelectedIndex == 2)
            {
                filters.Add("IsActive = 0");
            }

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                filters.Add($"(ProductName LIKE '%{txtSearch.Text}%' OR MainSupplierName LIKE '%{txtSearch.Text}%')");
            }

            base.Filter = string.Join(" AND ", filters);
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
