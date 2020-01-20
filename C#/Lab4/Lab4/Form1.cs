using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>();
        public Form1()
        {
            InitializeComponent();
            LoadOrders();

        }

        private void LoadOrders()
        {
            try
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

                orders = OrderDB.GetOrders();
                dataGridView1.DataSource = orders;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    dataGridView1.MultiSelect = false;
                //foreach(Order o in orders)
                //{
                //    dataGridView1.Rows.Add(o);
                //}

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

       

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode.
            //foreach (DataGridViewColumn column in dataGridView1.Columns)
            //{
            //    column.SortMode = DataGridViewColumnSortMode.Programmatic;
            //}
        }

        private void dataGridView1_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            //DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            //ListSortDirection direction;

            //// If oldColumn is null, then the DataGridView is not sorted.
            //if (oldColumn != null)
            //{
            //    // Sort the same column again, reversing the SortOrder.
            //    if (oldColumn == newColumn &&
            //        dataGridView1.SortOrder == SortOrder.Ascending)
            //    {
            //        direction = ListSortDirection.Descending;
            //    }
            //    else
            //    {
            //        // Sort a new column and remove the old SortGlyph.
            //        direction = ListSortDirection.Ascending;
            //        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
            //    }
            //}
            //else
            //{
            //    direction = ListSortDirection.Ascending;
            //}

            //// Sort the selected column.
            //dataGridView1.Sort(newColumn, direction);
            //newColumn.HeaderCell.SortGlyphDirection =
            //    direction == ListSortDirection.Ascending ?
            //    SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
