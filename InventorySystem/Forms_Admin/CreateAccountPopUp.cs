using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem.Forms_Admin
{
    public partial class CreateAccountPopUp : Form
    {
        public CreateAccountPopUp()
        {
            InitializeComponent();
            cbxAccountBranch.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            cbxAccountRole.Items.AddRange(Enum.GetNames(typeof(Enums.AccountRoles)));
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
            String password = tbPassword.Text;
            String branch = cbxAccountBranch.Text;
            String role = cbxAccountRole.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill up all fields.", "Error");
                return;
            }

            string newID = DatabaseHelper.CheckForExistingId("select id from employeeaccount order by id desc limit 1", "E");

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "insert into employeeaccount (ID, Email, password, Name, Branch, Role) values (@id, @email, @password, @name, @branch, @role)",
                    new MySqlParameter("@id", newID),
                    new MySqlParameter("@email", email),
                    new MySqlParameter("@password", password),
                    new MySqlParameter("@name", name),
                    new MySqlParameter("@branch", branch),
                    new MySqlParameter("@role", role)
                );

            if (rowsAffected > 0)
            {
                MessageBox.Show($"Account created! Given ID is: {newID}");
                DatabaseHelper.LogAction($"Added new account ({newID})", "Create Account Page");
            }
            else
            {
                MessageBox.Show("Account creation error");
            }

        }
    }
}
