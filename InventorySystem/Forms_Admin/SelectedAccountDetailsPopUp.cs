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
                DatabaseHelper.LogAction($"Edited Account Information for {empID}", "Edit Account Page");
            }
            else
            {
                MessageBox.Show("Account update error");
            }
        }

        private void loadDetails()
        {
            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;"))
            {
                con.Open();
                string query = "SELECT * FROM employeeaccount WHERE ID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", empID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbAccountEmail.Text = reader["Email"].ToString();
                            tbAccountName.Text = reader["Name"].ToString();
                        }
                    }
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
