namespace ProductSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label onHandQuantityLabel;
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.onHandQuantityTextBox = new System.Windows.Forms.TextBox();
            this.searchByCodeToolStrip = new System.Windows.Forms.ToolStrip();
            this.productCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productCodeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchByCodeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMABooksDataSet = new ProductSearch.MMABooksDataSet();
            this.productsTableAdapter = new ProductSearch.MMABooksDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new ProductSearch.MMABooksDataSetTableAdapters.TableAdapterManager();
            productCodeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            onHandQuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            this.searchByCodeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = null;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = null;
            this.productsBindingNavigator.MoveLastItem = null;
            this.productsBindingNavigator.MoveNextItem = null;
            this.productsBindingNavigator.MovePreviousItem = null;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.productsBindingNavigator.PositionItem = null;
            this.productsBindingNavigator.Size = new System.Drawing.Size(1018, 27);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(32, 83);
            productCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(138, 25);
            productCodeLabel.TabIndex = 1;
            productCodeLabel.Text = "Product Code:";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(178, 78);
            this.productCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(148, 30);
            this.productCodeTextBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(32, 127);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(115, 25);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(178, 122);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(460, 30);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(32, 170);
            unitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(62, 25);
            unitPriceLabel.TabIndex = 5;
            unitPriceLabel.Text = "Price:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(178, 166);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(148, 30);
            this.unitPriceTextBox.TabIndex = 6;
            // 
            // onHandQuantityLabel
            // 
            onHandQuantityLabel.AutoSize = true;
            onHandQuantityLabel.Location = new System.Drawing.Point(391, 171);
            onHandQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            onHandQuantityLabel.Name = "onHandQuantityLabel";
            onHandQuantityLabel.Size = new System.Drawing.Size(91, 25);
            onHandQuantityLabel.TabIndex = 7;
            onHandQuantityLabel.Text = "Quantity:";
            // 
            // onHandQuantityTextBox
            // 
            this.onHandQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "OnHandQuantity", true));
            this.onHandQuantityTextBox.Location = new System.Drawing.Point(490, 168);
            this.onHandQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.onHandQuantityTextBox.Name = "onHandQuantityTextBox";
            this.onHandQuantityTextBox.Size = new System.Drawing.Size(148, 30);
            this.onHandQuantityTextBox.TabIndex = 8;
            // 
            // searchByCodeToolStrip
            // 
            this.searchByCodeToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchByCodeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productCodeToolStripLabel,
            this.productCodeToolStripTextBox,
            this.searchByCodeToolStripButton});
            this.searchByCodeToolStrip.Location = new System.Drawing.Point(0, 27);
            this.searchByCodeToolStrip.Name = "searchByCodeToolStrip";
            this.searchByCodeToolStrip.Size = new System.Drawing.Size(1018, 27);
            this.searchByCodeToolStrip.TabIndex = 9;
            this.searchByCodeToolStrip.Text = "searchByCodeToolStrip";
            // 
            // productCodeToolStripLabel
            // 
            this.productCodeToolStripLabel.Name = "productCodeToolStripLabel";
            this.productCodeToolStripLabel.Size = new System.Drawing.Size(98, 24);
            this.productCodeToolStripLabel.Text = "ProductCode:";
            // 
            // productCodeToolStripTextBox
            // 
            this.productCodeToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productCodeToolStripTextBox.Name = "productCodeToolStripTextBox";
            this.productCodeToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchByCodeToolStripButton
            // 
            this.searchByCodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchByCodeToolStripButton.Name = "searchByCodeToolStripButton";
            this.searchByCodeToolStripButton.Size = new System.Drawing.Size(108, 24);
            this.searchByCodeToolStripButton.Text = "SearchByCode";
            this.searchByCodeToolStripButton.Click += new System.EventHandler(this.searchByCodeToolStripButton_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProductSearch.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 570);
            this.Controls.Add(this.searchByCodeToolStrip);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(onHandQuantityLabel);
            this.Controls.Add(this.onHandQuantityTextBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            this.searchByCodeToolStrip.ResumeLayout(false);
            this.searchByCodeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMABooksDataSet mMABooksDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MMABooksDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox onHandQuantityTextBox;
        private System.Windows.Forms.ToolStrip searchByCodeToolStrip;
        private System.Windows.Forms.ToolStripLabel productCodeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productCodeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchByCodeToolStripButton;
    }
}

