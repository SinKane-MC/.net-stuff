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
        List<OrderDetail> orderDetails = new List<OrderDetail>(); // instantiate empty lists for later use
        List<Order> orders = new List<Order>();
        int recordIndex = 0; // for keeping track of which order is current
        DateTime? tmpDate; // for setting Null and non-null Date value

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            orders = OrderDB.GetOrders(); // populate the list with all the orders from the DB
            LoadOrders(recordIndex); // set Form controls with the first order entity information
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = true; // if btnBack was disabled, re-enable
            recordIndex += 1; // increment list index count
            LoadOrders(recordIndex); // set Form controls based on selected order entity information


            if (recordIndex>=orders.Count) // if we are at the max list index value, disable the button
                btnNext.Enabled = false;
            CheckData(); // check the data to disable/enable the save button
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true; // if btnNext was disabled, re-enable it
            recordIndex -= 1; // decrement list index count
            LoadOrders(recordIndex); //set Form controls based on selected order entity information


            if (recordIndex == 0) // if we are at the first list index value, disable the button
                btnBack.Enabled = false;
            CheckData(); // check the data to disable/enable the save button
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            recordIndex = orders.Count - 1;
            LoadOrders(recordIndex);
            CheckData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            recordIndex = 0;
            LoadOrders(recordIndex);
            CheckData();
        }

        private void dtShippedDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtShippedDate.Value != null) // set the value of tmpDate if it's not null
                tmpDate = dtShippedDate.Value;
            CheckData(); // check the data to disable/enable the save button
        }
       
        private void btnSaveDate_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDB.SaveShippedDate(orders[recordIndex] , tmpDate); // call the Save method
                orders = OrderDB.GetOrders(); // reload the orders list
                LoadOrders(recordIndex); // redisplay the information based on the current record
                btnSaveDate.Enabled = false; // disable the button as we are done this operation
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       /// <summary>
       /// LoadOrders - populates the form controls based 
       /// on the index number of the select list item
       /// </summary>
       /// <param name="recordNum"></param>

        private void LoadOrders(int recordNum)
        {
            DateTime? tempDate;
            string tmpStr;
            lblOrderID.Text = orders[recordNum].OrderID.ToString();
            lblCustomerID.Text = orders[recordNum].CustomerID.ToString();
            // Convert Ordered date to short format
            tempDate = orders[recordNum].OrderDate;
            tmpStr = tempDate.Value.ToShortDateString();
            lblOrderDate.Text = tmpStr;
            // Convert Required date to short format
            tempDate = orders[recordNum].RequiredDate;
            tmpStr = tempDate.Value.ToShortDateString();
            lblRequiredDate.Text = tmpStr;

            // check if the entity ShippedDate is Null, if it is clear the DateTime Picker
            if (orders[recordNum].ShippedDate == null)
            {
                tmpDate = null; // set the global to null
                dtShippedDate.Format = DateTimePickerFormat.Custom;
                dtShippedDate.CustomFormat = " ";
            }
            else // otherwise set the format of the DateTime picker and it's value
            {
                dtShippedDate.Enabled = true;
                // sets the global to the value of the current record
                tmpDate = (DateTime)orders[recordNum].ShippedDate; 
                dtShippedDate.CustomFormat = "MM/dd/yyyy";
                dtShippedDate.Format = DateTimePickerFormat.Custom;
                dtShippedDate.Value = Convert.ToDateTime(tmpDate);
            }
            // get the Order Details for the currently selected Order
            LoadOrderDetails(orders[recordNum].OrderID); 
        }

        private void LoadOrderDetails(int orderNum)
        {
            double tmpTotal = 0; // used for storing the calculated value of the orders
            try
            {
                orderDetails = OrderDetailDB.GetOrderDetails(orderNum); // get the order details info
                dataGridView1.DataSource = orderDetails; // set the datasource of the datagrid to the list
                dataGridView1.AutoResizeColumns();

                // dataGrid formatting items - they don't all matter as we aren't allowing
                // data editing in this application
                // Allows the columns to Autoresize based on contents
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                // select full row instead of a single cell
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                // don't allow more than one row to be selected
                dataGridView1.MultiSelect = false;
                // do not allow edits in the datagrid
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                // set the display format to Currency for UnitPrice
                dataGridView1.Columns[2].DefaultCellStyle.Format = "c";
                // set the display format to Percentage for Discount
                dataGridView1.Columns[4].DefaultCellStyle.Format = "p";

                // calculate the total for the order based on the order details
                foreach (OrderDetail ord in orderDetails)
                {
                    tmpTotal += ord.UnitPrice * (1 - ord.Discount) * ord.Quantity;
                }
                lblOrderTotal.Text = tmpTotal.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// CheckData - Checks the tmpDate and shippeddate versus ordered and required
        /// and enableing the Save button if appropriate
        /// </summary>
        public void CheckData()
        {
            if (recordIndex > 0)
            {
                btnFirst.Enabled = true;
                btnBack.Enabled = true;
            }
            else
            {
                btnFirst.Enabled = false;
                btnBack.Enabled = false;
            }
            if (recordIndex< orders.Count - 1)
            {
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }
            else
            {
                btnLast.Enabled = false;
                btnNext.Enabled = false;
            }

            if (dtShippedDate.Value == null || dtShippedDate.Value > orders[recordIndex].OrderDate
                && dtShippedDate.Value < orders[recordIndex].RequiredDate)
            {
                if (tmpDate != null)
                {
                    dtShippedDate.CustomFormat = "MM/dd/yyyy";
                    dtShippedDate.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    dtShippedDate.CustomFormat = " ";
                    dtShippedDate.Format = DateTimePickerFormat.Custom;
                }
                if (orders[recordIndex].ShippedDate != tmpDate)
                {
                    btnSaveDate.Enabled = true;
                }else
                {
                    btnSaveDate.Enabled = false;
                }
            }
        }
        // Check for Backspace or Delete key in puts on DateTime picker and set dtp to 'null'
        private void dtShippedDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                tmpDate = null;
                CheckData();
            }
        }

    }
}
