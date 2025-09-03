using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Invoices
{
    public partial class frmInvoicesList : Form
    {
        public frmInvoicesList()
        {
            InitializeComponent();
        }
        
        private void frmInvoicesList_Load(object sender, EventArgs e)
        {
            lblSearchHintText.Text = "Enter Invoiece Number";
            cbDateRange.SelectedItem = "Today";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void frmInvoicesList_Activated(object sender, EventArgs e)
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
