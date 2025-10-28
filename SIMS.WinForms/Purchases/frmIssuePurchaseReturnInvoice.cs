using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Purchases
{
    public partial class frmIssuePurchaseReturnInvoice : Form
    {
        private clsPurchaseInvoice _OrginalInvoice;

        public frmIssuePurchaseReturnInvoice(clsPurchaseInvoice orginilInvoice)
        {
            InitializeComponent();
            _OrginalInvoice = orginilInvoice;
        }

        private void frmReturnPurchaseInvoice_Load(object sender, EventArgs e)
        {
            if (_OrginalInvoice == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على الفاتورة الأصلية");
                this.Close();
                return;
            }

            dtpPurchaseDate.Value = DateTime.Today;

            dgvInvoiceLines.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvInvoiceLines.Rows[0].Cells[colLineNa.Index].Value = 1;
            dgvInvoiceLines.Rows[0].Cells[colDelete.Index].Value = Resources.delete;

            txtOriginalInvoiceNo.Text = _OrginalInvoice.InvoiceNo;
            cbWarehouse.Text = _OrginalInvoice.WarehouseInfo.WarehouseName;
            cbSupplier.Text = (_OrginalInvoice as clsPurchaseInvoice).Supplier.PartyInfo.PartyName;
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
                    object subTotal = dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value;
                    object discountTotal = dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value;
                    object taxRate = dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value;
                    object grandTotal = dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value;

                    lblTotalSubTotal.Text = (Convert.ToDecimal(lblTotalSubTotal.Text) - (subTotal == null ? 0 : Convert.ToDecimal(subTotal))).ToString();
                    lblTotalDiscount.Text = (Convert.ToDecimal(lblTotalDiscount.Text) - (discountTotal == null ? 0 : Convert.ToDecimal(discountTotal))).ToString();
                    lblTotalTax.Text = (Convert.ToDecimal(lblTotalTax.Text) - (taxRate == null ? 0 : (Convert.ToDecimal(subTotal) - Convert.ToDecimal(discountTotal)) * (Convert.ToDecimal(taxRate) / 100))).ToString();
                    lblTotalGrandTotal.Text = (Convert.ToDecimal(lblTotalGrandTotal.Text) - (grandTotal == null ? 0 : Convert.ToDecimal(grandTotal))).ToString();
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

        private void dgvInvoiceLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == colProduct.Index)
            {
                dgvInvoiceLines.CurrentCell.Tag = dgvInvoiceLines.CurrentCell.Value;

                List<int> selectedProductIDs = dgvInvoiceLines.Rows.Cast<DataGridViewRow>()
                    .Where(row => row != dgvInvoiceLines.CurrentRow && row.Cells[colProduct.Index].Value != null)
                    .Select(row => Convert.ToInt32(row.Cells[colProduct.Index].Value))
                    .ToList();

                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _OrginalInvoice.Lines
                    .Where(line => line.GetRemainingQuantity() != 0)
                    .GroupBy(line => line.ProductInfo.ProductID)
                    .Select(group => group.First().ProductInfo)
                    .Where(product => 
                        !selectedProductIDs.Contains(product.ProductID.Value) || 
                        _GetSelectedProductUnitIDs(product.ProductID).Count != 
                        _OrginalInvoice.Lines.Where(line => line.ProductID == product.ProductID).Count())
                    .OrderBy(product => product.ProductName)
                    .ToList();

                colProduct.DisplayMember = "ProductName";
                colProduct.ValueMember = "ProductID";
            }

            if (e.ColumnIndex == colUnit.Index && dgvInvoiceLines.CurrentRow.Cells[colProduct.Index].Value != null)
            {
                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _OrginalInvoice.Lines
                    .Where(line => line.ProductID == Convert.ToInt32(dgvInvoiceLines.CurrentRow.Cells[colProduct.Index].Value))
                    .Select(line => line.UnitInfo)
                    .Where(unit => !_GetSelectedProductUnitIDs((int?)dgvInvoiceLines.CurrentRow.Cells[colProduct.Index].Value).Contains(unit.UnitID))
                    .ToList();

                colUnit.DisplayMember = "UnitName";
                colUnit.ValueMember = "UnitID";
            }
        }

        private List<int> _GetSelectedProductUnitIDs(int? productID)
        {
            return dgvInvoiceLines.Rows.Cast<DataGridViewRow>()
                   .Where(row => row != dgvInvoiceLines.CurrentRow && row.Cells[colUnit.Index].Value != null &&
                        (int?)row.Cells[colProduct.Index].Value == productID)
                   .Select(row => Convert.ToInt32(row.Cells[colUnit.Index].Value))
                   .ToList();
        }

        private void dgvInvoiceLines_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colProduct.Index)
            {
                if (dgvInvoiceLines.CurrentCell.Tag != dgvInvoiceLines.CurrentCell.Value)
                {
                    DataGridViewComboBoxCell cellComboBox = (dgvInvoiceLines.CurrentRow.Cells[colUnit.Index] as DataGridViewComboBoxCell);
                    cellComboBox.ValueMember = string.Empty;
                    cellComboBox.Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colConversionFactor.Index].Value = null;
                }
            }

            if (e.ColumnIndex == colUnit.Index && dgvInvoiceLines.CurrentCell.Value != null)
            {
                DataGridViewComboBoxCell unitComboBoxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;
                DataGridViewComboBoxCell productComboBoxCell = dgvInvoiceLines.CurrentRow.Cells[colProduct.Index] as DataGridViewComboBoxCell;
                clsProduct selectedProduct = (productComboBoxCell.DataSource as List<clsProduct>)
                    .First(product => product.ProductID == (int?)productComboBoxCell.Value);

                if ((int)dgvInvoiceLines.CurrentCell.Value != selectedProduct.MainUnitInfo.UnitID)
                {
                    dgvInvoiceLines.CurrentRow.Cells[colConversionFactor.Index].Value = selectedProduct.UnitConversions
                        .First(alternativeUnit => alternativeUnit.AlternativeUnitID == (int)dgvInvoiceLines.CurrentCell.Value).ConversionFactor;
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.Cells[colConversionFactor.Index].Value = 1;
                }
            }
            
            if (int.TryParse(dgvInvoiceLines.CurrentRow.Cells[colProduct.Index].Value?.ToString(), out int lineProductID) && 
                int.TryParse(dgvInvoiceLines.CurrentRow.Cells[colUnit.Index].Value?.ToString(), out int lineUnitID))
            {
                clsInvoiceLine cuurentLine = _OrginalInvoice.Lines
                    .First(line => line.ProductID == lineProductID && line.UnitID == lineUnitID);

                dgvInvoiceLines.CurrentRow.Cells[colUnitPrice.Index].Value = cuurentLine.UnitPrice.ToString();

                if (int.TryParse(dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value?.ToString(), out int lineQuantity))
                {
                    int remainingQuanity = cuurentLine.GetRemainingQuantity();

                    if (lineQuantity > remainingQuanity)
                    {
                        lineQuantity = remainingQuanity;
                        dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value = remainingQuanity;
                    }

                    decimal lineSubTotal = lineQuantity * cuurentLine.UnitPrice;

                    dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = lineSubTotal.ToString();
                    dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value = (lineSubTotal * cuurentLine.DiscountPercentage / 100).ToString();
                    dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value = cuurentLine.TaxRate.ToString() + "%";
                    dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = ((lineSubTotal - (lineSubTotal * cuurentLine.DiscountPercentage / 100)) * (1 + (cuurentLine.TaxRate / 100))).ToString();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = null;
                }
            }
            else
            {
                dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colUnitPrice.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = null;
            }

            decimal sum = 0;

            for (int i = 0; i < dgvInvoiceLines.RowCount - 1; i++)
            {
                if (dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value != null)
                {
                    sum += Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value);
                }
            }

            lblTotalSubTotal.Text = sum.ToString();

            sum = 0;

            for (int i = 0; i < dgvInvoiceLines.RowCount - 1; i++)
            {
                if (dgvInvoiceLines.Rows[i].Cells[colDiscountAmount.Index].Value != null)
                {
                    sum += Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colDiscountAmount.Index].Value);
                }
            }

            lblTotalDiscount.Text = sum.ToString();

            sum = 0;

            for (int i = 0; i < dgvInvoiceLines.RowCount - 1; i++)
            {
                if (dgvInvoiceLines.Rows[i].Cells[colTaxRate.Index].Value != null && dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value != null && dgvInvoiceLines.Rows[i].Cells[colDiscountAmount.Index].Value != null)
                {
                    sum += (((Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value) - (Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colDiscountAmount.Index].Value)))) * ((Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colTaxRate.Index].Value.ToString().Replace('%', '\u0000')) / 100)));
                }
            }

            lblTotalTax.Text = sum.ToString();

            sum = 0;

            for (int i = 0; i < dgvInvoiceLines.RowCount - 1; i++)
            {
                if (dgvInvoiceLines.Rows[i].Cells[colGrandTotal.Index].Value != null)
                {
                    sum += Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colGrandTotal.Index].Value);
                }
            }

            lblTotalGrandTotal.Text = sum.ToString();
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

        private void dgvInvoiceLines_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == colProduct.Index)
            {
                if (_IsCurrentCellEmpty() && _IsCurrentRowHasData())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب إختيار منتج";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colUnit.Index)
            {
                if (_IsCurrentCellEmpty() && _IsCurrentRowHasData())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب إختيار وحدة";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colQuantity.Index)
            {
                if (_IsCurrentCellEmpty() && _IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل الكمية فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if ((!_IsCurrentCellEmpty()) && (!int.TryParse(dgvInvoiceLines.CurrentCell.EditedFormattedValue?.ToString(), out int quantity) || quantity < 1))
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن تكون الكمية رقماً صحيحاً أكبر من صفر";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }
        }

        private void dgvInvoiceLines_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            bool isThereEmptyCellInCurrentRow = (
                _IsEmptyCell(e.RowIndex, colProduct.Index) ||
                _IsEmptyCell(e.RowIndex, colUnit.Index) ||
                _IsEmptyCell(e.RowIndex, colQuantity.Index) 
                );

            if ((!string.IsNullOrEmpty(dgvInvoiceLines.CurrentRow.ErrorText) || isThereEmptyCellInCurrentRow) && e.RowIndex != dgvInvoiceLines.NewRowIndex)
            {
                e.Cancel = true;
                dgvInvoiceLines.CurrentRow.ErrorText = "يجب إدخال جميع بيانات الصف الحالي بشكل صحيح قبل الإنتقال لصف جديد";
                SystemSounds.Asterisk.Play();
            }
        }

        private bool _IsCurrentCellEmpty()
        {
            return _IsEmptyCell(dgvInvoiceLines.CurrentCell.RowIndex, dgvInvoiceLines.CurrentCell.ColumnIndex);
        }

        private bool _IsEmptyCell(int rowIndex, int colIndex)
        {
            return string.IsNullOrWhiteSpace(dgvInvoiceLines.Rows[rowIndex].Cells[colIndex].EditedFormattedValue?.ToString());
        }

        private bool _IsCurrentRowHasData()
        {
            for (int i = 1; i < dgvInvoiceLines.ColumnCount - 3; i++)
            {
                if (!_IsEmptyCell(dgvInvoiceLines.CurrentCell.RowIndex, i) && i != dgvInvoiceLines.CurrentCell.ColumnIndex)
                {
                    return true;
                }
            }

            return false;
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

            clsPurchaseReturnInvoice purchaseReturnInvoice = new clsPurchaseReturnInvoice(
                _OrginalInvoice.InvoiceID.Value,
                dtpPurchaseDate.Value,
                rbPaid.Checked ? enInvoiceStatus.Paid : rbPartiallyPaid.Checked ? enInvoiceStatus.PartiallyPaid : enInvoiceStatus.Unpaid,
                _GetInvoiceLinesFromDGV(),
                _OrginalInvoice.Supplier.SupplierID.Value,
                _OrginalInvoice.WarehouseInfo.WarehouseID.Value,
                rbCash.Checked ? enPaymentMethod.Cash : rbBankTransfer.Checked ? enPaymentMethod.BankTransfer : (enPaymentMethod?)null,
                rbPaid.Checked ? Convert.ToDecimal(lblTotalGrandTotal.Text) : rbPartiallyPaid.Checked ? (string.IsNullOrWhiteSpace(txtPaidAmount.Text) ? (decimal?)null : Convert.ToDecimal(txtPaidAmount.Text)) : null
                );

            clsValidationResult validationResult = purchaseReturnInvoice.Issue();

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

        private List<clsInvoiceLine> _GetInvoiceLinesFromDGV()
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
                            DiscountPercentage = clsInvoiceLine.CalculateDiscountPercentage(Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colDiscountAmount.Index].Value), Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value)),
                            TaxRate = Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colTaxRate.Index].Value.ToString().Replace('%', '\u0000')),
                            LineGrandTotal = Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colGrandTotal.Index].Value)
                        }
                    );
                }
                catch (Exception ex)
                {
                    clsFormMessages.ShowError($"حدث خطأ في قراءة الصف {i + 1}: {ex.Message}\nسيتم إلغاء العملية الحالية الرجاء المحاولة مرة أخرى", "خطأ في البيانات");
                    this.Close();
                    break;
                }
            }

            return invoiceLines;
        }

    }
}
