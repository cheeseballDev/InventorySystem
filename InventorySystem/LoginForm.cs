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
            
            this.Hide();
            LoginStaffForm loginStaffForm = new LoginStaffForm();
            loginStaffForm.ShowDialog();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
