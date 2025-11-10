
using InventorySystem.Helper_Classes;

namespace InventorySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private int lookForAccount(string type)
        {
            if (type == "staff")
            {
                String query = "SELECT COUNT(*) FROM employeeAccount";
                return DatabaseHelper.ExecuteScalar(query);
            }
            else if (type == "admin")
            {
                String query = "SELECT COUNT(*) FROM adminAccount";
                return DatabaseHelper.ExecuteScalar(query);
            }
            return 0;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            int count = lookForAccount("staff");
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            int count = lookForAccount("admin");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
