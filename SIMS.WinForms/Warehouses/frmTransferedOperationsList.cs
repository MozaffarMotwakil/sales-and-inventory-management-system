using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Employees;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmTransferedOperationsList : BaseTransferedOperationsForm
    {
        private DateTime _FirstTransferOperationDate = clsTransferOperationService.GetFirstTransferOperationDate();
        private string[] _WarehouseNames;

        public frmTransferedOperationsList()
        {
            InitializeComponent();
            ShowSearchTextBox = false;
            frmMainForm.CreateInstance().lblCurrentFormName.Text = this.Text;
        }

        private void frmTransferedOperationsList_Load(object sender, EventArgs e)
        {
            dtpDateFrom.MinDate = dtpDateTo.MinDate = _FirstTransferOperationDate;
            dtpTimeFrom.MinDate = dtpTimeTo.MinDate = DateTime.MinValue;

            dtpDateFrom.MaxDate = dtpDateTo.MaxDate = DateTime.Now;
            dtpTimeFrom.MaxDate = dtpTimeTo.MaxDate = DateTime.MaxValue;

            cbRange.SelectedIndex = 3;

            _WarehouseNames = clsWarehouseService.GetWarehouseNames();

            cbSourceWarehouse.Items.AddRange(_WarehouseNames);

            cbDestinationWarehouse.Items.AddRange(_WarehouseNames
                .Cast<string>()
                .Where(warehouseName => warehouseName != cbSourceWarehouse.SelectedText)
                .ToArray()
                );

            cbResponseEmployee.Items.AddRange(clsEmployeeService.GetEmployeeNames());

            cbSourceWarehouse.SelectedIndex = cbDestinationWarehouse.SelectedIndex =
                cbResponseEmployee.SelectedIndex = 0;

            cbRange.SelectedIndex = 3;

            contextMenuStrip.Items.Clear();
            contextMenuStrip.Items.Add("عرض تفاصيل عملية النقل");
            contextMenuStrip.Items[0].Click += ShowTransferOperationInfo_Click;
            contextMenuStrip.Items[0].Image = Resources.inventory;
            contextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;
        }

        private void ShowTransferOperationInfo_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            clsTransferOperation currentTransferOperation  = clsTransferOperationService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

            if (currentTransferOperation != null)
            {
                frmShowTransferOperationInfo showTransferOperationInfo = new frmShowTransferOperationInfo(currentTransferOperation);
                showTransferOperationInfo.ShowDialog();
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على عملية النقل");
            }
        }

        protected override void dgvEntitiesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ShowTransferOperationInfo_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    base.DeleteSelectedEntity();
                }
            }
        }

        protected override void dgvEntitiesList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.Button == MouseButtons.Right || dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            ShowTransferOperationInfo_Click(sender, e);
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDateFrom.Enabled = dtpTimeFrom.Enabled =
                dtpDateTo.Enabled = dtpTimeTo.Enabled = false;

            dtpDateFrom.MinDate = dtpDateTo.MinDate = _FirstTransferOperationDate;

            DateTime currentTime = DateTime.Now;

            dtpDateFrom.MaxDate = dtpDateTo.MaxDate = currentTime;

            dtpDateFrom.Value = dtpDateTo.Value = dtpTimeFrom.Value =
                dtpTimeTo.Value = currentTime;

            if (cbRange.SelectedIndex == 0)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = _FirstTransferOperationDate > DateTime.Now.AddDays(-1) ?
                    _FirstTransferOperationDate :
                    DateTime.Now.AddDays(-1);
            }
            else if (cbRange.SelectedIndex == 1)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = _FirstTransferOperationDate > DateTime.Now.AddDays(-7) ?
                    _FirstTransferOperationDate :
                    DateTime.Now.AddDays(-7);
            }
            else if (cbRange.SelectedIndex == 2)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = _FirstTransferOperationDate > DateTime.Now.AddDays(-30) ?
                    _FirstTransferOperationDate :
                    DateTime.Now.AddDays(-30);
            }
            else if (cbRange.SelectedIndex == 3)
            {
                dtpDateFrom.Value = _FirstTransferOperationDate;
                dtpTimeFrom.Value = _FirstTransferOperationDate;
            }
            else
            {
                dtpDateFrom.Enabled = dtpTimeFrom.Enabled =
                    dtpDateTo.Enabled = dtpTimeTo.Enabled = true;

                dtpDateFrom.Value = currentTime.Date;
                dtpDateTo.Value = currentTime.Date;
                dtpTimeFrom.Value = currentTime.Date;
                dtpTimeTo.Value = currentTime.Date;
            }
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.MinDate = dtpDateFrom.Value;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            if (cbSourceWarehouse.SelectedIndex == -1 || cbDestinationWarehouse.SelectedIndex == -1
                || cbRange.SelectedIndex == -1 || cbResponseEmployee.SelectedIndex == -1)
            {
                clsFormMessages.ShowError("هناك بعض الحقول تحتوي على قيم غير صالحة, رجاءا قم بتعيين قيم صالحة في جميع الحقول للبحث");
                return;
            }

            if (cbSourceWarehouse.SelectedIndex != 0)
            {
                filters.Add($"SourceWarehouseName = '{cbSourceWarehouse.Text}'");
            }

            if (cbDestinationWarehouse.SelectedIndex != 0)
            {
                filters.Add($"DestinationWarehouseName = '{cbDestinationWarehouse.Text}'");
            }

            if (cbResponseEmployee.SelectedIndex != 0)
            {
                filters.Add($"ResponsibleEmployeeName = '{cbResponseEmployee.Text}'");
            }

            filters.Add($"(TransferOperationDateTime >= #{dtpTimeFrom.Value.ToString("HH:mm:ss") + " " + dtpDateFrom.Value.ToString("yyyy-MM-dd")}# AND TransferOperationDateTime <= #{dtpTimeTo.Value.ToString("HH:mm:ss") + " " + dtpDateTo.Value.ToString("yyyy-MM-dd")}#)");

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

        private void cbSourceWarehouse_Leave(object sender, EventArgs e)
        {
            string selectedValue = string.Empty;

            selectedValue = cbDestinationWarehouse.Text;
            cbDestinationWarehouse.Items.Clear();
            cbDestinationWarehouse.Items.Add("كل المخازن");

            cbDestinationWarehouse.Items.AddRange(_WarehouseNames
                 .Cast<string>()
                 .Where(warehouseName => warehouseName != cbSourceWarehouse.Text)
                 .ToArray()
                 );

            if (selectedValue != cbSourceWarehouse.Text)
            {
                cbDestinationWarehouse.SelectedItem = selectedValue;
            }
            else
            {
                cbDestinationWarehouse.SelectedIndex = 0;
            }
        }

        private void cbDestinationWarehouse_Leave(object sender, EventArgs e)
        {
            string selectedValue = string.Empty;

            selectedValue = cbSourceWarehouse.Text;
            cbSourceWarehouse.Items.Clear();
            cbSourceWarehouse.Items.Add("كل المخازن");

            cbSourceWarehouse.Items.AddRange(_WarehouseNames
                 .Cast<string>()
                 .Where(warehouseName => warehouseName != cbDestinationWarehouse.Text)
                 .ToArray()
                 );

            if (selectedValue != cbDestinationWarehouse.Text)
            {
                cbSourceWarehouse.SelectedItem = selectedValue;
            }
            else
            {
                cbSourceWarehouse.SelectedIndex = 0;
            }
        }

    }
}
