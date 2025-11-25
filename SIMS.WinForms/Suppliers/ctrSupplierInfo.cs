using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Parties;
using BusinessLogic.Suppliers;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Suppliers
{
    public partial class ctrSupplierInfo : UserControl
    {
        public ctrSupplierInfo()
        {
            InitializeComponent();
        }

        private clsSupplier _Supplier;
        public clsSupplier Supplier
        {
            get
            {
                return _Supplier;
            }
            set
            {
                if (value is null)
                {
                    return;
                }

                _Supplier = value;
                lblNotes.Text = string.IsNullOrEmpty(_Supplier.Notes) ? "N/A" : _Supplier.Notes;

                switch (_Supplier.PartyInfo.PartyCategory)
                {
                    case clsParty.enPartyCategory.Person:
                        ctrOrganizationInfo.Visible = false;
                        ctrPersonInfo.Visible = true;
                        ctrPersonInfo.Person = _Supplier.PartyInfo as clsPerson;
                        lblNotesTitle.Location = new Point(602, 188);
                        lblNotes.Location = new Point(87, 188);
                        break;
                    case clsParty.enPartyCategory.Organization:
                        ctrPersonInfo.Visible = false;
                        ctrOrganizationInfo.Visible = true;
                        ctrOrganizationInfo.Organization = _Supplier.PartyInfo as clsOrganization;
                        lblNotesTitle.Location = new Point(lblNotesTitle.Location.X, 142); 
                        lblNotes.Location = new Point(lblNotes.Location.X, 142);
                        break;
                    default:
                        this.Visible = false;
                        break;
                }

                _LoadDataForSuppliedProductsPage();
                _LoadDataForInvoicesPage();
            }
        }

        private void ctrSupplierInfo_Load(object sender, EventArgs e)
        {
            contextMenuStrip.Items.Add("عرض تفاصيل الفاتورة");
            contextMenuStrip.Items[0].Click += ShowInvoiceDetails_Click;
            contextMenuStrip.Items[0].Image = Resources.Invoice_32;
            contextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;
        }

        private void _LoadDataForSuppliedProductsPage()
        {
            DataTable suppliedProducts = _Supplier.GetAllProductsSupplied();

            dgvSuppliedProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Tahoma", 7, FontStyle.Bold);

            dgvSuppliedProducts.Rows.Clear();

            for (int i = 0; i < suppliedProducts.Rows.Count; i++)
            {
                dgvSuppliedProducts.Rows.Add();
                dgvSuppliedProducts.Rows[i].Cells[colNo.Index].Value = i + 1;
                dgvSuppliedProducts.Rows[i].Cells[colProduct.Index].Value = suppliedProducts.Rows[i]["ProductName"];
                dgvSuppliedProducts.Rows[i].Cells[colUnit.Index].Value = suppliedProducts.Rows[i]["UnitName"];
                dgvSuppliedProducts.Rows[i].Cells[colLastPurchaseDataTime.Index].Value = (suppliedProducts.Rows[i]["LastPurchaseDate"] as DateTime?)?.ToString("dd/MM/yyyy") ?? "N/A";
                dgvSuppliedProducts.Rows[i].Cells[colLastPurchasePrice.Index].Value = suppliedProducts.Rows[i]["LastPurchasePrice"];
            }
        }

        private void _LoadDataForInvoicesPage()
        {
            dgvInvoices.DataSource = _Supplier.GetInvoices();

            cbInvoiceType.SelectedIndex = cbPaymentStatus.SelectedIndex = 0;
            cbRange.SelectedIndex = 4;

            if (dgvInvoices.RowCount > 0)
            {
                cbInvoiceType.Enabled = cbPaymentStatus.Enabled =
                    cbRange.Enabled = colPurchaseNo.Visible = true;

                clsFormHelper.DisableSortableDataGridViewColumns(dgvInvoices);

                dgvInvoices.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Tahoma", 7, FontStyle.Bold);

                dgvInvoices.Columns[1].Visible = false;

                dgvInvoices.Columns[2].Visible = false;

                dgvInvoices.Columns[3].HeaderText = "نوع الحركة";
                dgvInvoices.Columns[3].Width = 75;

                dgvInvoices.Columns[4].HeaderText = "رقم الفاتورة";
                dgvInvoices.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvInvoices.Columns[5].HeaderText = "تاريخ المستند";
                dgvInvoices.Columns[5].Width = 100;

                dgvInvoices.Columns[6].Visible = false;

                dgvInvoices.Columns[7].Visible = false;

                dgvInvoices.Columns[8].HeaderText = "الإجمالي النهائي (جنيه)";
                dgvInvoices.Columns[8].Width = 100;

                dgvInvoices.Columns[9].HeaderText = "المبلغ المدفوع (جنيه)";
                dgvInvoices.Columns[9].Width = 100;

                dgvInvoices.Columns[10].HeaderText = "المبلغ المتبقي (جنيه)";
                dgvInvoices.Columns[10].Width = 100;
            }
            else
            {
                cbInvoiceType.Enabled = cbPaymentStatus.Enabled =
                    cbRange.Enabled = colPurchaseNo.Visible = false;
            }
        }

        private void ShowInvoiceDetails_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count == 0)
            {
                return;
            }

            frmShowInvoiceInfo showInvoiceInfo = new frmShowInvoiceInfo(Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceID"].Value));
            showInvoiceInfo.ShowDialog();
        }

        private void dgvInvoices_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ShowInvoiceDetails_Click(sender, e);
                }
            }
        }

        private void dgvInvoices_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInvoices.Rows[e.RowIndex].Selected = true;
                dgvInvoices.Columns[e.ColumnIndex].Selected = true;
            }
        }

        private void dgvInvoices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.Button == MouseButtons.Right || dgvInvoices.SelectedRows.Count == 0)
            {
                return;
            }

            ShowInvoiceDetails_Click(sender, e);
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvInvoices, e);
        }

        private void dgvInvoices_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = dgvInvoices.Rows[e.RowIndex];
                currentRow.Cells[0].Value = e.RowIndex + 1;
                
                int invoiceTypeID = Convert.ToInt32(currentRow.Cells["InvoiceTypeID"].Value);
                int invoiceStatusID = Convert.ToInt32(currentRow.Cells["InvoiceStatusID"].Value);

                if (invoiceTypeID == 1 && invoiceStatusID == 1)
                {
                    currentRow.DefaultCellStyle.BackColor = Color.LightGreen;
                    currentRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else if (invoiceTypeID == 1 && invoiceStatusID == 2)
                {
                    currentRow.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    currentRow.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                }
                else if (invoiceTypeID == 1 && invoiceStatusID == 3)
                {
                    currentRow.DefaultCellStyle.BackColor = Color.LightCoral;
                    currentRow.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    currentRow.DefaultCellStyle.BackColor = Color.Gainsboro;
                    currentRow.DefaultCellStyle.ForeColor = Color.DimGray;
                }
            }
        }

        private void dgvInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInvoices.ClearSelection();

            lblAmount.Text = dgvInvoices
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => (int)row.Cells["InvoiceTypeID"].Value == 1)
                .Sum(row => Convert.ToSingle(row.Cells["RemainingAmount"].Value))
                .ToString() + " جنيه";

            label3.Text = dgvInvoices
                .Rows
                .Cast<DataGridViewRow>()
                .Where(row => (int)row.Cells["InvoiceTypeID"].Value == 2)
                .Sum(row => Convert.ToSingle(row.Cells["RemainingAmount"].Value))
                .ToString() + " جنيه";
        }

        private void cbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void _ApplyFilter()
        {
            if (dgvInvoices.DataSource == null || (dgvInvoices.DataSource as DataTable).Rows.Count == 0)
            {
                return;
            }

            List<string> filters = new List<string>();
            DataView invoices = (dgvInvoices.DataSource as DataTable).DefaultView;
            DateTime range;

            if (cbInvoiceType.SelectedIndex != 0)
            {
                filters.Add($"InvoiceTypeName = '{cbInvoiceType.Text}'");
            }
            
            if (cbPaymentStatus.SelectedIndex != 0)
            {
                filters.Add($"InvoiceStatusName = '{cbPaymentStatus.Text}'");
            }

            if (cbRange.SelectedIndex == 0)
            {
                range = DateTime.Now.AddDays(-1);
            }
            else if (cbRange.SelectedIndex == 1)
            {
                range = DateTime.Now.AddDays(-7);
            }
            else if (cbRange.SelectedIndex == 2)
            {
                range = DateTime.Now.AddMonths(-1);
            }
            else if (cbRange.SelectedIndex == 3)
            {
                range = DateTime.Now.AddMonths(-6);
            }
            else
            {
                range = DateTime.Now.AddYears(-1);
            }

            filters.Add($"(InvoiceDate >= #{range:yyyy-MM-dd}# AND InvoiceDate <= #{DateTime.Now:yyyy-MM-dd}#)");
            invoices.RowFilter = string.Join(" AND ", filters);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == pageSuppliedProducts)
            {
                dgvSuppliedProducts.ClearSelection();
            }
        }

    }
}
