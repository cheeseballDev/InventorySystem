using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class StaffRequestForm : Form
    {
        public StaffRequestForm()
        {
            InitializeComponent();
            cbxRequestCurrentBranchFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));

            List<string> parfumList = new List<string>();
            parfumList = Helper_Classes.DatabaseHelper.GetListQuery("SELECT Perfume_Name FROM perfumetable GROUP BY Perfume_Name");

            cbxRequestCurrentBranchFilter.Items.RemoveAt(0);

            cbxRequestPerfumeFilter.Items.AddRange(parfumList.ToArray());

            loadExistingRequests();
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (cbxRequestCurrentBranchFilter.SelectedIndex < -1)
            {
                MessageBox.Show("Please select your current branch.");
                return;
            }
            if (cbxRequestPerfumeFilter.SelectedIndex < -1)
            {
                MessageBox.Show("Please select the perfume you want to request");
                return;
            }
            if (numPerfumeAmountToRequest.Value <= 0)
            {
                MessageBox.Show("Please enter a valid quantity to request.");
                return;
            }
            String reqID = DatabaseHelper.CheckForExistingId("select request_id from requestlogtable order by request_id desc limit 1", "REQ");
            String perfID = DatabaseHelper.getID($"select Perfume_ID from perfumetable where Perfume_Name = @perfume_name",
                new MySqlParameter("@perfume", cbxRequestPerfumeFilter.Text));
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "insert into requestlogtable values (@request_id, @perfume_id, @perfume_name, @quantity, @branch, NOW(), @message, @status)",
                    new MySqlParameter("@request_id", reqID),
                    new MySqlParameter("@perfume_id", perfID),
                    new MySqlParameter("@perfume", cbxRequestPerfumeFilter.Text),
                    new MySqlParameter("@quantity", int.Parse(numPerfumeAmountToRequest.Text)),
                    new MySqlParameter("@branch", cbxRequestCurrentBranchFilter.Text),
                    new MySqlParameter("@message", tbRequestMessage.Text),
                    new MySqlParameter("@status", "PENDING")
                );

            if (rowsAffected > 0)
            {
                MessageBox.Show($"Request submitted! Given ID is: {reqID}");
                DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                    new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                    new MySqlParameter("@userId", CurrentUser.id),
                    new MySqlParameter("@action", $"Sent product request ({reqID})"),
                    new MySqlParameter("@module", "Request Product Page"));
            }
            else
            {
                MessageBox.Show("Request submission error");
            }
        }

        private void loadExistingRequests()
        {
            String query = "select * from requestlogtable";
            dgExistingRequests.DataSource = DatabaseHelper.ExecuteQuery(query);
            dgExistingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgExistingRequests.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgExistingRequests.ScrollBars = ScrollBars.Both;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadExistingRequests();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxRequestCurrentBranchFilter.Items.Clear();
            cbxRequestPerfumeFilter.Items.Clear();
            tbRequestMessage.Clear();
            numPerfumeAmountToRequest.Value = 0;
        }

    }
}
