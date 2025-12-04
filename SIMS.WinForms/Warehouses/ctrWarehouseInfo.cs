using System.Windows.Forms;
using BusinessLogic.Warehouses;
using SIMS.WinForms.Interfaces;
using static BusinessLogic.Warehouses.clsWarehouse;

namespace SIMS.WinForms.Warehouses
{
    public partial class ctrWarehouseInfo : UserControl, IEntityView<clsWarehouse>
    {
        private clsWarehouse _Warehouse;

        public clsWarehouse Entity
        {
            get => _Warehouse;

            set
            {
                if (value == null || !value.WarehouseID.HasValue || value.WarehouseID < 1)
                {
                    return;
                }

                _Warehouse = value;

                stBasicInfo basicInfo = value.GetBasicInfo();
                lblWarehouseName.Text = basicInfo.WarehouseName;
                lblAddress.Text = basicInfo.Address;
                lblCategory.Text = basicInfo.TypeName;
                lblActivityStatus.Text = basicInfo.IsActive ? "نشط" : "غير نشط";
                llResponsibleEmployeeName.Text = basicInfo.ResponsibleEmployeeName;
                lblResponseEmplyeePhoneNumber.Text = basicInfo.ResponseEmplyeePhoneNumber;
                lblCreatedAt.Text = basicInfo.CreatedAt.ToString("HH:mm:ss dd/MM/yyyy");
                lblUpdatedAt.Text = basicInfo.UpdatedAt?.ToString("HH:mm:ss dd/MM/yyyy") ?? "N/A";

                tabControl.SelectedIndex = 0;

                stInventorySummary inventorySummary = value.GetInventorySummary();
                lblProductsCount.Text = inventorySummary.ProductsCount.ToString();
                lblInventoriesCount.Text = inventorySummary.InventoriesCount.ToString();
                lblTotalQuantity.Text = inventorySummary.TotalQuantity.ToString();
                lblSafeElements.Text = inventorySummary.SafeElements.ToString();
                lblLowElements.Text = inventorySummary.LowElements.ToString();
                lblFinishedElements.Text = inventorySummary.FinishedElements.ToString();
                lblReorderQuantityAverage.Text = inventorySummary.ReorderQuantityAverage.ToString();
                lblItemsThatNeedToBeReordered.Text = inventorySummary.ItemsThatNeedToBeReordered.ToString();
                lblTotalStockTransactions.Text = inventorySummary.TotalStockTransactions.ToString();
                lblTotalInsideStockTransactions.Text = inventorySummary.TotalInsideStockTransactions.ToString();
                lblTotalOutsideStockTransactions.Text = inventorySummary.TotalOutsideStockTransactions.ToString();
                lblDailyTransactionsAverage.Text = inventorySummary.DailyTransactionsAverage.ToString();
                lblLastInsideTransactionDate.Text = inventorySummary.LastInsideTransactionDate?.ToString("HH:mm:ss dd/MM/yyyy") ?? "N/A";
                lblLastOutsideTransactionDate.Text = inventorySummary.LastOutsideTransactionDate?.ToString("HH:mm:ss dd/MM/yyyy") ?? "N/A";

                stFinancialSummary financialSummary = value.GetFinancialSummary();
                lblInventoriesCostValue.Text = financialSummary.InventoriesCostValue.ToString() + " جنيه";
                lblInventoriesSellingValue.Text = financialSummary.InventoriesSellingValue.ToString() + " جنيه";
                lblExpectedProfit.Text = financialSummary.ExpectedProfit.ToString() + " جنيه";
                lblProfitRate.Text = financialSummary.ProfitRate.ToString() + "%";
                lblPurchasesValue.Text = financialSummary.PurchasesValue.ToString() + " جنيه";
                lblReturnPurchasesValue.Text = financialSummary.ReturnPurchasesValue.ToString() + " جنيه";
                lblSellingValue.Text = financialSummary.SellingValue.ToString() + " جنيه";
                lblReturnSellingValue.Text = financialSummary.ReturnSellingValue.ToString() + " جنيه";

                stKPIsSummary KPIsSummary = value.GetKPIsSummary();
                lblItemsThatNeedToBeReorderedRate.Text = KPIsSummary.ItemsThatNeedToBeReorderedRate.ToString() + "%";
                lblSafeElementsRate.Text = KPIsSummary.SafeElementsRate.ToString() + "%";
                lblLowElementsRate.Text = KPIsSummary.LowElementsRate.ToString() + "%";
                lblFinishedElementsRate.Text = KPIsSummary.FinishedElementsRate.ToString() + "%";
                lblItemsWithoutReorderQuantityRate.Text = KPIsSummary.ItemsWithoutReorderQuantityRate.ToString() + "%";
                lblInsideStockTransactionsRate.Text = KPIsSummary.InsideStockTransactionsRate.ToString() + "%";
                lblOutsideStockTransactionsRate.Text = KPIsSummary.OutsideStockTransactionsRate.ToString() + "%";
            }
        }

        public ctrWarehouseInfo() 
        {
            InitializeComponent();
        }

    }
}
