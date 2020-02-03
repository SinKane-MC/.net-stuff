using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_HeatConversion
{
    public partial class Conversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sFrom, sTo;
            sFrom = ddlFrom.Text;
            sTo = ddlTo.Text;
            decimal initValue, result=0;
            initValue = Convert.ToDecimal(txtInput.Text);
            
            switch (sFrom)
            {
                case "Celsius":
                    if(sTo == "Fahrenheit")
                    {
                        result = ((initValue * 9) / 5 + 32);
                        if (result < 33 ) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }else if( result > 86) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = result.ToString("f2");
                    }else if (sTo=="Kelvin") 
                    {
                        result = (initValue + 273.15m);
                        if (result < 273.15m) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }
                        else if (result > 303.15m) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = result.ToString("f2");
                    }
                    else
                    {
                        result = initValue;
                        if (result < 0) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }
                        else if (result > 30) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = initValue.ToString("f2");
                    }

                    break;
                case "Fahrenheit":
                    if (sTo == "Celsius")
                    {
                        result = ((initValue - 32) * 5 / 9);
                        if (result < 33) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }
                        else if (result > 86) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = result.ToString("f2");
                    }else if (sTo == "Kelvin")
                    {
                        result = ((initValue - 32) * 5 / 9 + 273.15m);
                        if (result < 273.15m) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }
                        else if (result > 303.15m) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = result.ToString("f2");
                    }
                    else
                    {
                        result = initValue;
                        if (result < 33) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }
                        else if (result > 86) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = initValue.ToString("f2");
                    }


                    break;
                case "Kelvin":
                    if(sTo == "Celsius")
                    {
                        result = (initValue - 273.15m);
                        if (result < 0) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }
                        else if (result > 30) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = result.ToString("f2");
                    } else if(sTo == "Fahrenheit")
                    {
                        result = ((initValue - 273.15m) * 9 / 5 + 32);
                        if (result < 33) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }
                        else if (result > 86) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = result.ToString("f2");
                    } else
                    {
                        if (initValue < 0)
                            initValue = 0; // technically nothing is colder than absolute zero Kelvin
                        result = initValue;
                        if (result < 273.15m) // 0 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Blue;
                        }
                        else if (result > 303.15m) // 30 Celsius
                        {
                            lblResult.ForeColor = System.Drawing.Color.Orange;
                        }
                        else
                        {
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        }
                        lblResult.Text = initValue.ToString("f2");
                    }
                    break;


            }



        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            
            txtInput.Text = "";
            ddlFrom.SelectedValue = "Celsius";
            ddlTo.SelectedValue = "Fahrenheit";
        }

       
    }
}