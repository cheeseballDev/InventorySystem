using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class StaffInventoryForm : Form
    {
        public StaffInventoryForm()
        {
            InitializeComponent();
            PlaceholderHelper.ApplyPlaceholder(tbSearchPerfumeFilter, "Search perfume...");
            cbxPerfumeBranchFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNote)));
            loadProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Product_ID"].Value.ToString();

                StaffEditPerfumePopUp editProductPopUp = new StaffEditPerfumePopUp(id);
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

        private void tbSearchProductFilter_TextChanged(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void loadProducts()
        {
            dgPerfume.DataSource = DatabaseHelper.ExecuteQuery("select * from perfumetable");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];
                string id = row.Cells["Product_ID"].Value.ToString();
                String incrementQuery = "UPDATE perfumetable SET quantity = quantity + 1 WHERE PRODUCT_ID = @id";
                DatabaseHelper.ExecuteNonQuery(incrementQuery, new MySqlParameter("@id", id));

                String addReport = "Added 1 to product quantity";
                String incrementReportQuery = "INSERT INTO reporttable (product_id, perfume, note, branch, quantity, status) SELECT product_id, perfume, note, branch, quantity, @status FROM perfumetable WHERE product_id = @id";
                DatabaseHelper.ExecuteNonQuery(incrementReportQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", addReport));
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

                String deductReport = "Deducted 1 to product quantity";
                String decrementReportQuery = "INSERT INTO reporttable (product_id, perfume, note, branch, quantity, status) SELECT product_id, perfume, note, branch, quantity, @status FROM perfumetable WHERE product_id = @id";
                DatabaseHelper.ExecuteNonQuery(decrementReportQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", deductReport));
                loadProducts();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void btnSearch(object sender, EventArgs e)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            string query = "select Product_ID, Perfume, Note, Branch, Quantity, Date_Created from perfumetable where 1=1 ";

            if (cbxPerfumeBranchFilter.SelectedIndex != -1)
            {
                query += " and Branch like @branch";
                parameters.Add(new MySqlParameter("@branch", "%" + cbxPerfumeBranchFilter.Text + "%"));
            }
            if (cbxPerfumeNoteFilter.SelectedIndex != -1)
            {
                query += " and Note like @note";
                parameters.Add(new MySqlParameter("@note", "%" + cbxPerfumeNoteFilter.Text + "%"));
            }
            if (!tbSearchPerfumeFilter.Text.Equals("Search perfume...") && !string.IsNullOrEmpty(tbSearchPerfumeFilter.Text))
            {
                query += " and (Product_ID like @search or Perfume like @search or Note like @search or Branch like @search)";
                parameters.Add(new MySqlParameter("@search", "%" + tbSearchPerfumeFilter.Text + "%"));
            }
            dgPerfume.DataSource = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }
    }
}
