using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Payments;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Payments;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Sales
{
    public partial class frmSalesList : BaseSalesForm
    {
        private static DateTime _FirstSaleInvoiceDate = clsSaleInvoice.GetFirstSaleInvoiceDate();

        public frmSalesList()
        {
            InitializeComponent();
        }

        private void frmSalesList_Load(object sender, EventArgs e)
        {
            clsFormHelper.InitializeDateRangeLimits(dtpDateFrom, dtpDateTo, _FirstSaleInvoiceDate);

            cbInvoiceType.SelectedIndex = cbInvoiceStatus.SelectedIndex = 0;
            cbRange.SelectedIndex = 6;

            contextMenuStrip.Items.Clear();
            contextMenuStrip.Items.Add("إصدار فاتورة مرتجعات");
            contextMenuStrip.Items[0].Image = Resources.Invoice_32;
            contextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[0].Click += IssueReturnPurchaseInvoice_Click;

            contextMenuStrip.Items.Add("إصدار مستند نقدي");
            contextMenuStrip.Items[1].Image = Resources.payment_method;
            contextMenuStrip.Items[1].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[1].Click += IssuePayment_Click;

            clsPaymentService.CreateInstance().EntitySaved += AfterIssueNewPayment_EntitySaved;
        }

        private void AfterIssueNewPayment_EntitySaved(object sender, BusinessLogic.Interfaces.EntitySavedEventArgs e)
        {
            e.OperationMode = BusinessLogic.enMode.Update;
            base.EntitySavedEvent(sender, e);
        }

        private void IssuePayment_Click(object sender, EventArgs e)
        {
            frmIssuePayment issuePayment = new frmIssuePayment(SelectedEntity);
            issuePayment.ShowDialog();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            base.EntityName = "الفاتورة";
            base.EntityInfoControl = ctrInvoiceInfo;
            base.AllowDeleteRecord = false;
        }

        protected override object GetDataSource()
        {
            return clsInvoiceService.CreateInstance().GetAllSaleInvoices();
        }

        private void issueSalesInvoiceToolStripButton_Click(object sender, EventArgs e)
        {
            frmIssueSaleInvoice issueSaleInvoice = new frmIssueSaleInvoice();
            issueSaleInvoice.ShowDialog();
        }

        private void IssueReturnPurchaseInvoice_Click(object sender, EventArgs e)
        {
            clsSaleInvoice originalInvoice = clsInvoiceService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList)) as clsSaleInvoice;

            if (originalInvoice == null)
            {
                clsFormMessages.ShowError($"لم يتم العثور على الفاتورة");
                return;
            }

            if (!originalInvoice.AreThereAnyItemsNotBeenReturned())
            {
                clsFormMessages.ShowError($"لا يمكن إصدار فاتورة مرتجعات جديدة, فقد تم بالفعل إرجاع كل البضاعة المشتراة في هذه الفاتورة");
                return;
            }

            frmIssueSaleReturnInvoice returnSaleInvoice = new frmIssueSaleReturnInvoice(originalInvoice);
            returnSaleInvoice.ShowDialog();
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsFormHelper.InitializeAndApplyDateRange(dtpDateFrom, dtpDateTo, cbRange, _FirstSaleInvoiceDate);
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.MinDate = dtpDateFrom.Value;
        }

        protected override void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            base.contextMenuStrip_Opening(sender, e);
            contextMenuStrip.Items[0].Visible = SelectedEntity.InvoiceType == enInvoiceType.Sales;
            contextMenuStrip.Items[1].Enabled = SelectedEntity.PaymentStatus != enPaymentStatus.Paid;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            if (cbInvoiceType.SelectedIndex == -1 || cbInvoiceStatus.SelectedIndex == -1 || cbRange.SelectedIndex == -1)
            {
                clsFormMessages.ShowError("هناك بعض الحقول تحتوي على قيم غير صالحة, رجاءا قم بتعيين قيم صالحة في جميع الحقول للبحث");
                return;
            }

            if (cbInvoiceType.SelectedIndex != 0)
            {
                filters.Add($"InvoiceType = '{cbInvoiceType.Text}'");
            }

            if (cbInvoiceStatus.SelectedIndex != 0)
            {
                filters.Add($"InvoiceStatus = '{cbInvoiceStatus.Text}'");
            }

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                filters.Add($"(InvoiceNa LIKE '%{txtSearch.Text}%' OR CustomerName LIKE '%{txtSearch.Text}%')");
            }

            filters.Add($"(InvoiceDate >= #{dtpDateFrom.Value:yyyy-MM-dd}# AND InvoiceDate <= #{dtpDateTo.Value:yyyy-MM-dd}#)");

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

    }
}
