using System;
using System.Drawing;
using System.Windows.Forms;
using SIMS.WinForms.Dashboard;
using SIMS.WinForms.Inventory;
using SIMS.WinForms.Sales;
using SIMS.WinForms.Suppliers;
using SIMS.WinForms.Users;

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
            frmPointOfSale pointOfSale = new frmPointOfSale();
            pointOfSale.MdiParent = this;
            pointOfSale.Dock = DockStyle.Fill;
            pointOfSale.Show();
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
            frmSuppliersList suppliersList = new frmSuppliersList();
            suppliersList.MdiParent = this;
            suppliersList.Dock = DockStyle.Fill;
            suppliersList.Show();
        }

        private void ReportsToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void UsersToolStripButton_Click(object sender, EventArgs e)
        {
            frmUsersList usersList = new frmUsersList();
            usersList.MdiParent = this;
            usersList.Dock = DockStyle.Fill;
            usersList.Show();
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
