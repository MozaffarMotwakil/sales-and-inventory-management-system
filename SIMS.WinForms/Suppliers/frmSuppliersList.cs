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
    public partial class frmSuppliersList : Form
    {
        public frmSuppliersList()
        {
            InitializeComponent();
        }

        private void frmSuppliersList_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addSupplier = new frmAddEditSupplier();
            addSupplier.ShowDialog();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            frmFindSuppliertForEdit suppliertForEdit = new frmFindSuppliertForEdit();
            suppliertForEdit.ShowDialog();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            frmFindSuppliertForDelete suppliertForDelete = new frmFindSuppliertForDelete();
            suppliertForDelete.ShowDialog();
        }

    }
}
