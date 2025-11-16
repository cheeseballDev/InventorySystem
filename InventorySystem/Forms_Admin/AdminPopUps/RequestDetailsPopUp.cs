using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class RequestDetailsPopUp : Form
    {
        private String reqID;
        public RequestDetailsPopUp(String id)
        {
            reqID = id;
            InitializeComponent();
            loadDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            String aprub = "APPROVED";
            String approveQuery = $"UPDATE requestlogtable SET status = @status WHERE request_id = @id";
            DatabaseHelper.ExecuteNonQuery(approveQuery, new MySqlParameter("@id", reqID), new MySqlParameter("@status", aprub));
            DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                new MySqlParameter("@userId", CurrentUser.id),
                new MySqlParameter("@action", $"Approved product request {reqID}"),
                new MySqlParameter("@module", "Request Details Module"));
        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            String rejek = "REJECTED";
            String approveQuery = $"UPDATE requestlogtable SET status = @status WHERE request_id = @id";
            DatabaseHelper.ExecuteNonQuery(approveQuery, new MySqlParameter("@id", reqID), new MySqlParameter("@status", rejek));
            DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                new MySqlParameter("@userId", CurrentUser.id),
                new MySqlParameter("@action", $"Rejected product request {reqID}"),
                new MySqlParameter("@module", "Request Details Module"));
        }

        private void loadDetails()
        {
            string query = "SELECT * FROM requestlogtable WHERE Request_ID = @id";
            DatabaseHelper.ExecuteReader(query, reader =>
            {
                lblRequestID.Text = reader["Request_ID"].ToString();
                lblPerfumeId.Text = reader["Perfume_ID"].ToString();
                lblStatus.Text = reader["status"].ToString();
                lblRequestDate.Text = reader["request_date"].ToString();
                lblPerfume.Text = reader["Perfume_Name"].ToString();
                lblQuantity.Text = reader["quantity"].ToString();
                lblBranch.Text = reader["branch"].ToString();
                lblMessage.Text = reader["message"].ToString();
            },
            new MySqlParameter("@id", reqID)
            );
        }
    }
}
