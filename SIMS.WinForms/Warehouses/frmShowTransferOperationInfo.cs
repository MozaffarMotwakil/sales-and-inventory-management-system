using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmShowTransferOperationInfo : Form
    {

        private clsTransferOperation _TransferOperation;
        public frmShowTransferOperationInfo(clsTransferOperation transferOperation)
        {
            InitializeComponent();
            _TransferOperation = transferOperation;
        }

        public frmShowTransferOperationInfo(int transferOperationID)
        {
            InitializeComponent();
            _TransferOperation = clsTransferOperationService.CreateInstance().Find(transferOperationID);
        }

        private void frmShowTransferOperationInfo_Load(object sender, EventArgs e)
        {
            if (_TransferOperation == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على عملية النقل");
                this.Close();
                return;
            }

            dgvTransferedInventories.ColumnHeadersDefaultCellStyle.Font =
                new Font("Tahoma", 8, FontStyle.Bold);

            dgvTransferedInventories.DefaultCellStyle.Font =
                new Font("Tahoma", 8);

            lblSourceWarehouseName.Text = _TransferOperation.SourceWarehouseInfo.WarehouseName;
            lblDestinationWarehouseName.Text = _TransferOperation.DestianationWarehouseInfo.WarehouseName;
            lblResponsiableEmployeeName.Text = _TransferOperation.ResponsibleEmployeeInfo.EmployeeName;
            lblTransferedOperationDateTime.Text = _TransferOperation.TransferOperationDateTime.ToString("ss:mm:HH dd/MM/yyyy");
            lblProductsCount.Text = _TransferOperation.TransferedProductsCount.ToString();
            lblInventoriesCount.Text = _TransferOperation.TransferedInventoriesCount.ToString();
            lblTotalQuantity.Text = _TransferOperation.TotalTransferedQuantity.ToString();
            lblTotalTransferedInventoriesValue.Text = _TransferOperation.TotalTransferedInventoriesValue.ToString() + " جنيه";

            for (int i = 0; i < _TransferOperation.TransferedInventories.Count; i++)
            {
                dgvTransferedInventories.Rows.Add();
                dgvTransferedInventories.Rows[i].Cells[colNo.Index].Value = i + 1;
                dgvTransferedInventories.Rows[i].Cells[colProduct.Index].Value =
                    _TransferOperation.TransferedInventories[i].SourceInventoryInfo.ProductInfo.ProductName;
                dgvTransferedInventories.Rows[i].Cells[colUnit.Index].Value =
                    _TransferOperation.TransferedInventories[i].SourceInventoryInfo.UnitInfo.UnitName;
                dgvTransferedInventories.Rows[i].Cells[colTransferedQuantity.Index].Value =
                    _TransferOperation.TransferedInventories[i].TransferedQuantity;
                dgvTransferedInventories.Rows[i].Cells[colPreviousSourceQuantity.Index].Value =
                    _TransferOperation.TransferedInventories[i].PrevioustSourceInventoryQuantity;
                dgvTransferedInventories.Rows[i].Cells[colNextSourceQuantity.Index].Value =
                    _TransferOperation.TransferedInventories[i].NextSourceInventoryQuantity;
                dgvTransferedInventories.Rows[i].Cells[colPreviousDestinationQuantity.Index].Value =
                    _TransferOperation.TransferedInventories[i].PreviousDestinationInventoryQuantity;
                dgvTransferedInventories.Rows[i].Cells[colNextDestinationQuantity.Index].Value =
                    _TransferOperation.TransferedInventories[i].NextDestinationInventoryQuantity;
                dgvTransferedInventories.Rows[i].Cells[colAverageInventoryPurchasePrice.Index].Value =
                    _TransferOperation.TransferedInventories[i].InventoryAveragePurchasePrice;
                dgvTransferedInventories.Rows[i].Cells[colTransferedInventoryValue.Index].Value =
                    _TransferOperation.TransferedInventories[i].TransferedInventoryValue;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
