using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public static class OrderDB
    {
        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            Order tmpOrder;
            using (SqlConnection conn = NorthwindDB.GetConnection())
            {
                //create command
                string query = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate FROM Orders ORDER BY OrderID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //run command and process results
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            //try
                            //{
                            tmpOrder = new Order();
                            tmpOrder.OrderID = Convert.ToInt32(reader["OrderID"]);
                            tmpOrder.CustomerID = reader["CustomerID"].ToString();
                            if (reader["OrderDate"] != DBNull.Value)
                            {
                                tmpOrder.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                            }
                            else
                            {
                                tmpOrder.OrderDate = null;
                            }
                            if (reader["RequiredDate"] != DBNull.Value)
                            {
                                tmpOrder.RequiredDate = Convert.ToDateTime(reader["RequiredDate"]);
                            }
                            else
                            {
                                tmpOrder.RequiredDate = null;
                            }
                            if (reader["ShippedDate"] != DBNull.Value)
                            {
                                tmpOrder.ShippedDate = Convert.ToDateTime(reader["ShippedDate"]);
                            }
                            else
                            {
                                tmpOrder.ShippedDate = null;
                            }


                            orders.Add(tmpOrder);
                            //}
                            //catch(Exception ex)
                            //{
                            //    //MessageBox.Show(ex.Message );
                            //}
                        }
                    }// closes reader
                } // cmd object recycled
            }// connection is closed if open & Connection object recycled


            return orders;
        }
    }
}
