using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.BaseForms
{
    public partial class frmGenericListBase<TManager, TEntity> : Form
        where TManager : IEntityListManager<TEntity>, new()
    {
        protected readonly TManager Manager;
        protected Control EntityInfoControl { get; set; }
        protected string EntityName { get; set; }
        protected string Filter { get; set; }
        protected string SearchHintMessage
        {
            get => lblSearchHintText.Text;
            set => lblSearchHintText.Text = value;
        }

        public frmGenericListBase()
        {
            InitializeComponent();
            Manager = new TManager();
            Manager.EntitySaved += EntitySavedEvent;
            Manager.EntityDeleted += EntityDeletedEvent;
        }

        protected virtual void EntitySavedEvent(object sender, EntitySavedEventArgs e)
        {
            txtSearch.Text = string.Empty;
            dgvEntitiesList.DataSource = Manager.GetAll();
            lblTotalRecords.Text = dgvEntitiesList.Rows.Count.ToString();

            if (e.OperationMode == BusinessLogic.enMode.Update && EntityInfoControl.Visible)
            {
                HandleEntityInfoDisplay(e.EntityID);
            }
            else
            {
                EntityInfoControl.Visible = false;
            }
        }

        protected virtual void EntityDeletedEvent(object sender, EntityDeletedEventArgs e)
        {
            txtSearch.Text = string.Empty;
            EntityInfoControl.Visible = false;
            dgvEntitiesList.DataSource = Manager.GetAll();
            lblTotalRecords.Text = dgvEntitiesList.Rows.Count.ToString();
        }

        private void frmGenericListBase_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetColumnsOfDGV();
        }

        private void frmGenericListBase_Shown(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        protected virtual void LoadData()
        {
            dgvEntitiesList.DataSource = Manager.GetAll();
            lblTotalRecords.Text = dgvEntitiesList.Rows.Count.ToString();
            dgvEntitiesList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
        }

        protected virtual void ResetColumnsOfDGV() { }

        protected virtual void SearchTextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);

            DataView entitiesList = (dgvEntitiesList.DataSource as DataTable).DefaultView;

            try
            {
                entitiesList.RowFilter = Filter;
            }
            catch (Exception) 
            {
                // في حال رمي إستثناء بسبب إدخال رموز غير صالحة فلا حاجة لعرض رسالة خطأ أو إيقاف تجربة المستخدم
            } 
                
            lblTotalRecords.Text = entitiesList.Count.ToString();
        }

        private void pictureBoxAndSearchHintText_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TEntity product = Manager.Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

            if (product == null)
            {
                clsFormMessages.ShowError($"لم يتم العثور على {EntityName}");
                return;
            }

            Form editEntity = CreateEditForm(product);

           editEntity.ShowDialog();
        }

        protected virtual Form CreateEditForm(TEntity entity) 
        {
            throw new NotImplementedException();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                clsFormMessages.ShowError($"لم يتم العثور على {EntityName}");
                return;
            }

            DeleteSelectedEntity();
        }

        private void dgvEntitiesList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                clsFormMessages.ShowError($"لم يتم العثور على {EntityName}");
                return;
            }

            if (e.Button is MouseButtons.Left)
            {
                ShowSelectedEntityInfo();
            }
        }

        private void dgvEntitiesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ShowSelectedEntityInfo();
                }
                else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    DeleteSelectedEntity();
                }
            }
        }

        private void dgvEntitiesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEntitiesList.ClearSelection();
        }

        private void dgvEntitiesList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvEntitiesList.Rows[e.RowIndex].Selected = true;
                dgvEntitiesList.Columns[e.ColumnIndex].Selected = true;
            }
        }

        protected void HideEntityInfo(object sender, MouseEventArgs e)
        {
            dgvEntitiesList.ClearSelection();

            if (sender != dgvEntitiesList && EntityInfoControl != null)
            {
                EntityInfoControl.Visible = false;
            }
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvEntitiesList, e);
        }

        private void ShowSelectedEntityInfo()
        {
            HandleEntityInfoDisplay(clsFormHelper.GetSelectedRowID(dgvEntitiesList));
        }

        protected virtual void HandleEntityInfoDisplay(int entityID) { }

        protected virtual void DeleteSelectedEntity()
        {
            if (clsFormMessages.Confirm($"هل أنت متأكد من أنك تريد حذف هذا {EntityName} ؟", messageBoxIcon: MessageBoxIcon.Warning, messageBoxDefaultButton: MessageBoxDefaultButton.Button2))
            {
                if (Manager.Delete(clsFormHelper.GetSelectedRowID(dgvEntitiesList)))
                {
                    clsFormMessages.ShowSuccess($"تم حذف {EntityName} بنجاح");
                }
                else
                {
                    clsFormMessages.ShowError($"فشلت عملية حذف {EntityName}");
                }
            }
        }

        private void frmGenericListBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.EntitySaved -= EntitySavedEvent;
            Manager.EntityDeleted -= EntityDeletedEvent;
        }

    }
}
