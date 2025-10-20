namespace InventorySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffLoginForm staffLoginForm = new StaffLoginForm();
            staffLoginForm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
            this.Hide();
        }
    }
}
