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
            lblSearchHintText.Text = "أدخل إسم المورد";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);
        }
    }
}
