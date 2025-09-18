using System;
using System.Windows.Forms;
using SIMS.WinForms.Properties;

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
            lblSearchHintText.Text = "أدخل إسم المورد أو رقم الهاتف أو إسم جهة التواصل داخل المنظمة";
        }

        private void frmSuppliersList_Activated(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);
        }

        private void pictureBoxAndSearchHintText_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
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

        private DataGridViewImageColumn _CreateEditColumn()
        {
            DataGridViewImageColumn edit = new DataGridViewImageColumn();
            edit.Name = "edit";
            edit.HeaderText = "Edit";
            edit.Image = Resources.edit;
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.SortMode = DataGridViewColumnSortMode.NotSortable;
            edit.Resizable = DataGridViewTriState.False;
            edit.Width = 50;

            return edit;
        }

        private DataGridViewImageColumn _CreateDeleteColumn()
        {
            DataGridViewImageColumn delete = new DataGridViewImageColumn();
            delete.Name = "delete";
            delete.HeaderText = "Delete";
            delete.Image = Resources.delete;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.SortMode = DataGridViewColumnSortMode.NotSortable;
            delete.Resizable = DataGridViewTriState.False;
            delete.Width = 50;

            return delete;
        }

    }
}
