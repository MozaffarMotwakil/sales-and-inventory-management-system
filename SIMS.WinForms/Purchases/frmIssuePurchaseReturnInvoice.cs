using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;

namespace SIMS.WinForms.Purchases
{
    public partial class frmIssuePurchaseReturnInvoice : frmBaseIssueInvoice
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

            txtInvoiceNo.Text = _OrginalInvoice.InvoiceNo;
            cbParty.Text = _OrginalInvoice.GetPartyName();

            colDiscountAmount.ReadOnly = colDiscountRate.ReadOnly = colTaxAmount.ReadOnly =
                colTaxRate.ReadOnly = colUnitPrice.ReadOnly = true;

            dgvInvoiceLines.CellEndEdit += dgvInvoiceLines_CellEndEdit;
            dgvInvoiceLines.CellValidating += dgvInvoiceLines_CellValidating;
        }

        protected override clsInvoice GetInvoiceInctance()
        {
            return new clsPurchaseReturnInvoice(
                _OrginalInvoice.InvoiceID.Value,
                dtpInvoiceIssueDate.Value,
                GetInvoiceStatus(),
                GetInvoiceLinesFromDGV(),
                (int)cbWarehouse.SelectedValue,
                GetPaymentMethod(),
                GetPaymentAmount()
                );
        }

        protected override void dgvInvoiceLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            base.dgvInvoiceLines_CellBeginEdit(sender, e);

            if (e.ColumnIndex == colProduct.Index)
            {
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

                dgvInvoiceLines.CurrentRow.Cells[colUnitPrice.Index].Value = cuurentLine.UnitPrice;

                if (int.TryParse(dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value?.ToString(), out int lineQuantity))
                {
                    int remainingQuantity = cuurentLine.GetRemainingQuantity();

                    if (lineQuantity > remainingQuantity)
                    {
                        lineQuantity = remainingQuantity;
                        dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value = remainingQuantity;
                    }

                    decimal lineSubTotal = clsInvoiceLine.CalculateSubTotal(cuurentLine.UnitPrice, lineQuantity);
                    dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = lineSubTotal;

                    decimal discountAmount = clsInvoiceLine.CalculateDiscountAmount(cuurentLine.DiscountRate, lineSubTotal);
                    decimal discountRate = clsInvoiceLine.CalculateDiscountRate(discountAmount, lineSubTotal);
                    dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value = discountAmount;
                    dgvInvoiceLines.CurrentRow.Cells[colDiscountRate.Index].Value = discountRate;

                    decimal taxAmount = clsInvoiceLine.CalculateTaxAmount(cuurentLine.TaxRate, discountAmount, lineSubTotal);
                    decimal taxRate = clsInvoiceLine.CalculateTaxRate(taxAmount, discountAmount, lineSubTotal);
                    dgvInvoiceLines.CurrentRow.Cells[colTaxAmount.Index].Value = taxAmount;
                    dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value = taxRate;

                    dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = clsInvoiceLine.CalculateGrandTotal(lineSubTotal, discountRate, taxRate);
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
                dgvInvoiceLines.CurrentRow.Cells[colQuantity.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colUnitPrice.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colSubTotal.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colDiscountAmount.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colDiscountRate.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colTaxAmount.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colTaxRate.Index].Value = null;
                dgvInvoiceLines.CurrentRow.Cells[colGrandTotal.Index].Value = null;
            }

            base.UpdateInvoiceSummary();
        }

        private void dgvInvoiceLines_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == colProduct.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
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
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
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
        }

    }
}
