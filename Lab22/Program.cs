using System;
using Microsoft.Data.SqlClient;
namespace Lab22
{
    class Insertion
    {
        static void Curd()
        {
            SqlConnection conn = null;
            try
            {
                // Creating Connection
                string conStr = @"Server=DESKTOP-2NNALVV\SQLEXPRESS01;Database=consolecrud;Integrated Security=true; TrustServerCertificate=True;Encrypt=False ";
                conn = new SqlConnection(conStr);
                //// Opening Connection
                conn.Open();
                Console.WriteLine("Connection to db established");
                int id = 1;
                string name = "Bibek Angdembe";
                string lab_no = "22";
                string query = "INSERT INTO Info (id, name, lab_no) VALUES (" + id + ",'" + name + "'," + lab_no + ")";
                //sql query
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                // Executing the SQL query
                int n = sqlcmd.ExecuteNonQuery();
                // Displaying a message
                Console.WriteLine(n + " Data inserted");

                //Read
                string readquery = "SELECT * FROM Info";
                //sql query
                SqlCommand cmd = new SqlCommand(readquery, conn);
                // Executing the SQL query
                SqlDataReader sdr = cmd.ExecuteReader();
                Console.WriteLine("Name \t\t Lab _ No");
                Console.WriteLine();
                //Looping through each record
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["Name"] + " \t " + sdr["lab_no"] );
                }
                sdr.Close();
                Console.WriteLine("All Records are fetched Successfully");
                Console.WriteLine();





                ///Updatee
                string updateQuery = "UPDATE Info SET name = @NewName WHERE name = @Name";
                SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                updateCommand.Parameters.AddWithValue("@NewName", "CodeZen");
                updateCommand.Parameters.AddWithValue("@Name", "Bibek Angdembe"); // Replace with the actual phone number
                int rowsUpdated = updateCommand.ExecuteNonQuery();
                if (rowsUpdated > 0)
                {
                    Console.WriteLine("Record updated ");
                }
                else
                {
                    Console.WriteLine("No records updated.");
                }

                Console.WriteLine();
                // Delete
                string deleteQuery = "DELETE FROM Info WHERE name = @name";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn);
                deleteCommand.Parameters.AddWithValue("@name", "CodeZen"); // Replace with the actual id
                int rowsDeleted = deleteCommand.ExecuteNonQuery();
                if (rowsDeleted > 0)
                {
                    Console.WriteLine("Record deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No records deleted.");
                }

            }

            catch (SqlException ex)
            {
                Console.WriteLine("Oops!Something went wrong. " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Curd();
        }
    }
}
