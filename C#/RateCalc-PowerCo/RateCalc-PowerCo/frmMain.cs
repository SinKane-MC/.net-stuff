using System;
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
        
       
        
        public frmMain()
        {
            InitializeComponent();

        }
        // Once the form is loaded and show, process these statements
        private void frmMain_Shown(object sender, EventArgs e)
        {
            InitializeListView();
            txtName.Focus(); // set focus on Textbox when form is loaded and shown
            customers = FileSystem.ReadCustomers();
            //DisplayCustomers();
            LoadCustomers();
        }

    
        // When a key is pressed in the txtInput Textbox, run this validation
        // only accepts numbers and backspace keystrokes
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  e.KeyChar contains the character that was pressed
            // e.Handled is a boolean that indicates that handling is done
            //if a bad character is entered, set e.Handled to true
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
            //if a bad character is entered, set e.Handled to true
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        
        // Check after each key press to see if we have required data
        // if not show an error and disable the Calculate button
        private void txtOffPeak_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOffPeak.Text))
            {
                btnAdd.Enabled = false;
                errorProvider1.SetError(txtOffPeak, "Value Required");
            }else
            {
                btnAdd.Enabled = true;
                errorProvider1.SetError(txtOffPeak, "");
            }
        }
        // Check after each key press to see if we have required data
        // if not show an error and disable the Calculate button
        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text) && !Validator.IsPresent(txtName, "Name"))
            {
                btnAdd.Enabled = false;
                errorProvider1.SetError(txtInput, "Value Required");
            }
            else
            {
                btnAdd.Enabled = true;
                errorProvider1.SetError(txtInput, "");
            }
        }

        private void radRes_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Focus();
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
            txtInput.Focus();
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
            //Customer client1 = new Customer();
            // optHours is only used if client is Industrial, set it to zero in the event it's
            // not set in the code below. The method requires a value to be passed through
            int hours = 0, opHours = 0;
            string name;
            char type = 'R';
            // Get values 
            if (Validator.IsPresent(txtName, "Name"))
            {
                name = txtName.Text;
                // Check txtInput for a valid integer, if false, display error icon and select data in field
                if (Int32.TryParse(txtInput.Text, out int val))
                {
                    // if the test passes, clear any previous errors and set the hours variable
                    errorProvider1.SetError(txtInput, "");
                    hours = Convert.ToInt32(txtInput.Text);
                }
                else
                {
                    // if the test fails. flash the error icon, slect bad data and set the focus on test field
                    errorProvider1.SetError(txtInput, "Invalid data");
                    txtInput.SelectAll();
                    txtInput.Focus();
                }

                if (radCommercial.Checked)
                {
                    // sets the type as Commercial;
                    type = 'C';
                    // creates a new Commercial customer object
                    Commercial client = new Commercial();
                    // set the uages hours
                    client.Hours = hours;
                    // asigns the Commercial client to a temp Client so it can be added to the Customers List 
                    client.Name = name;
                    client.AccountType = type;
                    client.CalculateRate();
                    // add the customer to the List
                    customers.Add(client);


                }
                else if (radIndustrial.Checked)
                {
                    // sets the opHours variable to be passed into the method
                    // Check txtOffPeak for a valid integer, if false, display error icon and select data in field
                    if (Int32.TryParse(txtOffPeak.Text, out val))
                    {
                        // if the test passes, clear any previous errors and set the opHours variable
                        errorProvider1.SetError(txtOffPeak, "");
                        opHours = Convert.ToInt32(txtOffPeak.Text);
                    }
                    else
                    {
                        // if the test fails. flash the error icon, slect bad data and set the focus on test field
                        errorProvider1.SetError(txtOffPeak, "Invalid data");
                        txtOffPeak.SelectAll();
                        txtOffPeak.Focus();
                    }
                    // sets the type as Industrial
                    type = 'I';
                    // creates a new Industrial customer object
                    Industrial client = new Industrial();
                    // sets Peak and Off Peak usage
                    client.PeakHours = hours;
                    client.OffPeakHours = opHours;
                    // asigns the Industrial client to a temp Client so it can be added to the Customers List 
                    client.Name = name;
                    client.AccountType = type;
                    client.CalculateRate();
                    // add the customer to the List
                    customers.Add(client);
                }
                else
                {
                    // type is (R)esidential by default
                    // create new Residential customer object
                    Residential client = new Residential();
                    // sets usage hours
                    client.Hours = hours;
                    // assign the Residential Client to a temp Client so it can be added to the Customer List
                    client.Name = name;
                    client.AccountType = type;
                    client.CalculateRate();
                    // add the customer to the List
                    customers.Add(client);
                }
               
                DisplayCustomers();
            }
        }
        public void DisplayCustomers()
        {
            //string cust;
            lvCust.Items.Clear();
            decimal resAmt=0, commAmt=0, indAmt=0, totalAmt=0;
            foreach (Customer c in customers)
            {

                lvCust.Items.Add(new ListViewItem(c.ToString().Split(',')));
                totalAmt += c.ChargeAmount;
                if(c.AccountType == 'R')
                {
                    resAmt += c.ChargeAmount;
                }else if (c.AccountType == 'C')
                {
                    commAmt += c.ChargeAmount;
                }else if (c.AccountType == 'I')
                {
                    indAmt += c.ChargeAmount;
                }


            }
            UpdateTotals(totalAmt,resAmt,commAmt,indAmt, lvCust.Items.Count);
        }
        public void LoadCustomers()
        {
            //string cust;
            decimal resAmt = 0, commAmt = 0, indAmt = 0, totalAmt = 0, tmpAmt=0;
            for(int i=0; i < customers.Count; i++)
            {
                string[] tmp = customers[i].ToString().Split(',');
                tmpAmt = Convert.ToDecimal(tmp[3].Remove(0,1));

                lvCust.Items.Add(new ListViewItem(tmp));
                totalAmt += tmpAmt;
                if (customers[i].AccountType == 'R')
                {
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


            }
            

            UpdateTotals(totalAmt, resAmt, commAmt, indAmt, lvCust.Items.Count);
        }

        private void UpdateTotals(decimal total, decimal res, decimal comm, decimal ind, int count)
        {
           
            lblTotalCharges.Text = total.ToString("c");
            lblTotalCust.Text = count.ToString();
            lblResSum.Text = res.ToString("c");
            lblComSum.Text = comm.ToString("c");
            lblIndSum.Text = ind.ToString("c");
            ClearForm();
            
        }
        public void InitializeListView()
        {
            lvCust.Columns.Add("Client Name",210);
            lvCust.Columns.Add("Account #",110);
            lvCust.Columns.Add("Type",60);
            lvCust.Columns.Add("Charge Amount",145);
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           FileSystem.SaveCustomers(customers);
        }

      
    }
}
