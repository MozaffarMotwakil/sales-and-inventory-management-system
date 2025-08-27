using System;
using System.Drawing;
using System.Windows.Forms;
using SIMS.WinForms.Dashboard;
using SIMS.WinForms.Inventory;

namespace SIMS.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //frmDashboard dashboard = new frmDashboard();
            //dashboard.MdiParent = this;
            //dashboard.Dock = DockStyle.Fill;
            //dashboard.Show();
        }

        private void DashboardToolStripButton_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();
        }

        private void PointOfSelesToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void InventoryToolStripButton3_Click(object sender, EventArgs e)
        {
            frmProductsList productsList = new frmProductsList();
            productsList.MdiParent = this;
            productsList.Dock = DockStyle.Fill;
            productsList.Show();
        }

        private void SuppliersToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ReportsToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void UsersToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void InvoicesToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ActivityLogToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutToolStripButton_Click(object sender, EventArgs e)
        {

        }

    }
}
