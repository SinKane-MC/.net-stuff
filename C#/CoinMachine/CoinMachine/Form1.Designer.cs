namespace CoinMachine
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
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToonies = new System.Windows.Forms.Label();
            this.lblLoonies = new System.Windows.Forms.Label();
            this.lblQuater = new System.Windows.Forms.Label();
            this.lblDime = new System.Windows.Forms.Label();
            this.lblNickel = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the amount of $";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(281, 21);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(178, 34);
            this.txtCash.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toonies";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(49, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loonies";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(49, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quarters";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(49, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dimes";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(49, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nickels";
            // 
            // lblToonies
            // 
            this.lblToonies.Location = new System.Drawing.Point(195, 101);
            this.lblToonies.Name = "lblToonies";
            this.lblToonies.Size = new System.Drawing.Size(107, 21);
            this.lblToonies.TabIndex = 7;
            // 
            // lblLoonies
            // 
            this.lblLoonies.Location = new System.Drawing.Point(195, 130);
            this.lblLoonies.Name = "lblLoonies";
            this.lblLoonies.Size = new System.Drawing.Size(107, 21);
            this.lblLoonies.TabIndex = 8;
            // 
            // lblQuater
            // 
            this.lblQuater.Location = new System.Drawing.Point(195, 162);
            this.lblQuater.Name = "lblQuater";
            this.lblQuater.Size = new System.Drawing.Size(107, 21);
            this.lblQuater.TabIndex = 9;
            // 
            // lblDime
            // 
            this.lblDime.Location = new System.Drawing.Point(195, 194);
            this.lblDime.Name = "lblDime";
            this.lblDime.Size = new System.Drawing.Size(107, 21);
            this.lblDime.TabIndex = 10;
            // 
            // lblNickel
            // 
            this.lblNickel.Location = new System.Drawing.Point(195, 226);
            this.lblNickel.Name = "lblNickel";
            this.lblNickel.Size = new System.Drawing.Size(107, 21);
            this.lblNickel.TabIndex = 11;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(498, 21);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(170, 34);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(726, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 34);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 709);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblNickel);
            this.Controls.Add(this.lblDime);
            this.Controls.Add(this.lblQuater);
            this.Controls.Add(this.lblLoonies);
            this.Controls.Add(this.lblToonies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToonies;
        private System.Windows.Forms.Label lblLoonies;
        private System.Windows.Forms.Label lblQuater;
        private System.Windows.Forms.Label lblDime;
        private System.Windows.Forms.Label lblNickel;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
    }
}

