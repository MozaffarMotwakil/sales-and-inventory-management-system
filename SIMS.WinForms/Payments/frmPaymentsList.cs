using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Employees;
using BusinessLogic.Payments;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Payments
{
    public partial class frmPaymentsList : BasePaymentsForm
    {
        private static DateTime _FirstPaymentDate = clsPaymentService.GetFirstPaymentDate();

        public frmPaymentsList()
        {
            InitializeComponent();
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

        private void frmPaymentsList_Load(object sender, EventArgs e)
        {
            clsFormHelper.InitializeDateRangeLimits(dtpDateFrom, dtpDateTo, _FirstPaymentDate);

            cbResponseEmployee.SelectedIndex = cbPaymentType.SelectedIndex =
                cbPaymentReason.SelectedIndex = cbPaymentMethod.SelectedIndex = 0;

            cbRange.SelectedIndex = 6;

            cbResponseEmployee.Items.AddRange(clsEmployeeService.GetEmployeeNames());

            contextMenuStrip.Items.Clear();

            contextMenuStrip.Items.Add("عرض تفاصيل الفاتورة");
            contextMenuStrip.Items[0].Click += ShowInvoiceDetails_Click;
            contextMenuStrip.Items[0].Image = Resources.Invoice_32;
            contextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;

            dgvEntitiesList.RowPrePaint += dgvEntitiesList_RowPrePaint;
        }

        private void ShowInvoiceDetails_Click(object sender, EventArgs e)
        {
            ShowSelectedEntityInfo();
        }

        private void dgvEntitiesList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            clsFormHelper.ApplyGreenRedRowStyle(dgvEntitiesList, e, "PaymentType", "قبض", "صرف");
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsFormHelper.InitializeAndApplyDateRange(dtpDateFrom, dtpDateTo, cbRange, _FirstPaymentDate);
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.MinDate = dtpDateFrom.Value;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            if (cbResponseEmployee.SelectedIndex == -1 || cbPaymentType.SelectedIndex == -1 ||
                cbPaymentReason.SelectedIndex == -1 || cbPaymentMethod.SelectedIndex == -1 || cbRange.SelectedIndex == -1)
            {
                clsFormMessages.ShowError("هناك بعض الحقول تحتوي على قيم غير صالحة, رجاءا قم بتعيين قيم صالحة في جميع الحقول للبحث");
                return;
            }

            if (cbResponseEmployee.SelectedIndex != 0)
            {
                filters.Add($"ResponsibleEmployee = '{cbResponseEmployee.Text}'");
            }

            if (cbPaymentType.SelectedIndex != 0)
            {
                filters.Add($"PaymentType = '{(cbPaymentType.Text == "المصروفات" ? "صرف" : "قبض")}'");
            }

            if (cbPaymentReason.SelectedIndex != 0)
            {
                filters.Add($"PaymentReason = '{cbPaymentReason.Text}'");
            }

            if (cbPaymentMethod.SelectedIndex != 0)
            {
                filters.Add($"PaymentMethodName = '{cbPaymentMethod.Text}'");
            }

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                filters.Add($"(InvoiceNa LIKE '%{txtSearch.Text}%' OR PartyName LIKE '%{txtSearch.Text}%')");
            }

            filters.Add($"(PaymentDate >= #{dtpDateFrom.Value:yyyy-MM-dd}# AND PaymentDate <= #{dtpDateTo.Value:yyyy-MM-dd}#)");

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

    }
}
