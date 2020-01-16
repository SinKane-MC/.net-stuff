using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class CustomerDB
    {
        public static Customer GetCustomer(int custID)
        {
            Customer cust = null;

            using (SqlConnection conn = MMABooksDB.GetConnection() )
            {
                string query = "SELECT CustomerID,Name,Address,City,State,ZipCode " +
                               "FROM Customers Where CustomerID = @CustomerID";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", custID);
                    conn.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            cust = new Customer
                            {
                                CustomerID = (int)reader["CustomerID"],
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                City = reader["City"].ToString(),
                                State = reader["State"].ToString(),
                                ZipCode = reader["ZipCode"].ToString()
                            };
                        }
                    }// closes reader
                }// closes cmd
            }// closes conection
            return cust;
        }

        public static int AddCustomer(Customer cust)
        {
            int custID = -1;
            using (SqlConnection conn = MMABooksDB.GetConnection())
            {
                string query = "INSERT INTO Customers(Name,Address,City,State,ZipCode) " +
                               "OUTPUT inserted.CustomerID " +
                               "Values(@Name,@Address,@City,@State,@ZipCode) ";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", cust.Name);
                    cmd.Parameters.AddWithValue("@Address", cust.Address);
                    cmd.Parameters.AddWithValue("@City", cust.City);
                    cmd.Parameters.AddWithValue("@State", cust.State);
                    cmd.Parameters.AddWithValue("@ZipCode", cust.ZipCode);
                    conn.Open();
                    custID = (int)cmd.ExecuteScalar();
                }
            }

            return custID;
        }
        public static bool DeleteCustomer(Customer cust)
        {
            int count=0;
            using ( SqlConnection conn = MMABooksDB.GetConnection())
            { // only delete the record if all the values are the same - 
              // no one has updated the record previous to delete
                string query = "DELETE from Customers where CustomerID = @CustomerID " +
                    "AND Name=@Name " +  // for optimistic concurrancy
                    "AND Address=@Address " +
                    "AND City=@City " +
                    "AND State=@State " +
                    "AND ZipCode=@ZipCode";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", cust.CustomerID);
                    cmd.Parameters.AddWithValue("@Name", cust.Name);
                    cmd.Parameters.AddWithValue("@Address", cust.Address);
                    cmd.Parameters.AddWithValue("@City", cust.City);
                    cmd.Parameters.AddWithValue("@State", cust.State);
                    cmd.Parameters.AddWithValue("@ZipCode", cust.ZipCode);
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                    
                }

            }
            return (count>0);
        }
        public static bool UpdateCustomer(Customer oldCust, Customer newCust)
        {
            int count = 0;
            using (SqlConnection conn = MMABooksDB.GetConnection())
            {
                string query =
                    "UPDATE Customers SET " +
                    "Name=@newName, " +
                    "Address=@newAddress, " +
                    "City=@newCity, " +
                    "State=@newState, " +
                    "ZipCode=@newZipCode " +
                    "Where CustomerID =@oldCustomerID " +//to identify record
                    "AND Name=@oldName " + // remaining conditions for optimistic concurrency
                    "AND Address=@oldAddress " +
                    "AND City=@oldCity " +
                    "AND State=@oldState " +
                    "AND ZipCode=@oldZipCode";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newName", newCust.Name);
                    cmd.Parameters.AddWithValue("@newAddress", newCust.Address);
                    cmd.Parameters.AddWithValue("@newCity", newCust.City);
                    cmd.Parameters.AddWithValue("@newState", newCust.State);
                    cmd.Parameters.AddWithValue("@newZipCode", newCust.ZipCode);
                    cmd.Parameters.AddWithValue("@oldCustomerID", oldCust.CustomerID);
                    cmd.Parameters.AddWithValue("@oldName", oldCust.Name);
                    cmd.Parameters.AddWithValue("@oldAddress", oldCust.Address);
                    cmd.Parameters.AddWithValue("@oldCity", oldCust.City);
                    cmd.Parameters.AddWithValue("@oldState", oldCust.State);
                    cmd.Parameters.AddWithValue("@oldZipCode", oldCust.ZipCode);
                    conn.Open();
                    count = cmd.ExecuteNonQuery(); // returns # of row updated

                }
            }

                return (count>0);
        }
    }
}
