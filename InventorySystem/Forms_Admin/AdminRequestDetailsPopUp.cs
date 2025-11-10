using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AdminRequestDetailsPopUp : Form
    {
        private String reqID;
        public AdminRequestDetailsPopUp(String id)
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
            AuditLogQuery alq = new AuditLogQuery();
            alq.LogAction($"Approved product request {reqID}", "Request Details Module");
        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            String rejek = "REJECTED";
            String approveQuery = $"UPDATE requestlogtable SET status = @status WHERE request_id = @id";
            DatabaseHelper.ExecuteNonQuery(approveQuery, new MySqlParameter("@id", reqID), new MySqlParameter("@status", rejek));
            AuditLogQuery alq = new AuditLogQuery();
            alq.LogAction($"Rejected product request {reqID}", "Request Details Module");
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblBranch_Click(object sender, EventArgs e)
        {

        }

        private void loadDetails()
        {
            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;"))
            {
                con.Open();
                string query = "SELECT * FROM requestlogtable WHERE Request_ID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", reqID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblRequestID.Text = reader["Request_ID"].ToString();
                            lblProductId.Text = reader["Product_ID"].ToString();
                            lblStatus.Text = reader["status"].ToString();
                            lblRequestDate.Text = reader["request_date"].ToString();
                            lblPerfume.Text = reader["perfume"].ToString();
                            lblQuantity.Text = reader["quantity"].ToString();
                            lblBranch.Text = reader["branch"].ToString();
                            lblMessage.Text = reader["message"].ToString();
                        }
                    }
                }
            }
        }
    }
}
