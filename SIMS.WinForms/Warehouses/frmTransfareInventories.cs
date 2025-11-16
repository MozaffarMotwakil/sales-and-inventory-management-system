using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmTransfareInventories : Form
    {
        public frmTransfareInventories()
        {
            InitializeComponent();
        }

        private void frmTransfareInventories_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Tahoma", 8, FontStyle.Bold);
        }

    }
}
