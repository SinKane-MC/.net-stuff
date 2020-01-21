using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTtSQL
{
    public partial class Form1 : Form
    {
        SQLDataContext dbContext = new SQLDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productDataGridView.DataSource = dbContext.Products;
        }
    }
}
