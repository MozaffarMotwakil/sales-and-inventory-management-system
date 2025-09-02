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

        private void cbUser_Enter(object sender, EventArgs e)
        {
            if (cbUser.SelectedIndex == -1)
            {
                cbUser.Text = string.Empty;
            }
        }

        private void cbUser_Leave(object sender, EventArgs e)
        {
            if (cbUser.SelectedIndex == -1)
            {
                cbUser.Text = "Select User";
            }
        }

    }
}
