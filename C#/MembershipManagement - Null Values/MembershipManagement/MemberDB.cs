using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement
{
    public static class MemberDB
    {
        // connection to the database
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog = MMABooks; Integrated Security = True";
            return new SqlConnection(connectionString);
        }

        // gets all member IDs
        public static List<int> GetMemberIDs()
        {
            List<int> memberIDs = new List<int>(); // empty list of IDs
            int id; // for reading
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT MemberID FROM Membership";
                // any exception not handled here is automatically thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    while (reader.Read())
                    {
                        id = (int)reader["MemberID"];
                        memberIDs.Add(id);
                    }
                } // command object recycled
            } // connection object recycled
         return memberIDs;
        }

        // get member with given ID
        public static Member GetMemberByID(int memberID)
        {
            Member member = null;
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT MemberID, MemberName, DateStarted, DateEnded " +
                               "FROM Membership " +
                               "WHERE MemberID = @MemberID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MemberID", memberID); 
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read()) // if member with given ID exists
                    {
                        member = new Member();
                        member.MemberID = (int)reader["MemberID"];
                        member.MemberName = reader["MemberName"].ToString();
                        member.DateStarted = Convert.ToDateTime(reader["DateStarted"]);

                        // for any column that can be null need to determine if it is DBNull
                        // and set accordingly
                        int col = reader.GetOrdinal("DateEnded"); // column number of DateEnded
                        if (reader.IsDBNull(col)) // if reader contains DBNull in this column
                            member.DateEnded = null; // make it null in the object
                        else // it is not null
                            member.DateEnded = Convert.ToDateTime(reader["DateEnded"]);
                    }
                } // cmd recycled
            } // connection recycled
            return member;
        }

        // update member: oldMember - before update, newNember - new data
        public static bool UpdateMember(Member oldMember, Member newMember)
        {
            bool success = false; // no success yet

            using(SqlConnection con = GetConnection())
            {
                string updateStatement = "UPDATE Membership SET " +
                                          "  DateEnded = @NewDateEnded " + // only DateEnded can be updated
                                          "WHERE MemberID = @OldMemberID " + // identifies member
                                          "  AND MemberName = @OldMemberName " + // optimistic concurrency
                                          "  AND DateStarted = @OldDateStarted  " +
                                          "  AND (DateEnded = @OldDateEnded OR " + // either equal or both are null
                                          "       DateEnded IS NULL AND @OldDateEnded IS NULL)";
                using(SqlCommand cmd = new SqlCommand(updateStatement, con))
                {
                    // provide values for parameters
                    // for every new column (new or old)that allows null have to check if null
                    if (newMember.DateEnded == null)
                        cmd.Parameters.AddWithValue("@NewDateEnded", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NewDateEnded", (DateTime)newMember.DateEnded);
                    cmd.Parameters.AddWithValue("@OldMemberID", oldMember.MemberID);
                    cmd.Parameters.AddWithValue("@OldMemberName", oldMember.MemberName);
                    cmd.Parameters.AddWithValue("@OldDateStarted", oldMember.DateStarted);
                    //for every old column that allows null also have to check if null
                    if (oldMember.DateEnded == null)
                                cmd.Parameters.AddWithValue("@OldDateEnded", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@OldDateEnded", (DateTime)oldMember.DateEnded);

                    // open connection
                    con.Open();
                    // execute UPDATE command
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        success = true;
                } // command object recycled
            } // connection closed and recycled
            return success;
        }

    } // class
}// namespace
