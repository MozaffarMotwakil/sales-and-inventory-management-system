using System;
using System.Windows.Forms;
using BusinessLogic.Products;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Products
{
    public partial class frmProductsList : frmGenericListBase<clsProductService, clsProduct>
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

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف المنتج";
                base.dgvEntitiesList.Columns[0].Width = 95;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم المنتج";
                base.dgvEntitiesList.Columns[1].Width = 200;

                base.dgvEntitiesList.Columns[2].HeaderText = "الباركود";
                base.dgvEntitiesList.Columns[2].Width = 150;

                base.dgvEntitiesList.Columns[3].HeaderText = "التصنيف/الفئة";
                base.dgvEntitiesList.Columns[3].Width = 150;

                base.dgvEntitiesList.Columns[4].HeaderText = "الوحدة الأساسية";
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "الوحدات البديلة";
                base.dgvEntitiesList.Columns[5].Width = 100;

                base.dgvEntitiesList.Columns[6].HeaderText = "سعر البيع";
                base.dgvEntitiesList.Columns[6].Width = 80;

                base.dgvEntitiesList.Columns[7].HeaderText = "المورد الرئيسي";
                base.dgvEntitiesList.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
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
