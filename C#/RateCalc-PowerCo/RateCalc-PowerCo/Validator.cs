using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RateCalc_PowerCo
{
    // Repo of Validation Methods
    public static class Validator
    {
        // Checks and returns a boolean value based on the presence of data in a text field
        public static bool IsPresent(TextBox tb, string name)
        {
            // Create return boolean variable and assume the test will pass
            bool valid =true;
            if (tb.Text == "")
            {
                // no text exists, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " is required", "Input error");
                // set focus on hte element mising information
                tb.Focus();
            }
            // return result to calling method
            return valid;
        }

        // Checks and returns a boolean value based on testing if the data in a text field is a valid Integer
        public static bool IsInt32(TextBox tb, string name)
        {
            // Create return boolean variable and assume the test will pass
            bool valid = true;
            // initialize the OUT variable we use in the TryParse method for its return if the test passes
            int val;
            if (!Int32.TryParse(tb.Text, out val))
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be a whole number", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }
            // return result to calling method
            return valid;
        }

        // checks and returns a boolean value based on testing data in textbox is a valid (non negative) integer
        public static bool IsNonNegativeInt32(TextBox tb, string name)
        {
            // Create return boolean variable and assume the test will pass
            bool valid = true;
            // initialize the OUT variable we use in the TryParse method for its return if the test passes
            int val;
            // first make sure the data is even an integer
            if (!Int32.TryParse(tb.Text, out val))
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be a whole number", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }else if (val < 0) // if it is a number, check to see if it's non negative
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be postive or zero", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }
            // return result to calling method
            return valid;

        }

        // checks and returns a boolean value based on testing data in textbox is of a double data type
        public static bool IsDouble(TextBox tb, string name)
        {
            // Create return boolean variable and assume the test will pass
            bool valid = true;
            // initialize the OUT variable we use in the TryParse method for its return if the test passes
            double val;
            if (!Double.TryParse(tb.Text, out val))
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be a number", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }
            // return result to calling method
            return valid;
        }
        // checks and returns a boolean value based on testing data in textbox is a valid (non negative) double data type
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            // Create return boolean variable and assume the test will pass
            bool valid = true;
            // initialize the OUT variable we use in the TryParse method for its return if the test passes
            double val;
            // First check if data is even a double
            if (!Double.TryParse(tb.Text, out val))
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be a whole number", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }
            else if (val < 0) // if it is a double, verify it's a non negative value
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be postive or zero", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }
            // return result to calling method
            return valid;

        }
        // checks and returns a boolean value based on testing data in textbox is a decimal data type
        public static bool IsDecimal(TextBox tb, string name)
        {
            // Create return boolean variable and assume the test will pass
            bool valid = true;
            // initialize the OUT variable we use in the TryParse method for its return if the test passes
            decimal val;

            if (!Decimal.TryParse(tb.Text, out val))
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be a number", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }
            // return result to calling method
            return valid;
        }
        // checks and returns a boolean value based on testing data in textbox is a valid (non negative) decimal data type
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            // Create return boolean variable and assume the test will pass
            bool valid = true;
            // initialize the OUT variable we use in the TryParse method for its return if the test passes
            decimal val;
            // First test if it's a valid decimal number
            if (!Decimal.TryParse(tb.Text, out val))
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be a whole number", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }
            else if (val < 0) // if it is a valid decimal number, verify it's non negative
            {
                // test failed, set return to false
                valid = false;
                // display a message for the user
                MessageBox.Show(name + " must be postive or zero", "Input error");
                // select the offending data in textbox
                tb.SelectAll();
                // set the focus to the textbox
                tb.Focus();
            }
            // return result to calling method
            return valid;
        }
    }
}
