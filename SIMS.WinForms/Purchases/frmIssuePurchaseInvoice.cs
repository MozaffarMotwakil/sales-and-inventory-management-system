using System;
using System.Drawing;
using System.Windows.Forms;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Inventory
{
    public partial class frmIssuePurchaseInvoice : Form
    {
        public frmIssuePurchaseInvoice()
        {
            InitializeComponent();
        }

        private void frmReceiveNewGoods_Load(object sender, EventArgs e)
        {
            dgvProductsDetailsList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvProductsDetailsList.Rows[0].Cells[colLineNa.Index].Value = 1;
            dgvProductsDetailsList.Rows[0].Cells[colDelete.Index].Value = Resources.delete;
        }


        private void dgvProductsDetailsList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _UpdateRowsDetails();
        }

        private void dgvProductsDetailsList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _UpdateRowsDetails();
        }

        private void dgvProductsDetailsList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvProductsDetailsList.Columns[colDelete.Index].Index && e.RowIndex != dgvProductsDetailsList.RowCount - 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    dgvProductsDetailsList.Rows.RemoveAt(e.RowIndex);
                }

                dgvProductsDetailsList.ClearSelection();
            }
        }

        private void _UpdateRowsDetails()
        {
            foreach (DataGridViewRow row in dgvProductsDetailsList.Rows)
            {
                row.Cells[colLineNa.Index].Value = row.Index + 1;
                row.Cells[colDelete.Index].Value = Resources.delete;
            }
        }

    }
}