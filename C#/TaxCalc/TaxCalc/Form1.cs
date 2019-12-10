using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            const decimal BT15 = 2250m, BT30 = 4950M, BT50 = 9350M, BT80 = 17450M;
            const decimal SR15 = 14999.99m, SR30 = 29999.99M, SR50 = 49999.99M, SR80 = 79999.99M;
            const decimal TR15 = .15m, TR30 = .18m, TR50 = .22m, TR80 = .27m, TR80P = .33m;
            decimal salary = 0, leftover = 0, overamount = 0, taxamount = 0, total = 0;
            salary = Convert.ToDecimal(txtSalary.Text);
            while (salary != 0)
            {
                if (salary < SR15)
                {
                    taxamount = salary * TR15;
                    lbl15.Text = taxamount.ToString("c");
                    total = taxamount;
                    salary = 0;
                }
                else if (salary < SR30 && salary > SR15)
                {
                    overamount = salary - SR15;
                    taxamount = overamount * TR15;
                    total += BT15;
                    lbl30.Text = taxamount.ToString("c");
                    total += taxamount;
                    salary -= SR15;
                }
                else if (salary < SR50 && salary > SR30)
                {
                    overamount = salary - SR30;
                    taxamount = overamount * TR30;
                    lbl50.Text = taxamount.ToString("c");
                    total += taxamount;
                    salary -=SR30-SR15;
                }
                else if (salary < SR80 && salary > SR50)
                {
                    overamount = salary - SR50;
                    taxamount = overamount * TR50;
                    lbl80.Text = taxamount.ToString("c");
                    total += taxamount;
                    salary -= SR50-SR30;
                }
                else if (salary > SR80)
                {
                    overamount = salary - SR80;
                    taxamount = overamount * TR80P;
                    lbl80plus.Text = taxamount.ToString("c");
                    total += taxamount;
                    salary -= (SR80-SR50);
                }

                    lblTotal.Text = total.ToString("c");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            lbl80plus.Text = "";
            lbl80.Text = "";
            lbl50.Text = "";
            lbl30.Text = "";
            lbl15.Text = "";
        }
    }
}
