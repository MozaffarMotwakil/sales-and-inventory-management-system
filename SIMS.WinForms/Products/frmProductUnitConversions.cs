using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Products;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Products
{
    public partial class frmProductUnitConversions : Form
    {
        public List<clsProductUnitConversion> UnitConversions { get; private set; }
        public new string ProductName { get; set; }
        public string BaseUnit { get; set; }
        public enMode FormMode { get; set; }

        private int _ErrorColumnIndex;
        private bool _FirstTimeEdit = true;
        private bool _IsSaved = false;

        public frmProductUnitConversions()
        {
            InitializeComponent();
            UnitConversions = new List<clsProductUnitConversion>();
            FormMode = enMode.Add;
        }

        public frmProductUnitConversions(List<clsProductUnitConversion> unitConversionsde)
        {
            InitializeComponent();
            UnitConversions = unitConversionsde;
            FormMode = enMode.Edit;
        }

        private void frmProductUnitConversions_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductName) || string.IsNullOrWhiteSpace(BaseUnit))
            {
                clsFormMessages.ShowError("لا يمكن أن يكون إسم المنتج أو إسم الوحدة الأساسية فارغا");
                this.Close();
                return;
            }

            this.Text = this.Text.Replace("اسم المنتج", ProductName);
            lblBaseUnitName.Text = BaseUnit;

            dgvUnitConversions.Rows[0].Cells[colDelete.Index].Value = Resources.delete;

            colUnitConversion.DataSource = clsUnit.GetUnitsList()
                .Rows
                .Cast<DataRow>()
                .Where(row => !row["UnitName"].Equals(BaseUnit))
                .CopyToDataTable();

            colUnitConversion.DisplayMember = "UnitName";
            colUnitConversion.ValueMember = "UnitID";

            if (FormMode is enMode.Edit && _FirstTimeEdit)
            {
                _FirstTimeEdit = false;
                _SetUnitConversionsToDGV(UnitConversions);
            }
        }

        private void frmProductUnitConversions_Shown(object sender, EventArgs e)
        {
            dgvUnitConversions.CurrentCell = dgvUnitConversions.Rows[dgvUnitConversions.NewRowIndex].Cells[colUnitConversion.Index];
            dgvUnitConversions.BeginEdit(true);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == colDelete.Index && (e.RowIndex != -1 || e.ColumnIndex != -1) && !dgvUnitConversions.Rows[e.RowIndex].IsNewRow)
            {
                _DeleteRow(e.RowIndex);
            }
        }

        private void dgvUnitConversions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvUnitConversions.CurrentCell.ColumnIndex == colDelete.Index && (dgvUnitConversions.CurrentRow.Index != -1 || dgvUnitConversions.CurrentCell.ColumnIndex != -1) && !dgvUnitConversions.Rows[dgvUnitConversions.CurrentRow.Index].IsNewRow)
                {
                    _DeleteRow(dgvUnitConversions.CurrentRow.Index);
                }
            }
        }

        private void dgvUnitConversions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _SetDefaultValuesForRows();
        }

        private void dgvUnitConversions_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _SetDefaultValuesForRows();
        }

        private void dgvUnitConversions_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            bool isThereDataInAnotherCellsInThisRow = (!_IsEmptyCell(e.RowIndex, colConversionFactor.Index) || !_IsEmptyCell(e.RowIndex, colSellingPrice.Index) || !_IsEmptyCell(e.RowIndex, colBarcode.Index));
            _ErrorColumnIndex = e.ColumnIndex;

            if (e.ColumnIndex == colUnitConversion.Index)
            {
                if (_IsEmptyCell(e.RowIndex, colUnitConversion.Index) && isThereDataInAnotherCellsInThisRow)
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "يجب إختيار نوع الوحدة البديلة";
                    dgvUnitConversions.Rows[e.RowIndex].Cells[colDescription.Index].Value = string.Empty;
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }

            isThereDataInAnotherCellsInThisRow = (!_IsEmptyCell(e.RowIndex, colUnitConversion.Index) || !_IsEmptyCell(e.RowIndex, colSellingPrice.Index) || !_IsEmptyCell(e.RowIndex, colBarcode.Index));

            if (e.ColumnIndex == colConversionFactor.Index)
            {
                if (_IsEmptyCell(e.RowIndex, colConversionFactor.Index) && isThereDataInAnotherCellsInThisRow)
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "لا يمكن أن يكون معامل التحويل فارغا";
                    dgvUnitConversions.Rows[e.RowIndex].Cells[colDescription.Index].Value = string.Empty;
                    SystemSounds.Asterisk.Play();
                }
                else if (!_IsEmptyCell(e.RowIndex, colConversionFactor.Index) && !_IsValidFactor(e.RowIndex))
                {
                    e.Cancel = true;
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "معامل التحويل يجب أن يكون رقماً صحيحاً وأكبر من 1";
                    dgvUnitConversions.Rows[e.RowIndex].Cells[colDescription.Index].Value = string.Empty;
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }

            isThereDataInAnotherCellsInThisRow = (!_IsEmptyCell(e.RowIndex, colUnitConversion.Index) || !_IsEmptyCell(e.RowIndex, colConversionFactor.Index) || !_IsEmptyCell(e.RowIndex, colBarcode.Index));

            if (e.ColumnIndex == colSellingPrice.Index)
            {
                if (_IsEmptyCell(e.RowIndex, colSellingPrice.Index) && isThereDataInAnotherCellsInThisRow)
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "لا يمكن أن يكون حقل سعر البيع فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!decimal.TryParse(dgvUnitConversions.Rows[e.RowIndex].Cells[colSellingPrice.Index].EditedFormattedValue?.ToString(), out decimal sellingPrice) && !_IsEmptyCell(e.RowIndex, colSellingPrice.Index))
                {
                    e.Cancel = true;
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "يجب إدخال قيمة رقمية صحيحة أو عشرية لسعر البيع";
                    SystemSounds.Asterisk.Play();
                }
                else if (sellingPrice < 1 && !_IsEmptyCell(e.RowIndex, colSellingPrice.Index))
                {
                    e.Cancel = true;
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "يجب أن يكون سعر البيع أكبر من صفر";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }

            isThereDataInAnotherCellsInThisRow = (!_IsEmptyCell(e.RowIndex, colUnitConversion.Index) || !_IsEmptyCell(e.RowIndex, colConversionFactor.Index) || !_IsEmptyCell(e.RowIndex, colSellingPrice.Index));

            if (e.ColumnIndex == colBarcode.Index)
            {
                if (_IsEmptyCell(e.RowIndex, colBarcode.Index) && isThereDataInAnotherCellsInThisRow)
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "لا يمكن أن يكون حقل الباركود فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        private void dgvUnitConversions_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvUnitConversions.CurrentCell.ColumnIndex == colUnitConversion.Index)
            {
                ComboBox editingComboBox = e.Control as ComboBox;
                editingComboBox.DropDown += EditingComboBox_DropDown;

                clsFormHelper.PreventComboBoxAutoSelection(dgvUnitConversions, editingComboBox);
                clsFormHelper.ResetCellBackColor(dgvUnitConversions, e);
            }
        }

        private void EditingComboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = colUnitConversion.DataSource as DataTable;

            int[] selectedUnitIDs = dgvUnitConversions
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => Convert.ToInt32(row.Cells[colUnitConversion.Index].Value))
                .ToArray();

            (sender as ComboBox).DataSource = dataTable
                .Rows
                .Cast<DataRow>()
                .Where(
                    row =>
                    Convert.ToInt32(row["UnitID"]) == Convert.ToInt32(dgvUnitConversions.CurrentCell.Value) ||
                    !selectedUnitIDs.Contains(Convert.ToInt32(row["UnitID"]))
                )
                .CopyToDataTable();

            object currentValue = (sender as ComboBox).SelectedValue;

            bool isValueExists = ((sender as ComboBox).DataSource as DataTable)
                .Rows
                .Cast<DataRow>()
                .Select(row => Convert.ToInt32(row["UnitID"]))
                .Any(value => value == Convert.ToInt32(currentValue));

            if (currentValue != null && isValueExists)
            {
                (sender as ComboBox).SelectedValue = currentValue;
            }
        }

        private void dgvUnitConversions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _AutoGenerateConversionDescription(e.RowIndex);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            _IsSaved = false;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _IsSaved = true;
            this.Close();
        }

        private void frmProductUnitConversions_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_IsSaved)
                {
                    if (clsFormHelper.IsDataGridViewCellsHasError(dgvUnitConversions, _ErrorColumnIndex))
                    {
                        e.Cancel = true;
                        clsFormMessages.ShowError("يجب إدخال جميع البيانات بصورة صحيحة قبل الحفظ");
                        return;
                    }

                    _IsSaved = false;
                    UnitConversions.Clear();
                    _SetUnitConversionsFromDGV(UnitConversions);
                }
                else
                {
                    dgvUnitConversions.Rows.Clear();
                    _SetUnitConversionsToDGV(UnitConversions);
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                clsFormMessages.ShowError(ex.Message, "خطأ في البيانات");
            }
        }

        private bool _IsValidFactor(int rowIndex)
        {
            return int.TryParse(dgvUnitConversions.Rows[rowIndex].Cells[colConversionFactor.Index].EditedFormattedValue?.ToString(), out int factor) && factor > 1;
        }

        private bool _IsEmptyCell(int rowIndex, int colIndex)
        {
            return string.IsNullOrWhiteSpace(dgvUnitConversions.Rows[rowIndex].Cells[colIndex].EditedFormattedValue?.ToString());
        }

        private void _SetDefaultValuesForRows()
        {
            foreach (DataGridViewRow row in dgvUnitConversions.Rows)
            {
                row.Cells[colDelete.Index].Value = Resources.delete;
            }
        }

        private void _SetUnitConversionsFromDGV(List<clsProductUnitConversion> unitConversions)
        {
            for (int i = 0; i < dgvUnitConversions.RowCount - 1; i++)
            {
                if (dgvUnitConversions.Rows[i].Cells[colUnitConversion.Index].Value != null &&
                    dgvUnitConversions.Rows[i].Cells[colConversionFactor.Index].Value != null &&
                    dgvUnitConversions.Rows[i].Cells[colSellingPrice.Index].Value != null &&
                    dgvUnitConversions.Rows[i].Cells[colBarcode.Index].Value != null)
                {
                    unitConversions.Add(new clsProductUnitConversion(
                        Convert.ToInt32(dgvUnitConversions.Rows[i].Cells[colUnitConversion.Index].Value),
                        Convert.ToString(dgvUnitConversions.Rows[i].Cells[colUnitConversion.Index].EditedFormattedValue),
                        Convert.ToInt32(dgvUnitConversions.Rows[i].Cells[colConversionFactor.Index].Value),
                        Convert.ToDecimal(dgvUnitConversions.Rows[i].Cells[colSellingPrice.Index].Value),
                        Convert.ToString(dgvUnitConversions.Rows[i].Cells[colBarcode.Index].Value)
                        )
                    );
                }
            }
        }

        private void _SetUnitConversionsToDGV(List<clsProductUnitConversion> unitConversions)
        {
            dgvUnitConversions.CellEndEdit -= dgvUnitConversions_CellEndEdit;

            for (int i = 0; i < unitConversions.Count; i++)
            {
                dgvUnitConversions.Rows.Add(unitConversions[i].AlternativeUnitID, unitConversions[i].ConversionFactor, unitConversions[i].SellingPrice, unitConversions[i].Barcode);
                _AutoGenerateConversionDescription(i);
            }

            dgvUnitConversions.CellEndEdit += dgvUnitConversions_CellEndEdit;
        }

        private void _AutoGenerateConversionDescription(int rowIndex)
        {
            DataGridViewCell descriptionCell = dgvUnitConversions.Rows[rowIndex].Cells[colDescription.Index];

            string factor = Convert.ToString(dgvUnitConversions.Rows[rowIndex].Cells[colConversionFactor.Index].EditedFormattedValue);
            string unitName = Convert.ToString(dgvUnitConversions.Rows[rowIndex].Cells[colUnitConversion.Index].EditedFormattedValue);

            if (!string.IsNullOrWhiteSpace(unitName) && !string.IsNullOrWhiteSpace(factor))
            {
                descriptionCell.Value = $"1 {unitName} = {factor} {BaseUnit}";
            }
            else
            {
                descriptionCell.Value = string.Empty;
            }
        }

        private void _DeleteRow(int rowIndex)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذه الوحدة البديلة ؟", "تأكيد",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                dgvUnitConversions.Rows.RemoveAt(rowIndex);
            }

            dgvUnitConversions.ClearSelection();
        }

    }
}