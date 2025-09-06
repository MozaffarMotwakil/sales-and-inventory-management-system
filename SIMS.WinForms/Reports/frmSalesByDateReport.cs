using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Reports
{
    public partial class frmSalesByDateReport : Form
    {
        public frmSalesByDateReport()
        {
            InitializeComponent();
        }

        private void frmSalesByDateReport_Load(object sender, EventArgs e)
        {
            cbDateRange.SelectedItem = "Today";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }
    }
}
