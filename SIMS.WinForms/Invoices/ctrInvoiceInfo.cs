using System;
using System.Windows.Forms;
using SIMS.WinForms.Users;

namespace SIMS.WinForms.Invoices
{
    public partial class ctrInvoiceInfo : UserControl
    {
        public ctrInvoiceInfo()
        {
            InitializeComponent();
        }

        private void llCreatedByUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowUserInfo userInfo = new frmShowUserInfo();
            userInfo.ShowDialog();
        }
    }
}
