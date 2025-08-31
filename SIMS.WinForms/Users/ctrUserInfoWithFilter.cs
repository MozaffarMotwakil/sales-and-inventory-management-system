using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Users
{
    public partial class ctrUserInfoWithFilter : UserControl
    {
        public ctrUserInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrUserInfoWithFilter_Load(object sender, EventArgs e)
        {
            ctrUserInfo.Visible = DesignMode;
        }

    }
}
