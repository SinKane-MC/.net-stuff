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
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        List<Order> orders = new List<Order>();
        int recordIndex = 0;
        DateTime? tmpDate;

        public Form1()
        {
            InitializeComponent();


        }


        private void LoadOrders(int recordNum)
        {
            lblOrderID.Text = orders[recordNum].OrderID.ToString();
            lblCustomerID.Text = orders[recordNum].CustomerID.ToString();
            lblOrderDate.Text = Convert.ToString(orders[recordNum].OrderDate.ToString());
            lblRequiredDate.Text = orders[recordNum].RequiredDate.ToString();
            if (orders[recordNum].ShippedDate == null)
            {
                dtShippedDate.Enabled = false;
            } else
            {
                dtShippedDate.Enabled = true;
                dtShippedDate.Value = (DateTime)orders[recordNum].ShippedDate;
            }
            LoadOrderDetails(orders[recordNum].OrderID);
        }
    

        private void LoadOrderDetails(int orderNum)
        {
            double tmpTotal = 0;
            try
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                

                orderDetails = OrderDetailDB.GetOrderDetails(orderNum);
                dataGridView1.DataSource = orderDetails;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.Columns[2].DefaultCellStyle.Format = "c";

                foreach (OrderDetail ord in orderDetails)
                {
                    tmpTotal+= ord.UnitPrice * (1 - ord.Discount) * ord.Quantity;
                    
                }
                lblOrderTotal.Text = tmpTotal.ToString("c");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

       
        private void Form1_Shown(object sender, EventArgs e)
        {
            orders = OrderDB.GetOrders();
            LoadOrders(0);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            btnBack.Enabled = true;
            recordIndex += 1;
            LoadOrders(recordIndex);
            if (recordIndex>=orders.Count)
                btnNext.Enabled = false;
            dtShippedDate.CustomFormat = "MM/dd/yyyy";
            dtShippedDate.Format = DateTimePickerFormat.Custom;
            CheckData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            recordIndex -= 1;
            LoadOrders(recordIndex);
            if (recordIndex == 0)
                btnBack.Enabled = false;
            dtShippedDate.CustomFormat = "MM/dd/yyyy";
            dtShippedDate.Format = DateTimePickerFormat.Custom;
            CheckData();
        }

        private void dtShippedDate_ValueChanged(object sender, EventArgs e)
        {
            CheckData();
        }
        public void CheckData()
        {

            if (dtShippedDate.Value == orders[recordIndex].ShippedDate)
            {
                btnSaveDate.Enabled = false;
            }
            else
            {
                if (dtShippedDate.Value == null || dtShippedDate.Value > orders[recordIndex].OrderDate
                   && dtShippedDate.Value < orders[recordIndex].RequiredDate)
                {
                    tmpDate = dtShippedDate.Value;
                    btnSaveDate.Enabled = true;
                }
            }
        }

        private void btnSaveDate_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDB.SaveShippedDate(orders[recordIndex] , tmpDate);
                //orders.Clear;
                orders = OrderDB.GetOrders();
                LoadOrders(recordIndex);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtShippedDate.CustomFormat = " ";
            dtShippedDate.Format = DateTimePickerFormat.Custom;
            tmpDate = null;
            btnSaveDate.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
