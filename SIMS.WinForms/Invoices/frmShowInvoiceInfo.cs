using System;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Invoices
{
    public partial class frmShowInvoiceInfo : Form
    {
        private clsInvoice _Invoice;

        public bool ShowPartyInfo
        {
            get => ctrInvoiceInfo.ShowPartyInfo;
            set => ctrInvoiceInfo.ShowPartyInfo = value;
        }

        public frmShowInvoiceInfo(int invoiceID)
        {
            InitializeComponent();
            _Invoice = clsInvoiceService.CreateInstance().Find(invoiceID);
        }

        public frmShowInvoiceInfo(clsInvoice invoice)
        {
            InitializeComponent();
            _Invoice = invoice;
        }

        private void frmShowInvoiceInfo_Load(object sender, EventArgs e)
        {
            if (_Invoice == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على الفاتورة");
                this.Close();
                return;
            }

            ctrInvoiceInfo.Entity = _Invoice;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}