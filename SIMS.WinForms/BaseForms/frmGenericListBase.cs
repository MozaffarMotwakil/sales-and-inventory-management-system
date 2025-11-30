using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.BaseForms
{
    public partial class frmGenericListBase<TManager, TEntity> : Form
        where TManager : IEntityListManager<TEntity>
        where TEntity : class
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

        protected bool AllowDeleteRecord;

        public bool ShowSearchTextBox
        {
            get => searchPanel.Visible;
            set => searchPanel.Visible = value;
        }

        public frmGenericListBase(TManager manager, bool showSearchTextBox = true)
        {
            InitializeComponent();
            Manager = manager;
            ShowSearchTextBox = showSearchTextBox;
            AllowDeleteRecord = true;
            EntityName = "الكيان";
            Manager.EntitySaved += EntitySavedEvent;
            Manager.EntityDeleted += EntityDeletedEvent;
        }

        protected virtual void EntitySavedEvent(object sender, EntitySavedEventArgs e)
        {
            dgvEntitiesList.DataSource = GetDataSource();
            UpdateRecordsCountLabels();

            if (e.OperationMode == BusinessLogic.enMode.Add && dgvEntitiesList.Rows.Count == 1)
            {
                ResetColumnsOfDGV();
                clsFormHelper.DisableSortableDataGridViewColumns(dgvEntitiesList);
            }
            else if (e.OperationMode == BusinessLogic.enMode.Update && (EntityInfoControl != null && EntityInfoControl.Visible))
            {
                HandleEntityInfoDisplay(Manager.Find(e.EntityID));
            }
            else if (EntityInfoControl != null)
            {
                EntityInfoControl.Visible = false;
            }
            
            ApplySearchFilter();
        }

        protected virtual void EntityDeletedEvent(object sender, EntityDeletedEventArgs e)
        {
            txtSearch.Text = string.Empty;

             if (EntityInfoControl != null)
             {
                EntityInfoControl.Visible = false;
             }

            dgvEntitiesList.DataSource = GetDataSource();
            UpdateRecordsCountLabels();
            ApplySearchFilter();
        }

        private void frmGenericListBase_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            LoadData();
            ResetColumnsOfDGV();
            clsFormHelper.DisableSortableDataGridViewColumns(dgvEntitiesList);
        }

        private void frmGenericListBase_Shown(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        protected virtual void LoadData()
        {
            if (Manager == null)
            {
                return;
            }

            dgvEntitiesList.DataSource = GetDataSource();
            UpdateRecordsCountLabels();
            dgvEntitiesList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
        }

        protected virtual void ResetColumnsOfDGV() { }

        protected virtual void UpdateRecordsCountLabels()
        {
            lblTotalRecords.Text = dgvEntitiesList.Rows.Count.ToString();
        }

        protected virtual void UpdateRecordsCountLabels(DataView filteredDataSource)
        {
            lblTotalRecords.Text = filteredDataSource.Count.ToString();
        }

        protected virtual object GetDataSource() 
        {
            return Manager.GetAll();
        }

        protected virtual void SearchTextChanged(object sender, EventArgs e)
        {
            lblSearchHintText.Visible = string.IsNullOrEmpty(txtSearch.Text);
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            ApplySearchFilter();
        }

        protected virtual void ApplySearchFilter()
        {
            if (dgvEntitiesList.DataSource == null)
            {
                return;
            }

            try
            {
                DataView entitiesList = (dgvEntitiesList.DataSource as DataTable).DefaultView;
                entitiesList.RowFilter = Filter;
                UpdateRecordsCountLabels(entitiesList);
            }
            catch
            {
                // في حال رمي إستثناء بسبب إدخال رموز غير صالحة فلا حاجة لعرض رسالة خطأ أو إيقاف تجربة المستخدم
            }

            txtSearch.Focus();
        }

        private void pictureBoxAndSearchHintText_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TEntity entity = Manager.Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

            if (entity == null)
            {
                clsFormMessages.ShowError($"لم يتم العثور على {EntityName}");
                return;
            }

            Form editEntity = CreateEditForm(entity);
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

        protected virtual void dgvEntitiesList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.Button == MouseButtons.Right || dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            ShowSelectedEntityInfo();
        }

        protected virtual void dgvEntitiesList_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvEntitiesList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvEntitiesList.Rows[e.RowIndex].Selected = true;
                dgvEntitiesList.Columns[e.ColumnIndex].Selected = true;
            }
        }

        protected void HideEntityInfoControl(object sender, MouseEventArgs e)
        {
            dgvEntitiesList.ClearSelection();

            if (sender != dgvEntitiesList && EntityInfoControl != null)
            {
                EntityInfoControl.Visible = false;
            }
        }

        protected virtual void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvEntitiesList, e);
        }

        protected virtual void ShowSelectedEntityInfo()
        {
            if (EntityInfoControl == null)
            {
                return;
            }

            TEntity entity = Manager.Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

            if (entity == null)
            {
                clsFormMessages.ShowError($"لم يتم العثور على {EntityName}");
                return;
            }

            HandleEntityInfoDisplay(entity);
            EntityInfoControl.Visible = true;
        }

        protected virtual void HandleEntityInfoDisplay(TEntity entity) { }

        protected virtual void DeleteSelectedEntity()
        {
            if (!AllowDeleteRecord)
            {
                return;
            }

            if (clsFormMessages.Confirm($"هل أنت متأكد من أنك تريد حذف هذا {EntityName} ؟", messageBoxIcon: MessageBoxIcon.Warning, messageBoxDefaultButton: MessageBoxDefaultButton.Button2))
            {
                try
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
                catch (Exception ex)
                {
                    clsFormMessages.ShowError(ex.Message);
                }
            }
        }

        protected object GetCellValue(int columnIndex)
        {
            if (dgvEntitiesList.CurrentRow == null || columnIndex < 0 || dgvEntitiesList.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvEntitiesList.SelectedRows[0].Cells[columnIndex].Value;
        }

        protected object GetCellValue(int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || columnIndex < 0)
            {
                return null;
            }

            return dgvEntitiesList.Rows[rowIndex].Cells[columnIndex].Value;
        }

        protected virtual void frmGenericListBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.EntitySaved -= EntitySavedEvent;
            Manager.EntityDeleted -= EntityDeletedEvent;
        }

    }
}
