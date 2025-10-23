using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using SIMS.WinForms.Properties;
using SIMS.WinForms.Suppliers;

namespace SIMS.WinForms.Inventory
{
    public partial class frmIssuePurchaseInvoice : Form
    {
        private int? CurrentProductID;

        public frmIssuePurchaseInvoice()
        {
            InitializeComponent();
        }

        private void frmReceiveNewGoods_Load(object sender, EventArgs e)
        {
            this.vw_SuppliersDetailsTableAdapter.Fill(this.supplierNames.vw_SuppliersDetails);
            this.productsTableAdapter.Fill(this.productNames.Products);
            this.warehousesTableAdapter.Fill(this.warehouseNames.Warehouses);

            dgvInvoiceLines.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvInvoiceLines.Rows[0].Cells[colLineNa.Index].Value = 1;
            dgvInvoiceLines.Rows[0].Cells[colDelete.Index].Value = Resources.delete;

            dtpPurchaseDate.Value = DateTime.Today;
            cbWarehouse.SelectedIndex = 0;
            cbSupplier.SelectedItem = null;
            cbSupplier.Text = "إختار المورد";

            clsSupplierService.CreateInstance().EntitySaved += ClsSupplier_SupplierSaved;
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
            if (e.ColumnIndex == dgvInvoiceLines.Columns[colDelete.Index].Index && e.RowIndex != dgvInvoiceLines.RowCount - 1)
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذا السطر ؟", "تأكيد",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    dgvInvoiceLines.Rows.RemoveAt(e.RowIndex);
                }

                dgvInvoiceLines.ClearSelection();
            }
        }

        private void _UpdateRowsDetails()
        {
            foreach (DataGridViewRow row in dgvInvoiceLines.Rows)
            {
                row.Cells[colLineNa.Index].Value = row.Index + 1;
                row.Cells[colDelete.Index].Value = Resources.delete;
            }
        }

        private void cbSupllier_Enter(object sender, EventArgs e)
        {
            if (cbSupplier.SelectedIndex == -1)
            {
                cbSupplier.Text = string.Empty;
            }
        }

        private void cbSupllier_Leave(object sender, EventArgs e)
        {
            if (cbSupplier.SelectedIndex == -1)
            {
                cbSupplier.Text = "إختار المورد";
            }
        }

        private void llAddPersonSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addPersonSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Person);
            addPersonSupplier.ShowDialog();
            cbSupplier.Focus();
            llAddPersonSupplier.Focus();
        }

        private void llAddOrganizationSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addEditOrganizationSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Organization);
            addEditOrganizationSupplier.ShowDialog();
            cbSupplier.Focus();
            llAddOrganizationSupplier.Focus();
        }

        private void ClsSupplier_SupplierSaved(object sender, EntitySavedEventArgs e)
        {
            this.vw_SuppliersDetailsTableAdapter.Fill(this.supplierNames.vw_SuppliersDetails);
            cbSupplier.SelectedItem = e.EntityName;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductsDetailsList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvInvoiceLines.CurrentCell.ColumnIndex == colUnit.Index)
            {
                int? productID = (int?)dgvInvoiceLines.Rows[dgvInvoiceLines.CurrentRow.Index].Cells[colProductName.Index].Value;

                if (productID == null)
                {
                    return;
                }

                DataGridViewComboBoxCell cellComboBox = (dgvInvoiceLines.Rows[dgvInvoiceLines.CurrentRow.Index].Cells[colUnit.Index] as DataGridViewComboBoxCell);
                cellComboBox.DataSource = clsProductService.GetAllProductUnits(productID.Value);
                cellComboBox.DisplayMember = "UnitName";
                cellComboBox.ValueMember = "UnitID";

                // Fix issue in back color of drop down list that changed to black.
                e.CellStyle.BackColor = this.dgvInvoiceLines.DefaultCellStyle.BackColor;
            }
        }

        private void dgvProductsDetailsList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == colProductName.Index)
            {
                 CurrentProductID = (int?)dgvInvoiceLines.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }

        private void dgvProductsDetailsList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colProductName.Index)
            {
                if (CurrentProductID != (int?)dgvInvoiceLines.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    DataGridViewComboBoxCell cellComboBox = (dgvInvoiceLines.Rows[e.RowIndex].Cells[colUnit.Index] as DataGridViewComboBoxCell);
                    cellComboBox.ValueMember = string.Empty;
                    cellComboBox.Value = null;
                }
            }
        }

        private void txtPurchaseInvoiceNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dgvInvoiceLines_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dgvInvoiceLines_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void rbPaid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPartiallyPaid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbUnpaid_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}