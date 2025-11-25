using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BusinessLogic.Parties;
using SIMS.WinForms.Properties;

namespace DVLD.WinForms.Utils
{
    public static class clsFormHelper
    {
        private static DataGridViewImageColumn CreateEditColumn()
        {
            DataGridViewImageColumn edit = new DataGridViewImageColumn();
            edit.Name = "edit";
            edit.HeaderText = "تعديل";
            edit.Image = Resources.edit;
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.SortMode = DataGridViewColumnSortMode.NotSortable;
            edit.Resizable = DataGridViewTriState.False;
            edit.Width = 50;

            return edit;
        }

        private static DataGridViewImageColumn CreateDeleteColumn()
        {
            DataGridViewImageColumn delete = new DataGridViewImageColumn();
            delete.Name = "delete";
            delete.HeaderText = "حذف";
            delete.Image = Resources.delete;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.SortMode = DataGridViewColumnSortMode.NotSortable;
            delete.Resizable = DataGridViewTriState.False;
            delete.Width = 50;

            return delete;
        }

        public static void DisableSortableDataGridViewColumns(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public static int GetSelectedRowID(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int.TryParse(dataGridView.SelectedRows[0].Cells[0].Value.ToString(), out int ID);
                return ID;
            }

            if (dataGridView.CurrentRow.Index >= 0)
            {
                int.TryParse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString(), out int ID);
                return ID;
            }

            return -1;
        }

        public static Point GetCurrentPoint(Control control)
        {
            return control.PointToClient(Cursor.Position);
        }

        public static DataGridView.HitTestInfo GetHitTestInfo(DataGridView dataGridView)
        {
            Point point = GetCurrentPoint(dataGridView);
            return dataGridView.HitTest(point.X, point.Y);
        }

        public static void PreventContextMenuOnEmptyClick(DataGridView dataGridView, System.ComponentModel.CancelEventArgs e)
        {
            DataGridView.HitTestInfo hit = GetHitTestInfo(dataGridView);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader)
            {
                e.Cancel = true;
                dataGridView.ClearSelection();
            }
        }

        public static Image GetDefaultPersonImage(clsPerson.enGender gender)
        {
            return gender is clsPerson.enGender.Male ? Resources.unknow_male : Resources.unknow_female;
        }

    }
}
