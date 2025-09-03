using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Users
{
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedItem = "Active";
            cbCountry.SelectedItem = "All Countries";
            lblSearchHintText.Text = "Enter Full Name or Username";
        }

        private void frmUsersList_Activated(object sender, EventArgs e)
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser addUser = new frmAddEditUser();
            addUser.FormMode = enMode.Add;
            addUser.ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmFindUserForEdit userForEdit = new frmFindUserForEdit();
            userForEdit.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmFindUserForDelete userForDelete = new frmFindUserForDelete();
            userForDelete.ShowDialog();
        }

    }
}
