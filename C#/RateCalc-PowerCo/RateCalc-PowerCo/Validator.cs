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
        // Checks and returns a boolean vlaue based on the presence of data in a text field
        public static bool IsPresent(TextBox tb, string name)
        {
            bool valid=true;
            if (tb.Text == "")
            {
                valid = false;
                MessageBox.Show(name + " is required", "Input error");
                tb.Focus();
            }
            return valid;
        }

        public static bool IsInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
        public static bool IsNonNegativeInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }else if (val < 0)
            {
                valid = false;
                MessageBox.Show(name + " must be postive or zero", "Input error");
                tb.SelectAll();
                tb.Focus();
            }

            return valid;

        }
        public static bool IsDouble(TextBox tb, string name)
        {
            bool valid = true;
            double val;
            if (!Double.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool valid = true;
            double val;
            if (!Double.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                valid = false;
                MessageBox.Show(name + " must be postive or zero", "Input error");
                tb.SelectAll();
                tb.Focus();
            }

            return valid;

        }
        public static bool IsDecimal(TextBox tb, string name)
        {
            bool valid = true;
            decimal val;
            if (!Decimal.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool valid = true;
            decimal val;
            if (!Decimal.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                valid = false;
                MessageBox.Show(name + " must be postive or zero", "Input error");
                tb.SelectAll();
                tb.Focus();
            }

            return valid;

        }


    }
}
