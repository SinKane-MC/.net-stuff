using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// For setting up the connection string to the 
/// localhost\sqlexpress server and the Northwinds Database instance
/// </summary>
namespace Lab4
{
    public static class NorthwindDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

    }
}
