using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Reports
{
    public partial class frmSalesByCategoryReport : Form
    {
        public frmSalesByCategoryReport()
        {
            InitializeComponent();
        }

        private void frmSalesByCategoryReport_Load(object sender, EventArgs e)
        {
            cbDateRange.SelectedItem = "Today";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }
    }
}
