using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogic.Suppliers;
using BusinessLogic.Parties;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmSuppliersList : Form
    {
        public frmSuppliersList()
        {
            InitializeComponent();
            clsSupplier.SupplierSaved += ClsSupplier_SupplierSaved;
            clsSupplier.SupplierDeleted += ClsSupplier_SupplierDeleted;
        }

        private void ClsSupplier_SupplierDeleted(object sender, clsSupplier.SupplierDeletedEventArgs e)
        {
            txtSearch.Text = string.Empty;
            dgvSuppliersList.DataSource = clsSupplier.GetAllSuppliers();
            ctrSupplierInfo.Visible = false;
            ctrSupplierInfo.Supplier = null;
        }

        private void ClsSupplier_SupplierSaved(object sender, clsSupplier.SupplierSavedEventArgs e)
        {
            txtSearch.Text = string.Empty;
            dgvSuppliersList.DataSource = clsSupplier.GetAllSuppliers();
            ctrSupplierInfo.Supplier = e.SavedSupplier;
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
            frmAddEditSupplier addPersonSupplier = new frmAddEditSupplier(clsParty.enPartyCategory.Person);
            addPersonSupplier.ShowDialog();
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier addOrganizationSupplier = new frmAddEditSupplier(clsParty.enPartyCategory.Organization);
            addOrganizationSupplier.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSupplier supplier = clsSupplier.Find(clsFormHelper.GetSelectedRowID(dgvSuppliersList));

            if (supplier is null)
            {
                clsFormMessages.ShowError("لم يتم العثور على المورد");
                return;
            }

            frmAddEditSupplier editSupplier = new frmAddEditSupplier(supplier, supplier.PartyInfo.PartyCategory);
            editSupplier.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSuppliersList.SelectedRows.Count == 0)
            {
                clsFormMessages.ShowError("لم يتم العثور على المورد");
                return;
            }

            if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد حذف هذا المورد ؟", messageBoxIcon: MessageBoxIcon.Warning)) 
            {
                if (clsSupplier.Delete(clsFormHelper.GetSelectedRowID(dgvSuppliersList)))
                {
                    clsFormMessages.ShowSuccess("تم حذف المورد بنجاح");
                }
                else
                {
                    clsFormMessages.ShowError("فشلت عملية حذف المورد");
                }
            }
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvSuppliersList, e);
        }

        private void dgvSuppliersList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Left)
            {
                clsSupplier supplier = clsSupplier.Find(clsFormHelper.GetSelectedRowID(dgvSuppliersList));
                ctrSupplierInfo.Supplier = supplier;
                ctrSupplierInfo.Visible = true;
            }
        }

        private void dgvSuppliersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSuppliersList.ClearSelection();
        }

        private void dgvSuppliersList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvSuppliersList.Rows[e.RowIndex].Selected = true;
                dgvSuppliersList.Columns[e.ColumnIndex].Selected = true;
            }
        }

        private void FormControls_MouseDown(object sender, MouseEventArgs e)
        {
            dgvSuppliersList.ClearSelection();
        }

        private void frmSuppliersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSupplier.SupplierSaved -= ClsSupplier_SupplierSaved;
            clsSupplier.SupplierDeleted -= ClsSupplier_SupplierDeleted;
        }

    }
}
