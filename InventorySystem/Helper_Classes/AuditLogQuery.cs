using System.Configuration;
using MySql.Data.MySqlClient;

namespace InventorySystem.Helper_Classes
{
    internal class AuditLogQuery
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["inventorysystemdatabase"].ConnectionString;

        public void LogAction(string action, String module)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    String auditIDQuery = "select log_id from auditlogtable order by log_id desc limit 1";
                    String ID = DatabaseHelper.CheckForExistingId(auditIDQuery, "AL");
                    string query = "INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())";
                    using (var auditCMD = new MySqlCommand(query, con))
                    {
                        auditCMD.Parameters.AddWithValue("@logID", ID);
                        auditCMD.Parameters.AddWithValue("@userID", CurrentUser.id);
                        auditCMD.Parameters.AddWithValue("@action", action);
                        auditCMD.Parameters.AddWithValue("@module", module);
                        auditCMD.ExecuteNonQuery();
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
