using System;
using System.Windows.Forms;

namespace SIMS.WinForms.ActivityLog
{
    public partial class frmActivityLog : Form
    {
        public frmActivityLog()
        {
            InitializeComponent();
        }

        private void frmActivityLog_Load(object sender, EventArgs e)
        {
            lblSearchHintText.Text = "Enter specific keywords";
            cbDateRange.SelectedItem = "Today";
            cbActivityType.SelectedItem = "All Activities";
            cbUser.SelectedItem = "All Users";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            dtpStartTime.Value = DateTime.Today;
            dtpEndTime.Value = DateTime.Today.AddSeconds(-1);
        }

        private void frmActivityLog_Activated(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);
        }

        private void pictureBoxAndSearchHintText_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

    }
}
