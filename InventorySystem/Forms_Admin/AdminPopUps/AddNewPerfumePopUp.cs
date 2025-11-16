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
            cbxNewPerfumeType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeType)));
            cbxNewPerfumeGenderType.Items.AddRange(Enum.GetNames(typeof(PerfumeGender)));

            cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
            cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
            cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
            cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
            cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));
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
            String type = cbxNewPerfumeType.Text;
            String branch = cbxNewPerfumeBranch.Text;
            String gender = cbxNewPerfumeGenderType.Text;
            String note = cbxNewPerfumeNoteType.Text;
            int quantity = int.Parse(numPerfumeQuantity.Text);

            if (string.IsNullOrEmpty(perfumeName))
            {
                MessageBox.Show("Please fill up the name field.", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please select a perfume type.", "Warning", MessageBoxButtons.OK);
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
            if (string.IsNullOrEmpty(note))
            {
                MessageBox.Show("Please select a note type.", "Warning", MessageBoxButtons.OK);
                return;
            }

            string newID = DatabaseHelper.CheckForExistingId("select Perfume_ID from perfumetable order by Perfume_ID desc limit 1", "PERF");

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "insert into perfumetable (Perfume_ID, Perfume_Name, Perfume_Type, Note, Gender, Branch, Quantity) values (@id, @name, @type, @note, @gender, @branch, @quantity)",
                    new MySqlParameter("@id", newID),
                    new MySqlParameter("@name", perfumeName),
                    new MySqlParameter("@type", type),
                    new MySqlParameter("@note", note),
                    new MySqlParameter("@gender", gender),
                    new MySqlParameter("@branch", branch),
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
                this.Close();
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
                cbxNewPerfumeNoteType.Enabled = true;
                cbxNewPerfumeNoteType.Items.Clear();
                cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Male")
            {
                cbxNewPerfumeNoteType.Enabled = true;
                cbxNewPerfumeNoteType.Items.Clear();
                cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxNewPerfumeNoteType.Enabled = true;
                cbxNewPerfumeNoteType.Items.Clear();
                cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Female")
            {
                cbxNewPerfumeNoteType.Enabled = true;
                cbxNewPerfumeNoteType.Items.Clear();
                cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Male")
            {
                cbxNewPerfumeNoteType.Enabled = true;
                cbxNewPerfumeNoteType.Items.Clear();
                cbxNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxNewPerfumeNoteType.Enabled = true;
                cbxNewPerfumeNoteType.Items.Clear();
            }
            else
            {
                cbxNewPerfumeNoteType.Enabled = false;
            }
        }

        private void cbxNewPerfumeNoteType_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeNote = cbxNewPerfumeType.Text;
            changeFilter();
        }

        private void cbxNewPerfumeGenderType_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeGender = cbxNewPerfumeGenderType.Text;
            changeFilter();
        }
    }
}