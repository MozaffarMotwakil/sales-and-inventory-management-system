using System;
using System.Windows.Forms;
using SIMS.WinForms.Properties;
using SIMS.WinForms.Suppliers;

namespace SIMS.WinForms.Inventory
{
    public partial class frmReceiveNewGoods : Form
    {
        public frmReceiveNewGoods()
        {
            InitializeComponent();
        }

        private void frmReceiveNewGoods_Load(object sender, EventArgs e)
        {
            dgvProductsDetailsList.Rows[0].Cells["No"].Value = 1;
            dgvProductsDetailsList.Rows[0].Cells["Delete"].Value = Resources.delete;
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
            if (e.ColumnIndex == dgvProductsDetailsList.Columns["Delete"].Index && e.RowIndex != dgvProductsDetailsList.RowCount - 1)
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
                row.Cells["No"].Value = row.Index + 1;
                row.Cells["Delete"].Value = Resources.delete;
            }
        }

        private void llAddSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmAddEditSupplier addSupplier = new frmAddEditSupplier();
            //addSupplier.FormMode = enMode.Add;
            //addSupplier.ShowDialog();
        }

    }
}