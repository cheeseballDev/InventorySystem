using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            return result;
        }


        // SELF EXPLANATORY
        public static string CheckForExistingId(string query, string type, params MySqlParameter[] paramters)
        {
            string lastID = null;

            int substringType;
            string idFormat = "";

            switch(type)
            {
                case "PERF":
                    substringType = 5;
                    idFormat = "PERF-";
                    break;
                case "E":
                    substringType = 3;
                    idFormat = "E-";
                    break;
                case "AL":
                    substringType = 4;
                    idFormat = "AL-";
                    break;
                default:
                    throw new Exception("Invalid type specified.");
            }
            using(MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lastID = reader.GetString("Product_ID");
                    }
                }
                string newID;
                if (lastID != null)
                {
                    int numID = int.Parse(lastID.Substring(substringType));
                    numID++;
                    return newID = $"{idFormat}{numID.ToString("D3")}";
                }
                else
                {
                    return newID = $"{idFormat}-001";
                }
            }
        }

        // TRANSACTION -> UPDATES AND WHATNOT
        public static int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            int rowsAffected = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);
                    con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            return rowsAffected;
        }
    }
}

