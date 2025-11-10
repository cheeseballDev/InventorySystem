using InventorySystem.Enums;
using InventorySystem.Forms_Admin;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AdminInventoryForm : Form
    {
        public AdminInventoryForm()
        {
            InitializeComponent();
            loadProducts();
            Helper_Classes.PlaceholderHelper.ApplyPlaceholder(tbSearchPerfumeFilter, "Search perfume...");

            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNote)));
            cbxPerfumeBranchFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddNewPerfumePopUp addPerfume = new AddNewPerfumePopUp();
            addPerfume.ShowDialog();
        }

        private void btnScanQR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT PART OF THIS MINI-THESIS' SCOPE", "WIP", MessageBoxButtons.OK);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Product_ID"].Value.ToString();

                AdminEditPerfumePopUp editProductPopUp = new AdminEditPerfumePopUp(id);
                editProductPopUp.ShowDialog();

                loadProducts();
            }
            else if (dgPerfume.SelectedRows.Count > 1)
            {
                MessageBox.Show("One row at a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadProducts()
        {
            String query = "select * from perfumetable";
            dgPerfume.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void tbSearchPerfumeFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchPerfumeFilter.Text == "Search perfume..." || string.IsNullOrWhiteSpace(tbSearchPerfumeFilter.Text))
            {
                loadProducts();
                return;
            }
            String query = "select Product_ID, Perfume, Note, Branch, Quantity, Date_Created from perfumetable where Product_ID like @search or Perfume like @search or Note like @search or Branch like @search";
            MySqlParameter searchParameter = new MySqlParameter("@search", "%" + tbSearchPerfumeFilter.Text + "%");

            dgPerfume.DataSource = DatabaseHelper.ExecuteQuery(query, searchParameter);
        }

        private void btnAddSelectedPerfumeQuantity_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Product_ID"].Value.ToString();

                String incrementQuery = "UPDATE perfumetable SET quantity = quantity + 1 WHERE PRODUCT_ID = @id";

                DatabaseHelper.ExecuteNonQuery(incrementQuery, new MySqlParameter("@id", id));

                loadProducts();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeductSelectedPerfumeQuantity_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Product_ID"].Value.ToString();

                String decrementQuery = "UPDATE perfumetable SET quantity = quantity - 1 WHERE PRODUCT_ID = @id";

                DatabaseHelper.ExecuteNonQuery(decrementQuery, new MySqlParameter("@id", id));

                loadProducts();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
