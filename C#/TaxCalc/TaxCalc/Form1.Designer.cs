namespace TaxCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl80plus = new System.Windows.Forms.Label();
            this.lbl80 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl30 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input your yearly salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(238, 27);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(277, 30);
            this.txtSalary.TabIndex = 1;
            this.txtSalary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "$0-14,999:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "$15k - $29,999.99";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "$30k - $49,999.99";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "$50k - $79,999.99";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "$80k +";
            // 
            // lbl80plus
            // 
            this.lbl80plus.Location = new System.Drawing.Point(233, 199);
            this.lbl80plus.Name = "lbl80plus";
            this.lbl80plus.Size = new System.Drawing.Size(220, 30);
            this.lbl80plus.TabIndex = 11;
            this.lbl80plus.Text = "label7";
            // 
            // lbl80
            // 
            this.lbl80.Location = new System.Drawing.Point(233, 169);
            this.lbl80.Name = "lbl80";
            this.lbl80.Size = new System.Drawing.Size(220, 30);
            this.lbl80.TabIndex = 10;
            this.lbl80.Text = "label8";
            // 
            // lbl50
            // 
            this.lbl50.Location = new System.Drawing.Point(233, 139);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(220, 30);
            this.lbl50.TabIndex = 9;
            this.lbl50.Text = "label9";
            // 
            // lbl30
            // 
            this.lbl30.Location = new System.Drawing.Point(233, 109);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(220, 30);
            this.lbl30.TabIndex = 8;
            this.lbl30.Text = "label10";
            // 
            // lbl15
            // 
            this.lbl15.Location = new System.Drawing.Point(233, 79);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(220, 30);
            this.lbl15.TabIndex = 7;
            this.lbl15.Text = "label11";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(561, 26);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(182, 31);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(760, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 31);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(233, 242);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(202, 32);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 699);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbl80plus);
            this.Controls.Add(this.lbl80);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.lbl30);
            this.Controls.Add(this.lbl15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl80plus;
        private System.Windows.Forms.Label lbl80;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl30;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotal;
    }
}

