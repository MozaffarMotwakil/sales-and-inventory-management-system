using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Warehouses;
using SIMS.WinForms.Invoices;

namespace SIMS.WinForms.Sales
{
    public partial class frmIssueSaleInvoice : frmBaseIssueInvoice
    {
        private List<clsInventory> _WarehouseAvailableInventories;

        public frmIssueSaleInvoice() : base(enInvoiceType.Sales)
        {
            InitializeComponent();
        }

        private void frmIssueSaleInvoice_Load(object sender, EventArgs e)
        {
            colUnitPrice.ReadOnly = colDiscountRate.ReadOnly = colDiscountAmount.ReadOnly =
                colTaxRate.ReadOnly = colTaxAmount.ReadOnly = true;

            _WarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbWarehouse.SelectedValue)
                .GetAvailableInventories();
        }

        protected override clsInvoice GetInvoiceInctance()
        {
            return new clsSaleInvoice(
                dtpInvoiceIssueDate.Value,
                base.GetInvoiceStatus(),
                base.GetInvoiceLinesFromDGV(),
                (int?)cbParty.SelectedValue,
                (int)cbWarehouse.SelectedValue,
                base.GetPaymentMethod(),
                base.GetPaymentAmount()
            );
        }

        protected override void dgvInvoiceLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            base.dgvInvoiceLines_CellBeginEdit(sender, e);

            if (e.ColumnIndex == colProduct.Index)
            {
                List<int> selectedProductIDs = InvoiceLinesDataSource
                    .Where(line => line != CurrentLine && line.ProductID != null)
                    .Select(line => line.ProductID.Value)
                    .ToList();

                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _WarehouseAvailableInventories
                    .GroupBy(inventory => inventory.ProductInfo.ProductID)
                    .Select(group => group.First().ProductInfo)
                    .Where(
                        product =>
                        !selectedProductIDs.Contains(product.ProductID.Value) ||
                        GetSelectedProductUnitIDs(product.ProductID.Value).Count !=_WarehouseAvailableInventories
                            .Where(inventory => inventory.ProductInfo.ProductID == product.ProductID)
                            .Count()
                    )
                    .OrderBy(product => product.ProductName)
                    .ToList();

                colProduct.DisplayMember = "ProductName";
                colProduct.ValueMember = "ProductID";
            }

            if (e.ColumnIndex == colUnit.Index && CurrentLine != null && CurrentLine.ProductID.HasValue)
            {
                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _WarehouseAvailableInventories
                    .Where(inventory => inventory.ProductInfo.ProductID == CurrentLine.ProductID)
                    .Select(inventory => inventory.UnitInfo)
                    .Where(
                        unit => 
                        !GetSelectedProductUnitIDs(CurrentLine.ProductID.Value)
                        .Contains(unit.UnitID)
                    )
                    .ToList();

                colUnit.DisplayMember = "UnitName";
                colUnit.ValueMember = "UnitID";
            }
        }

        protected override void dgvInvoiceLines_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (CurrentLine == null)
            {
                return;
            }

            ApplyEditOnDGV(e.RowIndex);
            base.UpdateInvoiceSummary();
        }

        protected override void dgvInvoiceLines_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.ErrorColumnIndex = e.ColumnIndex;

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
                else if ((!int.TryParse(GetEditedValue()?.ToString(), out int quantity) || quantity < 1) && (!IsCurrentCellEmpty()))
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
