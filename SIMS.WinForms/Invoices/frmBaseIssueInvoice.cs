using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Invoices
{
    public partial class frmBaseIssueInvoice : Form
    {
        public frmBaseIssueInvoice()
        {
            InitializeComponent();
        }

        private void frmBaseIssueInvoice_Load(object sender, EventArgs e)
        {
            this.warehousesTableAdapter.Fill(this.warehouseNames.Warehouses);

            dgvInvoiceLines.Rows[0].Cells[colLineNa.Index].Value = 1;
            dgvInvoiceLines.Rows[0].Cells[colDelete.Index].Value = Resources.delete;

            dtpInvoiceIssueDate.MaxDate = dtpInvoiceIssueDate.Value = DateTime.Today;
            dtpInvoiceIssueDate.MinDate = DateTime.Today.AddYears(-1);
            cbWarehouse.SelectedIndex = 0;
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

        private void dgvInvoiceLines_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            bool isThereEmptyCellInCurrentRow = (
                IsEmptyCell(e.RowIndex, colProduct.Index) ||
                IsEmptyCell(e.RowIndex, colUnit.Index) ||
                IsEmptyCell(e.RowIndex, colQuantity.Index) ||
                IsEmptyCell(e.RowIndex, colUnitPrice.Index) ||
                IsEmptyCell(e.RowIndex, colDiscountAmount.Index) ||
                IsEmptyCell(e.RowIndex, colDiscountRate.Index) ||
                IsEmptyCell(e.RowIndex, colTaxAmount.Index) ||
                IsEmptyCell(e.RowIndex, colTaxRate.Index) ||
                IsEmptyCell(e.RowIndex, colSubTotal.Index) ||
                IsEmptyCell(e.RowIndex, colGrandTotal.Index)
                );

            if ((!string.IsNullOrEmpty(dgvInvoiceLines.CurrentRow.ErrorText) || isThereEmptyCellInCurrentRow) && e.RowIndex != dgvInvoiceLines.NewRowIndex)
            {
                e.Cancel = true;
                dgvInvoiceLines.CurrentRow.ErrorText = "يجب إدخال جميع بيانات الصف الحالي بشكل صحيح قبل الإنتقال لصف جديد";
                SystemSounds.Asterisk.Play();
            }
        }

        protected bool IsQuantityOrUnitPriceChange()
        {
            return IsCellValueChange(colQuantity.Index) || IsCellValueChange(colUnitPrice.Index);
        }

        protected bool IsCellValueChange(int columnIndex)
        {
            return GetLastValueOfCell(columnIndex) != GetCellValue(columnIndex);
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

        protected object GetCellValue(int rowIndex, int columnIndex)
        {
            return dgvInvoiceLines.Rows[rowIndex].Cells[columnIndex].Value;
        }

        protected bool IsCellValueChange()
        {
            return IsEmptyCell(dgvInvoiceLines.CurrentCell.RowIndex, dgvInvoiceLines.CurrentCell.ColumnIndex);
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

        protected virtual clsInvoice GetInvoiceInctance()
        {
            throw new NotImplementedException("يجب تعيين كائن  من نوع الفاتورة");
        }

        protected List<clsInvoiceLine> GetInvoiceLinesFromDGV()
        {
            List<clsInvoiceLine> invoiceLines = new List<clsInvoiceLine>();

            for (int i = 0; i < dgvInvoiceLines.RowCount - 1; i++)
            {
                try
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
                catch (Exception ex)
                {
                    clsFormMessages.ShowError($"حدث خطأ في قراءة الصف {i + 1}: {ex.Message}\nسيتم إلغاء العملية الحالية الرجاء المحاولة مرة أخرى", "خطأ في البيانات");
                    break;
                }
            }

            return invoiceLines;
        }
       
    }
}
