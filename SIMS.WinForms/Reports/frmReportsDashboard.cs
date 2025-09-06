using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Reports
{
    public partial class frmReportsDashboard : Form
    {
        public frmReportsDashboard()
        {
            InitializeComponent();
        }

        private void frmReportsDashboard_Load(object sender, EventArgs e)
        {
            _ConfigureMainReportForm();
        }

        private void mainReportToolStripButton_Click(object sender, EventArgs e)
        {
            _ConfigureMainReportForm();
        }

        private void salesByCategoryReportToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(new frmSalesByCategoryReport());
        }

        private void salesByDateReportToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(new frmSalesByDateReport());
        }

        private void salesByEmployeeReporttoolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(new frmSalesByEmployeeReport());
        }

        private void profitAndLossReportToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenReportForm(new frmProfitAndLossReport());
        }

        private void _OpenReportForm(Form reportForm)
        {
            pnlReportsContainer.Controls.Clear();
            reportForm.TopLevel = false;
            reportForm.FormBorderStyle = FormBorderStyle.None;
            reportForm.Dock = DockStyle.Fill;
            pnlReportsContainer.Controls.Add(reportForm);
            reportForm.Show();
        }

        private void _ConfigureMainReportForm()
        {
            pnlReportsContainer.Controls.Clear();
            pnlReportsContainer.Controls.AddRange(
                new Control[] {
                    pnlAverageDailyInvoices,
                    pnlAverageInvoiceValue,
                    pnlTotalMonthlyProfits,
                    pnlTotalProjectedSalesValue,
                    label1, label2, label3, label4,
                    chartSlowMovingProducts,
                    chartTopFiveBestSalling,
                    chartButtomFiveLeastSelling
                }
            );
        }

    }
}
