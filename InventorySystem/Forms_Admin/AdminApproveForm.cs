namespace InventorySystem
{
    public partial class AdminApproveForm : Form
    {
        public AdminApproveForm()
        {
            InitializeComponent();
            cbxRequestBranchFilter.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
        }

        private void btnOpenDetails_Click(object sender, EventArgs e)
        {
            AdminRequestDetailsPopUp adminRequestDetailsPopUp = new AdminRequestDetailsPopUp();
            adminRequestDetailsPopUp.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
