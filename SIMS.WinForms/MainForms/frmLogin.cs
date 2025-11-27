using System;
using System.Windows.Forms;
using SIMS.WinForms;

namespace DVLD.WinForms.MainForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMainForm.CreateInstance().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
