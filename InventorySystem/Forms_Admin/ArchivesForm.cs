using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class ArchivesForm : Form
    {
        public ArchivesForm()
        {
            InitializeComponent();
            PlaceholderHelper.ApplyPlaceholder(tbSearchPerfumeFilter, "Search perfume...");
            PlaceholderHelper.ApplyPlaceholder(tbSearchUserFilter, "Search user...");
            loadAccounts();
            loadPerfume();
        }

        private void tbSearchProductFilter_TextChanged(object sender, EventArgs e)
        {
            loadPerfume();
        }

        private void tbSearchUserFilter_TextChanged(object sender, EventArgs e)
        {
            loadAccounts();
        }

        private void loadPerfume()
        {
            string query = "select * from archiveperfumestable where 1 = 1 ";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (!tbSearchPerfumeFilter.Text.Equals("Search perfume...") && !string.IsNullOrEmpty(tbSearchPerfumeFilter.Text))
            {
                query += " and Perfume_ID like @search or Perfume like @search or Branch like @search";
                parameters.Add(new MySqlParameter("@search", "%" + tbSearchPerfumeFilter.Text + "%"));
            }
            dgArchivedPerfume.DataSource = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
            dgArchivedPerfume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgArchivedPerfume.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgArchivedPerfume.ScrollBars = ScrollBars.Both;
        }

        private void loadAccounts()
        {
            String query = "select * from archiveaccountstable where 1 = 1 ";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (!tbSearchUserFilter.Text.Equals("Search user...") && !string.IsNullOrEmpty(tbSearchUserFilter.Text))
            {
                query += " and ID like @search or Name like @search or Email like @search or Branch like @search or Role like @search";
                parameters.Add(new MySqlParameter("@search", "%" + tbSearchUserFilter.Text + "%"));
            }
            dgArchivedAccounts.DataSource = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
            dgArchivedAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgArchivedAccounts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgArchivedAccounts.ScrollBars = ScrollBars.Both;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPerfume();
            loadAccounts();
        }

        private void dgArchivedPerfume_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgArchivedPerfume.ClearSelection();
            dgArchivedPerfume.CurrentCell = null;
        }

        private void dgArchivedAccounts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgArchivedAccounts.ClearSelection();
            dgArchivedAccounts.CurrentCell = null;
        }
    }
}
