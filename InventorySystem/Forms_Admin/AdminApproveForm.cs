using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AdminApproveForm : Form
    {
        private DateTime firstDay;
        private DateTime lastDay;
        public AdminApproveForm()
        {
            InitializeComponent();
            loadExistingRequests();
            cbxRequestBranchFilter.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            lastDay = firstDay.AddMonths(1).AddDays(-1);

            dtpRequestDateFrom.Value = firstDay;
            dtpRequestDateTo.Value = lastDay;
        }

        private void btnOpenDetails_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgExistingRequests.SelectedRows[0];

            string id = row.Cells["Request_ID"].Value.ToString();

            RequestDetailsPopUp adminRequestDetailsPopUp = new RequestDetailsPopUp(id);
            adminRequestDetailsPopUp.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadResults();
        }

        private void loadResults()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            String query = "select * from requestlogtable where 1=1";
            if (cbxRequestBranchFilter.SelectedIndex != -1)
            {
                query += " and branch like @branch";
                parameters.Add(new MySqlParameter("@branch", "%" + cbxRequestBranchFilter.Text + "%"));
            }
            if (cbxRequestStatusFilter.SelectedIndex != -1)
            {
                query += " and status like @status";
                parameters.Add(new MySqlParameter("@status", "%" + cbxRequestStatusFilter.Text + "%"));
            }
            if (dtpRequestDateFrom.Value <= dtpRequestDateTo.Value)
            {
                query += " and date(request_date) between @startDate and @endDate";
                parameters.Add(new MySqlParameter("@startDate", dtpRequestDateFrom.Value.Date));
                parameters.Add(new MySqlParameter("@endDate", dtpRequestDateTo.Value.Date));
            }
            dgExistingRequests.DataSource = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }

        private void loadExistingRequests()
        {
            dgExistingRequests.DataSource = DatabaseHelper.ExecuteQuery("select * from requestlogtable");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbxRequestBranchFilter.SelectedIndex = 0;
            cbxRequestStatusFilter.SelectedIndex = 0;
            dtpRequestDateFrom.Value = firstDay;
            dtpRequestDateTo.Value = lastDay;
            loadExistingRequests();
        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnApproveRequest_Click_1(object sender, EventArgs e)
        {
            if (dgExistingRequests.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgExistingRequests.SelectedRows[0];
                string id = row.Cells["Request_ID"].Value.ToString();
                String aprub = "APPROVED";
                String approveQuery = $"UPDATE requestlogtable SET status = @status WHERE request_id = @id";
                DatabaseHelper.ExecuteNonQuery(approveQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", aprub));
                DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                    new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                    new MySqlParameter("@userId", CurrentUser.id),
                    new MySqlParameter("@action", $"Approved product request {id}"),
                    new MySqlParameter("@module", "Request Details Module"));
                loadResults();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRejectRequest_Click_1(object sender, EventArgs e)
        {
            if (dgExistingRequests.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgExistingRequests.SelectedRows[0];
                string id = row.Cells["Request_ID"].Value.ToString();
                String rejek = "REJECTED";
                String approveQuery = $"UPDATE requestlogtable SET status = @status WHERE request_id = @id";
                DatabaseHelper.ExecuteNonQuery(approveQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", rejek));
                DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                    new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                    new MySqlParameter("@userId", CurrentUser.id),
                    new MySqlParameter("@action", $"Rejected product request {id}"),
                    new MySqlParameter("@module", "Request Details Module"));
                loadResults();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
