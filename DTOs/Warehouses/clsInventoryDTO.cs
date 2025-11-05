using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Warehouses
{
    public class clsInventoryDTO
    {
        public int InventoryID { get; set; }
        public int WarehouseID { get; set; }
        public int ProductID { get; set; }
        public int UnitID { get; set; }
        public int ReorderQuantity { get; set; }
    }
}
