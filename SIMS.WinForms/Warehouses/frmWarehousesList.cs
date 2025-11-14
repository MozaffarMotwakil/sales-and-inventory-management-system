using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Warehouses
{
    public partial class e : BaseWarehousesForm
    {
        private clsWarehouseService _WarehouseService;
        public e() 
        {
            InitializeComponent();
            _WarehouseService = clsWarehouseService.CreateInstance();
        }

        private void frmWarehousesList_Load(object sender, EventArgs e)
        {
            cbWarehouseActivity.SelectedIndex = 1;

            contextMenuStrip.Items.Add("تنشيط", Resources.active);
            contextMenuStrip.Items[2].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[2].Click += MarkSupplierAsActive_Click;

            contextMenuStrip.Items.Add("إلغاء التنشيط", Resources.in_active);
            contextMenuStrip.Items[3].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[3].Click += MarkSupplierAsInActive_Click; 

            contextMenuStrip.Items.Add("عرض نسب تمثيل التصنيفات/الفئات");
            contextMenuStrip.Items[4].ImageScaling = ToolStripItemImageScaling.None;
            
            contextMenuStrip.Items.Add("عرض نسب تمثيل الوحدات");
            contextMenuStrip.Items[5].ImageScaling = ToolStripItemImageScaling.None;

            dgvEntitiesList.CellMouseDown += dgvEntitiesList_CellMouseDown;
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.SearchHintMessage = "أدخل إسم المخزن أو العنوان";
            base.EntityName = "المخزن";
            base.EntityInfoControl = ctrWarehouseInfo;
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

        private void dgvEntitiesList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEntitiesList.Rows[e.RowIndex].Selected = true;
        }

        protected override void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            base.contextMenuStrip_Opening(sender, e);

            if (dgvEntitiesList.CurrentRow.Index >= 0)
            {
                contextMenuStrip.Items[2].Visible = contextMenuStrip.Items[3].Visible = false;
                clsWarehouse warehouse = _WarehouseService.Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));
                
                if (warehouse != null)
                {
                    if (warehouse.Type == clsWarehouse.enWarehouseType.ShopWarehouse)
                    {
                        e.Cancel = true;
                        return;
                    }

                    if (warehouse.IsActive)
                    {
                        contextMenuStrip.Items[3].Visible = true;
                    }
                    else
                    {
                        contextMenuStrip.Items[2].Visible = true;
                    }
                } 
            }
        }

        private void MarkSupplierAsInActive_Click(object sender, EventArgs e)
        {
            if (base.dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            clsWarehouse warehouse = _WarehouseService.Find(clsFormHelper.GetSelectedRowID(base.dgvEntitiesList));

            if (warehouse == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على المخزن");
                return;
            }

            if (_WarehouseService.MarkAsInActive(warehouse))
            {
                clsFormMessages.ShowSuccess("تم إلغاء تنشيط المخزن بنجاح");
            }
            else
            {
                clsFormMessages.ShowError("فشل إلغاء تنشيط المخزن");
            }
        }

        private void MarkSupplierAsActive_Click(object sender, EventArgs e)
        {
            if (base.dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            clsWarehouse warehouse = _WarehouseService.Find(clsFormHelper.GetSelectedRowID(base.dgvEntitiesList));

            if (warehouse == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على المخزن");
                return;
            }

            if (_WarehouseService.MarkAsActive(warehouse))
            {
                clsFormMessages.ShowSuccess("تم تنشيط المخزن بنجاح");
            }
            else
            {
                clsFormMessages.ShowError("فشل تنشيط المخزن");
            }
        }

    }
}
