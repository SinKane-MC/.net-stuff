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

        
       
        
        public frmMain()
        {
            InitializeComponent();

        }
        // Once the form is loaded and show, process these statements
        private void frmMain_Shown(object sender, EventArgs e)
        {
            txtInput.Focus(); // set focus on Textbox when form is loaded and shown
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
                btnCalculate.Enabled = false;
                errorProvider1.SetError(txtOffPeak, "Value Required");
            }else
            {
                btnCalculate.Enabled = true;
                errorProvider1.SetError(txtOffPeak, "");
            }
        }
        // Check after each key press to see if we have required data
        // if not show an error and disable the Calculate button
        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                btnCalculate.Enabled = false;
                errorProvider1.SetError(txtInput, "Value Required");
            }
            else
            {
                btnCalculate.Enabled = true;
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
            // set Radio button to default to Residential customer
            radRes.Select();
            //disable Calculate button
            btnCalculate.Enabled = false;
            // reset information fields
            lblInput.Text = "Input kWh";
            lblAmount.Text = "";
            // reset the text fields
            txtOffPeak.Text = "0";
            txtInput.Text = "0";
            // if any errors were set clear them
            errorProvider1.SetError(txtInput, "");
            errorProvider1.SetError(txtOffPeak, "");
            // Select the data in txtInput
            txtInput.SelectAll();
            // set focus on txtInput item
            txtInput.Focus();

        }
        // Fires when the Calculate button is clicked, will test for valid data and 
        // pass that into a method call to calculate the amount due by the client
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Set local varibles

            // Boolean values to determine client types for calculations later on
            // initialized to false as we are defaulting to a Residential client
            bool IsIndustrial = false, IsCommercial = false;

            // Varible to store the return value from the CalculateTotal method
            decimal total;

            // Varibles to store the data from input for the usage hours
            // optHours is only used if client is Industrial, set it to zero in the event it's
            // not set in the code below. The method requires a value to be passed through
            int hours = 0, opHours = 0, val;

            // Get values 

            // Check txtInput for a valid integer, if false, display error icon and select data in field
            if (Int32.TryParse(txtInput.Text, out val))
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
                // sets the boolean for Commercial if radio button is 'checked'
                IsCommercial = true;
            }
            else if (radIndustrial.Checked)
            {
                // sets the boolean for the Industrial client
                IsIndustrial = true;
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

            }

            // calculate values
            total = CalculateTotal(IsIndustrial, IsCommercial, hours, opHours);

            // display values
            lblAmount.Text = total.ToString("c");
        }

      
       
    }
}
