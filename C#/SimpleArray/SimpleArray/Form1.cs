using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleArray
{
    public partial class Form1 : Form
    {
        // form level varibles
        const int MAX_SIZE = 20;
        decimal[] numbers = new decimal[MAX_SIZE];
        int count = 0;
        decimal sum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // local variables
            decimal nextNum = Convert.ToDecimal(txtInput.Text);

            numbers[count] = nextNum;
            count++;
            sum += nextNum;
            DisplayNumbers();
            if (count == MAX_SIZE)
            {
                DisableAdd();
            }
            
            
           
        }

        private void DisableAdd()
        {
            gbStuff.Enabled = false;
        }

        private void DisplayNumbers()
        {
            lstNumbers.Items.Clear();
            for(int i =0; i< count; i++)
            {
                lstNumbers.Items.Add(numbers[i]);
                
            }
            lblCount.Text = count.ToString();
            lblSum.Text = (sum / count).ToString("f3");
        }
    }
}
