using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            decimal cashIN;
            decimal toonie, loonie;
            cashIN = Convert.ToDecimal(txtCash.Text);
            cashIN = Math.Round(cashIN * 20) / 20;

            decimal quarters = 0, dimes = 0, nickels = 0;
            while (cashIN >=2.00m)
            {
                toonie = Math.Truncate((cashIN / 2.00m));
                cashIN = cashIN % 2.00m;
                lblToonies.Text = toonie.ToString();
            } while (cashIN >= 1.00m)
            {
                loonie = Math.Truncate((cashIN / 1.00m));
                cashIN = cashIN % 1.00m;
                lblLoonies.Text = loonie.ToString();
            }
            while (cashIN >= 0.25m)
            {
                quarters = Math.Truncate((cashIN / 0.25m));
                cashIN = cashIN % 0.25m;
                lblQuater.Text = quarters.ToString();
            }

            while (cashIN >= 0.10m)
            {
                dimes = Math.Truncate((cashIN / 0.10m));
                cashIN = cashIN % 0.10m;
                lblDime.Text = dimes.ToString();
            }

            while (cashIN >= 0.05m)
            {
                Console.WriteLine(cashIN);
                nickels = Math.Truncate(cashIN / 0.05m);
                cashIN = cashIN % 0.05m;

                lblNickel.Text = nickels.ToString();
                
            }

        }
    }
}
