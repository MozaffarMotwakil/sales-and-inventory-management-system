using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmSuppliedItemsLogList : BaseSuppliedItemsLogForm
    {
        private static DateTime _FirstSuppliedItemDate = clsSupplierService.GetFirstSuppliedItemDate();
        private enShowMode _ShowMode;
        private string _SupplierName;
        private string _ProductName;
        private string _UnitName;

        public frmSuppliedItemsLogList()
        {
            InitializeComponent();
            _ShowMode = enShowMode.Normal;
        }

        public frmSuppliedItemsLogList(string supplierName = "كل الموردين", string productName = "كل المنتجات", string unitName = "كل الوحدات")
        {
            InitializeComponent();
            _SupplierName = string.IsNullOrWhiteSpace(supplierName) ? "كل الموردين" : supplierName;
            _ProductName = string.IsNullOrWhiteSpace(productName) ? "كل المنتجات" : productName;
            _UnitName = string.IsNullOrWhiteSpace(unitName) ? "كل الوحدات" : unitName;
            _ShowMode = enShowMode.Special;
        }

        protected override object GetDataSource()
        {
            return Manager.GetAllSuppliedItemsLog();
        }

        protected override void LoadData()
        {
            base.LoadData();
            AllowDeleteRecord = false;
        }

        protected override void ShowSelectedEntityInfo()
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            int? invoiceID = (int?)base.GetCellValue(dgvEntitiesList.Columns["InvoiceID"].Index);

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

        private void frmSuppliedItemsLogList_Load(object sender, EventArgs e)
        {
            clsFormHelper.InitializeDateRangeLimits(dtpDateFrom, dtpDateTo, _FirstSuppliedItemDate);

            cbProduct.SelectedIndex = cbUnit.SelectedIndex = cbWarehouse.SelectedIndex =
                cbInvoiceType.SelectedIndex = cbSupplier.SelectedIndex = 0;

            cbRange.SelectedIndex = 6;

            cbProduct.Items.AddRange(clsProductService.GetAllProductNames());
            cbUnit.Items.AddRange(clsUnit.GetAllUnitNames());
            cbWarehouse.Items.AddRange(clsWarehouseService.GetWarehouseNames());
            cbSupplier.Items.AddRange(clsSupplierService.GetAllSupplierNames());

            contextMenuStrip.Items.Clear();

            contextMenuStrip.Items.Add("عرض تفاصيل الفاتورة");
            contextMenuStrip.Items[0].Click += ShowInvoiceDetails_Click;
            contextMenuStrip.Items[0].Image = Resources.Invoice_32;
            contextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;

            if (_ShowMode == enShowMode.Special)
            {
                cbSupplier.SelectedItem = _SupplierName;
                cbProduct.SelectedItem = _ProductName;
                cbUnit.SelectedItem = _UnitName;
                btnApplyFilter_Click(sender, e);
            }

            dgvEntitiesList.RowPrePaint += dgvEntitiesList_RowPrePaint;
        }

        private void ShowInvoiceDetails_Click(object sender, EventArgs e)
        {
            ShowSelectedEntityInfo();
        }

        private void dgvEntitiesList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            clsFormHelper.ApplyGreenRedRowStyle(dgvEntitiesList, e, "InvoiceTypeID", 1, 2);
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsFormHelper.InitializeAndApplyDateRange(dtpDateFrom, dtpDateTo, cbRange, _FirstSuppliedItemDate);
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.MinDate = dtpDateFrom.Value;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            if (cbProduct.SelectedIndex == -1 || cbUnit.SelectedIndex == -1 || cbWarehouse.SelectedIndex == -1 ||
                cbInvoiceType.SelectedIndex == -1 || cbSupplier.SelectedIndex == -1 || cbRange.SelectedIndex == -1)
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

            if (cbInvoiceType.SelectedIndex != 0)
            {
                filters.Add($"InvoiceTypeName = '{cbInvoiceType.Text}'");
            }

            if (cbSupplier.SelectedIndex != 0)
            {
                filters.Add($"SupplierName = '{cbSupplier.Text}'");
            }

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                filters.Add($"InvoiceNa LIKE '%{txtSearch.Text}%'");
            }

            filters.Add($"(InvoiceDate >= #{dtpDateFrom.Value:yyyy-MM-dd}# AND InvoiceDate <= #{dtpDateTo.Value:yyyy-MM-dd}#)");

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }
        
    }

}
