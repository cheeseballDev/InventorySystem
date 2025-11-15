using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AddNewPerfumePopUp : Form
    {
        private string currentSelectedPerfumeNote;
        private string currentSelectedPerfumeGender;
        public AddNewPerfumePopUp(String id)
        {
            InitializeComponent();
            cbxNewPerfumeBranch.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeNote)));
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

            if (String.IsNullOrEmpty(perfumeName))
            {
                MessageBox.Show("Please fill up the name field.", "Warning", MessageBoxButtons.OK);
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
                DatabaseHelper.LogAction($"Added new perfume ({newID})", "Add perfume page");
            }
            else
            {
                MessageBox.Show("Product addition error");
            }
        }

        private void changeFilter()
        {
            if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "All")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "All" && currentSelectedPerfumeGender == "Female")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "All" && currentSelectedPerfumeGender == "Male")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeGender == "Unisex" && currentSelectedPerfumeNote == "All")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "All")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Female")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Male")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Female")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Male")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxNewPerfumeFragranceType.Items.Clear();
            }
            else
            {
                cbxNewPerfumeFragranceType.Items.Clear();
                cbxNewPerfumeFragranceType.Items.Add("All");
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxNewPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxNewPerfumeFragranceType.SelectedIndex = 0;
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