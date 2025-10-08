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
        public List<clsProductUnitConversion> UnitConversions { get; private set; }
        public new string ProductName { get; set; }
        public string BaseUnit { get; set; }
        public enMode FormMode { get; set; }

        private HashSet<string> _SelectedUnits = new HashSet<string>();
        private string _PreviousUnitValue = null;
        private List<string> _AllUnits = new List<string>();
        private bool _IsSaved = false;
        private bool _FirstTimeEdit = true;
        private Form _Sender;

        public frmProductUnitConversions(Form sender)
        {
            InitializeComponent();
            UnitConversions = new List<clsProductUnitConversion>();
            _Sender = sender;
            FormMode = enMode.Add;
        }

        public frmProductUnitConversions(Form sender, List<clsProductUnitConversion> unitConversionsde)
        {
            InitializeComponent();
            UnitConversions = unitConversionsde;
            _Sender = sender;
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

            colUnitConversion.Items.Clear();
            colUnitConversion.Items.AddRange(clsUnit.GetUnitNames());
            _SelectedUnits.Add(BaseUnit);

            _AllUnits.Clear();

            foreach (var item in colUnitConversion.Items)
            {
                _AllUnits.Add(item.ToString());
            }

            dgvUnitConversions.Rows[0].Cells[colDelete.Index].Value = Resources.delete;
            dgvUnitConversions.Rows[0].Cells[colBaseUnit.Index].Value = BaseUnit;

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
            if (e.ColumnIndex == dgvUnitConversions.Columns[colDelete.Index].Index && !dgvUnitConversions.Rows[e.RowIndex].IsNewRow)
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد حذف معامل التحويل هذا ؟", "تأكيد",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    string deletedValue = dgvUnitConversions.Rows[e.RowIndex].Cells[colUnitConversion.Index].Value?.ToString();

                    if (!string.IsNullOrEmpty(deletedValue))
                    {
                        _SelectedUnits.Remove(deletedValue); 
                    }

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
                    e.Cancel = true;
                    dgvUnitConversions.Rows[e.RowIndex].ErrorText = "يجب إختيار نوع الوحدة البديلة أولا";
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
                    descriptionCell.Value = $"1 {unitName} = {factor} {BaseUnit}";
                }
                else
                {
                    descriptionCell.Value = string.Empty;
                }

                if (e.ColumnIndex == colUnitConversion.Index)
                {
                    string newValue = dgvUnitConversions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                    if (!string.IsNullOrEmpty(_PreviousUnitValue))
                    {
                        _SelectedUnits.Remove(_PreviousUnitValue);
                    }

                    if (!string.IsNullOrEmpty(newValue))
                    {
                        _SelectedUnits.Add(newValue);
                    }

                    _PreviousUnitValue = null;
                }
            }
        }

        private void dgvUnitConversions_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == colUnitConversion.Index)
            {
                _PreviousUnitValue = dgvUnitConversions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }

        private void dgvUnitConversions_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvUnitConversions.CurrentCell.ColumnIndex == colUnitConversion.Index)
            {
                if (e.Control is ComboBox comboBox)
                {
                    comboBox.Items.Clear();

                    foreach (string unit in _AllUnits)
                    {
                        if (!_SelectedUnits.Contains(unit) || unit == _PreviousUnitValue)
                        {
                            comboBox.Items.Add(unit);
                        }
                    }
                }
            }
        }

        private void dgvUnitConversions_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvUnitConversions.Rows[e.RowIndex].ErrorText))
            {
                e.Cancel = true;
                SystemSounds.Asterisk.Play();
            }
        }

        private bool _IsValidFactor(int rowIndex)
        {
            return !(_IsEmptyCell(rowIndex, colConversionFactor.Index)) &&
                   (int.TryParse(dgvUnitConversions.Rows[rowIndex].Cells[colConversionFactor.Index].EditedFormattedValue?.ToString(), out int factor) && factor > 1);
        }

        private bool _IsEmptyCell(int rowIndex, int colIndex)
        {
            return string.IsNullOrEmpty(dgvUnitConversions.Rows[rowIndex].Cells[colIndex].EditedFormattedValue?.ToString());
        }

        private void _SetDefaultValuesForRows()
        {
            foreach (DataGridViewRow row in dgvUnitConversions.Rows)
            {
                row.Cells[colDelete.Index].Value = Resources.delete;

                if (!row.IsNewRow)
                {
                    row.Cells[colBaseUnit.Index].Value = BaseUnit;
                }
            }
        }

        private void _SetUnitConversionsFromDGV(List<clsProductUnitConversion> unitConversions)
        {
            for (int i = 0; i < dgvUnitConversions.RowCount - 1; i++)
            {
                if (dgvUnitConversions.Rows[i].Cells[colUnitConversion.Index].Value != null &&
                    dgvUnitConversions.Rows[i].Cells[colConversionFactor.Index].Value != null)
                {
                    try
                    {
                        DataGridViewComboBoxCell alternativeUnitCell = dgvUnitConversions.Rows[i].Cells[colUnitConversion.Index] as DataGridViewComboBoxCell;

                        int alternativeUnitID = alternativeUnitCell.Items.IndexOf(alternativeUnitCell.Value) + 1;
                        string alternativeUnitName = alternativeUnitCell.Value.ToString();
                        int conversionFactor = Convert.ToInt32(dgvUnitConversions.Rows[i].Cells[colConversionFactor.Index].Value);

                        unitConversions.Add(new clsProductUnitConversion(
                            alternativeUnitID,
                            alternativeUnitName,
                            conversionFactor
                            )
                        );
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                        _Sender.Close();
                        clsFormMessages.ShowError($"حدث خطأ في قراءة الصف {i + 1}: {ex.Message}\nسيتم إلغاء العملية الحالية الرجاء المحاولة مرة أخرى", "خطأ في البيانات");
                    }
                }
            }
        }

        private void _SetUnitConversionsToDGV(List<clsProductUnitConversion> unitConversions)
        {
            for (int i = 0; i < unitConversions.Count; i++)
            {
                try
                {
                    dgvUnitConversions.Rows.Add(unitConversions[i].UnitName, unitConversions[i].ConversionFactor);
                    dgvUnitConversions.CurrentCell = dgvUnitConversions.Rows[i].Cells[colConversionFactor.Index];
                    dgvUnitConversions.BeginEdit(true);
                    _SelectedUnits.Add(unitConversions[i].UnitName);
                }
                catch (Exception ex)
                {
                    this.Close();
                    _Sender.Close();
                    clsFormMessages.ShowError($"حدث خطأ في قراءة الصف {i + 1}: {ex.Message}\nسيتم إلغاء العملية الحالية الرجاء المحاولة مرة أخرى", "خطأ في البيانات");
                }
            }
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
                    _IsSaved = false;
                    UnitConversions.Clear();
                    _SetUnitConversionsFromDGV(UnitConversions);
                }
                else
                {
                    dgvUnitConversions.Rows.Clear();
                    _SelectedUnits.Clear();
                    _SetUnitConversionsToDGV(UnitConversions);
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                clsFormMessages.ShowError(ex.Message, "خطأ في البيانات");
            }
        }

    }
}
