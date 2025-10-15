using MySql.Data.MySqlClient;
namespace InventorySystem
{
    public partial class LoginForm : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=capstun;Pwd=cooked123;SslMode=None;");

        public LoginForm()
        {
            InitializeComponent();
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            con.Open();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

            try
            {
                String query = "SELECT COUNT(*) FROM employeeaccount";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("No accounts found, please ask the admin to add/create an account", "OK");
                    }
                    else
                    {
                        this.Hide();
                        LoginStaffForm loginStaffForm = new LoginStaffForm();
                        loginStaffForm.ShowDialog();
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
                String query = "SELECT COUNT(*) FROM adminaccount";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("Table empty, WIP", "OK");
                    }
                    else
                    {
                        MessageBox.Show("WIP", "OK");
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
            this.Close();
        }
    }
}

