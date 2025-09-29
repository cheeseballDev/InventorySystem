namespace InventorySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginStaffForm loginStaffForm = new LoginStaffForm();
            loginStaffForm.ShowDialog();
            
            
        }
    }
}
