using System;
using System.Windows.Forms;
using BusinessLogic.Suppliers;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmShowSupplierInfo : Form
    {
        private clsSupplier _Supplier;

        public frmShowSupplierInfo(clsSupplier supplier)
        {
            InitializeComponent();
            _Supplier = supplier;
        }

        private void frmShowSupplierInfo_Load(object sender, EventArgs e)
        {
            if (_Supplier == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على المورد");
                this.Close();
                return; 
            }

            ctrSupplierInfo.Supplier = _Supplier;
        }

        private void ctrSupplierInfo_SizeChanged(object sender, EventArgs e)
        {
            this.Height -= 65;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
