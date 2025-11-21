using InventorySystem.Forms_Admin;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AccountForm : Form
    {

        public AccountForm()
        {
            InitializeComponent();
            displayAccounts();
            PlaceholderHelper.ApplyPlaceholder(tbSearchUserFilter, "Search user...");
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateAccountPopUp capp = new CreateAccountPopUp();
            capp.ShowDialog();
        }

        private void displayAccounts()
        {
            String query = "select ID, Name, Email, Branch, Role, Date_Created from employeeaccount";
            dgAccounts.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dgAccounts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgAccounts.SelectedRows[0];

                string id = row.Cells["ID"].Value.ToString();

                SelectedAccountDetailsPopUp sapd = new SelectedAccountDetailsPopUp(id);
                sapd.ShowDialog();

                displayAccounts();
            }
            else if (dgAccounts.SelectedRows.Count > 1)
            {
                MessageBox.Show("One row at a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tbSearchUserFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchUserFilter.Text == "Search user..." || string.IsNullOrWhiteSpace(tbSearchUserFilter.Text))
            {
                displayAccounts();
                return;
            }
            String query = "select ID, Name, Email, Branch, Role, Date_Created from employeeaccount where ID like @search or Name like @search or Email like @search or Branch like @search or Role like @search";
            MySqlParameter searchParameter = new MySqlParameter("@search", "%" + tbSearchUserFilter.Text + "%");

            dgAccounts.DataSource = DatabaseHelper.ExecuteQuery(query, searchParameter);
            dgAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgAccounts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgAccounts.ScrollBars = ScrollBars.Both;
        }

        private void dgAccounts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgAccounts.ClearSelection();
            dgAccounts.CurrentCell = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayAccounts();
        }
    }
}
