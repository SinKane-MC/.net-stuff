using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoicesData;

namespace DBObject
{
    public partial class Form1 : Form
    {
        List<Invoice> invoices;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            invoices = InvoiceDB.GetInvoices();
            invoiceDataGridView.DataSource = invoices;
        }
    }
}
