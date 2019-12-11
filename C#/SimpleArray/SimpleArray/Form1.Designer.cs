namespace SimpleArray
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.gbStuff = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbStuff.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 25;
            this.lstNumbers.Location = new System.Drawing.Point(687, 105);
            this.lstNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(285, 454);
            this.lstNumbers.TabIndex = 0;
            // 
            // gbStuff
            // 
            this.gbStuff.Controls.Add(this.label2);
            this.gbStuff.Controls.Add(this.label3);
            this.gbStuff.Controls.Add(this.lblSum);
            this.gbStuff.Controls.Add(this.lblCount);
            this.gbStuff.Controls.Add(this.button1);
            this.gbStuff.Controls.Add(this.txtInput);
            this.gbStuff.Controls.Add(this.label1);
            this.gbStuff.Location = new System.Drawing.Point(65, 105);
            this.gbStuff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStuff.Name = "gbStuff";
            this.gbStuff.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStuff.Size = new System.Drawing.Size(563, 321);
            this.gbStuff.TabIndex = 1;
            this.gbStuff.TabStop = false;
            this.gbStuff.Text = "Enter numbers";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(779, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter value";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(184, 56);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(158, 30);
            this.txtInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(179, 205);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(163, 25);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(179, 234);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(163, 25);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sum";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 622);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbStuff);
            this.Controls.Add(this.lstNumbers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbStuff.ResumeLayout(false);
            this.gbStuff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.GroupBox gbStuff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblCount;
    }
}

