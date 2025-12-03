using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmWarehouswList : BaseWarehousesForm
    {
        protected override Form EditEntityForm => new frmAddEditWarehouse(SelectedEntity);

        public frmWarehouswList() 
        {
            InitializeComponent();
            frmMainForm.CreateInstance().lblCurrentFormName.Text = this.Text;
        }

        private void frmWarehousesList_Load(object sender, EventArgs e)
        {
            cbWarehouseActivity.SelectedIndex = 1;
            dgvEntitiesList.CellMouseDown += dgvEntitiesList_CellMouseDown;
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.EntityName = "المخزن";
            base.IsEntitySupportActivityStatus = true;
            base.EntityInfoControl = ctrWarehouseInfo;
        }

        private void cbWarehouseActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ApplySearchFilter();
        }

        protected override void ApplySearchFilter()
        {
            List<string> filters = new List<string>();

            if (cbWarehouseActivity.SelectedIndex == 1)
            {
                filters.Add("IsActive = 1");
            }
            else if (cbWarehouseActivity.SelectedIndex == 2)
            {
                filters.Add("IsActive = 0");
            }

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                filters.Add($"(WarehouseName LIKE '%{txtSearch.Text}%' OR Address LIKE '%{txtSearch.Text}%')");
            }

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

        private void addWarehouseToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddEditWarehouse AddWarehouse = new frmAddEditWarehouse();
            AddWarehouse.ShowDialog();
        }

        private void TransfareInventoriesBetweenWarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsWarehouseService.GetActiveWarehousesList().Rows.Count < 2)
            {
                clsFormMessages.ShowError("يجب أن يتوفر مخزنين نشطين على الأقل لإجراء عملية نقل");
                return;
            }

            frmTransfareInventories transfareInventories = new frmTransfareInventories();
            transfareInventories.ShowDialog();
        }

        protected override void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            base.contextMenuStrip_Opening(sender, e);

            if (dgvEntitiesList.CurrentRow.Index >= 0)
            {
                if (SelectedEntity != null)
                {
                    if (SelectedEntity.Type == clsWarehouse.enWarehouseType.ShopWarehouse)
                    {
                        e.Cancel = true;
                        return;
                    }
                } 
            }
        }

    }
}
