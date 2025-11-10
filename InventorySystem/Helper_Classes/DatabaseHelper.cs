using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace InventorySystem.Helper_Classes
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["inventorysystemdatabase"].ConnectionString;

        // EXECUTE QUERIES FOR DATATABLE
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

        // GETS ALL STRING LIST FROM QUERY
        public static List<string> GetListQuery(string query, params MySqlParameter[] parameters)
        {
            List<string> results = new List<string>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);
                    con.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return results;
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
        public static string CheckForExistingId(string query, string type)
        {
            string lastID = null;

            int substringType;
            string idFormat = "";
            string moduleID = "";

            switch (type)
            {
                case "PERF":
                    substringType = 5;
                    idFormat = "PERF";
                    moduleID = "Product_ID";
                    break;
                case "E":
                    substringType = 3;
                    idFormat = "E";
                    moduleID = "ID";
                    break;
                case "AL":
                    substringType = 4;
                    idFormat = "AL";
                    moduleID = "Log_ID";
                    break;
                default:
                    throw new Exception("Invalid type specified.");
            }
            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lastID = reader.GetString(moduleID);
                    }
                }
                string newID;
                if (lastID != null)
                {
                    int numID = int.Parse(lastID.Substring(substringType));
                    numID++;
                    return newID = $"{idFormat}-{numID.ToString("D3")}";
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

        public static string getID(string email, string employee)
        {
            string id = null;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = $"select id FROM {employee} where email = @email limit 1";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        id = result.ToString();
                    }
                }
            }
            return id;
        }

        public static void cbxLoader(String type, ComboBox cbx)
        {
            String query;
            switch (type)
            {
                case ("Staff"):
                    query = "select ID from employeeaccount";
                    break;
                case ("Admin"):
                    query = "select ID from adminaccount";
                    break;
                default:
                    return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbx.Items.Add(reader[0].ToString());
                    }
                }
            }
        }
    }
}

