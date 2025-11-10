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
    public partial class AdminApproveForm : Form
    {
        public AdminApproveForm()
        {
            InitializeComponent();
            cbxRequestBranchFilter.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            loadExistingRequests();
        }

        private void btnOpenDetails_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgExistingRequests.SelectedRows[0];

            string id = row.Cells["Request_ID"].Value.ToString();

            AdminRequestDetailsPopUp adminRequestDetailsPopUp = new AdminRequestDetailsPopUp(id);
            adminRequestDetailsPopUp.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxRequestBranchFilter.Text) || string.IsNullOrWhiteSpace(cbxRequestStatusFilter.Text))
            {
                loadExistingRequests();
                return;
            }
            String query = "select * from requestlogtable where branch like @branch and status like @status and date(request_date) between @startDate and @endDate";
            MySqlParameter actionParameter = new MySqlParameter("@branch", "%" + cbxRequestBranchFilter.Text + "%");
            MySqlParameter userParameter = new MySqlParameter("@status", "%" + cbxRequestStatusFilter.Text + "%");
            MySqlParameter startDateParameter = new MySqlParameter("@startDate", dtpRequestDateFrom.Value.Date);
            MySqlParameter endDateParameter = new MySqlParameter("@endDate", dtpRequestDateTo.Value.Date);

            dgExistingRequests.DataSource = DatabaseHelper.ExecuteQuery(query, actionParameter, userParameter, startDateParameter, endDateParameter);
        }

        private void loadExistingRequests()
        {
            String query = "select * from requestlogtable";
            dgExistingRequests.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadExistingRequests();
        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            if (dgExistingRequests.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgExistingRequests.SelectedRows[0];
                string id = row.Cells["Request_ID"].Value.ToString();
                String aprub = "APPROVED";
                String approveQuery = $"UPDATE requestlogtable SET status = @status WHERE request_id = @id";
                DatabaseHelper.ExecuteNonQuery(approveQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", aprub));
                loadExistingRequests();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            if (dgExistingRequests.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgExistingRequests.SelectedRows[0];
                string id = row.Cells["Request_ID"].Value.ToString();
                String rejek = "REJECTED";
                String approveQuery = $"UPDATE requestlogtable SET status = @status WHERE request_id = @id";
                DatabaseHelper.ExecuteNonQuery(approveQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", rejek));
                loadExistingRequests();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
