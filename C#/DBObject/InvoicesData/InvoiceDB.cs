using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesData
{
    public static class InvoiceDB
    {
        public static SqlConnection GetConnection()
        {
            string conn = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=MMABooks;Integrated Security=True";
            return new SqlConnection(conn);
        }

        public static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            Invoice inv;

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT InvoiceID, CustomerID, InvoiceDate,ProductTotal" +
                                ",SalesTax,Shipping,InvoiceTotal FROM Invoices ORDER BY InvoiceID";
                using(SqlCommand cmd = new SqlCommand(query,conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        inv = new Invoice();
                        inv.InvoiceID = (int)reader["InvoiceID"];
                        inv.CustomerID = (int)reader["CustomerID"];
                        inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
                        inv.ProductTotal = (decimal)reader["ProductTotal"];
                        inv.SalesTax = (decimal)reader["SalesTax"];
                        inv.Shipping = (decimal)reader["Shipping"];
                        inv.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                        invoices.Add(inv);

                    }
                    
                }
            }
            return invoices;
        }
    }
}
