using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_to_SQL_Demo
{
    public partial class frmAddModifyProduct : Form
    {

       //public frmProducts mainForm; // link to the main form
        public bool isAdd;              // main form sets it
        public Product currentProduct;  // main form sets it

        public frmAddModifyProduct()
        {
            InitializeComponent();
        }


        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                productCodeTextBox.Enabled = true;
                productCodeTextBox.Focus(); // focus of the first text box
            }
            else // it is Modify
            {
                DisplayCurrentProduct(); // display data of the current product
                productCodeTextBox.Enabled = false; // code is not updatable
                descriptionTextBox.Focus(); // focus on description
            }
        }

        private void DisplayCurrentProduct()
        {
            // display current Product data 
            productCodeTextBox.Text = currentProduct.ProductCode;
            descriptionTextBox.Text = currentProduct.Description;
            unitPriceTextBox.Text = currentProduct.UnitPrice.ToString();
            onHandQuantityTextBox.Text = currentProduct.OnHandQuantity.ToString();         
        }

        private void ClearTextBoxes()
        {
            productCodeTextBox.Text = "";
            descriptionTextBox.Text = "";
            unitPriceTextBox.Text = "";
            onHandQuantityTextBox.Text = "";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            { 
                if (Validator.IsPresent(productCodeTextBox) &&
                    Validator.IsCorrectLength(productCodeTextBox, 10) &&
                    IsUniqueCode(productCodeTextBox) && // coded below in this form
                    Validator.IsPresent(descriptionTextBox) &&
                    Validator.IsCorrectLength(descriptionTextBox, 50) &&
                    Validator.IsPresent(unitPriceTextBox) &&
                    Validator.IsDecimal(unitPriceTextBox) &&
                    Validator.IsNonNegativeDecimal(unitPriceTextBox) &&
                    Validator.IsPresent(onHandQuantityTextBox) &&
                    Validator.IsInt32(onHandQuantityTextBox) &&
                    Validator.IsNonNegativeInt(onHandQuantityTextBox)
                    )
                    // replace with data validation: all fields provided, code unique, 
                         // price and quantity appropriate numeric type and non-negative
                {
                    Product newProduct = new Product // create product using provided data
                    {
                        ProductCode = productCodeTextBox.Text,
                        Description = descriptionTextBox.Text,
                        UnitPrice = Convert.ToDecimal(unitPriceTextBox.Text),
                        OnHandQuantity = Convert.ToInt32(onHandQuantityTextBox.Text)
                    };
                    using (ProductsDataContext dbContext = new ProductsDataContext())
                    {
                        // insert through data context object from the main form
                        dbContext.Products.InsertOnSubmit(newProduct);
                        dbContext.SubmitChanges(); // submit to the database
                    }
                    DialogResult = DialogResult.OK;
                }
                else // validation  failed
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            else // it is Modify
            {
                if (Validator.IsPresent(descriptionTextBox) &&
                    Validator.IsCorrectLength(descriptionTextBox, 50) &&
                    Validator.IsPresent(unitPriceTextBox) &&
                    Validator.IsDecimal(unitPriceTextBox) &&
                    Validator.IsNonNegativeDecimal(unitPriceTextBox) &&
                    Validator.IsPresent(onHandQuantityTextBox) &&
                    Validator.IsInt32(onHandQuantityTextBox) &&
                    Validator.IsNonNegativeInt(onHandQuantityTextBox)
                    )
                {
                    try
                    {
                        using (ProductsDataContext dbContext = new ProductsDataContext())
                        {
                            // get the product with Code from the current text box
                            Product prod = dbContext.Products.Single(p => p.ProductCode == productCodeTextBox.Text);

                            //MessageBox.Show("Testing concurrency: update or delete current record from SSMS and click OK");

                            if (prod != null)
                            {
                                // make changes by copying values from text boxes
                                prod.Description = descriptionTextBox.Text;
                                prod.UnitPrice = Convert.ToDecimal(unitPriceTextBox.Text);
                                prod.OnHandQuantity = Convert.ToInt32(onHandQuantityTextBox.Text);
                                // submit changes 
                                dbContext.SubmitChanges();
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    catch (ChangeConflictException)
                    {
                        MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");                  
                        DialogResult = DialogResult.Retry;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else // validation failed
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private bool IsUniqueCode(TextBox productCodeTextBox)
        {
            Product prod = null;
            using (ProductsDataContext dbContext = new ProductsDataContext())
            {
                prod = (from p in dbContext.Products
                        where p.ProductCode == productCodeTextBox.Text
                        select p).SingleOrDefault();

                    //dbContext.Products.Single(p => p.ProductCode == productCodeTextBox.Text);
                if (prod != null) // there is another product with same code
                {
                    MessageBox.Show("Product code must be unique", "Entry Error");
                    return false;
                }
                else
                    return true;
            }
        }
    }
}
