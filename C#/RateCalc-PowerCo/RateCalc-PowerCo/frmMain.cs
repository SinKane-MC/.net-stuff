using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RateCalc_PowerCo
{
    public partial class frmMain : Form
    {
        const decimal RES_FLAT = 6.00m, RES_PER_HOUR = 0.52m;
        const decimal COM_FLAT = 60.00m, COM_PER_HOUR = 0.045m;
        const int BASE_HOURS = 1000;
        const decimal IND_PK_FLAT = 76.00m, IND_PK_PER_HOUR = 0.065m, IND_OP_FLAT = 40.00m, IND_OP_PER_HOUR = 0.028m;
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            if (radIndustrial.Checked)
            {
                lblOffPeak.Visible = true;
                txtOffPeak.Visible = true;
                lblInput.Text = "Peak kWh";
            }
            else
            {
                lblOffPeak.Visible = false;
                txtOffPeak.Visible = false;
                lblInput.Text = "Input kWh";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radRes.Select();
            txtInput.Text = "0";
            lblInput.Text = "Input kWh";
            lblAmount.Text = "";
            //btnCalculate.Enabled = false;
            txtOffPeak.Text = "0";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (radRes.Checked)
            {
                decimal resAmount;
                resAmount = RES_FLAT + (RES_PER_HOUR * Convert.ToDecimal(txtInput.Text));
                lblAmount.Text = resAmount.ToString("c");
            }else if (radCommercial.Checked)
            {
                decimal comAmount;
                int comHours;
                if (Convert.ToInt32(txtInput.Text) > BASE_HOURS)
                {
                    comHours = Convert.ToInt32(txtInput.Text) - BASE_HOURS;
                    comAmount = comHours * COM_PER_HOUR;
                    comAmount += COM_FLAT;
                }
                else
                {
                    comAmount = COM_FLAT;
                }
                lblAmount.Text = comAmount.ToString("c");
            }else if (radIndustrial.Checked)
            {
                decimal indAmountPK, indAmountOP,indTotal;
                int indHoursPK, indHoursOP;
                if (Convert.ToInt32(txtInput.Text) > BASE_HOURS)
                {
                    indHoursPK = Convert.ToInt32(txtInput.Text) - BASE_HOURS;
                    indAmountPK = (indHoursPK * IND_PK_PER_HOUR)+IND_PK_FLAT;
                    
                }
                else
                {
                    indAmountPK = IND_PK_FLAT;
                }
                if (Convert.ToInt32(txtOffPeak.Text) > BASE_HOURS)
                {
                    indHoursOP = Convert.ToInt32(txtOffPeak.Text) - BASE_HOURS;
                    indAmountOP = (indHoursOP * IND_OP_PER_HOUR) + IND_OP_FLAT;
                }else
                {
                    indAmountOP = IND_OP_FLAT;
                }
                indTotal = indAmountPK + indAmountOP;
                lblAmount.Text = indTotal.ToString("c");
            }
            
        }


        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //btnCalculate.Enabled = !string.IsNullOrWhiteSpace(txtInput.Text);
        }

       
    }
}
