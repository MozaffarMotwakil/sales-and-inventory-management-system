using System;
using System.Data;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Suppliers;

namespace SIMS.WinForms.Inventory
{
    public partial class frmIssuePurchaseInvoice : frmBaseIssueInvoice
    {
        public frmIssuePurchaseInvoice()
        {
            InitializeComponent();
        }

        private void frmReceiveNewGoods_Load(object sender, EventArgs e)
        {
            this.vw_SuppliersDetailsTableAdapter.Fill(this.supplierNames.vw_SuppliersDetails);
            this.productsTableAdapter.Fill(this.productNames.Products);

            cbParty.SelectedItem = null;
            cbParty.Text = "إختار المورد";

            clsSupplierService.CreateInstance().EntitySaved += clsSupplier_SupplierSaved;
            dgvInvoiceLines.CellEndEdit += dgvInvoiceLines_CellEndEdit;
            dgvInvoiceLines.EditingControlShowing += dgvInvoiceLines_EditingControlShowing;
            dgvInvoiceLines.CellValidating += dgvInvoiceLines_CellValidating;
            txtInvoiceNo.Validating += txtInvoiceNo_Validating;
            cbParty.Validating += cbParty_Validating;
            cbParty.Enter += cbParty_Enter;
            cbParty.Leave += cbParty_Leave;
        }

        private void cbParty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(cbParty, errorProvider, "يجب تعيين مورد للفاتورة");
        }

        protected override clsInvoice GetInvoiceInctance()
        {
            return new clsPurchaseInvoice(
                txtInvoiceNo.Text,
                dtpInvoiceIssueDate.Value,
                GetInvoiceStatus(),
                GetInvoiceLinesFromDGV(),
                (int)cbParty.SelectedValue,
                (int)cbWarehouse.SelectedValue,
                GetPaymentMethod(),
                GetPaymentAmount()
                );
        }

        private void cbParty_Enter(object sender, EventArgs e)
        {
            if (cbParty.SelectedIndex == -1)
            {
                cbParty.Text = string.Empty;
            }
        }

        private void cbParty_Leave(object sender, EventArgs e)
        {
            if (cbParty.SelectedIndex == -1)
            {
                cbParty.Text = "إختار المورد";
            }
        }

        private void llAddPersonSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addPersonSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Person);
            addPersonSupplier.ShowDialog();
            cbParty.Focus();
            llAddPersonSupplier.Focus();
        }

        private void llAddOrganizationSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addEditOrganizationSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Organization);
            addEditOrganizationSupplier.ShowDialog();
            cbParty.Focus();
            llAddOrganizationSupplier.Focus();
        }

        private void clsSupplier_SupplierSaved(object sender, EntitySavedEventArgs e)
        {
            this.vw_SuppliersDetailsTableAdapter.Fill(this.supplierNames.vw_SuppliersDetails);
            cbParty.SelectedItem = e.EntityName;
        }

        private void dgvInvoiceLines_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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

        private void dgvInvoiceLines_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colProduct.Index)
            {
                if (IsCellValueChange())
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

            if (dgvInvoiceLines.CurrentRow.Cells[colProduct.Index].Value != null && dgvInvoiceLines.CurrentRow.Cells[colUnit.Index].Value != null)
            {
                if (int.TryParse(dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value?.ToString(), out int lineQuantity) &&
                    decimal.TryParse(dgvInvoiceLines.CurrentRow.Cells[colUnitPrice.Index].Value?.ToString(), out decimal lineUnitPrice))
                {
                    decimal lineSubTotal = clsInvoiceLine.CalculateSubTotal(lineUnitPrice, lineQuantity);
                    decimal lineDiscountAmount = Convert.ToDecimal(dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value);
                    decimal lineDiscountRate = Convert.ToDecimal(dgvInvoiceLines.CurrentRow.Cells[colDiscountRate.Index].Value);
                    decimal lineTaxAmount = Convert.ToDecimal(dgvInvoiceLines.CurrentRow.Cells[colTaxAmount.Index].Value);
                    decimal lineTaxRate = Convert.ToDecimal(dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value);

                    if (e.ColumnIndex == colDiscountAmount.Index)
                    {
                        lineDiscountRate = clsInvoiceLine.CalculateDiscountRate(lineDiscountAmount, lineSubTotal);
                    }

                    if (e.ColumnIndex == colTaxAmount.Index)
                    {
                        lineTaxRate = clsInvoiceLine.CalculateTaxRate(lineTaxAmount, lineDiscountAmount, lineSubTotal);
                    }

                    lineDiscountAmount = clsInvoiceLine.CalculateDiscountAmount(lineDiscountRate, lineSubTotal);
                    lineDiscountRate = clsInvoiceLine.CalculateDiscountRate(lineDiscountAmount, lineSubTotal);
                    lineTaxAmount = clsInvoiceLine.CalculateTaxAmount(lineTaxRate, lineDiscountAmount, lineSubTotal);
                    lineTaxRate = clsInvoiceLine.CalculateTaxRate(lineTaxAmount, lineDiscountAmount, lineSubTotal);

                    dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = lineSubTotal;
                    dgvInvoiceLines.CurrentRow.Cells[colDiscountRate.Index].Value = lineDiscountRate;
                    dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value = lineDiscountAmount;
                    dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value = lineTaxRate;
                    dgvInvoiceLines.CurrentRow.Cells[colTaxAmount.Index].Value = lineTaxAmount;

                    if ((dgvInvoiceLines.CurrentRow.Cells[colDiscountRate.Index].Value != null && dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value != null))
                    {
                        dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = clsInvoiceLine.CalculateGrandTotal(lineSubTotal, lineDiscountRate, lineTaxRate);
                    }
                    else
                    {
                        dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = null;
                    }
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colDiscountRate.Index].Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colTaxAmount.Index].Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value = null;
                    dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = null;
                }
            }
            else
            {
                dgvInvoiceLines.CurrentRow.Cells[colUnitPrice.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colDiscountRate.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colTaxAmount.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = null;
            }

            base.UpdateInvoiceSummary();
        }

        private void txtInvoiceNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtInvoiceNo, errorProvider, "لا يمكن أن يكون حقل رقم الفاتورة فارغا");
        }

        private void dgvInvoiceLines_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == colProduct.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
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
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
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
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل الكمية فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if ((!IsCurrentCellEmpty()) && (!int.TryParse(dgvInvoiceLines.CurrentCell.EditedFormattedValue?.ToString(), out int quantity) || quantity < 1))
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
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل سعر شراء الوحدة فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!decimal.TryParse(dgvInvoiceLines.CurrentCell.EditedFormattedValue?.ToString(), out decimal unitPrice) &&
                    !IsCurrentCellEmpty())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب إدخال قيمة رقمية صحيحة أو عشرية لسعر شراء الوحدة";
                    SystemSounds.Asterisk.Play();
                }
                else if (unitPrice < 1 && !IsCurrentCellEmpty())
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

            if (e.ColumnIndex == colDiscountRate.Index || e.ColumnIndex == colDiscountAmount.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل قيمة الخصم أو نسبة الخصم فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!(decimal.TryParse(dgvInvoiceLines.CurrentCell.EditedFormattedValue?.ToString(), out decimal discount) || discount < 0) && !IsCurrentCellEmpty())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن تكون نسبة الخصم أو مبلغ الخصم رقم موجب صحيح";
                    SystemSounds.Asterisk.Play();
                }
                else if (!IsCurrentCellEmpty())
                {
                    decimal subTotal = (decimal)GetCellValue(colSubTotal.Index);

                    if ((e.ColumnIndex == colDiscountAmount.Index && discount >= subTotal) ||
                        (e.ColumnIndex == colDiscountRate.Index && clsInvoiceLine.CalculateDiscountAmount(discount, subTotal) >= subTotal))
                    {
                        e.Cancel = true;
                        dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون مبلغ الخصم أكبر من أو يساوي الإجمالي الفرعي";
                        SystemSounds.Asterisk.Play();
                    }
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colTaxRate.Index || e.ColumnIndex == colTaxAmount.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل قيمة الضريبة أو نسبة الضريبة فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!IsCurrentCellEmpty() && (!(decimal.TryParse(dgvInvoiceLines.CurrentCell.EditedFormattedValue?.ToString(), out decimal tax) || tax < 0)))
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن تكون نسبة الضريبة أو مبلغ الضريبة رقم موجب صحيح";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

        }

    }
}