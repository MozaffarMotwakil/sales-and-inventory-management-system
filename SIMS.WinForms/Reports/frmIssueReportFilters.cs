using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Reports;
using DVLD.WinForms.Utils;
using Microsoft.Reporting.WinForms;

namespace SIMS.WinForms.Reports
{
    public partial class frmIssueReportFilters : Form
    {
        private string _ReportName;
        public frmIssueReportFilters(string reportName)
        {
            InitializeComponent();
            _ReportName = reportName;
        }

        private void frmIssueReportFilters_Load(object sender, EventArgs e)
        {
            clsFormHelper.InitializeDateRangeLimits(dtpDateFrom, dtpDateTo, clsSaleInvoice.GetFirstSaleInvoiceDate());
            cbRange.SelectedIndex = 2;
            lblReportName.Text = _ReportName;
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsFormHelper.InitializeAndApplyDateRange(dtpDateFrom, dtpDateTo, cbRange, clsSaleInvoice.GetFirstSaleInvoiceDate());
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.MinDate = dtpDateFrom.Value;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueReport_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;

            frmReportViewer reportViewerForm = new frmReportViewer();
            reportViewerForm.Controls.Add(reportViewer);

            reportViewer.LocalReport.ReportPath = "C:\\Users\\mozaf\\GitHub\\sales-and-inventory-management-system\\SIMS.WinForms\\Reports\\repSales.rdlc";

            List<clsBasicSalesReport> basicFinancialSummary = new List<clsBasicSalesReport>
            {
                new clsBasicSalesReport(dtpDateFrom.Value, dtpDateTo.Value)
            };

            List<ReportParameter> parameters = new List<ReportParameter>
            {
                new ReportParameter("DateFrom", basicFinancialSummary[0].DateFrom.ToString("yyyy/MM/dd")),
                new ReportParameter("DateTo", basicFinancialSummary[0].DateTo.ToString("yyyy/MM/dd")),
                new ReportParameter("IssuedEmployeeName", basicFinancialSummary[0].IssuedEmployeeName.EmployeeName),
                new ReportParameter("TodayDate", basicFinancialSummary[0].IssuedDate.ToString("yyyy/MM/dd HH:mm:ss")),
                new ReportParameter("CurrentYear", basicFinancialSummary[0].IssuedYear.ToString())
            };

            reportViewer.LocalReport.SetParameters(parameters);
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("BasicFinancialSummary", basicFinancialSummary));

            reportViewer.RefreshReport();
            reportViewerForm.ShowDialog();
        }

    }
}
