using System.Windows.Forms;
using BusinessLogic.Warehouses;

namespace SIMS.WinForms.Warehouses
{
    public partial class ctrWarehouseInfo : UserControl
    {
        public clsWarehouse Warehouse
        {
            set
            {
                if (value == null)
                {
                    return;
                }

                lblWarehouseName.Text = value.WarehouseName;
                lblAddress.Text = value.Address;
                lblCategory.Text = 
                    value.Type == clsWarehouse.enWarehouseType.ShopWarehouse ?
                    "محلي" :
                    value.Type == clsWarehouse.enWarehouseType.MainWarehouse ?
                    "رئيسي" :
                    "فرعي";
                lblActivityStatus.Text = value.IsActive ? "نشط" : "غير نشط";
            }
        }

        public ctrWarehouseInfo()
        {
            InitializeComponent();
        }
    }
}
