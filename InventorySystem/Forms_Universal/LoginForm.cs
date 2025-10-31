using MySql.Data.MySqlClient;
namespace InventorySystem
{
    public partial class LoginForm : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;");

        
        public LoginForm()
        {
            InitializeComponent();
            con.Open();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

            try
            {
                String query = "SELECT COUNT(*) FROM employeeAccount";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("No accounts found, please ask the admin to add/create an account", "OK");
                    }
                    else
                    {
                        this.Tag = "StaffLoginForm";
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT COUNT(*) FROM adminAccount";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("No accounts found, add one through the database", "OK");
                    }
                    else
                    {
                        this.Tag = "AdminLoginForm";
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
