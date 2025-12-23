using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS.WinForms.Invoices;

namespace SIMS.WinForms.Sales
{
    public partial class frmIssueSaleReturnInvoice : frmBaseIssueInvoice
    {
        public frmIssueSaleReturnInvoice() : base(BusinessLogic.Invoices.enInvoiceType.SalesReturn)
        {
            InitializeComponent();
        }
    }
}
