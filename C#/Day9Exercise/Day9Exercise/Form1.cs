using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customers;

namespace Day9Exercise
{
    public partial class Form1 : Form
    {
        
        List<Customer> customers = CustomerDB.GetCustomers();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            customerIDComboBox.DataSource = customers;


            //var details = from order

        }

        private void customerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get CustomerID from combo box
            string custID = customerIDComboBox.Text;

            var temp = from customer in customers where customer.CustomerID == custID select customer;

            foreach (var c in temp)
            {
                companyNameTextBox.Text = c.CompanyName;
                contactNameTextBox.Text = c.ContactName;
                contactTitleTextBox.Text = c.ContactTitle;
                addressTextBox.Text = c.Address;
                cityTextBox.Text = c.City;
                postalCodeTextBox.Text = c.PostalCode;
                countryTextBox.Text = c.Country;
                regionTextBox.Text = c.Region;
                phoneTextBox.Text = c.Phone;
                faxTextBox.Text = c.Fax;
            }

            // get the orders for that customer id and populate the orders table
            List<Order> orders = OrderDB.GetOrdersByID(custID);

            //var temp2 = from order in orders where order.CustomerID == custID select order;
            dataGridView1.DataSource = orders;
        }
    }
}
