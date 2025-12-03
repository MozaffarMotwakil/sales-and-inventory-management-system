using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Invoices
{
    public partial class frmBaseIssueInvoice : Form
    {
        protected int ErrorColumnIndex;

        public frmBaseIssueInvoice()
        {
            InitializeComponent();
        }

        private void frmBaseIssueInvoice_Load(object sender, EventArgs e)
        {
            dgvInvoiceLines.ColumnHeadersDefaultCellStyle.Font =
                new Font("Tahoma", 7, FontStyle.Bold);

            if (!DesignMode)
            {
                cbWarehouse.DataSource = clsWarehouseService.GetActiveWarehousesList();
                cbWarehouse.DisplayMember = "WarehouseName";
                cbWarehouse.ValueMember = "WarehouseID";
                cbWarehouse.SelectedValue = 1;
            }

            dgvInvoiceLines.Rows[0].Cells[colLineNa.Index].Value = 1;
            dgvInvoiceLines.Rows[0].Cells[colDelete.Index].Value = Resources.delete;

            dtpInvoiceIssueDate.MaxDate = DateTime.Today;
            dtpInvoiceIssueDate.MinDate = DateTime.Today.AddYears(-1);
            dtpInvoiceIssueDate.Value = DateTime.Today;
        }

        private void dgvInvoiceLines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _UpdateRowsDetails();
        }

        private void dgvInvoiceLines_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _UpdateRowsDetails();
        }

        private void _UpdateRowsDetails()
        {
            foreach (DataGridViewRow row in dgvInvoiceLines.Rows)
            {
                row.Cells[colLineNa.Index].Value = row.Index + 1;
                row.Cells[colDelete.Index].Value = Resources.delete;
            }
        }

        private void dgvInvoiceLines_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvInvoiceLines.Columns[colDelete.Index].Index && e.RowIndex != dgvInvoiceLines.RowCount - 1)
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذا السطر ؟", "تأكيد",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    object subTotal = dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value;
                    object discountAmount = dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value;
                    object taxAmount = dgvInvoiceLines.CurrentRow.Cells[colTaxAmount.Index].Value;
                    object taxRate = dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value;
                    object grandTotal = dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value;

                    lblTotalSubTotal.Text = (Convert.ToDecimal(lblTotalSubTotal.Text) - (subTotal == null ? 0 : Convert.ToDecimal(subTotal))).ToString();
                    lblTotalDiscount.Text = (Convert.ToDecimal(lblTotalDiscount.Text) - (discountAmount == null ? 0 : Convert.ToDecimal(discountAmount))).ToString();
                    lblTotalTax.Text = (Convert.ToDecimal(lblTotalTax.Text) - (taxAmount == null ? 0 : (Convert.ToDecimal(subTotal) - Convert.ToDecimal(discountAmount)) * (Convert.ToDecimal(taxRate) / 100))).ToString();
                    lblTotalGrandTotal.Text = (Convert.ToDecimal(lblTotalGrandTotal.Text) - (grandTotal == null ? 0 : Convert.ToDecimal(grandTotal))).ToString();
                    dgvInvoiceLines.Rows.RemoveAt(e.RowIndex);
                }

                dgvInvoiceLines.ClearSelection();
            }
        }

        protected virtual void dgvInvoiceLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvInvoiceLines.CurrentCell.Tag = dgvInvoiceLines.CurrentCell.Value;
        }

        private void txtPaidAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!rbPartiallyPaid.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtPaidAmount.Text))
                {
                    errorProvider.SetError(txtPaidAmount, "يتم تعيين مبلغ مدفوع في حالة كانت حالة الفاتورة مدفوعة جزئيا فقط");
                }

                return;
            }

            if (string.IsNullOrWhiteSpace(txtPaidAmount.Text))
            {
                errorProvider.SetError(txtPaidAmount, "لا يمكن أن يكون حقل المبلغ المدفوع فارغا فارغاً");
            }
            else if (!decimal.TryParse(txtPaidAmount.Text, out decimal sellingPrice))
            {
                errorProvider.SetError(txtPaidAmount, "يجب أن يكون المبلغ المدفوع قيمة رقمية صحيحة أو عشرية");
            }
            else if (sellingPrice < 1)
            {
                errorProvider.SetError(txtPaidAmount, "يجب أن يكون المبلغ المدفوع أكبر من صفر");
            }
            else
            {
                errorProvider.SetError(txtPaidAmount, string.Empty);
            }
        }

        private void rbPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPaid.Checked)
            {
                rbCash.Enabled = rbBankTransfer.Enabled = true;
                rbCash.Checked = true;
                errorProvider.SetError(txtPaidAmount, string.Empty);
                txtPaidAmount.Text = string.Empty;
                txtPaidAmount.Enabled = false;
            }
        }

        private void rbPartiallyPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPartiallyPaid.Checked)
            {
                rbCash.Enabled = rbBankTransfer.Enabled = true;
                rbCash.Checked = true;
                txtPaidAmount.Enabled = true;
            }
        }

        private void rbUnpaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnpaid.Checked)
            {
                rbCash.Checked = rbBankTransfer.Checked = false;
                rbCash.Enabled = rbBankTransfer.Enabled = false;
                errorProvider.SetError(txtPaidAmount, string.Empty);
                txtPaidAmount.Text = string.Empty;
                txtPaidAmount.Enabled = false;
            }
        }

        protected object GetLastValueOfCell()
        {
            return dgvInvoiceLines.CurrentCell.Tag;
        }

        protected object GetLastValueOfCell(int columnIndex)
        {
            return dgvInvoiceLines.CurrentRow.Cells[columnIndex].Tag;
        }

        protected object GetCellValue()
        {
            return dgvInvoiceLines.CurrentCell.Value;
        }

        protected object GetCellValue(int columnIndex)
        {
            return dgvInvoiceLines.CurrentRow.Cells[columnIndex].Value;
        }

        protected bool IsCellValueChange()
        {
            return !(GetCellValue() == GetLastValueOfCell());
        }

        protected bool IsCurrentCellEmpty()
        {
            return IsEmptyCell(dgvInvoiceLines.CurrentCell.RowIndex, dgvInvoiceLines.CurrentCell.ColumnIndex);
        }

        protected bool IsCurrentRowHasData()
        {
            for (int i = 1; i < dgvInvoiceLines.ColumnCount - 3; i++)
            {
                if (!IsEmptyCell(dgvInvoiceLines.CurrentCell.RowIndex, i) && i != dgvInvoiceLines.CurrentCell.ColumnIndex)
                {
                    return true;
                }
            }

            return false;
        }

        protected bool IsEmptyCell(int rowIndex, int colIndex)
        {
            return string.IsNullOrWhiteSpace(dgvInvoiceLines.Rows[rowIndex].Cells[colIndex].EditedFormattedValue?.ToString());
        }

        protected enInvoiceStatus GetInvoiceStatus()
        {
            return rbPaid.Checked ? enInvoiceStatus.Paid : rbPartiallyPaid.Checked ? enInvoiceStatus.PartiallyPaid : enInvoiceStatus.Unpaid;
        }

        protected enPaymentMethod? GetPaymentMethod()
        {
            return rbCash.Checked ? enPaymentMethod.Cash : rbBankTransfer.Checked ? enPaymentMethod.BankTransfer : (enPaymentMethod?)null;
        }

        protected decimal? GetPaymentAmount()
        {
            return rbPaid.Checked ?
                Convert.ToDecimal(lblTotalGrandTotal.Text) :
                rbPartiallyPaid.Checked ?
                (string.IsNullOrWhiteSpace(txtPaidAmount.Text) ? (decimal?)null : Convert.ToDecimal(txtPaidAmount.Text)) :
                null;
        }

        protected virtual clsInvoice GetInvoiceInctance()
        {
            throw new NotImplementedException("يجب تعيين كائن  من نوع الفاتورة");
        }

        protected List<clsInvoiceLine> GetInvoiceLinesFromDGV()
        {
            List<clsInvoiceLine> invoiceLines = new List<clsInvoiceLine>();

            for (int i = 0; i < dgvInvoiceLines.RowCount - 1; i++)
            {
                invoiceLines.Add(
                    new clsInvoiceLine
                    {
                        ProductID = Convert.ToInt32(dgvInvoiceLines.Rows[i].Cells[colProduct.Index].Value),
                        UnitID = Convert.ToInt32(dgvInvoiceLines.Rows[i].Cells[colUnit.Index].Value),
                        UnitPrice = Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colUnitPrice.Index].Value),
                        ConversionFactor = Convert.ToInt32(dgvInvoiceLines.Rows[i].Cells[colConversionFactor.Index].Value),
                        Quantity = Convert.ToInt32(dgvInvoiceLines.Rows[i].Cells[colQuantity.Index].Value),
                        LineSubTotal = Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value),
                        DiscountRate = Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colDiscountRate.Index].Value),
                        TaxRate = Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colTaxRate.Index].Value),
                        LineGrandTotal = Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colGrandTotal.Index].Value)
                    }
                );
            }

            return invoiceLines;
        }

        protected void UpdateInvoiceSummary()
        {
            _RefreshInvoiceTotalLabel(lblTotalSubTotal, colSubTotal);
            _RefreshInvoiceTotalLabel(lblTotalDiscount, colDiscountAmount);
            _RefreshInvoiceTotalLabel(lblTotalTax, colTaxAmount);
            _RefreshInvoiceTotalLabel(lblTotalGrandTotal, colGrandTotal);
        }

        private void _RefreshInvoiceTotalLabel(Label label, DataGridViewColumn dataGridViewColumn)
        {
            label.Text = dgvInvoiceLines.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Sum(row => Convert.ToDecimal(row.Cells[dataGridViewColumn.Index].Value))
                .ToString("0.##");
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

            if (clsFormHelper.IsDataGridViewCellsHasError(dgvInvoiceLines, ErrorColumnIndex))
            {
                clsFormMessages.ShowError("يجب إدخال جميع البيانات بصورة صحيحة قبل الحفظ");
                return;
            }

            if (!clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                return;
            }
            
            clsInvoice invoice = GetInvoiceInctance();

            clsValidationResult validationResult = invoice.Issue();

            if (validationResult.IsValid)
            {
                clsFormMessages.ShowSuccess("تم إصدار الفاتورة بنجاح");
                this.Close();
            }
            else
            {
                clsFormMessages.ShowValidationErrors(validationResult);
            }
        }

    }
}