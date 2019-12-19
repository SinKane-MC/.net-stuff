using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInventory
{
    public partial class frmProducts : Form
    {
        // form level variables
        List<Product> products = new List<Product>();

        public frmProducts()
        {
            InitializeComponent();
        }

        // exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // prepare for next entry
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            decimal price;
            int qty;
            
            // get the data from textboxes
            if (Validator.IsPresent(txtName, "Name") &&
                Validator.IsPresent(txtPrice, "Price") &&
                Validator.IsNonNegativeDecimal(txtPrice, "Price") &&
                Validator.IsPresent(txtQty, "Quantity") &&
                Validator.IsNonNegativeInt32(txtQty, "Quantity"))
            {
                name = txtName.Text;
                price = Convert.ToDecimal(txtPrice.Text);
                qty = Convert.ToInt32(txtQty.Text);

                // create product object
                Product p = new Product(name, price, qty);

                // add to the list
                products.Add(p);
                DisplayProducts();
                ClearForm();

            }
        }
        public void ClearForm()
        {
            txtQty.Text = "";
            txtPrice.Text = "";
            txtName.Text = "";
            txtBSQty.Text = "";
            txtName.Focus();
        }

        // populate the listbox with item sin the list
        private void DisplayProducts()
        {
            lstProducts.Items.Clear();
            foreach (Product p in products)
                lstProducts.Items.Add(p); // Implict call to ToString() method

            lblProducts.Text = products.Count.ToString();
            lblInventory.Text = CalculateInventory().ToString("c");
        }

        // total inventory value of all products
        public decimal CalculateInventory()
        {
            decimal total = 0;
            foreach (Product p in products)
                total += p.InventoryValue();
            return total;
        }

        // save data prior to exiting
        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductDB.SaveProducts(products);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductDB.SaveProducts(products);
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            products = ProductDB.ReadProducts();
            DisplayProducts();
        }

        // But selected product
        private void btnBuy_Click(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;
            int qtyToBuy;
            if(index == -1)
            {
                MessageBox.Show("Please select product first");
                return;
            }
            if (Validator.IsPresent(txtBSQty, "Quantity to buy")&& 
                Validator.IsNonNegativeInt32(txtBSQty,"Quantity to buy"))
            {
                qtyToBuy = Convert.ToInt32(txtBSQty.Text);
                products[index].Qty += qtyToBuy;
                DisplayProducts();
                ClearForm();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;
            int qtyToSell;
            if (index == -1)
            {
                MessageBox.Show("Please select product first");
                return;
            }
            if (Validator.IsPresent(txtBSQty, "Quantity to buy") &&
                Validator.IsNonNegativeInt32(txtBSQty, "Quantity to buy"))
            {
                qtyToSell = Convert.ToInt32(txtBSQty.Text);
                if (qtyToSell > products[index].Qty)
                {
                    MessageBox.Show("We only have " + products[index].Qty + " of product "
                        + products[index].Name + "(s)" + "\nTry again");
                }
                else
                {
                    products[index].Qty -= qtyToSell;
                    DisplayProducts();
                    ClearForm();
                }
            }
        }
    } // end of form
} // end of namespace
