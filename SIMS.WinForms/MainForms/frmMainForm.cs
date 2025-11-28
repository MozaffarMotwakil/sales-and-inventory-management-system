using System;
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
using SIMS.WinForms.Purchases;
using System.Linq;

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
            InventoriesList,
            StockTransactionsList,
            TransferOperations,
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
        private Form _InventoriesList;
        private Form _StockTransactionsList;
        private Form _TransferOperations;
        private Form _PurchasesList;
        private Form _ReportsDashboardForm;
        private Form _UsersListForm;
        private Form _InvoicesListForm;
        private Form _ActivityLogForm;
        private static frmMainForm _Instance;

        private frmMainForm()
        {
            InitializeComponent();
            ClockAndDateTimer.Start();

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        public static frmMainForm CreateInstance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new frmMainForm();
            }

            return _Instance;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WarehousesAndInventories.DropDownDirection = ToolStripDropDownDirection.Left;
            _OpenForm(ref _DashboardForm, enFormType.Dashboard);
        }

        private void ClockAndDateTimer_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblCurrentDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
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

        private void InventoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _InventoriesList, enFormType.InventoriesList);
        }

        private void StockTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _StockTransactionsList, enFormType.StockTransactionsList);
        }

        private void TransferOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _TransferOperations, enFormType.TransferOperations);
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
            frmMainForm.CreateInstance();
            Application.OpenForms["frmLogin"].Activate();
        }

        private void _OpenForm(ref Form form, enFormType formType)
        {
            if (form == null || form.IsDisposed)
            {
                form = _GerFormType(formType);

                Type type = form.GetType();

                if (Application.OpenForms.Cast<Form>().Any(f => f.GetType() == type))
                {
                    form = null;
                    return;
                }

                // Close any opened form before opening a new form.
                for (byte i = 2; i < Application.OpenForms.Count; i++)
                {
                    Application.OpenForms[i].Close();
                }
                
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        public static void OpenForm(Form form)
        {
            // Close any opened form before opening a new form.
            for (byte i = 2; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Close();
            }

            form.MdiParent = Application.OpenForms["frmMainForm"];
            form.Dock = DockStyle.Fill;
            form.Show();
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
                    return new frmWarehouswList();
                case enFormType.InventoriesList:
                    return new frmInventoriesList();
                case enFormType.StockTransactionsList:
                    return new frmStockTransactionsList();
                case enFormType.TransferOperations:
                    return new frmTransferedOperationsList();
                case enFormType.PurchasesList:
                    return new frmPurchasesList();
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
