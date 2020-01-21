using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public static class CustomerDB
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> Customers = new List<Customer>();
            
            using (SqlConnection conn = NorthwindDB.GetConnection())
            {
                //create command
                string query = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers ORDER BY CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //run command and process results
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        
                        while (reader.Read())
                        {
                            Customer cust = new Customer();
                            cust.CustomerID = reader["CustomerID"].ToString();
                            cust.CompanyName = reader["CompanyName"].ToString();
                            cust.ContactName = reader["ContactName"].ToString();
                            cust.ContactTitle = reader["ContactTitle"].ToString();
                            cust.Address = reader["Address"].ToString();
                            cust.City = reader["City"].ToString();
                            cust.Region = reader["Region"].ToString();
                            cust.PostalCode = reader["PostalCode"].ToString();
                            cust.Country = reader["Country"].ToString();
                            cust.Phone = reader["Phone"].ToString();
                            cust.Fax = reader["Fax"].ToString();
                            Customers.Add(cust);
                        }
                    }
                }
            }
            return Customers;
        }
    }
}
