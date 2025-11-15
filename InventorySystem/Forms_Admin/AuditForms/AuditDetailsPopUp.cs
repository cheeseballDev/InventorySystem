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

        private void loadDetails()
        {
            string query = "SELECT * FROM auditlogtable WHERE log_id = @id";
            DatabaseHelper.ExecuteReader(query, reader =>
            {
                lblAuditUserId.Text = reader["User_ID"].ToString();
                lblAuditAction.Text = reader["Action"].ToString();
                lblAuditModule.Text = reader["Module"].ToString();
                lblAuditTimestamp.Text = reader["Timestamp"].ToString();
            },
            new MySqlParameter("@id", logID)
            );
        }
    }
}
