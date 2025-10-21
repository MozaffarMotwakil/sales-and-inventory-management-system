﻿using System;
using System.Drawing;
using System.Windows.Forms;
using SIMS.WinForms.ActivityLog;
using SIMS.WinForms.Dashboard;
using SIMS.WinForms.Products;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Reports;
using SIMS.WinForms.Sales;
using SIMS.WinForms.Suppliers;
using SIMS.WinForms.Users;
using SIMS.WinForms.Warehouses;
using SIMS.WinForms.Inventory;

namespace SIMS.WinForms
{
    public partial class frmMainForm : Form
    {
        enum enFormType 
        {
            Dashboard,
            PointOfSale,
            ProductsList,
            SuppliersList,
            WarehousesList,
            PurchasesList,
            ReportsDashboard,
            UsersList,
            InvoicesList,
            ActivityLog
        };

        private Form _DashboardForm;
        private Form _PointOfSaleForm;
        private Form _ProductsListForm;
        private Form _SuppliersList;
        private Form _WarehousesList;
        private Form _PurchasesList;
        private Form _ReportsDashboardForm;
        private Form _UsersListForm;
        private Form _InvoicesListForm;
        private Form _ActivityLogForm;

        public frmMainForm()
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
            _OpenForm(ref _DashboardForm, enFormType.Dashboard);
        }

        private void DashboardToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _DashboardForm, enFormType.Dashboard);
        }

        private void PointOfSelesToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _PointOfSaleForm, enFormType.PointOfSale);
        }

        private void SuppliersToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _SuppliersList, enFormType.SuppliersList);
        }

        private void InventoryToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _ProductsListForm, enFormType.ProductsList);
        }

        private void WarehousesToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _WarehousesList, enFormType.WarehousesList);
        }

        private void PurchasesToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _PurchasesList, enFormType.PurchasesList);
        }

        private void ReportsToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _ReportsDashboardForm, enFormType.ReportsDashboard);
        }

        private void UsersToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _UsersListForm, enFormType.UsersList);
        }

        private void InvoicesToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _InvoicesListForm, enFormType.InvoicesList);
        }

        private void ActivityLogToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _ActivityLogForm, enFormType.ActivityLog);
        }

        private void LogoutToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["frmLogin"].Activate();
        }

        private void _OpenForm(ref Form form, enFormType formType)
        {
            if (form == null || form.IsDisposed)
            {
                // Close any opened form before opening a new form.
                for (byte i = 2; i < Application.OpenForms.Count; i++)
                {
                    Application.OpenForms[i].Close();
                }
                
                form = _GerFormType(formType);
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private Form _GerFormType(enFormType formType)
        {
            switch (formType)
            {
                case enFormType.Dashboard:
                    return new frmDashboard();
                case enFormType.PointOfSale:
                    return new frmPointOfSale();
                case enFormType.ProductsList:
                    return new frmProductsList();
                case enFormType.SuppliersList:
                    return new frmSuppliersList();
                case enFormType.WarehousesList:
                    return new frmWarehousesList();
                case enFormType.ReportsDashboard:
                    return new frmReportsDashboard();
                case enFormType.UsersList:
                    return new frmUsersList();
                case enFormType.InvoicesList:
                    return new frmInvoicesList();
                case enFormType.ActivityLog:
                    return new frmActivityLog();
                default:
                    return new Form();
            }
        }

    }
}
