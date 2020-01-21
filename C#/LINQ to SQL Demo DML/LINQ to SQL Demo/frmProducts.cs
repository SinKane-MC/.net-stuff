using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Uses LINQ to SQL  to retrieve and update records of Products table in MMABooks database
 * Does NOT guarantee optimistic concurrency
 */
namespace LINQ_to_SQL_Demo
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ProductsDataContext dbContext = new ProductsDataContext())
            {

                productDataGridView.DataSource = dbContext.Products; // entire table - no need for LINQ query
                //productDataGridView.DataSource = from prod in dbContext.Products
                //                                 orderby prod.Description
                //                                 select prod;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = true;
            secondForm.currentProduct = null; // no current product when inserting
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if(result == DialogResult.OK) // new row got inserted
            {
                RefreshGridView();
            }
        }
        private void RefreshGridView()
        {
            ProductsDataContext dbContext = new ProductsDataContext();
            productDataGridView.DataSource = dbContext.Products;
        }

        private void btnModify_Click(object sender, EventArgs e)
        { 
            // get the key of the current product in the data grid view
            int rowNum = productDataGridView.CurrentCell.RowIndex; // index of the current row
            string prodCode = productDataGridView["dataGridViewTextBoxColumn1", rowNum].Value.ToString(); // Column for ProductCode

            Product currentProduct;
            using (ProductsDataContext dbContext = new ProductsDataContext())
            {
                currentProduct = (from p in dbContext.Products
                                          where p.ProductCode == prodCode
                                          select p).Single();
            }

            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = false; // it Modify
            secondForm.currentProduct = currentProduct;
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                RefreshGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // get the key of the current product in the data grid view
            int rowNum = productDataGridView.CurrentCell.RowIndex; // index of the current row
            string prodCode = productDataGridView["dataGridViewTextBoxColumn1", rowNum].Value.ToString(); // Column for ProductCode

            DialogResult answer = MessageBox.Show("Are you sure you want to delete " + prodCode + "?", "Confirm",MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                using (ProductsDataContext dbContext = new ProductsDataContext())
                {
                    try
                    {
                        Product currentProduct = (from p in dbContext.Products
                                                  where p.ProductCode == prodCode
                                                  select p).Single();
                        //MessageBox.Show("Testing concurrency: update or delete current record from SSMS and click OK");

                        dbContext.Products.DeleteOnSubmit(currentProduct);
                        dbContext.SubmitChanges();
                        RefreshGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
    }
}
