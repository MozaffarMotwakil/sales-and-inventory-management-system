using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Inventory
{
    public partial class ctrProductInfoWithFilter : UserControl
    {
        public ctrProductInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrProductInfoWithFilter_Load(object sender, EventArgs e)
        {
            ctrProductInfo.Visible = DesignMode;
        }

    }
}
