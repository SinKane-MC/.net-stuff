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
               
                orders = OrderDB.GetOrders();
                dataGridView1.DataSource = orders;
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
    }
}
