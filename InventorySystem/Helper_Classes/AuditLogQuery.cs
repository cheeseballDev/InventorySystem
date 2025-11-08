using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventorySystem.Helper_Classes
{
    internal class AuditLogQuery
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;");

        public void LogAction(string action, String module)
        {
            try
            {
                using (con)
                {
                    String auditIDQuery = "select log_id from auditlogtable order by log_id desc limit 1";
                    String lastID = null;

                    using (MySqlCommand cmd = new MySqlCommand(auditIDQuery, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lastID = reader.GetString("log_id");
                            }
                        }

                        string newID;
                        if (lastID != null)
                        {
                            int numID = int.Parse(lastID.Substring(3));
                            numID++;
                            newID = $"AL-{numID:D3}";
                        }
                        else
                        {
                            newID = "AL-001";
                        }

                        string query = "INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())";
                        using (var auditCMD = new MySqlCommand(query, con))
                        {
                            auditCMD.Parameters.AddWithValue("@logID", newID);
                            auditCMD.Parameters.AddWithValue("@userID", CurrentUser.id);
                            auditCMD.Parameters.AddWithValue("@action", action);
                            auditCMD.Parameters.AddWithValue("@module", module);
                            auditCMD.ExecuteNonQuery(); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error");
            }  
        }
    }
}
