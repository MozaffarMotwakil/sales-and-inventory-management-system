using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SIMS.WinForms
{
    public partial class frmTest : Form
    {

        public frmTest()
        {
            InitializeComponent();
            
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer);
            reportViewer.RefreshReport();
        }

    }
}
