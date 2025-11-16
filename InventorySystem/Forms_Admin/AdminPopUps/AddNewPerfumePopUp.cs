using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AddNewPerfumePopUp : Form
    {
        private string currentSelectedPerfumeNote;
        private string currentSelectedPerfumeGender;
        public AddNewPerfumePopUp()
        {
            InitializeComponent();
            cbxNewPerfumeBranch.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            cbxNewPerfumeBranch.Items.RemoveAt(0);
            cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeNote)));
            cbxNewPerfumeGenderType.Items.AddRange(Enum.GetNames(typeof(PerfumeGender)));

            cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
            cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
            cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
            cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
            cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
            changeFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String perfumeName = tbNewPerfumeName.Text;
            String note = cbxNewPerfumeNoteType.Text;
            String branch = cbxNewPerfumeBranch.Text;
            String gender = cbxNewPerfumeGenderType.Text;
            String fragrance = cbxNewPerfumeFragranceType.Text;
            int quantity = int.Parse(numPerfumeQuantity.Text);

            if (string.IsNullOrEmpty(perfumeName))
            {
                MessageBox.Show("Please fill up the name field.", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(note))
            {
                MessageBox.Show("Please select a note type.", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(branch))
            {
                MessageBox.Show("Please select a branch.", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender type.", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(fragrance))
            {
                MessageBox.Show("Please select a fragrance type.", "Warning", MessageBoxButtons.OK);
                return;
            }

            string newID = DatabaseHelper.CheckForExistingId("select Product_ID from perfumetable order by Product_ID desc limit 1", "PERF");

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "insert into perfumetable (Product_ID, Perfume, Note, Branch, Gender, Fragrance Quantity) values (@id, @name, @note, @branch, @gender, @fragrance, @quantity)",
                    new MySqlParameter("@id", newID),
                    new MySqlParameter("@name", perfumeName),
                    new MySqlParameter("@note", note),
                    new MySqlParameter("@branch", branch),
                    new MySqlParameter("@gender", gender),
                    new MySqlParameter("@fragrance", fragrance),
                    new MySqlParameter("@quantity", quantity)
                );

            if (rowsAffected > 0)
            {
                MessageBox.Show($"Product added to the inventory! Product ID is: {newID}");
                DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                    new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                    new MySqlParameter("@userId", CurrentUser.id),
                    new MySqlParameter("@action", $"Added new perfume ({newID})"),
                    new MySqlParameter("@module", "Add perfume page"));
            }
            else
            {
                MessageBox.Show("Product addition error");
            }
        }

        private void changeFilter()
        {
            if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Female")
            {
                cbxNewPerfumeFragranceType.Enabled = true;
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Male")
            {
                cbxNewPerfumeFragranceType.Enabled = true;
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxNewPerfumeFragranceType.Enabled = true;
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Female")
            {
                cbxNewPerfumeFragranceType.Enabled = true;
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Male")
            {
                cbxNewPerfumeFragranceType.Enabled = true;
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxNewPerfumeFragranceType.Enabled = true;
                cbxNewPerfumeFragranceType.Items.Clear();
            }
            else
            {
                cbxNewPerfumeFragranceType.Enabled = false;
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
            }
        }


        private void cbxNewPerfumeNoteType_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeNote = cbxNewPerfumeNoteType.Text;
            changeFilter();
        }

        private void cbxNewPerfumeGenderType_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeGender = cbxNewPerfumeGenderType.Text;
            changeFilter();
        }

    }
}