using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS.WinForms.Sales
{
    public partial class frmPointOfSale : Form
    {
        public frmPointOfSale()
        {
            InitializeComponent();
        }

        private void btnCancleSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
