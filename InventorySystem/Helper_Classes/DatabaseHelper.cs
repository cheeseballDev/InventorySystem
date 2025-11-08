using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventorySystem.Helper_Classes
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["inventorysystemdatabase"].ConnectionString;


        // EXECUTE QUERIES 
        public static DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable tb = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tb);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tb;
        }


        // EXECUTE SCALAR 
        public static int ExecuteScalar(string query, params MySqlParameter[] parameters)
        {
            int result = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    con.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            return result;
        }

        public static string getID (String email)
        {
            try
            {
                String query = "select id from adminaccount where email = @email";
                using (var con = new MySqlConnection(connectionString))
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString("id");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            return "null";
        }
    }
}
