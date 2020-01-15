using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// This application will calculate the current bill amount for either Residential,
/// Commercial or Industrial customers based on user input
/// 
/// Created week of Dec 9 -12, 2019
/// Created by Wade Grimm
/// Course: CPRG 200 - OOSD FastTrack
/// </summary>
namespace RateCalc_PowerCo
{
    public partial class frmMain : Form
    {
        // Globally define the constants that will be used throughout the application
        // I chose to use decimal as it is likely that clients will use fractions of hours
        // and this prevent the need for type casting or data conversions later on
        List<Customer> customers = new List<Customer>();
        
       
        //initialize the components on the form
        public frmMain()
        {
            InitializeComponent();

        }
        // Once the form is loaded and shown, process these statements
        private void frmMain_Shown(object sender, EventArgs e)
        {
            InitializeListView(); //setup the Listview
            txtName.Focus(); // set focus on Textbox when form is loaded and shown
            customers = FileSystem.ReadCustomers(); // Read any existing 'records' from file into a List
            LoadCustomers(); // runs one time during load to populate the listview with data from the List
        }

    
        // When a key is pressed in the txtInput Textbox, run this validation
        // only accepts numbers and backspace keystrokes
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  e.KeyChar contains the character that was pressed
            // e.Handled is a boolean that indicates that handling is done
            //if a bad character is entered, set e.Handled to true and discard the keypress
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        // When a key is pressed in the txtOffPeak Textbox, run this validation
        // only accepts numbers and backspace keystrokes
        private void txtOffPeak_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  e.KeyChar contains the character that was pressed
            // e.Handled is a boolean that indicates that handling is done
            //if a bad character is entered, set e.Handled to true and discard the keypress
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        
        // Check after each key press to see if we have required data
        // if not show an error and disable the Calculate button
        private void txtOffPeak_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOffPeak.Text)) // check if we have data in text field
            {
                btnAdd.Enabled = false; // disable Add button
                errorProvider1.SetError(txtOffPeak, "Value Required"); // set error and alert user
            }else
            {
                btnAdd.Enabled = true; // enable Add button 
                errorProvider1.SetError(txtOffPeak, ""); // clear any previous errors
            }
        }
        // Check after each key press to see if we have required data
        // if not show an error and disable the Calculate button
        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {// check if we have data in the text field
            if (string.IsNullOrWhiteSpace(txtInput.Text) && !Validator.IsPresent(txtName, "Name"))
            {
                btnAdd.Enabled = false; // disable Add button
                errorProvider1.SetError(txtInput, "Value Required"); // set error and alert user
            }
            else
            {
                btnAdd.Enabled = true; // Enable Add button
                errorProvider1.SetError(txtInput, ""); // clear any previous error
            }
        }

        private void radRes_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Focus(); // set focus on Name field after changing the Customer type
        }

        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Focus(); // set focus on Name field after changing the Customer type
        }

        // if the radio button for industrial clients is clicked or selected utem moves to 
        // another entry run these statements
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            if (radIndustrial.Checked) // if it is selected
            {
                // Make the additional items for OffPeak visable
                lblOffPeak.Visible = true;
                txtOffPeak.Visible = true;
                // Change the text to indicated Peak kWh instead of just kWh
                lblInput.Text = "Peak kWh";
            }
            else
            {
                // if the radio button is not 'Checked', hide the OffPeak items and change the 
                // label for txtInput back to default text
                lblOffPeak.Visible = false;
                txtOffPeak.Visible = false;
                lblInput.Text = "Input kWh";
            }
            txtName.Focus(); // set focus on the Name field 
        }

        //closes the application
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // resets form items to defaults when clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();

        }
        /// <summary>
        /// Function to reset form items to 'defaults'
        /// </summary>
        private void ClearForm()
        {
            // set Radio button to default to Residential customer
            radRes.Select();
            //disable Calculate button
            btnAdd.Enabled = false;
            // reset information fields
            lblInput.Text = "Input kWh";
            lblAmount.Text = "";
            // reset the text fields
            txtOffPeak.Text = "0";
            txtInput.Text = "0";
            txtName.Text = "";
            // if any errors were set clear them
            errorProvider1.SetError(txtInput, "");
            errorProvider1.SetError(txtOffPeak, "");
            // Select the data in txtName
            txtName.SelectAll();
            // set focus on txtName item
            txtName.Focus();
        }

        // Fires when the Calculate button is clicked, will test for valid data and 
        // set various Customer object (or derivatives) 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create a Base Customer object that will hold the object info
            // set a few varibles for later use
            int hours = 0, opHours = 0;
            string name;
            // set default customer 'Type' to residential
            char type = 'R';
            // check if we have a client name
            if (Validator.IsPresent(txtName, "Name"))
            {
                name = txtName.Text; // set the name variable
                // Check txtInput for a valid integer, if false, display error icon 
                // and select data in field
                if (Int32.TryParse(txtInput.Text, out int val))
                {
                    // if the test passes, clear any previous errors and set the hours variable
                    errorProvider1.SetError(txtInput, "");
                    hours = Convert.ToInt32(txtInput.Text);
                }
                else
                {
                    // if the test fails. flash the error icon, select bad data 
                    // and set the focus on text field
                    errorProvider1.SetError(txtInput, "Invalid data");
                    txtInput.SelectAll();
                    txtInput.Focus();
                }

                if (radCommercial.Checked)
                {
                    type = 'C'; // sets the 'Type' as Commercial;
                    // creates a new Commercial customer object
                    Commercial client = new Commercial();
                    client.Hours = hours; // set the usage hours
                    client.Name = name; // set name attribute
                    client.AccountType = type; // set the 'Type'
                    client.CalculateRate(); // calculate the payout
                    customers.Add(client); // add the customer to the List
                }
                else if (radIndustrial.Checked)
                {
                    // sets the opHours variable to be passed into the method
                    // Check txtOffPeak for a valid integer, if false, 
                    // display error icon and select data in field
                    if (Int32.TryParse(txtOffPeak.Text, out val))
                    {
                        // if the test passes, clear any previous errors and set the opHours variable
                        errorProvider1.SetError(txtOffPeak, "");
                        opHours = Convert.ToInt32(txtOffPeak.Text);
                    }
                    else
                    {
                        // if the test fails. flash the error icon, select bad data 
                        // and set the focus on test field
                        errorProvider1.SetError(txtOffPeak, "Invalid data");
                        txtOffPeak.SelectAll();
                        txtOffPeak.Focus();
                    }
                    type = 'I'; // sets the type as Industrial
                    Industrial client = new Industrial(); // creates a new Industrial customer object
                    client.PeakHours = hours; // sets Peak usage
                    client.OffPeakHours = opHours; // set Off Peak usage
                    client.Name = name; // set name
                    client.AccountType = type; // set 'Type'
                    client.CalculateRate(); // Calculate the payout
                    customers.Add(client); // add the customer to the List
                }
                else
                {
                    // type is (R)esidential by default
                    // create new Residential customer object
                    Residential client = new Residential();
                    client.Hours = hours; // sets usage hours
                    client.Name = name; // set Name
                    client.AccountType = type; // set 'Type'
                    client.CalculateRate(); // Calculate the Payout
                    customers.Add(client); // add the customer to the List
                }
                DisplayCustomers(); // update the ListView
            }
        }
        /// <summary>
        /// DisplayCustomers will update the ListView and call the UpdateTotals
        /// </summary>
        public void DisplayCustomers()
        {
            lvCust.Items.Clear();
            decimal resAmt=0, commAmt=0, indAmt=0, totalAmt=0;
            foreach (Customer c in customers) // proces the List of customers
            {

                lvCust.Items.Add(new ListViewItem(c.ToString().Split(','))); // add to the listview
                totalAmt += c.ChargeAmount; // set the total Amount used in the UpdateTotals method
                if(c.AccountType == 'R') // determine the client type and set the corresponding
                {                        // Amt varible for use in UpdateTotals
                    resAmt += c.ChargeAmount;
                }else if (c.AccountType == 'C')
                {
                    commAmt += c.ChargeAmount;
                }else if (c.AccountType == 'I')
                {
                    indAmt += c.ChargeAmount;
                }


            }// call UpdateTotals to refresh info on the form
            UpdateTotals(totalAmt,resAmt,commAmt,indAmt, lvCust.Items.Count);
        }

        /// <summary>
        /// LoadCustomers is run only once, during form initialzation
        /// gets info from the List generate from the ReadFile method
        /// and updates the form controls wit the information
        /// </summary>
        public void LoadCustomers()
        {// set variables to use later on
            decimal resAmt = 0, commAmt = 0, indAmt = 0, totalAmt = 0, tmpAmt=0;
            for(int i=0; i < customers.Count; i++) // loop through the List
            {
                string[] tmp = customers[i].ToString().Split(',');// convert item to a text string array
                tmpAmt = Convert.ToDecimal(tmp[3].Remove(0,1));  // pull the 4th item out and assign it 
                 // to a temp Variable for processing, also remove the $ from the sting for conversion
                lvCust.Items.Add(new ListViewItem(tmp)); // add the item to the list
                totalAmt += tmpAmt; // item the amount to the global variable
                if (customers[i].AccountType == 'R') // determine Customer 'Type' and assign the 
                {                                    // amoun to the corresponding variable
                    resAmt += tmpAmt;
                }
                else if (customers[i].AccountType == 'C')
                {
                    commAmt += tmpAmt;
                }
                else if (customers[i].AccountType == 'I')
                {
                    indAmt += tmpAmt;
                }
            } // call UpdateTotals to refresh information on the form
            UpdateTotals(totalAmt, resAmt, commAmt, indAmt, lvCust.Items.Count);
        }
        /// <summary>
        /// UpdateTotals will update the various labels on the form
        /// </summary>
        /// <param name="total">amount of total billing</param>
        /// <param name="res">amount of total billing for Residential</param>
        /// <param name="comm">amount of total billing for Commercial</param>
        /// <param name="ind">amount of total billing for Industrial</param>
        /// <param name="count">total number of items in the ListView</param>
        private void UpdateTotals(decimal total, decimal res, decimal comm, decimal ind, int count)
        {
           
            lblTotalCharges.Text = total.ToString("c");
            lblTotalCust.Text = count.ToString();
            lblResSum.Text = res.ToString("c");
            lblComSum.Text = comm.ToString("c");
            lblIndSum.Text = ind.ToString("c");
            ClearForm(); // clears text fields to prepare for more entries
            
        }
        /// <summary>
        /// initialize the ListView control
        /// add columns, set names and sizes
        /// </summary>
        public void InitializeListView()
        {
            lvCust.Columns.Add("Client Name",210);
            lvCust.Columns.Add("Account #",110);
            lvCust.Columns.Add("Type",60);
            lvCust.Columns.Add("Charge Amount",145);
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           FileSystem.SaveCustomers(customers); // save data on App unload
        }

        private void lvCust_ColumnClick(object sender, ColumnClickEventArgs e)
        {// sort the data based on column clicked
            lvCust.ListViewItemSorter = new ListViewItemComparer(e.Column); 
        }
        /// <summary>
        /// Sorts the ListView based on the Column header clicked
        /// </summary>
        public class ListViewItemComparer : IComparer
        {
            private int col = 0;

            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
    }
}
