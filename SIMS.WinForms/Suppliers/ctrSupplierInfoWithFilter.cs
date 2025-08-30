using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS.WinForms.Suppliers
{
    public partial class ctrSupplierInfoWithFilter : UserControl
    {
        public ctrSupplierInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrSupplierInfoWithFilter_Load(object sender, EventArgs e)
        {
            ctrSupplierInfo.Visible = DesignMode;
        }

    }
}
