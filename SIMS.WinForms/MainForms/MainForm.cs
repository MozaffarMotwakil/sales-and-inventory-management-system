using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIMS.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTest form = new frmTest();
            form.MdiParent = this;
            form.Show();
        }

    }
}
