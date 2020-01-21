namespace LINQ_to_SQL_Demo
{
    partial class frmAddModifyProduct
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label onHandQuantityLabel;
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label unitPriceLabel;
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onHandQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            onHandQuantityLabel = new System.Windows.Forms.Label();
            productCodeLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(70, 62);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // onHandQuantityLabel
            // 
            onHandQuantityLabel.AutoSize = true;
            onHandQuantityLabel.Location = new System.Drawing.Point(23, 155);
            onHandQuantityLabel.Name = "onHandQuantityLabel";
            onHandQuantityLabel.Size = new System.Drawing.Size(140, 20);
            onHandQuantityLabel.TabIndex = 3;
            onHandQuantityLabel.Text = "On Hand Quantity:";
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(53, 18);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(110, 20);
            productCodeLabel.TabIndex = 5;
            productCodeLabel.Text = "Product Code:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(82, 113);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(81, 20);
            unitPriceLabel.TabIndex = 7;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(181, 59);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(441, 26);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.Tag = "Description";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LINQ_to_SQL_Demo.Product);
            // 
            // onHandQuantityTextBox
            // 
            this.onHandQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "OnHandQuantity", true));
            this.onHandQuantityTextBox.Location = new System.Drawing.Point(181, 155);
            this.onHandQuantityTextBox.Name = "onHandQuantityTextBox";
            this.onHandQuantityTextBox.Size = new System.Drawing.Size(119, 26);
            this.onHandQuantityTextBox.TabIndex = 4;
            this.onHandQuantityTextBox.Tag = "On Hand Quantity";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(181, 12);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(119, 26);
            this.productCodeTextBox.TabIndex = 6;
            this.productCodeTextBox.Tag = "Product Code";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(181, 107);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(119, 26);
            this.unitPriceTextBox.TabIndex = 8;
            this.unitPriceTextBox.Tag = "Unit Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(57, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(516, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 38);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 286);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(onHandQuantityLabel);
            this.Controls.Add(this.onHandQuantityTextBox);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddModifyProduct";
            this.Text = "frmAddModufyProduct";
            this.Load += new System.EventHandler(this.frmAddModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox onHandQuantityTextBox;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}