using BankingData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Form1 : Form
    {
        // form-level list of accounts
        List<Account> accounts = new List<Account>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Create new Acct and add to list
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // get intial balance
            decimal initBalance = Convert.ToDecimal(txtInitial.Text);
            // create new acct
            Account acct = new Account(initBalance);
            // add to list
            accounts.Add(acct);
            DisplayAccts();
        }

        private void DisplayAccts()
        {
            lstAccounts.Items.Clear();
            foreach (Account a in accounts)
                lstAccounts.Items.Add(a);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // get amount
            decimal depAmount = Convert.ToDecimal(txtAmount.Text);

            // get account
            Account acct = GetSelectedAcct();
            // deposit amount
                
            if(acct != null)
            {
                acct.Deposit(depAmount);
                DisplayAccts();
            }

            // update list


        }

        private Account GetSelectedAcct()
        {
            Account selectedAcct = null;
            int selected = lstAccounts.SelectedIndex;
            if (selected < 0)
            {
                MessageBox.Show("Please select an Account first");
            }
            else
            {
                selectedAcct = accounts[selected];
            }
            return selectedAcct;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // get amount
            decimal withdrawAmount = Convert.ToDecimal(txtAmount.Text);

            // get account
            Account acct = GetSelectedAcct();
            // deposit amount
            bool result;
            if (acct != null)
            {
                result = acct.Withdrawl(withdrawAmount);

                if (!result)
                {
                    DisplayAccts();
                }
                else
                {
                    MessageBox.Show("You cannot withdraw more than you have in the account!");
                }
            }
        }
    }
}
