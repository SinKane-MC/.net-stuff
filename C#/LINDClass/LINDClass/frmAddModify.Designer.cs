namespace LINDClass
{
    partial class frmAddModify
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
            System.Windows.Forms.Label dateEndedLabel;
            System.Windows.Forms.Label dateStartedLabel;
            System.Windows.Forms.Label memberIDLabel;
            System.Windows.Forms.Label memberNameLabel;
            this.dateEndedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateStartedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            dateEndedLabel = new System.Windows.Forms.Label();
            dateStartedLabel = new System.Windows.Forms.Label();
            memberIDLabel = new System.Windows.Forms.Label();
            memberNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEndedLabel
            // 
            dateEndedLabel.AutoSize = true;
            dateEndedLabel.Location = new System.Drawing.Point(12, 95);
            dateEndedLabel.Name = "dateEndedLabel";
            dateEndedLabel.Size = new System.Drawing.Size(87, 17);
            dateEndedLabel.TabIndex = 1;
            dateEndedLabel.Text = "Date Ended:";
            // 
            // dateStartedLabel
            // 
            dateStartedLabel.AutoSize = true;
            dateStartedLabel.Location = new System.Drawing.Point(12, 67);
            dateStartedLabel.Name = "dateStartedLabel";
            dateStartedLabel.Size = new System.Drawing.Size(92, 17);
            dateStartedLabel.TabIndex = 3;
            dateStartedLabel.Text = "Date Started:";
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Enabled = false;
            memberIDLabel.Location = new System.Drawing.Point(12, 9);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(80, 17);
            memberIDLabel.TabIndex = 5;
            memberIDLabel.Text = "Member ID:";
            // 
            // memberNameLabel
            // 
            memberNameLabel.AutoSize = true;
            memberNameLabel.Location = new System.Drawing.Point(12, 37);
            memberNameLabel.Name = "memberNameLabel";
            memberNameLabel.Size = new System.Drawing.Size(104, 17);
            memberNameLabel.TabIndex = 7;
            memberNameLabel.Text = "Member Name:";
            // 
            // dateEndedDateTimePicker
            // 
            this.dateEndedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.membershipBindingSource, "DateEnded", true));
            this.dateEndedDateTimePicker.Location = new System.Drawing.Point(122, 91);
            this.dateEndedDateTimePicker.Name = "dateEndedDateTimePicker";
            this.dateEndedDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateEndedDateTimePicker.TabIndex = 2;
            this.dateEndedDateTimePicker.ValueChanged += new System.EventHandler(this.dateEndedDateTimePicker_ValueChanged);
            this.dateEndedDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateEndedDateTimePicker_KeyPress);
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataSource = typeof(LINDClass.Membership);
            // 
            // dateStartedDateTimePicker
            // 
            this.dateStartedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.membershipBindingSource, "DateStarted", true));
            this.dateStartedDateTimePicker.Location = new System.Drawing.Point(122, 63);
            this.dateStartedDateTimePicker.Name = "dateStartedDateTimePicker";
            this.dateStartedDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateStartedDateTimePicker.TabIndex = 4;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipBindingSource, "MemberID", true));
            this.memberIDTextBox.Enabled = false;
            this.memberIDTextBox.Location = new System.Drawing.Point(122, 6);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.memberIDTextBox.TabIndex = 6;
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipBindingSource, "MemberName", true));
            this.memberNameTextBox.Location = new System.Drawing.Point(122, 34);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.memberNameTextBox.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(52, 136);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 35);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(dateEndedLabel);
            this.Controls.Add(this.dateEndedDateTimePicker);
            this.Controls.Add(dateStartedLabel);
            this.Controls.Add(this.dateStartedDateTimePicker);
            this.Controls.Add(memberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(memberNameLabel);
            this.Controls.Add(this.memberNameTextBox);
            this.Name = "frmAddModify";
            this.Text = "frmAddModify";
            this.Load += new System.EventHandler(this.frmAddModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource membershipBindingSource;
        private System.Windows.Forms.DateTimePicker dateEndedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateStartedDateTimePicker;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox memberNameTextBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}