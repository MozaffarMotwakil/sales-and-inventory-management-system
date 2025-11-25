using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Employees;
using BusinessLogic.Products;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmStockTransactionsList : BaseStockTransactionsForm
    {
        enum enShowMode
        {
            Normal,
            Special
        }

        private static DateTime _FirstStockTransactionDate = clsStockTransactionService.GetFirstStockTransactionDate();
        private enShowMode _ShowMode;
        private string _ProductName;
        private string _UnitName;
        private string _WarehouseName;

        public frmStockTransactionsList()
        {
            InitializeComponent();
            _ShowMode = enShowMode.Normal;
        }

        public frmStockTransactionsList(string productName, string unitName = "كل الوحدات", string warehouseName = "كل المخازن")
        {
            InitializeComponent();
            _ProductName = productName;
            _UnitName = unitName;
            _WarehouseName = warehouseName;
            _ShowMode = enShowMode.Special;
        }

        private void frmStockTransactionsList_Load(object sender, EventArgs e)
        {
            dtpDateFrom.MinDate = dtpDateTo.MinDate = _FirstStockTransactionDate;
            dtpTimeFrom.MinDate = dtpTimeTo.MinDate = DateTime.MinValue;

            dtpDateFrom.MaxDate = dtpDateTo.MaxDate = DateTime.Now;
            dtpTimeFrom.MaxDate = dtpTimeTo.MaxDate = DateTime.MaxValue;

            cbRange.SelectedIndex = 3;

            cbProduct.SelectedIndex = cbUnit.SelectedIndex = cbWarehouse.SelectedIndex = 
                cbTransactionType.SelectedIndex = cbResponseEmployee.SelectedIndex = cbTransactionReason.SelectedIndex = 0;

            cbProduct.Items.AddRange(clsProductService.GetAllProductNames());
            cbUnit.Items.AddRange(clsUnit.GetAllUnitNames());
            cbWarehouse.Items.AddRange(clsWarehouseService.GetWarehouseNames());
            cbTransactionType.Items.AddRange(clsStockTransactionService.GetStockTransactionTypeNames());
            cbResponseEmployee.Items.AddRange(clsEmployeeService.GetEmployeeNames());
            cbTransactionReason.Items.AddRange(clsStockTransactionService.GetStockTransactionReasonNames());

            dgvEntitiesList.RowPrePaint += dgvEntitiesList_RowPrePaint;

            contextMenuStrip.Items.Clear();

            contextMenuStrip.Items.Add("عرض تفاصيل الفاتورة");
            contextMenuStrip.Items[0].Click += ShowInvoiceDetails_Click;
            contextMenuStrip.Items[0].Image = Resources.Invoice_32;
            contextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;

            contextMenuStrip.Items.Add("عرض تفاصيل عملية النقل");
            contextMenuStrip.Items[1].Click += ShowTransferOperationInfo_Click;
            contextMenuStrip.Items[1].Image = Resources.inventory;
            contextMenuStrip.Items[1].ImageScaling = ToolStripItemImageScaling.None;

            if (_ShowMode == enShowMode.Special)
            {
                cbProduct.SelectedItem = _ProductName;
                cbUnit.SelectedItem = _UnitName;
                cbWarehouse.SelectedItem = _WarehouseName;
                btnApplyFilter_Click(sender, e);
            }

            dgvEntitiesList.CellMouseDown += dgvEntitiesList_CellMouseDown;
        }

        private void ShowTransferOperationInfo_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

            if (currentStockTransaction != null)
            {
                if (currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.TransferOperation)
                {
                    int? transferOperationID = (int?)GetCellValue(dgvEntitiesList.Columns["TransferOperationID"].Index);

                    if (transferOperationID != null)
                    {
                        frmShowTransferOperationInfo showTransferOperationInfo = new frmShowTransferOperationInfo(transferOperationID.Value);
                        showTransferOperationInfo.ShowDialog();
                    }
                    else
                    {
                        clsFormMessages.ShowError("لم يتم العثور على عملية النقل");
                    }
                }
                else
                {
                    clsFormMessages.ShowError("لا يمكن عرض تفاصيل عملية النقل لأن سبب حركة المخزون ليس من نوع نقل بضاعة");
                }
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على سجل حركة المخزون");
            }
        }

        private void ShowInvoiceDetails_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

            if (currentStockTransaction != null)
            {
                if (currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.Purchase ||
                    currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.PurchaseReturn ||
                    currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.Sales ||
                    currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.SalesReturn)
                {
                    int? invoiceID = (int?)GetCellValue(dgvEntitiesList.Columns["SourceInvoiceID"].Index);

                    if (invoiceID != null)
                    {
                        frmShowInvoiceInfo showInvoiceInfo = new frmShowInvoiceInfo(invoiceID.Value);
                        showInvoiceInfo.ShowDialog();
                    }
                    else
                    {
                        clsFormMessages.ShowError("لم يتم العثور على الفاتورة");
                    }
                }
                else
                {
                    clsFormMessages.ShowError("لا يمكن عرض تفاصيل الفاتورة لأن سبب حركة المخزون لم ينتج عنه فاتورة مشتريات/مرتجعاتمشتريات/مبيعات/مرتجعات مبيعات");
                }
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على سجل حركة المخزون");
            }
        }

        private void dgvEntitiesList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int transactionType = Convert.ToInt32(dgvEntitiesList.Rows[e.RowIndex].Cells["TransactionTypeID"].Value);

                if (transactionType == 1)
                {
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else if (transactionType == 2)
                {
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvEntitiesList.DefaultCellStyle.BackColor;
                    dgvEntitiesList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgvEntitiesList.DefaultCellStyle.ForeColor;
                }
            }
        }

        protected override void LoadData()
        {
            base.LoadData();
            base.SearchHintMessage = "أدخل رقم الفاتورة";
        }

        protected override void dgvEntitiesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

                    if (currentStockTransaction != null && currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.TransferOperation)
                    {
                        ShowTransferOperationInfo_Click(sender, e);
                    }
                    else
                    {
                        ShowInvoiceDetails_Click(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    base.DeleteSelectedEntity();
                }
            }
        }

        protected override void dgvEntitiesList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.Button == MouseButtons.Right || dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

            if (currentStockTransaction != null && currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.TransferOperation)
            {
                ShowTransferOperationInfo_Click(sender, e);
            }
            else
            {
                ShowInvoiceDetails_Click(sender, e);
            }
        }

        private void cbProduct_Leave(object sender, EventArgs e)
        {
            if (cbProduct.SelectedIndex == -1)
            {
                cbProduct.SelectedIndex = 0;
            }
        }

        private void cbResponseEmployee_Leave(object sender, EventArgs e)
        {
            if (cbResponseEmployee.SelectedIndex == -1)
            {
                cbResponseEmployee.SelectedIndex = 0;
            }
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDateFrom.Enabled = dtpTimeFrom.Enabled =
                dtpDateTo.Enabled = dtpTimeTo.Enabled = false;

            dtpDateFrom.MinDate = dtpDateTo.MinDate = _FirstStockTransactionDate;

            DateTime currentTime = DateTime.Now;

            dtpDateFrom.MaxDate = dtpDateTo.MaxDate = currentTime;

            dtpDateFrom.Value = dtpDateTo.Value = dtpTimeFrom.Value =
                dtpTimeTo.Value = currentTime;

            if (cbRange.SelectedIndex == 0)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = _FirstStockTransactionDate > DateTime.Now.AddDays(-1) ?
                    _FirstStockTransactionDate :
                    DateTime.Now.AddDays(-1);
            }
            else if (cbRange.SelectedIndex == 1)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = _FirstStockTransactionDate > DateTime.Now.AddDays(-7) ?
                    _FirstStockTransactionDate :
                    DateTime.Now.AddDays(-7);
            }
            else if (cbRange.SelectedIndex == 2)
            {
                dtpDateFrom.Value = dtpTimeFrom.Value = _FirstStockTransactionDate > DateTime.Now.AddDays(-30) ?
                    _FirstStockTransactionDate :
                    DateTime.Now.AddDays(-30);
            }
            else if (cbRange.SelectedIndex == 3)
            {
                dtpDateFrom.Value = _FirstStockTransactionDate;
                dtpTimeFrom.Value = _FirstStockTransactionDate;
            }
            else
            {
                dtpDateFrom.Enabled = dtpTimeFrom.Enabled =
                    dtpDateTo.Enabled = dtpTimeTo.Enabled = true;

                dtpDateFrom.Value = currentTime.Date;
                dtpDateTo.Value = currentTime.Date;
                dtpTimeFrom.Value = currentTime.Date;
                dtpTimeTo.Value = currentTime.Date;
            }
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.MinDate = dtpDateFrom.Value;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            if (cbProduct.SelectedIndex == -1 || cbUnit.SelectedIndex == -1 || cbWarehouse.SelectedIndex == -1 ||
                cbTransactionType.SelectedIndex == -1 || cbResponseEmployee.SelectedIndex == -1 || cbRange.SelectedIndex == -1)
            {
                clsFormMessages.ShowError("هناك بعض الحقول تحتوي على قيم غير صالحة, رجاءا قم بتعيين قيم صالحة في جميع الحقول للبحث");
                return;
            }

            if (cbProduct.SelectedIndex != 0)
            {
                filters.Add($"ProductName = '{cbProduct.Text}'");
            }

            if (cbUnit.SelectedIndex != 0)
            {
                filters.Add($"UnitName = '{cbUnit.Text}'");
            }

            if (cbWarehouse.SelectedIndex != 0)
            {
                filters.Add($"WarehouseName = '{cbWarehouse.Text}'");
            }

            if (cbTransactionType.SelectedIndex != 0)
            {
                filters.Add($"TransactionTypeName = '{cbTransactionType.Text}'");
            }

            if (cbTransactionReason.SelectedIndex != 0)
            {
                filters.Add($"ReasonName = '{cbTransactionReason.Text}'");
            }

            if (cbResponseEmployee.SelectedIndex != 0)
            {
                filters.Add($"CreatedBy = '{cbResponseEmployee.Text}'");
            }

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                filters.Add($"InvoiceNa LIKE '%{txtSearch.Text}%'");
            }

            filters.Add($"(TransactionTime >= #{dtpTimeFrom.Value.ToString("HH:mm:ss") + " " + dtpDateFrom.Value.ToString("yyyy-MM-dd")}# AND TransactionTime <= #{dtpTimeTo.Value.ToString("HH:mm:ss") + " " + dtpDateTo.Value.ToString("yyyy-MM-dd")}#)");

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

        protected override void UpdateRecordsCountLabels()
        {
            base.UpdateRecordsCountLabels();
            clsStockTransactionService.StockTransactionInfo transactionInfo = clsStockTransactionService.CreateInstance()
                .GetStockTransactionInfo(dgvEntitiesList.DataSource as DataTable);

            lblInTransactions.Text = transactionInfo.InTransactions.ToString();
            lblOutTransactions.Text = transactionInfo.OutTransactions.ToString();
        }

        protected override void UpdateRecordsCountLabels(DataView dataSource)
        {
            base.UpdateRecordsCountLabels();
            clsStockTransactionService.StockTransactionInfo transactionInfo = clsStockTransactionService.CreateInstance()
                .GetStockTransactionInfo(dataSource);

            lblInTransactions.Text = transactionInfo.InTransactions.ToString();
            lblOutTransactions.Text = transactionInfo.OutTransactions.ToString();
        }

        private void dgvEntitiesList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvEntitiesList.Rows[e.RowIndex].Selected = true;
            }
        }

        protected override void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            base.contextMenuStrip_Opening(sender, e);

            if (dgvEntitiesList.CurrentRow.Index >= 0)
            {
                contextMenuStrip.Items[0].Visible = contextMenuStrip.Items[1].Visible = false;

                clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

                if (currentStockTransaction != null)
                {
                    if (currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.TransferOperation)
                    {
                        contextMenuStrip.Items[1].Visible = true;
                    }
                    else
                    {
                        contextMenuStrip.Items[0].Visible = true;
                    }
                }
            }
        }

    }
}
