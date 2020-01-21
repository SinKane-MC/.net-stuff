using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipManagement
{
    public partial class frmUpdate : Form
    {
        public Member current; // frmMembers sets current member
        public frmUpdate()
        {
            InitializeComponent();
        }

        // as theh form loads
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            DisplayCurrentMember();
        }

        private void DisplayCurrentMember()
        {
            txtMemberID.Text = current.MemberID.ToString();
            txtMemberName.Text = current.MemberName;
            txtDateStarted.Text = current.DateStarted.ToShortDateString();
            if (current.DateEnded == null)
                txtDateEnded.Text = "";
            else
            {
                DateTime endDate = (DateTime)current.DateEnded;
                txtDateEnded.Text = endDate.ToShortDateString();
            }
        }

        // accepts changes
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidDateEnded())
            {
                // build Member object with the new data
                Member newMember = new Member();
                newMember.MemberID = current.MemberID;
                newMember.MemberName = current.MemberName;
                newMember.DateStarted = current.DateStarted;
                if (txtDateEnded.Text == "")
                    newMember.DateEnded = null;
                else
                    newMember.DateEnded = Convert.ToDateTime(txtDateEnded.Text);

                try // try to update
                {
                    if(!MemberDB.UpdateMember(current, newMember))//failed
                    {
                        MessageBox.Show("Another user has updated or " +
                                "deleted current member", "Concurrency Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        current = newMember;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating: " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        // can be empty or if provided that correct DateTime format and later than DateStarted
        private bool IsValidDateEnded()
        {
            bool valid = true; // empty is valid
            DateTime endDate;
            if(txtDateEnded.Text != "")// if not empty
            {
                if (DateTime.TryParse(txtDateEnded.Text, out endDate))//valid date
                {
                    DateTime startDate = Convert.ToDateTime(txtDateStarted.Text);
                    if(startDate >= endDate)
                    {
                        valid = false;
                        MessageBox.Show("Date Ended must be later than Date Started", "Data Error");
                        txtDateEnded.SelectAll();
                        txtDateEnded.Focus();                 
                    }
                }
                else
                {
                    valid = false;
                    MessageBox.Show("Please enter Date Ended in format YYYY-MM-DD", "Data Error");
                    txtDateEnded.SelectAll();
                    txtDateEnded.Focus();
                }                  
            }
            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form
        }
    } // class
}// namespace
