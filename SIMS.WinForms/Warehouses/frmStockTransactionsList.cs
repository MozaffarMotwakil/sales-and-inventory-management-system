using System;
using BusinessLogic.Employees;
using BusinessLogic.Products;
using BusinessLogic.Warehouses;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmStockTransactionsList : BaseStockTransactionsForm
    {
        public frmStockTransactionsList()
        {
            InitializeComponent();
        }

        private void frmStockTransactionsList_Load(object sender, EventArgs e)
        {
            cbProduct.SelectedIndex = cbUnit.SelectedIndex =
                cbWarehouse.SelectedIndex = cbTransactionType.SelectedIndex =
                cbResponseEmployee.SelectedIndex = 0;

            cbProduct.Items.AddRange(clsProductService.GetAllProductNames());
            cbUnit.Items.AddRange(clsUnit.GetAllUnitNames());
            cbWarehouse.Items.AddRange(clsWarehouseService.GetAllWarehouseNames());
            cbTransactionType.Items.AddRange(clsStockTransactionService.GetAllStockTransactionTypeNames());
            cbResponseEmployee.Items.AddRange(clsEmployeeService.GetAllEmployeeName());
        }

    }
}
