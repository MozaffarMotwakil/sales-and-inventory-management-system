using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Products;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmWarehouswList : BaseWarehousesForm
    {
        private clsWarehouseService _WarehouseService;
        public frmWarehouswList() 
        {
            InitializeComponent();
            _WarehouseService = clsWarehouseService.CreateInstance();
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

        protected override Form CreateEditForm(clsWarehouse warehouse)
        {
            return new frmAddEditWarehouse(warehouse);
        }

        protected override void HandleEntityInfoDisplay(clsWarehouse warehouse)
        {
            ctrWarehouseInfo.Warehouse = warehouse;
        }

        private void dgvEntitiesList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvEntitiesList.Rows[e.RowIndex].Selected = true;
            }
        }

        protected override void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            base.contextMenuStrip_Opening(sender, e);

            if (dgvEntitiesList.CurrentRow.Index >= 0)
            {
                clsWarehouse warehouse = GetSelectedEntity();
                
                if (warehouse != null)
                {
                    if (warehouse.Type == clsWarehouse.enWarehouseType.ShopWarehouse)
                    {
                        e.Cancel = true;
                        return;
                    }
                } 
            }
        }

        private void TransfareInventoriesBetweenWarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransfareInventories transfareInventories = new frmTransfareInventories();
            transfareInventories.ShowDialog();
        }

    }
}
