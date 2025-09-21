using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic;
using SIMS.WinForms.Properties;

namespace DVLD.WinForms.Utils
{
    public static class clsFormHelper
    {
        public static void SelectEntireRow(DataGridView dataGridView, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Clicks == 2 || e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[e.RowIndex].Selected = true;
                dataGridView.CurrentCell = dataGridView.SelectedRows[0].Cells[0];
            }
        }

        public static void ClearSelectionOnEmptyClick(DataGridView dataGridView, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridView.HitTest(e.X, e.Y);

            if ((e.Button == MouseButtons.Right || e.Button == MouseButtons.Left) && hit.Type == DataGridViewHitTestType.None)
            {
                DeselectCellsAndRows(dataGridView);
            }
        }

        public static void DeselectCellsAndRows(DataGridView dataGridView)
        {
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                cell.Selected = false;
            }

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                row.Selected = false;
            }
        }


        public static int RefreshDataGridView(DataGridView dataGridView, object DataSource)
        {
            dataGridView.DataSource = DataSource;
            return dataGridView.RowCount;
        }

        public static int GetSelectedRowID(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
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

        public static void PreventContextMenuOnHeaderOrEmptySpace(DataGridView dataGridView, System.ComponentModel.CancelEventArgs e)
        {
            DataGridView.HitTestInfo hit = GetHitTestInfo(dataGridView);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader)
            {
                e.Cancel = true;
            }
        }

        public static void ShowAnotherContextMenuOnEmptySpaceInDGV(DataGridView dataGridView, ContextMenuStrip contextMenuStrip)
        {
            DataGridView.HitTestInfo hit = clsFormHelper.GetHitTestInfo(dataGridView);

            if (hit.Type == DataGridViewHitTestType.None)
            {
                contextMenuStrip.Show(dataGridView, clsFormHelper.GetCurrentPoint(dataGridView));
            }
        }

        public static Image GetDefaultPersonImage(clsPerson.enGender gender)
        {
            return gender is clsPerson.enGender.Male ? Resources.unknow_male : Resources.unknow_female;
        }

    }
}
