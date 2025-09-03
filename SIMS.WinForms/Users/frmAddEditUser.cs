using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Users
{
    public partial class frmAddEditUser : Form
    {
        public enMode FormMode { get; set; }

        public frmAddEditUser()
        {
            InitializeComponent();
            FormMode = enMode.Add;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            cbCountry.SelectedItem = "Sudan";
            cbRole.SelectedItem = "Employee";

            if (FormMode == enMode.Add)
            {
                this.Text = lblFormTitle.Text = "Add New User";
            }
            else
            {
                this.Text = lblFormTitle.Text = "Edit User";
            }
        }

        private void cbCountry_Leave(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex == -1)
            {
                cbCountry.SelectedItem = "Sudan";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
