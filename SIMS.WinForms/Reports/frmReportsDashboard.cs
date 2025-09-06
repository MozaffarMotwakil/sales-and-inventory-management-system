using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Reports
{
    public partial class frmReportsDashboard : Form
    {
        enum enFormType
        {
            MainReport,
            SalesByCategoryReport,
            SalesByDateReport,
            SalesByEmployeeReport,
            ProfitAndLossReport
        };

        private Form _MainReportForm;
        private Form _SalesByCategoryReportForm;
        private Form _SalesByDateReportForm;
        private Form _SalesByEmployeeReportForm;
        private Form _ProfitAndLossReportForm;

        public frmReportsDashboard()
        {
            InitializeComponent();
        }

        private void frmReportsDashboard_Load(object sender, EventArgs e)
        {
            _OpenReportForm(ref _MainReportForm, enFormType.MainReport);
        }

        private void mainReportToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(ref _MainReportForm, enFormType.MainReport);
        }

        private void salesByCategoryReportToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(ref _SalesByCategoryReportForm, enFormType.SalesByCategoryReport);
        }

        private void salesByDateReportToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(ref _SalesByDateReportForm, enFormType.SalesByDateReport);
        }

        private void salesByEmployeeReportToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(ref _SalesByEmployeeReportForm, enFormType.SalesByEmployeeReport);
        }

        private void profitAndLossReportToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(ref _ProfitAndLossReportForm, enFormType.ProfitAndLossReport);
        }

        private void _OpenReportForm(ref Form reportForm, enFormType formType)
        {
            // Close the current form before openning the new form.
            if (Application.OpenForms.Count == 4 && reportForm != Application.OpenForms[3])
            {
                Application.OpenForms[3].Close();
            }

            if (reportForm == null || reportForm.IsDisposed)
            {
                pnlReportsContainer.Controls.Clear();
                reportForm = _GetFormType(formType);
                reportForm.TopLevel = false;
                reportForm.FormBorderStyle = FormBorderStyle.None;
                reportForm.Dock = DockStyle.Fill;
                pnlReportsContainer.Controls.Add(reportForm);
                reportForm.Show();
            }
        }

        private Form _GetFormType(enFormType formType)
        {
            switch (formType)
            {
                case enFormType.MainReport:
                    return new frmMainReport();
                case enFormType.SalesByCategoryReport:
                    return new frmSalesByCategoryReport();
                case enFormType.SalesByDateReport:
                    return new frmSalesByCategoryReport();
                case enFormType.SalesByEmployeeReport:
                    return new frmSalesByCategoryReport();
                case enFormType.ProfitAndLossReport:
                    return new frmSalesByCategoryReport();
                default:
                    return new Form();
            }
        }

        private void frmReportsDashboard_Deactivate(object sender, EventArgs e)
        {
            for (byte i = 3; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Close();
            }
        }

    }
}
