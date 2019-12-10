using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Uses salary to calculate tax based on the following rules:
         * 
         * SalaryRange:                    Base Tax:            Percent on Excess:
         * 0.00 - 14,999,99                 0                    15
         * 15,000 = 29,999.99               2,250                18
         * 30,000 - 49,999.99               4,950                22
         * 50,000 - 79,999.99               9,350               27
         * 80,000 or more                   17,450               33
         */
        private void btnTaxCalculation_Click(object sender, EventArgs e)
        {
            //tax brackets and percents
            const double PCT_LEVEL0 = 0.15;
            const double LEVEL1 = 15000;
            const double TAX_LEVEL1 = 2250;
            const double PCT_LEVEL1 = 0.18;
            const double LEVEL2 = 30000;
            const double TAX_LEVEL2 = 4950;
            const double PCT_LEVEL2 = 0.22;
            const double LEVEL3 = 50000;
            const double TAX_LEVEL3 = 9350;
            const double PCT_LEVEL3 = 0.27;
            const double LEVEL4 = 80000;
            const double TAX_LEVEL4 = 17450;
            const double PCT_LEVEL4 = 0.33;

            double salary;
            double taxAmount;

            salary = Convert.ToDouble(txtSalary.Text);

            if (salary < LEVEL1)
                taxAmount = PCT_LEVEL0 * salary;
            else if (salary < LEVEL2)
                taxAmount = TAX_LEVEL1 + PCT_LEVEL1 * (salary - LEVEL1);
            else if (salary < LEVEL3)
                taxAmount = TAX_LEVEL2 + PCT_LEVEL2 * (salary - LEVEL2);
            else if (salary < LEVEL4)
                taxAmount = TAX_LEVEL3 + PCT_LEVEL3 * (salary - LEVEL3);
            else // salary >= LEVEL4
                taxAmount = TAX_LEVEL4 + PCT_LEVEL4 * (salary - LEVEL4);

            txtTaxAmount.Text = taxAmount.ToString("c");
        }
    }
}
