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

            cbxPerfumeTypeFilter.Items.Add("All");
            cbxPerfumeNoteFilter.Items.Add("All");
            cbxPerfumeGenderFilter.Items.Add("All");

            cbxPerfumeBranchFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));
            cbxPerfumeTypeFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeType)));
            cbxPerfumeGenderFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeGender)));


            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));

            cbxPerfumeBranchFilter.SelectedIndex = 0;
            cbxPerfumeTypeFilter.SelectedIndex = 0;
            cbxPerfumeGenderFilter.SelectedIndex = 0;

            loadResults();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Perfume_ID"].Value.ToString();

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
                string id = row.Cells["Perfume_ID"].Value.ToString();
                String incrementQuery = "UPDATE perfumetable SET quantity = quantity + 1 WHERE Perfume_ID = @id";
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
            loadResults();
            DataGridViewRow row = dgPerfume.SelectedRows[0];
            string id = row.Cells["Perfume_ID"].Value.ToString();

            String addReport = $"Added {quantityAmount} to product quantity";
            String incrementReportQuery = "INSERT INTO reporttable (Perfume_ID, perfume, note, branch, quantity, status) SELECT Perfume_ID, perfume, note, branch, gender, fragrance, quantity, @status FROM perfumetable WHERE Perfume_ID = @id";
            DatabaseHelper.ExecuteNonQuery(incrementReportQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", addReport));
            quantityAmount = 0;
        }


        private void btnDeductSelectedPerfumeQuantity_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];
                string id = row.Cells["Perfume_ID"].Value.ToString();
                int qty = int.Parse(row.Cells["Quantity"].Value.ToString());
                if (qty > 0)
                {
                    String decrementQuery = "UPDATE perfumetable SET quantity = quantity - 1 WHERE Perfume_ID = @id";
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
            loadResults();
            DataGridViewRow row = dgPerfume.SelectedRows[0];
            string id = row.Cells["Perfume_ID"].Value.ToString();

            String deductReport = $"Deducted {quantityAmount} to product quantity";
            String decrementReportQuery = "INSERT INTO reporttable (Perfume_ID, perfume, note, branch, quantity, status) SELECT Perfume_ID, perfume, note, branch, gender, fragrance, quantity, @status FROM perfumetable WHERE Perfume_ID = @id";
            DatabaseHelper.ExecuteNonQuery(decrementReportQuery, new MySqlParameter("@id", id), new MySqlParameter("@status", deductReport));
            quantityAmount = 0;
        }

        private void loadResults()
        {
            string query = "SELECT Perfume_ID, Perfume_Name, Perfume_Type, Note, Gender, Branch, Quantity, Date_created from perfumetable where 1=1 ";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (!tbSearchPerfumeFilter.Text.Equals("Search perfume...") && !string.IsNullOrEmpty(tbSearchPerfumeFilter.Text))
            {
                query += " and Perfume like @perfume";
                parameters.Add(new MySqlParameter("@perfume", "%" + tbSearchPerfumeFilter.Text + "%"));
            }
            if (!cbxPerfumeBranchFilter.Text.Equals("All"))
            {
                query += " and Branch like @branch";
                parameters.Add(new MySqlParameter("@branch", "%" + cbxPerfumeBranchFilter.Text + "%"));
            }
            if (!cbxPerfumeTypeFilter.Text.Equals("All"))
            {
                query += " and Perfume_Type like @perfume_type";
                parameters.Add(new MySqlParameter("@perfume_type", "%" + cbxPerfumeTypeFilter.Text + "%"));
            }
            if (!cbxPerfumeNoteFilter.Text.Equals("All"))
            {
                query += " and Note like @note";
                parameters.Add(new MySqlParameter("@note", "%" + cbxPerfumeNoteFilter.Text + "%"));
            }
            if (!cbxPerfumeGenderFilter.Text.Equals("All"))
            {
                query += " and Gender like @gender";
                parameters.Add(new MySqlParameter("@gender", "%" + cbxPerfumeGenderFilter.Text + "%"));
            }

            dgPerfume.DataSource = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
            dgPerfume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgPerfume.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgPerfume.ScrollBars = ScrollBars.Both;
        }

        private void changeFilter()
        {
            if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "All")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "All" && currentSelectedPerfumeGender == "Female")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "All" && currentSelectedPerfumeGender == "Male")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeGender == "Unisex" && currentSelectedPerfumeNote == "All")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "All")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Female")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Male")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Female")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Male")
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxPerfumeNoteFilter.Items.Clear();
            }
            else
            {
                cbxPerfumeNoteFilter.Items.Clear();
                cbxPerfumeNoteFilter.Items.Add("All");
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
                cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));
                cbxPerfumeNoteFilter.SelectedIndex = 0;
            }
        }

        private void cbxPerfumeNoteFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeNote = cbxPerfumeTypeFilter.Text;
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
            cbxPerfumeNoteFilter.Items.Clear();
            cbxPerfumeNoteFilter.Items.Add("All");
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));
            cbxPerfumeBranchFilter.SelectedIndex = 0;
            cbxPerfumeTypeFilter.SelectedIndex = 0;
            cbxPerfumeGenderFilter.SelectedIndex = 0;
            cbxPerfumeNoteFilter.SelectedIndex = 0;
            loadResults();
        }
    }
}
