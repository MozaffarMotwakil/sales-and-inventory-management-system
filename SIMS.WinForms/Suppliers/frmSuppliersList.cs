using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogic;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmSuppliersList : Form
    {
        public frmSuppliersList()
        {
            InitializeComponent();
            clsSupplier.SupplierSaved += ClsSupplier_SupplierSaved;
        }

        private void ClsSupplier_SupplierSaved(object sender, clsSupplier.SupplierSavedEventArgs e)
        {
            txtSearch.Text = string.Empty;
            dgvSuppliersList.DataSource = clsSupplier.GetAllSuppliers();
        }

        private void frmSuppliersList_Load(object sender, EventArgs e)
        {
            lblSearchHintText.Text = "أدخل إسم المورد";
            dgvSuppliersList.DataSource = clsSupplier.GetAllSuppliers();
            _ResetRecordsListColumnsWidthAndName();
        }

        private void frmSuppliersList_Activated(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void _ResetRecordsListColumnsWidthAndName()
        {
            if (dgvSuppliersList.RowCount > 0)
            {
                dgvSuppliersList.Columns[0].HeaderText = "معرف المورد";
                dgvSuppliersList.Columns[0].Width = 100;

                dgvSuppliersList.Columns[1].HeaderText = "إسم المورد";
                dgvSuppliersList.Columns[1].Width = 200;

                dgvSuppliersList.Columns[2].HeaderText = "نوع المورد";
                dgvSuppliersList.Columns[2].Width = 100;

                dgvSuppliersList.Columns[3].HeaderText = "الجنسية/البلد";
                dgvSuppliersList.Columns[3].Width = 100;

                dgvSuppliersList.Columns[4].HeaderText = "رقم الهاتف";
                dgvSuppliersList.Columns[4].Width = 100;

                dgvSuppliersList.Columns[5].HeaderText = "العنوان";
                dgvSuppliersList.Columns[5].Width = 225;

                dgvSuppliersList.Columns[6].HeaderText = "الملاحظات";
                dgvSuppliersList.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                foreach (DataGridViewColumn column in dgvSuppliersList.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvSuppliersList.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);

            DataView suppliersList = (dgvSuppliersList.DataSource as DataTable).DefaultView;

            try
            {
                suppliersList.RowFilter = $"PartyName LIKE '{txtSearch.Text}%'";
            }
            catch (Exception) { }
        }

        private void pictureBoxAndSearchHintText_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addSupplier = new frmAddEditSupplier(BusinessLogic.clsParty.enPartyCategory.Person);
            addSupplier.ShowDialog();
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addSupplier = new frmAddEditSupplier(BusinessLogic.clsParty.enPartyCategory.Organization);
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

        private void dgvSuppliersList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clsSupplier supplier = clsSupplier.Find(clsFormHelper.GetSelectedRowID(dgvSuppliersList));
            ctrSupplierInfo.Supplier = supplier;
            ctrSupplierInfo.Visible = true;
        }

        private void dgvSuppliersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSuppliersList.ClearSelection();
        }

        private void frmSuppliersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSupplier.SupplierSaved -= ClsSupplier_SupplierSaved;
        }

    }
}
