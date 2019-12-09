namespace Hello_World
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(24, 26);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(239, 46);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Hello World!";
            this.lblDisplay.Visible = false;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(32, 276);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(181, 38);
            this.btnMessage.TabIndex = 1;
            this.btnMessage.Text = "Show Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "What is your name?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(302, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 30);
            this.txtName.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(302, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 38);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(529, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnMessage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(693, 339);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.lblDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "My First C# App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

