using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkout
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare Variables
            int qty;
            decimal price, payAmount, taxAmount, subtotal;
            const decimal TAX_PCT = 0.05m;
            if (Validator.IsPresent(txtPrice, "Price") && Validator.IsNonNegativeDecimal(txtPrice, "Price")&&
                Validator.IsPresent(txtQty, "Quantity") && Validator.IsNonNegativeDecimal(txtQty, "Quantity"))
            {
                // set Qty and Price
                price = Convert.ToDecimal(txtPrice.Text);
                qty = Convert.ToInt32(txtQty.Text);
                //Calculate the output
                subtotal = price * qty;
                taxAmount = subtotal * TAX_PCT;
                payAmount = subtotal + taxAmount;
                //set the Label to display the amount
                lblSubtotal.Text = subtotal.ToString("c");
                lblTax.Text = taxAmount.ToString("c");
                lblAmountDue.Text = payAmount.ToString("c");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblAmountDue.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtPrice.Focus();
        }
    }
}
