using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public static class StateDB
    {
        public static List<State> GetStates()
        {
            List<State> states = new List<State>();
            State st;
            // retrieve all states and add to list
            // create connection
            using (SqlConnection conn = MMABooksDB.GetConnection())
            {
                //create command
                string query = "SELECT StateCode,StateName FROM States ORDER BY StateName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //run command and process results
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            st = new State
                            {
                                StateCode = reader["StateCode"].ToString(),
                                StateName = reader["StateName"].ToString()
                            };
                            states.Add(st);
                        }
                    }// closes reader
                } // cmd object recycled
            }// connection is closed if open & Connection object recycled
            return states;
        } // end of method
    }// end of class
}// end of namespace
