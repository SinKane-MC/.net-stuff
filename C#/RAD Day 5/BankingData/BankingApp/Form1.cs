using BankingData; // our class library
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
        // form-level variables
        List<Account> accounts = new List<Account>(); // empty list
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // close form and terminate
        }

        // create new account and  add to the list
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // get initial balance (skipping validation)
            decimal initial = Convert.ToDecimal(txtInitial.Text);
            // create another account
            Account acct = new Account(initial);
            // add to the list
            accounts.Add(acct);
            DisplayAccounts();
        }

        private void DisplayAccounts()
        {
            lstAccounts.Items.Clear(); // clear the list box
            foreach (Account a in accounts)
                lstAccounts.Items.Add(a);
        }

        // perform deposit on selected account
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Account acct = GetSelectedAccount();
            decimal amount = Convert.ToDecimal(txtAmount.Text); // skipping validation
            if (acct != null)
            {
                acct.Deposit(amount);
                DisplayAccounts();
            }
        }

        private Account GetSelectedAccount()
        {
            Account selectedAcct = null; // no selection
            int selectedIndex = lstAccounts.SelectedIndex;
            if (selectedIndex < 0)// user did not select
            {
                MessageBox.Show("You need to select an account from the list");
            }
            else // user selected
            {
                selectedAcct = accounts[selectedIndex];
            }
            return selectedAcct;
        }

        // perform withdraw from selected account
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Account acct = GetSelectedAccount();
            decimal amount = Convert.ToDecimal(txtAmount.Text); // skipping validation
            bool result;
            if (acct != null)
            {
                result = acct.Withdraw(amount);
                if(!result)
                {
                    MessageBox.Show("Cannot withdraw more than balance");
                }
                DisplayAccounts();
            }
        }
    }
}
