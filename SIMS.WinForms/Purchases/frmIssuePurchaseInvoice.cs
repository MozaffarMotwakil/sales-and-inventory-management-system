using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;
using SIMS.WinForms.Suppliers;

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
                    object subTotal = dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value;
                    object discountTotal = dgvInvoiceLines.CurrentRow.Cells[colDiscount.Index].Value;
                    object taxRate = dgvInvoiceLines.CurrentRow.Cells[colTax.Index].Value;
                    object grandTotal = dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value;

                    lblTotalSubTotal.Text = (Convert.ToDecimal(lblTotalSubTotal.Text) - (subTotal == null ? 0 : Convert.ToDecimal(subTotal))).ToString();
                    lblTotalDiscount.Text = (Convert.ToDecimal(lblTotalDiscount.Text) - (discountTotal == null ? 0 : Convert.ToDecimal(discountTotal))).ToString();
                    lblTotalTax.Text = (Convert.ToDecimal(lblTotalTax.Text) - (taxRate == null ? 0 : (Convert.ToDecimal(subTotal) -  Convert.ToDecimal(discountTotal)) * (Convert.ToDecimal(taxRate) / 100))).ToString();
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
                int? productID = (int?)dgvInvoiceLines.Rows[dgvInvoiceLines.CurrentRow.Index].Cells[colProduct.Index].Value;

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
            if (e.ColumnIndex == colProduct.Index)
            {
                dgvInvoiceLines.CurrentCell.Tag = dgvInvoiceLines.CurrentCell.Value;
            }

            if (e.ColumnIndex == colSubTotal.Index)
            {
                dgvInvoiceLines.CurrentCell.Tag = dgvInvoiceLines.CurrentCell.Value;
            }

            if (e.ColumnIndex == colDiscount.Index)
            {
                dgvInvoiceLines.CurrentCell.Tag = dgvInvoiceLines.CurrentCell.Value;
            }

            if (e.ColumnIndex == colTax.Index)
            {
                dgvInvoiceLines.CurrentCell.Tag = dgvInvoiceLines.CurrentCell.Value;
            }

            if (e.ColumnIndex == colGrandTotal.Index)
            {
                dgvInvoiceLines.CurrentCell.Tag = dgvInvoiceLines.CurrentCell.Value;
            }
        }

        private void dgvProductsDetailsList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colProduct.Index)
            {
                if ((int?)dgvInvoiceLines.CurrentCell.Tag != (int?)dgvInvoiceLines.CurrentCell.Value)
                {
                    DataGridViewComboBoxCell cellComboBox = (dgvInvoiceLines.CurrentRow.Cells[colUnit.Index] as DataGridViewComboBoxCell);
                    cellComboBox.ValueMember = string.Empty;
                    cellComboBox.Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colConversionFactor.Index].Value = null;
                }
            }

            if (e.ColumnIndex == colUnit.Index && dgvInvoiceLines.CurrentCell.Value != null)
            {
                DataGridViewComboBoxCell comboBoxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;
                dgvInvoiceLines.CurrentRow.Cells[colConversionFactor.Index].Value = (comboBoxCell.DataSource as DataTable).Rows.Find(dgvInvoiceLines.CurrentCell.Value).Field<object>("ConversionFactor");
            }

            if (int.TryParse(dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value?.ToString(), out int lineQuantity) &&
                decimal.TryParse(dgvInvoiceLines.CurrentRow.Cells[colUnitPrice.Index].Value?.ToString(), out decimal lineUnitPrice))
            {
                decimal lineSubTotal = lineQuantity * lineUnitPrice;
                dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = lineSubTotal;

                if (decimal.TryParse(dgvInvoiceLines.CurrentRow.Cells[colDiscount.Index].Value?.ToString(), out decimal lineDiscount) &&
                    decimal.TryParse(dgvInvoiceLines.CurrentRow.Cells[colTax.Index].Value?.ToString(), out decimal lineTax))
                {
                    dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = ((lineSubTotal - lineDiscount) * (1 + (lineTax / 100)));
                }
            }

            if (dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value == null || dgvInvoiceLines.CurrentRow.Cells[colUnitPrice.Index].Value == null)
            {
                dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = null;
            }
            else if (dgvInvoiceLines.CurrentRow.Cells[colTax.Index].Value == null || dgvInvoiceLines.CurrentRow.Cells[colTax.Index].Value == null)
            {
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
                if (dgvInvoiceLines.Rows[i].Cells[colDiscount.Index].Value != null)
                {
                    sum += Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colDiscount.Index].Value);
                }
            }

            lblTotalDiscount.Text = sum.ToString();

            sum = 0;

            for (int i = 0; i < dgvInvoiceLines.RowCount - 1; i++)
            {
                if (dgvInvoiceLines.Rows[i].Cells[colTax.Index].Value != null && dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value != null && dgvInvoiceLines.Rows[i].Cells[colDiscount.Index].Value != null)
                {
                    sum += (((Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value) - (Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colDiscount.Index].Value)))) * ((Convert.ToDecimal(dgvInvoiceLines.Rows[i].Cells[colTax.Index].Value) / 100)));
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

        private void txtPurchaseInvoiceNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtPurchaseInvoiceNo, errorProvider, "لا يمكن أن يكون حقل رقم الفاتورة فارغا");
        }

        private void txtPaidAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!rbPartiallyPaid.Checked)
            {
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

            if (e.ColumnIndex == colUnitPrice.Index)
            {
                if (_IsCurrentCellEmpty() && _IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل سعر شراء الوحدة فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!decimal.TryParse(dgvInvoiceLines.CurrentCell.EditedFormattedValue?.ToString(), out decimal unitPrice) && 
                    !_IsCurrentCellEmpty())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب إدخال قيمة رقمية صحيحة أو عشرية لسعر شراء الوحدة";
                    SystemSounds.Asterisk.Play();
                }
                else if (unitPrice < 1 && !_IsCurrentCellEmpty())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن يكون سعر شراء الوحدة أكبر من صفر";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colDiscount.Index)
            {
                if (_IsCurrentCellEmpty() && _IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل قيمة الخصم فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!_IsCurrentCellEmpty() && (!(decimal.TryParse(dgvInvoiceLines.CurrentCell.EditedFormattedValue?.ToString(), out decimal discount) || discount < 0)))
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن تكون قيمة الخصم رقم موجب صحيح";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colTax.Index)
            {
                if (_IsCurrentCellEmpty() && _IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل قيمة الخصم فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!_IsCurrentCellEmpty() && (!(decimal.TryParse(dgvInvoiceLines.CurrentCell.EditedFormattedValue?.ToString(), out decimal tax) || tax < 0)))
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن تكون نسبة الضريبة رقم موجب صحيح";
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
                _IsEmptyCell(e.RowIndex, colQuantity.Index) || 
                _IsEmptyCell(e.RowIndex, colUnitPrice.Index) ||
                _IsEmptyCell(e.RowIndex, colDelete.Index) ||
                _IsEmptyCell(e.RowIndex, colTax.Index)
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
                errorProvider.SetError(txtPaidAmount, string.Empty);
                txtPaidAmount.Text =string.Empty;
                txtPaidAmount.Enabled = false;
            }
        }

        private void rbPartiallyPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPartiallyPaid.Checked)
            {
                txtPaidAmount.Enabled = true;
            }
        }

        private void rbUnpaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnpaid.Checked)
            {
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

            clsPurchaseInvoice purchaseInvoice = new clsPurchaseInvoice(
                txtPurchaseInvoiceNo.Text,
                dtpPurchaseDate.Value,
                rbPaid.Checked ? clsInvoice.enInvoiceStatus.Paid : rbPartiallyPaid.Checked ? clsInvoice.enInvoiceStatus.PartiallyPaid : clsInvoice.enInvoiceStatus.Unpaid,
                _GetInvoiceLinesFromDGV(),
                rbCash.Checked ? clsInvoice.enPaymentMethod.Cash : clsInvoice.enPaymentMethod.BankTransfer,
                rbPaid.Checked ? Convert.ToDecimal(lblTotalGrandTotal.Text) : rbPartiallyPaid.Checked ? (string.IsNullOrWhiteSpace(txtPaidAmount.Text) ? (decimal?)null : Convert.ToDecimal(txtPaidAmount.Text)) : null,
                (int?)cbSupplier.SelectedValue ?? -1,
                (int)cbWarehouse.SelectedValue
                );

            clsValidationResult validationResult = purchaseInvoice.Issue();

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
                            ProductID = int.Parse(dgvInvoiceLines.Rows[i].Cells[colProduct.Index].Value.ToString()),
                            UnitID = int.Parse(dgvInvoiceLines.Rows[i].Cells[colUnit.Index].Value.ToString()),
                            UnitPrice = decimal.Parse(dgvInvoiceLines.Rows[i].Cells[colUnitPrice.Index].Value.ToString()),
                            ConversionFactor = int.Parse(dgvInvoiceLines.Rows[i].Cells[colConversionFactor.Index].Value.ToString()),
                            Quantity = int.Parse(dgvInvoiceLines.Rows[i].Cells[colQuantity.Index].Value.ToString()),
                            LineSubTotal = decimal.Parse(dgvInvoiceLines.Rows[i].Cells[colSubTotal.Index].Value.ToString()),
                            Discount = decimal.Parse(dgvInvoiceLines.Rows[i].Cells[colDiscount.Index].Value.ToString()),
                            TaxRate = decimal.Parse(dgvInvoiceLines.Rows[i].Cells[colTax.Index].Value.ToString()),
                            LineGrandTotal = decimal.Parse(dgvInvoiceLines.Rows[i].Cells[colGrandTotal.Index].Value.ToString())
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