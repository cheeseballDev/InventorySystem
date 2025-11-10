using InventorySystem.Enums;

namespace InventorySystem
{
    public partial class StaffRequestForm : Form
    {
        public StaffRequestForm()
        {
            InitializeComponent();
            cbxRequestCurrentBranchFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));

            List<string> parfumList = new List<string>();
            parfumList = Helper_Classes.DatabaseHelper.GetListQuery("SELECT Perfume FROM perfumetable GROUP BY Perfume");

            cbxRequestParfumFilter.Items.AddRange(parfumList.ToArray());
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
