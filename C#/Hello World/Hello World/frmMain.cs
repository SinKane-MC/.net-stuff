using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Visible  == true)
            {
                lblDisplay.Visible = false;
                btnMessage.Text = "Show Message";
                //System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                lblDisplay.Visible = true;
                btnMessage.Text = "Hide Message";
                //System.Media.SystemSounds.Beep.Play();
            }
            if (txtName.Text != "")
            {
                lblDisplay.Text = "Hello World! Welcome " + txtName.Text;
            }
            else
            {
                lblDisplay.Text = "Hello World!";
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Hello World!";
            lblDisplay.Visible = false;
            btnMessage.Text = "Show Message";
            txtName.Text = "";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
