using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINDClass
{
    public partial class frmAddModify : Form
    {
        public bool isModify;
        public Membership currentMember;
        DateTime? tmpDate;
        public frmAddModify()
        {
            InitializeComponent();
        }

        private void frmAddModify_Load(object sender, EventArgs e)
        {
            if (isModify)
            {
                memberNameTextBox.Text = currentMember.MemberName;
                memberIDTextBox.Text = currentMember.MemberID.ToString();
                dateStartedDateTimePicker.Value = currentMember.DateStarted;
                if (currentMember.DateEnded != null)
                {
                    dateEndedDateTimePicker.Value = Convert.ToDateTime(currentMember.DateEnded);
                }else
                {
                    dateEndedDateTimePicker.CustomFormat = " ";
                    dateEndedDateTimePicker.Format = DateTimePickerFormat.Custom;
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            using (MembershipDataContext dbContext = new MembershipDataContext())
            {
                if (isModify)
                {
                    Membership memb = dbContext.Memberships.Single(m => m.MemberID == Convert.ToInt32(memberIDTextBox.Text));
                    memb.MemberName = (memberNameTextBox.Text).ToString();
                    memb.DateStarted = Convert.ToDateTime(dateStartedDateTimePicker.Value);
                    memb.DateEnded = tmpDate;
                }
                else
                {
                    Membership newMember = new Membership
                    {
                        MemberName = (memberNameTextBox.Text).ToString(),
                        DateStarted = Convert.ToDateTime(dateStartedDateTimePicker.Value),
                        DateEnded = tmpDate
                    };
                    dbContext.Memberships.InsertOnSubmit(newMember);
                }
                dbContext.SubmitChanges();

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateEndedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if( dateEndedDateTimePicker.Value != null)
            {
                dateEndedDateTimePicker.Enabled = true;
                dateEndedDateTimePicker.Format = DateTimePickerFormat.Long;
                tmpDate = dateEndedDateTimePicker.Value;
            }
        }

        private void dateEndedDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                dateEndedDateTimePicker.CustomFormat = " ";
                dateEndedDateTimePicker.Format = DateTimePickerFormat.Custom;
                tmpDate = null;
            }
        }
    }
}
