namespace RateCalc_PowerCo
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radRes = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCust = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResSum = new System.Windows.Forms.Label();
            this.lblComSum = new System.Windows.Forms.Label();
            this.lblIndSum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvCust = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Rate Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radRes);
            this.groupBox1.Location = new System.Drawing.Point(240, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(7, 79);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(102, 28);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(7, 54);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(129, 28);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radRes
            // 
            this.radRes.AutoSize = true;
            this.radRes.Location = new System.Drawing.Point(7, 29);
            this.radRes.Name = "radRes";
            this.radRes.Size = new System.Drawing.Size(120, 28);
            this.radRes.TabIndex = 0;
            this.radRes.TabStop = true;
            this.radRes.Text = "Residential";
            this.radRes.UseVisualStyleBackColor = true;
            this.radRes.CheckedChanged += new System.EventHandler(this.radRes_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(569, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 44);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(239, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 44);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(24, 246);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(105, 44);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(439, 58);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(94, 24);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "Input kWh";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(569, 58);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 29);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "0";
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // lblAmount
            // 
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Green;
            this.lblAmount.Location = new System.Drawing.Point(443, 133);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(226, 44);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(569, 94);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(100, 29);
            this.txtOffPeak.TabIndex = 5;
            this.txtOffPeak.Text = "0";
            this.txtOffPeak.Visible = false;
            this.txtOffPeak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOffPeak_KeyPress);
            this.txtOffPeak.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOffPeak_KeyUp);
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeak.Location = new System.Drawing.Point(439, 94);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(123, 24);
            this.lblOffPeak.TabIndex = 9;
            this.lblOffPeak.Text = "Off-peak kWh";
            this.lblOffPeak.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(506, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 29);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // lblTotalCust
            // 
            this.lblTotalCust.Location = new System.Drawing.Point(236, 270);
            this.lblTotalCust.Name = "lblTotalCust";
            this.lblTotalCust.Size = new System.Drawing.Size(128, 24);
            this.lblTotalCust.TabIndex = 14;
            this.lblTotalCust.Text = "0";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.Location = new System.Drawing.Point(439, 270);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(139, 24);
            this.lblTotalCharges.TabIndex = 15;
            this.lblTotalCharges.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(476, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Industrial";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(350, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Commercial";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(236, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Residential";
            // 
            // lblResSum
            // 
            this.lblResSum.Location = new System.Drawing.Point(236, 337);
            this.lblResSum.Name = "lblResSum";
            this.lblResSum.Size = new System.Drawing.Size(94, 24);
            this.lblResSum.TabIndex = 21;
            this.lblResSum.Text = "0";
            // 
            // lblComSum
            // 
            this.lblComSum.Location = new System.Drawing.Point(350, 337);
            this.lblComSum.Name = "lblComSum";
            this.lblComSum.Size = new System.Drawing.Size(97, 24);
            this.lblComSum.TabIndex = 20;
            this.lblComSum.Text = "0";
            // 
            // lblIndSum
            // 
            this.lblIndSum.Location = new System.Drawing.Point(476, 337);
            this.lblIndSum.Name = "lblIndSum";
            this.lblIndSum.Size = new System.Drawing.Size(100, 24);
            this.lblIndSum.TabIndex = 19;
            this.lblIndSum.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(437, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total Charges";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(236, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total Customers";
            // 
            // lvCust
            // 
            this.lvCust.HideSelection = false;
            this.lvCust.Location = new System.Drawing.Point(685, 21);
            this.lvCust.Name = "lvCust";
            this.lvCust.Size = new System.Drawing.Size(530, 349);
            this.lvCust.TabIndex = 24;
            this.lvCust.UseCompatibleStateImageBehavior = false;
            this.lvCust.View = System.Windows.Forms.View.Details;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1227, 382);
            this.Controls.Add(this.lvCust);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblResSum);
            this.Controls.Add(this.lblComSum);
            this.Controls.Add(this.lblIndSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblTotalCust);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOffPeak);
            this.Controls.Add(this.lblOffPeak);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Calculate Rate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radRes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.Label lblOffPeak;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResSum;
        private System.Windows.Forms.Label lblComSum;
        private System.Windows.Forms.Label lblIndSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblTotalCust;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvCust;
    }
}

