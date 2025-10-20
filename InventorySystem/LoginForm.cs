using MySql.Data.MySqlClient;
namespace InventorySystem
{
    public partial class LoginForm : Form
    {
<<<<<<< HEAD
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=capstun;Pwd=cooked123;SslMode=None;");
=======
        MySqlConnection con = new MySqlConnection("Server=sql12.freesqldatabase.com;Port=3306;Database=sql12803779;Uid=sql12803779;Pwd=3DiTUASBpH;SslMode=None;");
>>>>>>> c2ac6498838e9be29187822f769c1249e318883e

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
<<<<<<< HEAD
                String query = "SELECT COUNT(*) FROM employeeaccount";
=======
                String query = "SELECT COUNT(*) FROM employeeAccount";
>>>>>>> c2ac6498838e9be29187822f769c1249e318883e
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
<<<<<<< HEAD
                        LoginStaffForm loginStaffForm = new LoginStaffForm();
=======
                        StaffLoginForm loginStaffForm = new StaffLoginForm();
>>>>>>> c2ac6498838e9be29187822f769c1249e318883e
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
<<<<<<< HEAD
                String query = "SELECT COUNT(*) FROM adminaccount";
=======
                String query = "SELECT COUNT(*) FROM adminAccount";
>>>>>>> c2ac6498838e9be29187822f769c1249e318883e
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
<<<<<<< HEAD
                        MessageBox.Show("Table empty, WIP", "OK");
                    }
                    else
                    {
                        MessageBox.Show("WIP", "OK");
=======
                        MessageBox.Show("No accounts found, add one through the database", "OK");
                    }
                    else
                    {
                        this.Hide();
                        AdminLoginForm adminStaffForm = new AdminLoginForm();
                        adminStaffForm.ShowDialog();
>>>>>>> c2ac6498838e9be29187822f769c1249e318883e
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

