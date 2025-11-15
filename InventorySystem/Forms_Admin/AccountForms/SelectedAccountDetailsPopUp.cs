using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem.Forms_Admin
{
    public partial class SelectedAccountDetailsPopUp : Form
    {
        private String empID;
        public SelectedAccountDetailsPopUp(String id)
        {
            InitializeComponent();
            cbxAccountBranch.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));
            cbxAccountRole.Items.AddRange(Enum.GetNames(typeof(AccountRoles)));
            empID = id;
            loadDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = tbAccountName.Text;
            String email;
            if (!tbAccountEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Invalid email address!");
                return;
            }
            else
            {
                email = tbAccountEmail.Text;
            }
            String branch = cbxAccountBranch.Text;
            String role = cbxAccountRole.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill up all fields.", "Error");
                return;
            }
            String query = "update employeeaccount set Email = @email, Name = @name, Branch = @branch, Role = @role where ID = @id";

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query,
                    new MySqlParameter("@email", email),
                    new MySqlParameter("@name", name),
                    new MySqlParameter("@branch", branch),
                    new MySqlParameter("@role", role),
                    new MySqlParameter("@id", empID)
                );

            if (rowsAffected > 0)
            {
                MessageBox.Show($"Account successfully updated!");
                DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                    new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                    new MySqlParameter("@userId", CurrentUser.id),
                    new MySqlParameter("@action", $"Edited Account Information for {empID}"),
                    new MySqlParameter("@module", "Edit Account Page"));
            }
            else
            {
                MessageBox.Show("Account update error");
            }
        }

        private void loadDetails()
        {
            string query = "SELECT * FROM employeeaccount WHERE ID = @id";
            DatabaseHelper.ExecuteReader(query, reader =>
            {
                tbAccountEmail.Text = reader["Email"].ToString();
                tbAccountName.Text = reader["Name"].ToString();
            },
            new MySqlParameter("@id", empID)
            );
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArchiveAccount_Click(object sender, EventArgs e)
        {
            //TODO: Archive Account Functionality
        }
    }
}
