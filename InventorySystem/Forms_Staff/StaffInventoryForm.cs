using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class StaffInventoryForm : Form
    {
        private string currentSelectedPerfumeNote;
        private string currentSelectedPerfumeGender;
        private int quantityAmount = 0;
        public StaffInventoryForm()
        {
            InitializeComponent();
            PlaceholderHelper.ApplyPlaceholder(tbSearchPerfumeFilter, "Search perfume...");

            cbxPerfumeNoteFilter.Items.Add("All");
            cbxPerfumeFragranceFilter.Items.Add("All");
            cbxPerfumeGenderFilter.Items.Add("All");

            cbxPerfumeBranchFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNote)));
            cbxPerfumeGenderFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeGender)));


            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));

            cbxPerfumeBranchFilter.SelectedIndex = 0;
            cbxPerfumeNoteFilter.SelectedIndex = 0;
            cbxPerfumeGenderFilter.SelectedIndex = 0;

            loadResults();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Product_ID"].Value.ToString();

                StaffEditPerfumePopUp editProductPopUp = new StaffEditPerfumePopUp(id);
                editProductPopUp.ShowDialog();

                loadResults();
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
            loadResults();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];
                string id = row.Cells["Product_ID"].Value.ToString();
                String incrementQuery = "UPDATE perfumetable SET quantity = quantity + 1 WHERE PRODUCT_ID = @id";
                DatabaseHelper.ExecuteNonQuery(incrementQuery, new MySqlParameter("@id", id));

                quantityAmount++;
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddSelectedPerfumeQuantity_Leave(object sender, EventArgs e)
        {
            DataGridViewRow row = dgPerfume.SelectedRows[0];
            string id = row.Cells["Product_ID"].Value.ToString();

            String addReport = $"Added {quantityAmount} to product quantity";
            String incrementReportQuery = "INSERT INTO reporttable (product_id, perfume, note, branch, quantity, status) SELECT product_id, perfume, note, branch, gender, fragrance, quantity, @status FROM perfumetable WHERE product_id = @id";
            DatabaseHelper.ExecuteNonQuery(incrementReportQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", addReport));
            quantityAmount = 0;
        }


        private void btnDeductSelectedPerfumeQuantity_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];
                string id = row.Cells["Product_ID"].Value.ToString();
                int qty = int.Parse(row.Cells["Quantity"].Value.ToString());
                if (qty > 0)
                {
                    String decrementQuery = "UPDATE perfumetable SET quantity = quantity - 1 WHERE PRODUCT_ID = @id";
                    DatabaseHelper.ExecuteNonQuery(decrementQuery, new MySqlParameter("@id", id));

                    quantityAmount--;
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeductSelectedPerfumeQuantity_Leave(object sender, EventArgs e)
        {
            DataGridViewRow row = dgPerfume.SelectedRows[0];
            string id = row.Cells["Product_ID"].Value.ToString();

            String deductReport = $"Deducted {quantityAmount} to product quantity";
            String decrementReportQuery = "INSERT INTO reporttable (product_id, perfume, note, branch, quantity, status) SELECT product_id, perfume, note, branch, gender, fragrance, quantity, @status FROM perfumetable WHERE product_id = @id";
            DatabaseHelper.ExecuteNonQuery(decrementReportQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", deductReport));
            quantityAmount = 0;
        }

        private void loadResults()
        {
            string query = "select Product_ID, Perfume, Note, Branch, Gender, Fragrance, Quantity, Date_created from perfumetable where 1=1 ";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (!tbSearchPerfumeFilter.Text.Equals("Search perfume...") && !string.IsNullOrEmpty(tbSearchPerfumeFilter.Text))
            {
                query += " and Perfume like @perfume";
                parameters.Add(new MySqlParameter("@perfume", "%" + tbSearchPerfumeFilter.Text + "%"));
            }
            if (!cbxPerfumeBranchFilter.Text.Equals("All"))
            {
                query += " and Branch like @branch";
                parameters.Add(new MySqlParameter("@branch", "%" + cbxPerfumeFragranceFilter.Text + "%"));
            }
            if (!cbxPerfumeNoteFilter.Text.Equals("All"))
            {
                query += " and Note like @note";
                parameters.Add(new MySqlParameter("@note", "%" + cbxPerfumeNoteFilter.Text + "%"));
            }
            if (!cbxPerfumeFragranceFilter.Text.Equals("All"))
            {
                query += " and Fragrance like @fragrance";
                parameters.Add(new MySqlParameter("@fragrance", "%" + cbxPerfumeFragranceFilter.Text + "%"));
            }
            if (!cbxPerfumeGenderFilter.Text.Equals("All"))
            {
                query += " and Gender like @gender";
                parameters.Add(new MySqlParameter("@gender", "%" + cbxPerfumeGenderFilter.Text + "%"));
            }

            dgPerfume.DataSource = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }

        private void changeFilter()
        {
            if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "All")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "All" && currentSelectedPerfumeGender == "Female")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "All" && currentSelectedPerfumeGender == "Male")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeGender == "Unisex" && currentSelectedPerfumeNote == "All")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "All")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Female")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Male")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Female")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Male")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxPerfumeFragranceFilter.Items.Clear();
            }
            else
            {
                cbxPerfumeFragranceFilter.Items.Clear();
                cbxPerfumeFragranceFilter.Items.Add("All");
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxPerfumeFragranceFilter.SelectedIndex = 0;
            }
        }

        private void cbxPerfumeNoteFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeNote = cbxPerfumeNoteFilter.Text;
            changeFilter();
            loadResults();
        }
        private void cbxPerfumeGenderFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeGender = cbxPerfumeGenderFilter.Text;
            changeFilter();
            loadResults();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadResults();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxPerfumeFragranceFilter.Items.Clear();
            cbxPerfumeFragranceFilter.Items.Add("All");
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
            cbxPerfumeFragranceFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
            cbxPerfumeBranchFilter.SelectedIndex = 0;
            cbxPerfumeNoteFilter.SelectedIndex = 0;
            cbxPerfumeGenderFilter.SelectedIndex = 0;
            cbxPerfumeFragranceFilter.SelectedIndex = 0;
            loadResults();
        }


    }
}
