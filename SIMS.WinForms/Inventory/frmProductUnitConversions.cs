using System;
using System.Windows.Forms;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Inventory
{
    public partial class frmProductUnitConversions : Form
    {
        private string _ProductName;
        private string _BaseUnit;

        public frmProductUnitConversions(string productName, string baseUnit)
        {
            InitializeComponent();
            _ProductName = productName;
            _BaseUnit = baseUnit;
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
            dgvUnitConversions.Rows[0].Cells["colDelete"].Value = Resources.delete;
            dgvUnitConversions.Rows[0].Cells["colBaseUnit"].Value = colBaseUnit.Tag;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvUnitConversions.Columns["colDelete"].Index && e.RowIndex != dgvUnitConversions.RowCount - 1)
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

        private void _SetDefaultValuesForRows()
        {
            foreach (DataGridViewRow row in dgvUnitConversions.Rows)
            {
                row.Cells["colDelete"].Value = Resources.delete;
                row.Cells["colBaseUnit"].Value = colBaseUnit.Tag;
            }
        }

        private void dgvUnitConversions_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewCell cell = dgvUnitConversions.CurrentCell;

            if (cell.ColumnIndex == 1)
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int factor) || factor <= 1)
                {
                    cell.ErrorText = "معامل التحويل يجب أن يكون رقماً صحيحاً وأكبر من 1";
                }
                else
                {
                    cell.ErrorText = string.Empty;
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
