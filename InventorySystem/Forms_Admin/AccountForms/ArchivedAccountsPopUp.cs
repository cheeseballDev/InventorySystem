using InventorySystem.Forms_Admin;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class ArchivedAccountsPopUp : Form
    {

        public ArchivedAccountsPopUp()
        {
            InitializeComponent();
            displayAccounts();
            PlaceholderHelper.ApplyPlaceholder(tbSearchUserFilter, "Search user...");
        }

        private void displayAccounts()
        {
            String query = "select * from archiveaccountstable";
            dgArchivedAccounts.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dgArchivedAccounts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgArchivedAccounts.SelectedRows[0];

                string id = row.Cells["ID"].Value.ToString();

                SelectedAccountDetailsPopUp sapd = new SelectedAccountDetailsPopUp(id);
                sapd.ShowDialog();

                displayAccounts();
            }
            else if (dgArchivedAccounts.SelectedRows.Count > 1)
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

            String query = "select * from archiveaccountstable where ID like @search or Name like @search or Email like @search or Branch like @search or Role like @search";
            MySqlParameter searchParameter = new MySqlParameter("@search", "%" + tbSearchUserFilter.Text + "%");

            dgArchivedAccounts.DataSource = DatabaseHelper.ExecuteQuery(query, searchParameter);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
