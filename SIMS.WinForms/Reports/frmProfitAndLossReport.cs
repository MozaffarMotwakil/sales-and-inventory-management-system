using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Reports
{
    public partial class frmProfitAndLossReport : Form
    {
        public frmProfitAndLossReport()
        {
            InitializeComponent();
        }

        private void frmProfitAndLossReport_Load(object sender, EventArgs e)
        {
            cbDateRange.SelectedItem = "Current Month";
            dtpStartDate.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            dtpEndDate.Value = DateTime.Today;
        }

    }
}
