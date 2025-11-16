using System.Data;
using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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
            String password = tbAccountPassword.Text;
            String branch = cbxAccountBranch.Text;
            String role = cbxAccountRole.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill up all fields.", "Error");
                return;
            }
            String query = "update employeeaccount set Email = @email, Password = @password, Name = @name, Branch = @branch, Role = @role where ID = @id";

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query,
                    new MySqlParameter("@email", email),
                    new MySqlParameter("@password", password),
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
                tbAccountPassword.Text = reader["Password"].ToString();
                cbxAccountBranch.Text = reader["Branch"].ToString();
                cbxAccountRole.Text = reader["Role"].ToString();
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
            String name = tbAccountName.Text;
            String email = tbAccountEmail.Text;
            String password = tbAccountPassword.Text;
            String branch = cbxAccountBranch.Text;
            String role = cbxAccountRole.Text;

            DialogResult wot = MessageBox.Show("Are you sure you want to archive this account?", "Archive confirmation", MessageBoxButtons.YesNo);

            if (wot == DialogResult.Yes)
            {
                String query = "insert into archiveaccountstable values (@id, @email, @password, @name, @role, @branch, NOW())";

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query,
                        new MySqlParameter("@email", email),
                        new MySqlParameter("@password", password),
                        new MySqlParameter("@name", name),
                        new MySqlParameter("@branch", branch),
                        new MySqlParameter("@role", role),
                        new MySqlParameter("@id", empID)
                    );

                if (rowsAffected > 0)
                {
                    DatabaseHelper.ExecuteNonQuery("Delete from employeeaccount where id = @id", new MySqlParameter("@id", empID));
                    MessageBox.Show("Account archived");
                    DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                       new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                       new MySqlParameter("@userId", CurrentUser.id),
                       new MySqlParameter("@action", $"Archived account ({empID})"),
                       new MySqlParameter("@module", "Edit Account Page"));
                    this.Close();
                }
            }
        }
    }
}
