using System;
using System.Windows.Forms;
using BusinessLogic.Warehouses;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmWarehousesList : frmGenericListBase<clsWarehouseService, clsWarehouse>
    {
        public frmWarehousesList() : base(clsWarehouseService.GetInstance())
        {
            InitializeComponent();
        }

        private void frmWarehousesList_Load(object sender, EventArgs e)
        {
            cbWarehouseActivity.SelectedIndex = 1;
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.SearchHintMessage = "أدخل إسم المخزن أو العنوان";
            base.EntityName = "المخزن";
            base.EntityInfoControl = ctrWarehouseInfo;
        }

        protected override void ResetColumnsOfDGV()
        {
            if (base.dgvEntitiesList.RowCount > 0)
            {
                base.dgvEntitiesList.Columns[0].HeaderText = "معرف المخزن";
                base.dgvEntitiesList.Columns[0].Width = 105;

                base.dgvEntitiesList.Columns[1].HeaderText = "إسم المخزن";
                base.dgvEntitiesList.Columns[1].Width = 225;

                base.dgvEntitiesList.Columns[2].HeaderText = "العنوان";
                base.dgvEntitiesList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.dgvEntitiesList.Columns[3].HeaderText = "عدد العناصر";
                base.dgvEntitiesList.Columns[3].Width = 150;

                base.dgvEntitiesList.Columns[4].HeaderText = "التصنيف";
                base.dgvEntitiesList.Columns[4].Width = 100;

                base.dgvEntitiesList.Columns[5].HeaderText = "الحالة";
                base.dgvEntitiesList.Columns[5].Width = 100;
            }
        }

        protected override void SearchTextChanged(object sender, EventArgs e)
        {
            base.SearchTextChanged(sender, e);

            if (cbWarehouseActivity.SelectedIndex == 0)
            {
                base.Filter = $"WarehouseName LIKE '%{txtSearch.Text}%' OR Address LIKE '%{txtSearch.Text}%'";
            }
            else
            {
                string category = cbWarehouseActivity.SelectedIndex == 1 ? "نشط" : "غير نشط";
                base.Filter = $"(WarehouseName LIKE '%{txtSearch.Text}%' OR Address LIKE '%{txtSearch.Text}%') AND Activity = '{category}'";
            }
        }

        private void cbWarehouseActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;

            if (cbWarehouseActivity.SelectedIndex == 1)
            {
                base.Filter = "Activity = 'نشط'";
            }
            else if (cbWarehouseActivity.SelectedIndex == 2)
            {
                base.Filter = "Activity = 'غير نشط'";
            }
            else
            {
                base.Filter = string.Empty;
            }

            base.ApplySearchFilter();
        }

        private void addWarehouseToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditWarehouse AddWarehouse = new frmAddEditWarehouse();
            AddWarehouse.ShowDialog();
        }

        protected override Form CreateEditForm(clsWarehouse warehouse)
        {
            return new frmAddEditWarehouse(warehouse);
        }

        protected override void HandleEntityInfoDisplay(clsWarehouse warehouse)
        {
            ctrWarehouseInfo.Warehouse = warehouse;
        }

    }
}
