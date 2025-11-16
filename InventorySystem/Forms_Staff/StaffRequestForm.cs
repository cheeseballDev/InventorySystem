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
            parfumList = Helper_Classes.DatabaseHelper.GetListQuery("SELECT Perfume FROM perfumetable GROUP BY Perfume");

            cbxRequestCurrentBranchFilter.Items.RemoveAt(0);

            cbxRequestParfumFilter.Items.AddRange(parfumList.ToArray());

            loadExistingRequests();
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (cbxRequestCurrentBranchFilter.SelectedIndex < -1)
            {
                MessageBox.Show("Please select your current branch.");
                return;
            }
            if (cbxRequestParfumFilter.SelectedIndex < -1)
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
            String prodID = DatabaseHelper.getID($"select product_id from perfumetable where perfume = @perfume",
                new MySqlParameter("@perfume", cbxRequestParfumFilter.Text));
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "insert into requestlogtable values (@reqid, @prodid, @perfume, @quantity, @branch, NOW(), @message, @status)",
                    new MySqlParameter("@reqid", reqID),
                    new MySqlParameter("@prodid", prodID),
                    new MySqlParameter("@perfume", cbxRequestParfumFilter.Text),
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
            cbxRequestParfumFilter.Items.Clear();
            tbRequestMessage.Clear();
            numPerfumeAmountToRequest.Value = 0;
        }

    }
}
