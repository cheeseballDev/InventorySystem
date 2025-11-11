using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email = tbEmail.Text;
            String password = tbPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password.", "Error");
                return;
            }
            string query = "SELECT COUNT(*) FROM adminaccount WHERE email=@email AND password=@password";

            int count = DatabaseHelper.ExecuteScalar(query,
                new MySqlParameter("@email", email),
                new MySqlParameter("@password", password)
                );

            if (count > 0)
            {
                this.Tag = "AdminHomeForm";
                this.Close();
                String id = DatabaseHelper.getID("select id FROM adminaccount where email = @email limit 1", new MySqlParameter("@email", email));
                CurrentUser.id = id;
            }
            else
            {
                MessageBox.Show("Invalid Email or Password.", "Login Failed");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Tag = "Back";
            this.Close();
        }
    }
}
