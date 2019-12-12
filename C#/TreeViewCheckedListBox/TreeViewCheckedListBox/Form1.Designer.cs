namespace TreeViewCheckedListBox
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnTreeView = new System.Windows.Forms.Button();
            this.btnCheckedListBox = new System.Windows.Forms.Button();
            this.lblCheckedItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(432, 242);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(477, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(425, 242);
            this.treeView1.TabIndex = 1;
            // 
            // btnTreeView
            // 
            this.btnTreeView.Location = new System.Drawing.Point(477, 279);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(177, 84);
            this.btnTreeView.TabIndex = 2;
            this.btnTreeView.Text = "Populate Tree";
            this.btnTreeView.UseVisualStyleBackColor = true;
            this.btnTreeView.Click += new System.EventHandler(this.btnTreeView_Click);
            // 
            // btnCheckedListBox
            // 
            this.btnCheckedListBox.Location = new System.Drawing.Point(12, 279);
            this.btnCheckedListBox.Name = "btnCheckedListBox";
            this.btnCheckedListBox.Size = new System.Drawing.Size(177, 84);
            this.btnCheckedListBox.TabIndex = 3;
            this.btnCheckedListBox.Text = "Populate List Boxes";
            this.btnCheckedListBox.UseVisualStyleBackColor = true;
            this.btnCheckedListBox.Click += new System.EventHandler(this.btnCheckedListBox_Click);
            // 
            // lblCheckedItems
            // 
            this.lblCheckedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckedItems.Location = new System.Drawing.Point(282, 325);
            this.lblCheckedItems.Name = "lblCheckedItems";
            this.lblCheckedItems.Size = new System.Drawing.Size(99, 47);
            this.lblCheckedItems.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Items Checked";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCheckedItems);
            this.Controls.Add(this.btnCheckedListBox);
            this.Controls.Add(this.btnTreeView);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnTreeView;
        private System.Windows.Forms.Button btnCheckedListBox;
        private System.Windows.Forms.Label lblCheckedItems;
        private System.Windows.Forms.Label label1;
    }
}

