using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Products;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Products
{
    public partial class frmProductUnitConversions : Form
    {
        private List<clsProductUnitConversion> _UnitConversionsde;
        private string _ProductName;
        private string _BaseUnit;
        private enMode _Mode;

        public frmProductUnitConversions(string productName, string baseUnit)
        {
            InitializeComponent();
            _ProductName = productName;
            _BaseUnit = baseUnit;
            _Mode = enMode.Add;
        }

        public frmProductUnitConversions(string productName, string baseUnit, List<clsProductUnitConversion> unitConversionsde)
        {
            InitializeComponent();
            _UnitConversionsde = unitConversionsde;
            _ProductName = productName;
            _BaseUnit = baseUnit;
            _Mode = enMode.Edit;
        }

        private void frmProductUnitConversions_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_ProductName) || string.IsNullOrWhiteSpace(_BaseUnit))
            {
                clsFormMessages.ShowError("لا يمكن أن يكون إسم المنتج أو إسم الوحدة الأساسية فارغا");
                this.Close();
                return;
            }

            this.Text = this.Text.Replace("اسم المنتج", _ProductName);
            colUnitConversion.Items.Remove(_BaseUnit);
            dgvUnitConversions.Rows[0].Cells[colDelete.Index].Value = Resources.delete;
            dgvUnitConversions.Rows[0].Cells[colBaseUnit.Index].Value = _BaseUnit;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvUnitConversions.Columns[colDelete.Index].Index && !dgvUnitConversions.Rows[e.RowIndex].IsNewRow)
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد حذف معامل التحويل هذا ؟", "تأكيد",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    dgvUnitConversions.Rows.RemoveAt(e.RowIndex);
                }

                dgvUnitConversions.ClearSelection();
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
            if (e.ColumnIndex == colUnitConversion.Index)
            {
                if (_IsEmptyCell(e.RowIndex, colUnitConversion.Index) && !(_IsEmptyCell(e.RowIndex, colConversionFactor.Index)))
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "يجب إختيار نوع الوحدة البديلة أولا";
                    e.Cancel = true;
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colConversionFactor.Index)
            {
                if ((!_IsEmptyCell(e.RowIndex, colUnitConversion.Index) || (!_IsEmptyCell(e.RowIndex, colConversionFactor.Index))) && !(_IsValidFactor(e.RowIndex)))
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "معامل التحويل يجب أن يكون رقماً صحيحاً وأكبر من 1";
                    dgvUnitConversions.Rows[e.RowIndex].Cells[colDescription.Index].Value = string.Empty;
                    e.Cancel = true;
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        private void dgvUnitConversions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell factorCell = dgvUnitConversions.Rows[e.RowIndex].Cells[colConversionFactor.Index];
                DataGridViewCell unitCell = dgvUnitConversions.Rows[e.RowIndex].Cells[colUnitConversion.Index];
                DataGridViewCell descriptionCell = dgvUnitConversions.Rows[e.RowIndex].Cells[colDescription.Index];

                string factor = factorCell.EditedFormattedValue?.ToString() ?? factorCell.Value?.ToString();
                string unitName = unitCell.EditedFormattedValue?.ToString() ?? unitCell.Value?.ToString();

                if (!string.IsNullOrWhiteSpace(unitName) && !string.IsNullOrWhiteSpace(factor) && dgvUnitConversions.Rows[e.RowIndex].ErrorText == string.Empty)
                {
                    descriptionCell.Value = $"1 {unitName} = {factor} {_BaseUnit}";
                }
                else
                {
                    descriptionCell.Value = string.Empty;
                }
            }
        }

        private void dgvUnitConversions_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (_IsEmptyCell(e.RowIndex, colUnitConversion.Index) && !(_IsEmptyCell(e.RowIndex, colConversionFactor.Index)))
            {
                dgvUnitConversions.Rows[e.RowIndex].ErrorText = "يجب إختيار نوع الوحدة البديلة أولا";
                e.Cancel = true;
                SystemSounds.Asterisk.Play();
            }

            if ((!_IsEmptyCell(e.RowIndex, colUnitConversion.Index) || (!_IsEmptyCell(e.RowIndex, colConversionFactor.Index))) && !(_IsValidFactor(e.RowIndex)))
            {
                dgvUnitConversions.Rows[e.RowIndex].ErrorText = "معامل التحويل يجب أن يكون رقماً صحيحاً وأكبر من 1";
                e.Cancel = true;
                SystemSounds.Asterisk.Play();
            }
        }

        private bool _IsValidFactor(int rowIndex)
        {
            return !(_IsEmptyCell(rowIndex, colConversionFactor.Index)) && (int.TryParse(dgvUnitConversions.Rows[rowIndex].Cells[colConversionFactor.Index].EditedFormattedValue?.ToString(), out int factor) && factor > 1);
        }

        private bool _IsEmptyCell(int rowIndex, int colIndex)
        {
            return string.IsNullOrEmpty(dgvUnitConversions.Rows[rowIndex].Cells[colIndex].EditedFormattedValue?.ToString());
        }

        private void _SetDefaultValuesForRows()
        {
            foreach (DataGridViewRow row in dgvUnitConversions.Rows)
            {
                row.Cells["colDelete"].Value = Resources.delete;

                if (!row.IsNewRow)
                {
                    row.Cells["colBaseUnit"].Value = _BaseUnit;
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
