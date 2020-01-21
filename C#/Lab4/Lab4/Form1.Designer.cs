namespace Lab4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblProdID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveDate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Shipped Date";
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtShippedDate.Location = new System.Drawing.Point(191, 164);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(324, 30);
            this.dtShippedDate.TabIndex = 14;
            this.dtShippedDate.ValueChanged += new System.EventHandler(this.dtShippedDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(191, 205);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(324, 21);
            this.lblOrderTotal.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(18, 129);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(136, 25);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Required Date";
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRequiredDate.Location = new System.Drawing.Point(191, 133);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(324, 21);
            this.lblRequiredDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Order Date";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderDate.Location = new System.Drawing.Point(191, 98);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(324, 21);
            this.lblOrderDate.TabIndex = 6;
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Location = new System.Drawing.Point(21, 60);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(121, 25);
            this.lblProdID.TabIndex = 7;
            this.lblProdID.Text = "Customer ID";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerID.Location = new System.Drawing.Point(191, 64);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(324, 21);
            this.lblCustomerID.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Order ID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderID.Location = new System.Drawing.Point(191, 29);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(324, 21);
            this.lblOrderID.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(194, 244);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveDate
            // 
            this.btnSaveDate.Enabled = false;
            this.btnSaveDate.Location = new System.Drawing.Point(535, 164);
            this.btnSaveDate.Name = "btnSaveDate";
            this.btnSaveDate.Size = new System.Drawing.Size(75, 36);
            this.btnSaveDate.TabIndex = 16;
            this.btnSaveDate.Text = "Save";
            this.btnSaveDate.UseVisualStyleBackColor = true;
            this.btnSaveDate.Click += new System.EventHandler(this.btnSaveDate_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(535, 244);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 36);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(616, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 643);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSaveDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtShippedDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblProdID);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRequiredDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtShippedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRequiredDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
    }
}

