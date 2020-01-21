using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * In MMABooks:
 create table Membership(
  MemberID int primary key identity,
  MemberName varchar(40) not null,
  DateStarted datetime not null,
  DateEnded datetime
 ) 

 insert into Membership values
 ('Ann', '2018-11-21', '2019-04-10'),
 ('Bob', '2019-01-20', null),
 ('Chris', '2019-02-05', '2019-04-11'),
 ('Dana', '2019-02-07', null)
 */
namespace MembershipManagement
{
    public partial class frmMembers : Form
    {
        Member current = null; // current member
        List<int> memberIDs = null; // all members IDs

        public frmMembers()
        {
            InitializeComponent();
        }

        // populate combo bod as the form loads
        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            memberIDs = MemberDB.GetMemberIDs();
            if (memberIDs.Count > 0) // if there are members
            {
                cboMemberID.DataSource = memberIDs;
                cboMemberID.SelectedIndex = 0; // triggers SelectedIndexChanged
            }
            else // no members
            {
                MessageBox.Show("There are no members. " +
                    "Add some members in the database, and restart the application ", "Empty Load");
                Application.Exit();
            }
        }
        

        // member selection  changes
        private void cboMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID = (int)cboMemberID.SelectedValue;
            try
            {
                current = MemberDB.GetMemberByID(selectedID);
                DisplayCurrentMemberData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving member with selected ID: " + ex.Message, 
                    ex.GetType().ToString());
            }
        }

        private void DisplayCurrentMemberData()
        {
            if (current != null)
            {
                txtName.Text = current.MemberName;
                txtDateStarted.Text = current.DateStarted.ToShortDateString();
                if (current.DateEnded == null)
                {
                    txtDateEnded.Text = "";
                }
                else
                {
                    DateTime endDate = (DateTime)current.DateEnded;
                    txtDateEnded.Text = endDate.ToShortDateString();
                }
            }
            else // null - this customer does not exist - need to refresh combo box
                LoadComboBox();
        }



        // user wants to update DateEnded of the current member
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate secondForm = new frmUpdate();
            secondForm.current = current; // set current member on the second form
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if(result == DialogResult.OK)
            {
                current = secondForm.current; // receive current member from the second form             
            }
            else if(result == DialogResult.Retry)
            {
                current = MemberDB.GetMemberByID(current.MemberID);
            }
            DisplayCurrentMemberData();
        }


        // terminate application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
