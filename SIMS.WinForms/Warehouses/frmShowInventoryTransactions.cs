using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmShowInventoryTransactions : Form
    {
        private clsInventory _Inventory;

        public frmShowInventoryTransactions(int inventoryID)
        {
            InitializeComponent();
            _Inventory = clsInventoryService.CreateInstance().Find(inventoryID);
        }

        private void frmShowInventoryTransactions_Load(object sender, EventArgs e)
        {
            if (_Inventory == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على المخزون");
                this.Close();
                return;
            }

            dgvStockTransactions.ColumnHeadersDefaultCellStyle.Font = 
                new Font("Tahoma", 8, FontStyle.Bold);

            lblProductName.Text = _Inventory.ProductInfo.ProductName;
            lblUnitName.Text = _Inventory.UnitInfo.UnitName;
            lblWarehouseName.Text = _Inventory.WarehouseInfo.WarehouseName;
            dgvStockTransactions.DataSource = _Inventory.GetStockTransactions();
            ResetColumnsOfDGV();
        }

        private void dgvStockTransactions_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int transactionType = Convert.ToInt32(dgvStockTransactions.Rows[e.RowIndex].Cells["TransactionTypeID"].Value);

                if (transactionType == 1)
                {
                    dgvStockTransactions.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvStockTransactions.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else if (transactionType == 2)
                {
                    dgvStockTransactions.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dgvStockTransactions.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    dgvStockTransactions.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvStockTransactions.DefaultCellStyle.BackColor;
                    dgvStockTransactions.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgvStockTransactions.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void ResetColumnsOfDGV()
        {
            if (dgvStockTransactions.RowCount > 0)
            {
                dgvStockTransactions.Columns[0].HeaderText = "معرف سجل الحركة";
                dgvStockTransactions.Columns[0].Visible = false;

                dgvStockTransactions.Columns[1].HeaderText = "المنتج";
                dgvStockTransactions.Columns[1].Visible = false;

                dgvStockTransactions.Columns[2].HeaderText = "الوحدة";
                dgvStockTransactions.Columns[2].Visible = false;

                dgvStockTransactions.Columns[3].HeaderText = "المخزن";
                dgvStockTransactions.Columns[3].Visible = false;

                dgvStockTransactions.Columns[4].HeaderText = "معرف نوع الحركة";
                dgvStockTransactions.Columns[4].Visible = false;

                dgvStockTransactions.Columns[5].HeaderText = "نوع الحركة";
                dgvStockTransactions.Columns[5].Width = 80;

                dgvStockTransactions.Columns[6].HeaderText = "سبب الحركة";
                dgvStockTransactions.Columns[6].Width = 100;

                dgvStockTransactions.Columns[7].HeaderText = "الكمية قبل الحركة";
                dgvStockTransactions.Columns[7].Width = 80;

                dgvStockTransactions.Columns[8].HeaderText = "التأثير على المخزون";
                dgvStockTransactions.Columns[8].Width = 80;

                dgvStockTransactions.Columns[9].HeaderText = "الكمية بعد الحركة";
                dgvStockTransactions.Columns[9].Width = 80;

                dgvStockTransactions.Columns[10].HeaderText = "معرف الفاتورة المؤثرة";
                dgvStockTransactions.Columns[10].Visible = false;

                dgvStockTransactions.Columns[11].HeaderText = "رقم الفاتورة المؤثرة";
                dgvStockTransactions.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvStockTransactions.Columns[12].HeaderText = "الموظف المسؤول";
                dgvStockTransactions.Columns[12].Width = 180;

                dgvStockTransactions.Columns[13].HeaderText = "تاريخ الحركة";
                dgvStockTransactions.Columns[13].Width = 150;

                foreach (DataGridViewColumn column in dgvStockTransactions.Columns)
                {
                    if (column.Index != 12)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
        }

        private void dgvStockTransactions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStockTransactions.ClearSelection();
        }

        private void showInvoiceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvStockTransactions.SelectedRows.Count == 0)
            {
                return;
            }

            int? invoiceID = (int?)dgvStockTransactions.SelectedRows[0].Cells[dgvStockTransactions.Columns["SourceInvoiceID"].Index].Value;

            if (invoiceID.HasValue)
            {
                frmShowInvoiceInfo showInvoiceInfo = new frmShowInvoiceInfo(invoiceID.Value);
                showInvoiceInfo.ShowDialog();
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على الفاتورة");
            }
        }

        private void dgvStockTransactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvStockTransactions.SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    showInvoiceInfoToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void dgvStockTransactions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvStockTransactions.Rows[e.RowIndex].Selected = true;
                dgvStockTransactions.Columns[e.ColumnIndex].Selected = true;
            }
        }

        private void dgvStockTransactions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.Button == MouseButtons.Right || dgvStockTransactions.SelectedRows.Count == 0)
            {
                return;
            }

            showInvoiceInfoToolStripMenuItem_Click(sender, e);
        }

        private void ClearSelectionFromDGV(object sender, MouseEventArgs e)
        {
            dgvStockTransactions.ClearSelection();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
