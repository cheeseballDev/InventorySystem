using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AuditDetailsPopUp : Form
    {
        private String logID;
        public AuditDetailsPopUp(String id)
        {
            InitializeComponent();
            logID = id;
            lblAuditLogId.Text = logID;
            loadDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this log?", "Delete Log", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String query = "delete from auditlogtable where log_id = @id";
                DatabaseHelper.ExecuteQuery(query, new MySqlParameter("@id", logID));
                MessageBox.Show("Log deleted");
                this.Close();
            }
        }

        private void loadDetails()
        {
            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;"))
            {
                con.Open();
                string query = "SELECT * FROM auditlogtable WHERE log_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", logID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblAuditUserId.Text = reader["User_ID"].ToString();
                            lblAuditAction.Text = reader["Action"].ToString();
                            lblAuditModule.Text = reader["Module"].ToString();
                            lblAuditTimestamp.Text = reader["Timestamp"].ToString();
                        }
                    }
                }
            }
        }
    }
}
