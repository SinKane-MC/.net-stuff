namespace Checkout
{
    partial class frmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 232);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qty";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(324, 42);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(324, 114);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(114, 30);
            this.txtQty.TabIndex = 4;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.Color.DimGray;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountDue.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblAmountDue.Location = new System.Drawing.Point(445, 341);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(151, 31);
            this.lblAmountDue.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(324, 185);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(114, 36);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pay Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.DimGray;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblSubtotal.Location = new System.Drawing.Point(445, 247);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(151, 31);
            this.lblSubtotal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "+5% tax";
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.DimGray;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTax.Location = new System.Drawing.Point(445, 293);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(151, 31);
            this.lblTax.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(445, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(803, 412);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCheckout";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnClear;
    }
}

