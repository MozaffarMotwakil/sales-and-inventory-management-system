using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Employees;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmTransfareInventories : Form
    {
        private DataTable _Warehouses;
        private List<clsInventory> _SourceWarehouseAvailableInventories;
        private List<clsInventory> _DestinationWarehouseAvailableInventories;

        public frmTransfareInventories()
        {
            InitializeComponent();
        }

        private void frmTransfareInventories_Load(object sender, EventArgs e)
        {
            dgvTransferedInventories.ColumnHeadersDefaultCellStyle.Font =
                new Font("Tahoma", 7, FontStyle.Bold);

            dgvTransferedInventories.DefaultCellStyle.Font =
                new Font("Tahoma", 8);

            dgvTransferedInventories.Rows[0].Cells[colNo.Index].Value = 1;
            dgvTransferedInventories.Rows[0].Cells[colDelete.Index].Value = Resources.delete;

            dtpDate.Value = dtpTime.Value = DateTime.Now;

            _Warehouses = clsWarehouseService.GetWarehousesList();

            cbSourceWarehouse.DataSource = _Warehouses;
            cbSourceWarehouse.DisplayMember = "WarehouseName";
            cbSourceWarehouse.ValueMember = "WarehouseID";
            cbSourceWarehouse.SelectedValue = 1;

            cbDestinationWarehouse.DataSource = _Warehouses
                .Rows
                .Cast<DataRow>()
                .Where(row => Convert.ToInt32(row["WarehouseID"]) != Convert.ToInt32(cbSourceWarehouse.SelectedValue))
                .CopyToDataTable();

            cbDestinationWarehouse.DisplayMember = "WarehouseName";
            cbDestinationWarehouse.ValueMember = "WarehouseID";
            cbDestinationWarehouse.SelectedValue = 3;

            cbResponsibleEmployee.DataSource = clsEmployeeService.GetEmployeesList();
            cbResponsibleEmployee.DisplayMember = "EmployeeName";
            cbResponsibleEmployee.ValueMember = "EmployeeID";
            cbResponsibleEmployee.SelectedIndex = -1;

            _SourceWarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbSourceWarehouse.SelectedValue)
                .GetAvailableInventories();

            _DestinationWarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbDestinationWarehouse.SelectedValue)
                .GetAvailableInventories();
        }

        private void cbResponsibleEmployee_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(cbResponsibleEmployee, errorProvider, "يجب تعيين موظف مسؤول عن نقل البضاعة");
        }

        private void dgvTransferedInventories_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvTransferedInventories.Rows.Count > 1)
            {
                cbSourceWarehouse.Enabled = cbDestinationWarehouse.Enabled = false;
            }

            _UpdateRowsDetails();
        }

        private void dgvTransferedInventories_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvTransferedInventories.Rows.Count == 1)
            {
                cbSourceWarehouse.Enabled = cbDestinationWarehouse.Enabled = true;
            }

            _UpdateRowsDetails();

            lblTotalProsuctsCount.Text = dgvTransferedInventories
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .GroupBy(row => row.Cells[colProduct.Index].Value)
                .Count()
                .ToString();

            lblTotalItemsCount.Text = dgvTransferedInventories
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Count()
                .ToString();

            lblTotalQuantity.Text = dgvTransferedInventories
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Sum(row => Convert.ToInt32(row.Cells[colTransfareQuantity.Index].Value))
                .ToString();

            lblTotalItemsValue.Text = dgvTransferedInventories
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Sum(row => Convert.ToSingle(row.Cells[colAveragePurchasePrice.Index].Value) * Convert.ToInt32(row.Cells[colTransfareQuantity.Index].Value))
                .ToString() + " جنيه";
        }

        private void _UpdateRowsDetails()
        {
            foreach (DataGridViewRow row in dgvTransferedInventories.Rows)
            {
                row.Cells[colNo.Index].Value = row.Index + 1;
                row.Cells[colDelete.Index].Value = Resources.delete;
            }
        }

        private void cbSourceWarehouse_Leave(object sender, EventArgs e)
        {
            string selectedValue = string.Empty;

            selectedValue = cbDestinationWarehouse.Text;
            cbDestinationWarehouse.SelectedItem = null;
            cbDestinationWarehouse.DataSource = null;

            cbDestinationWarehouse.DataSource = _Warehouses
                .Rows
                .Cast<DataRow>()
                .Where(row => Convert.ToInt32(row["WarehouseID"]) != Convert.ToInt32(cbSourceWarehouse.SelectedValue))
                .CopyToDataTable();

            cbDestinationWarehouse.DisplayMember = "WarehouseName";
            cbDestinationWarehouse.ValueMember = "WarehouseID";

            if (selectedValue != cbSourceWarehouse.Text)
            {
                cbDestinationWarehouse.SelectedItem = selectedValue;
            }
            else
            {
                cbDestinationWarehouse.SelectedIndex = 0;
            }

            _SourceWarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbSourceWarehouse.SelectedValue)
                .GetAvailableInventories();

            _DestinationWarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbDestinationWarehouse.SelectedValue)
                .GetAvailableInventories();
        }

        private void cbDestinationWarehouse_Leave(object sender, EventArgs e)
        {
            string selectedValue = string.Empty;

            selectedValue = cbSourceWarehouse.Text;
            cbSourceWarehouse.DataSource = null;

            cbSourceWarehouse.DataSource = _Warehouses;
            cbSourceWarehouse.DisplayMember = "WarehouseName";
            cbSourceWarehouse.ValueMember = "WarehouseID";

            if (selectedValue != cbDestinationWarehouse.Text)
            {
                cbSourceWarehouse.SelectedItem = selectedValue;
            }
            else
            {
                cbSourceWarehouse.SelectedIndex = 0;
            }

            _SourceWarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbSourceWarehouse.SelectedValue)
                .GetAvailableInventories();

            _DestinationWarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbDestinationWarehouse.SelectedValue)
                .GetAvailableInventories();
        }

        private void dgvTransferedInventories_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvTransferedInventories.Columns[colDelete.Index].Index && e.RowIndex != -1 && e.ColumnIndex != -1 && !dgvTransferedInventories.Rows[e.RowIndex].IsNewRow)
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذا العنصر ؟", "تأكيد",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    dgvTransferedInventories.Rows.RemoveAt(e.RowIndex);
                }

                dgvTransferedInventories.ClearSelection();
            }
        }

        private void dgvTransferedInventories_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow currentRow = dgvTransferedInventories.CurrentRow;
            currentRow.Cells[colProduct.Index].Tag = currentRow.Cells[colProduct.Index].Value;
            currentRow.Cells[colUnit.Index].Tag = currentRow.Cells[colUnit.Index].Value;

            if (e.ColumnIndex == colProduct.Index)
            {
                List<int> selectedProductIDs = dgvTransferedInventories
                    .Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => row != dgvTransferedInventories.CurrentRow && row.Cells[colProduct.Index].Value != null)
                    .Select(row => Convert.ToInt32(row.Cells[colProduct.Index].Value))
                    .ToList();

                DataGridViewComboBoxCell boxCell = dgvTransferedInventories.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _SourceWarehouseAvailableInventories
                    .GroupBy(inventory => inventory.ProductInfo.ProductID)
                    .Select(group => group.First().ProductInfo)
                    .Where(product =>
                        !selectedProductIDs.Contains(product.ProductID.Value) ||
                        _GetSelectedProductUnitIDs(product.ProductID).Count !=
                        _SourceWarehouseAvailableInventories
                        .Where(inventory => inventory.ProductInfo.ProductID == product.ProductID)
                        .Count()
                    )
                    .OrderBy(product => product.ProductName)
                    .ToList();

                colProduct.DisplayMember = "ProductName";
                colProduct.ValueMember = "ProductID";
            }

            if (e.ColumnIndex == colUnit.Index && dgvTransferedInventories.CurrentRow.Cells[colProduct.Index].Value != null)
            {
                DataGridViewComboBoxCell boxCell = dgvTransferedInventories.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _SourceWarehouseAvailableInventories
                    .Where(inventory => inventory.ProductInfo.ProductID == Convert.ToInt32(dgvTransferedInventories.CurrentRow.Cells[colProduct.Index].Value))
                    .Select(inventory => inventory.UnitInfo)
                    .Where(unit => !_GetSelectedProductUnitIDs((int?)dgvTransferedInventories.CurrentRow.Cells[colProduct.Index].Value).Contains(unit.UnitID))
                    .ToList();

                colUnit.DisplayMember = "UnitName";
                colUnit.ValueMember = "UnitID";
            }
        }

        private void dgvTransferedInventories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvTransferedInventories.CurrentRow;
            
            if (e.ColumnIndex == colProduct.Index && dgvTransferedInventories.CurrentCell.Tag != dgvTransferedInventories.CurrentCell.Value && dgvTransferedInventories.CurrentCell.Tag != null)
            {
                DataGridViewComboBoxCell boxCell = currentRow.Cells[colUnit.Index] as DataGridViewComboBoxCell;

                boxCell.DataSource = _SourceWarehouseAvailableInventories
                    .Where(inventory => inventory.ProductInfo.ProductID == Convert.ToInt32(dgvTransferedInventories.CurrentRow.Cells[colProduct.Index].Value))
                    .Select(inventory => inventory.UnitInfo)
                    .Where(unit => !_GetSelectedProductUnitIDs((int?)dgvTransferedInventories.CurrentRow.Cells[colProduct.Index].Value).Contains(unit.UnitID))
                    .ToList();

                colUnit.DisplayMember = "UnitName";
                colUnit.ValueMember = "UnitID";

                currentRow.Cells[colUnit.Index].Value = null;
                currentRow.Cells[colTransfareQuantity.Index].Value = null;

                currentRow.Cells[ColCurrentQuantitySource.Index].Value = null;
                currentRow.Cells[colStatusSource.Index].Value = null;

                currentRow.Cells[colCurrentQuantityDestination.Index].Value = null;
                currentRow.Cells[colStatusDestination.Index].Value = null;

                currentRow.Cells[colAveragePurchasePrice.Index].Value = null;
                currentRow.Cells[colSellingPrice.Index].Value = null;
            }

            if (currentRow.Cells[colProduct.Index].Value != null && currentRow.Cells[colUnit.Index].Value != null)
            {
                clsInventory sourceInventory = _SourceWarehouseAvailableInventories
                    .Find(
                        inventory =>
                        inventory.ProductInfo.ProductID == (int?)currentRow.Cells[colProduct.Index].Value &&
                        inventory.UnitInfo.UnitID == (int)currentRow.Cells[colUnit.Index].Value
                    );

                clsInventory destinationInventory = _DestinationWarehouseAvailableInventories
                    .Find(
                        inventory =>
                        inventory.ProductInfo.ProductID == (int?)currentRow.Cells[colProduct.Index].Value &&
                        inventory.UnitInfo.UnitID == (int)currentRow.Cells[colUnit.Index].Value
                    );

                currentRow.Cells[ColCurrentQuantitySource.Index].Value = sourceInventory?.GetCurrentQuantity();
                currentRow.Cells[colStatusSource.Index].Value = sourceInventory?.GetStatus();

                currentRow.Cells[colCurrentQuantityDestination.Index].Value = destinationInventory?.GetCurrentQuantity() ?? 0;
                currentRow.Cells[colStatusDestination.Index].Value = destinationInventory?.GetStatus() ?? "غير مدرج";

                currentRow.Cells[colAveragePurchasePrice.Index].Value = sourceInventory.AveragePurchasePrice;
                currentRow.Cells[colSellingPrice.Index].Value = sourceInventory.SellingPrice;

                lblTotalProsuctsCount.Text = dgvTransferedInventories
                    .Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow)
                    .GroupBy(row => row.Cells[colProduct.Index].Value)
                    .Count()
                    .ToString();

                lblTotalItemsCount.Text = dgvTransferedInventories
                    .Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow)
                    .Count()
                    .ToString();

                if (currentRow.Cells[colTransfareQuantity.Index].Value != null)
                {
                    int currentQuantity = sourceInventory.GetCurrentQuantity();
                    int transferedQuantity = Convert.ToInt32(currentRow.Cells[colTransfareQuantity.Index].Value);

                    if (transferedQuantity > currentQuantity)
                    {
                        transferedQuantity = currentQuantity;
                        currentRow.Cells[colTransfareQuantity.Index].Value = currentQuantity;
                    }

                    currentRow.Cells[colTransafareQuantityAmount.Index].Value = 
                        Convert.ToSingle(currentRow.Cells[colAveragePurchasePrice.Index].Value) * transferedQuantity;

                    lblTotalQuantity.Text = dgvTransferedInventories
                        .Rows
                        .Cast<DataGridViewRow>()
                        .Where(row => !row.IsNewRow)
                        .Sum(row => Convert.ToInt32(row.Cells[colTransfareQuantity.Index].Value))
                        .ToString();

                    lblTotalItemsValue.Text = dgvTransferedInventories
                        .Rows
                        .Cast<DataGridViewRow>()
                        .Where(row => !row.IsNewRow)
                        .Sum(row => Convert.ToSingle(row.Cells[colAveragePurchasePrice.Index].Value) * Convert.ToInt32(row.Cells[colTransfareQuantity.Index].Value))
                        .ToString() + " جنيه";
                }
            }
        }

        private List<int> _GetSelectedProductUnitIDs(int? productID)
        {
            return dgvTransferedInventories
                .Rows
                .Cast<DataGridViewRow>()
                .Where(
                    row =>
                    row != dgvTransferedInventories.CurrentRow &&
                    row.Cells[colUnit.Index].Value != null &&
                    (int?)row.Cells[colProduct.Index].Value == productID
                )
                .Select(row => Convert.ToInt32(row.Cells[colUnit.Index].Value))
                .ToList();
        }

        private void dgvTransferedInventories_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == colProduct.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    e.Cancel = true;
                    dgvTransferedInventories.CurrentRow.ErrorText = "يجب إختيار منتج";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvTransferedInventories.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colUnit.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    e.Cancel = true;
                    dgvTransferedInventories.CurrentRow.ErrorText = "يجب إختيار وحدة";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvTransferedInventories.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colTransfareQuantity.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvTransferedInventories.CurrentRow.ErrorText = "لا يمكن أن يكون حقل الكمية فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if ((!IsCurrentCellEmpty()) && (!int.TryParse(dgvTransferedInventories.CurrentCell.EditedFormattedValue?.ToString(), out int quantity) || quantity < 1))
                {
                    e.Cancel = true;
                    dgvTransferedInventories.CurrentRow.ErrorText = "يجب أن تكون الكمية رقماً صحيحاً أكبر من صفر";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvTransferedInventories.CurrentRow.ErrorText = string.Empty;
                }
            }
        }

        private bool IsEmptyCell(int rowIndex, int colIndex)
        {
            return string.IsNullOrWhiteSpace(dgvTransferedInventories.Rows[rowIndex].Cells[colIndex].EditedFormattedValue?.ToString());
        }

        private bool IsCurrentCellEmpty()
        {
            return IsEmptyCell(dgvTransferedInventories.CurrentCell.RowIndex, dgvTransferedInventories.CurrentCell.ColumnIndex);
        }

        private bool IsCurrentRowHasData()
        {
            for (int i = 1; i <= 3; i++)
            {
                if (!IsEmptyCell(dgvTransferedInventories.CurrentCell.RowIndex, i) && i != dgvTransferedInventories.CurrentCell.ColumnIndex)
                {
                    return true;
                }
            }

            return false;
        }

        private void dgvTransferedInventories_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            bool isThereEmptyCellInCurrentRow = (
                IsEmptyCell(e.RowIndex, colProduct.Index) ||
                IsEmptyCell(e.RowIndex, colUnit.Index) ||
                IsEmptyCell(e.RowIndex, colTransfareQuantity.Index) 
                );

            if ((!string.IsNullOrEmpty(dgvTransferedInventories.CurrentRow.ErrorText) || isThereEmptyCellInCurrentRow) && e.RowIndex != dgvTransferedInventories.NewRowIndex)
            {
                e.Cancel = true;
                dgvTransferedInventories.CurrentRow.ErrorText = "يجب إدخال جميع بيانات الصف الحالي بشكل صحيح قبل الإنتقال لصف جديد";
                SystemSounds.Asterisk.Play();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsFormValidation.IsDataValid(this, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            if (!clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                return;
            }

            clsTransferOperation transferOperation = new clsTransferOperation(
                Convert.ToInt32(cbSourceWarehouse.SelectedValue),
                Convert.ToInt32(cbDestinationWarehouse.SelectedValue),
                Convert.ToInt32(cbResponsibleEmployee.SelectedValue),
                _GetTransferedInventories(),
                new DateTime(
                    dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day,
                    dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second
                    )
                );

            clsValidationResult validationResult = transferOperation.PerformTransferOperation();

            if (validationResult.IsValid)
            {
                clsFormMessages.ShowSuccess("تم إدراج عملية النقل بنجاح");
                this.Close();
            }
            else
            {
                clsFormMessages.ShowValidationErrors(validationResult);
            }

        }

        private List<clsTransferedInventory> _GetTransferedInventories()
        {
            List<clsTransferedInventory> transferedInventories = new List<clsTransferedInventory>();

            for (int i = 0; i < dgvTransferedInventories.Rows.Count - 1; i++)
            {
                for (int j = 0; j < _SourceWarehouseAvailableInventories.Count; j++)
                {
                    if (Convert.ToInt32(dgvTransferedInventories.Rows[i].Cells[colProduct.Index].Value) == 
                        Convert.ToInt32(_SourceWarehouseAvailableInventories[j].ProductInfo.ProductID) &&
                        Convert.ToInt32(dgvTransferedInventories.Rows[i].Cells[colUnit.Index].Value) ==
                        Convert.ToInt32(_SourceWarehouseAvailableInventories[j].UnitInfo.UnitID))
                    {
                        transferedInventories.Add(new clsTransferedInventory(
                            _SourceWarehouseAvailableInventories[j].InventoryID,
                            Convert.ToInt32(dgvTransferedInventories.Rows[i].Cells[colTransfareQuantity.Index].Value),
                            Convert.ToSingle(dgvTransferedInventories.Rows[i].Cells[colAveragePurchasePrice.Index].Value)
                            )
                        );
                    }
                }
            }

            return transferedInventories;
        }

    }
}
