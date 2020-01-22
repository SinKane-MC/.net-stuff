using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// OrderDetails data access class for retrieving all the detail entities for a given order number
/// and creating a List of OrderDetails which is returned to the calling method.
/// </summary>
namespace Lab4
{
    public static class OrderDetailDB
    {
        
    public static List<OrderDetail> GetOrderDetails(int orderNum)
        {
            List<OrderDetail> orders = new List<OrderDetail>();
            OrderDetail tmpOrder;
            using (SqlConnection conn = NorthwindDB.GetConnection())
            {
                //create command
                string query = "SELECT * FROM [Order Details] WHERE OrderID='" + orderNum + "' ORDER BY OrderID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //run command and process results
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            tmpOrder = new OrderDetail();
                            tmpOrder.OrderID = Convert.ToInt32(reader["OrderID"]);
                            tmpOrder.ProductID = Convert.ToInt32(reader["ProductID"]);
                            tmpOrder.Quantity = Convert.ToInt32(reader["Quantity"]);
                            tmpOrder.UnitPrice = Math.Round(Convert.ToDouble(reader["UnitPrice"]),2);
                            tmpOrder.Discount = Math.Round(Convert.ToDouble(reader["Discount"]),2);
                                                        
                            orders.Add(tmpOrder);
                        }
                    }// closes reader
                } // cmd object recycled
            }// connection is closed if open & Connection object recycled


            return orders;
        }
    }
}
