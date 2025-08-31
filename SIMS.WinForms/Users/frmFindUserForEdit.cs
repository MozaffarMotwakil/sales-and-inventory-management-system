using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Users
{
    public partial class frmFindUserForEdit : Form
    {
        public frmFindUserForEdit()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditUser editUser = new frmAddEditUser();
            editUser.FormMode = enMode.Edit;
            editUser.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
