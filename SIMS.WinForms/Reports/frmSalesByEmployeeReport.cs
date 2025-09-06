using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Reports
{
    public partial class frmSalesByEmployeeReport : Form
    {
        public frmSalesByEmployeeReport()
        {
            InitializeComponent();
        }

        private void frmSalesByEmployeeReport_Load(object sender, EventArgs e)
        {
            lblSearchHintText.Text = "Enter Full Name";
            cbDateRange.SelectedItem = "Today";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            cbEmployeesFilter.SelectedItem = "All Employees";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);
        }

    }
}
