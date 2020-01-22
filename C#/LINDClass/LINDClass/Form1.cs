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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MembershipDataContext dbContext = new MembershipDataContext();
            membershipDataGridView.DataSource = dbContext.Memberships;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowNum = Convert.ToInt32(membershipDataGridView.CurrentCell.RowIndex);
            int membNum = Convert.ToInt32(membershipDataGridView["dataGridViewTextBoxColumn1", rowNum].Value);

            DialogResult answer = MessageBox.Show("Are you sure?", "Confirm",MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                using( MembershipDataContext dbContext = new MembershipDataContext())
                {
                    try
                    {
                        Membership currentMember = (from m in dbContext.Memberships
                                                    where m.MemberID == membNum
                                                    select m).Single();

                        dbContext.Memberships.DeleteOnSubmit(currentMember);
                        dbContext.SubmitChanges();
                        membershipDataGridView.DataSource = dbContext.Memberships;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModify secondFrm = new frmAddModify();

            DialogResult result = secondFrm.ShowDialog();
            using (MembershipDataContext dbContext = new MembershipDataContext())
            {
                if (result == DialogResult.OK)
                {
                    membershipDataGridView.DataSource = dbContext.Memberships;
                }
            }
                
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModify secondFrm = new frmAddModify();
            secondFrm.isModify = true;
            int rowNum = Convert.ToInt32(membershipDataGridView.CurrentCell.RowIndex);
            int membNum = Convert.ToInt32(membershipDataGridView["dataGridViewTextBoxColumn1", rowNum].Value);
            using (MembershipDataContext dbContext = new MembershipDataContext()) 
            { 
            secondFrm.currentMember = (from m in dbContext.Memberships
                                       where m.MemberID == membNum
                                       select m).Single();
            }
            
            DialogResult result = secondFrm.ShowDialog();
            using (MembershipDataContext dbContext = new MembershipDataContext())
            {
                if (result == DialogResult.OK)
                {
                    membershipDataGridView.DataSource = dbContext.Memberships;
                }
            }
        }
    }
}
