using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        const double CM_IN_INCH = 2.54;
        const int INCH_IN_FT = 12;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Convert from feet and inches to centimeters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToMetric_Click(object sender, EventArgs e)
        {
            int feet = 0, inches = 0;
            double cm = 0;
            if (Validator.IsPresent(txtFeet, "Feet") && Validator.IsNonNegativeInt32(txtFeet, "Feet") &&
                Validator.IsPresent(txtInches, "Inches") && Validator.IsNonNegativeInt32(txtInches, "Inches"))
            {

                //get feet and inches from user input
                feet = Convert.ToInt32(txtFeet.Text);
                inches = Convert.ToInt32(txtInches.Text);
                //calculate centimeters
                cm = CalculateCentimeters(feet, inches);
                //display result
                txtCent.Text = cm.ToString("f2");
            }
            
        }
        
        private double CalculateCentimeters(int f, int i)
        {
            double centimeters = 0;
            int totalInches = f * INCH_IN_FT + i;
            centimeters = totalInches * CM_IN_INCH;
            return centimeters;
        }
        /// <summary>
        /// Convert from Centimeters to Feet and Inches
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToImperial_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtCent,"Centimeters") && Validator.IsNonNegativeDouble(txtCent, "Centimeters"))
                {

                    // get centimeters
                    double cm = 0;
                    int feet, inches;
                    cm = Convert.ToDouble(txtCent.Text);
                    //calculate
                    CalculateFeetInches(cm, out feet, out inches);

                    //display
                    txtFeet.Text = feet.ToString();
                    txtInches.Text = inches.ToString();
                
            }
        }
        //convert centimetres to feet and inches
        private void CalculateFeetInches(double centimeters, out int f, out int i)
        {
            f = 0;
            i = 0;
            int totalinches = (int)Math.Round(centimeters / CM_IN_INCH);
            f = totalinches / INCH_IN_FT;
            i = totalinches % INCH_IN_FT;
        }
    }
}
