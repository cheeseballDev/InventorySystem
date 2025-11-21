using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class StaffEditPerfumePopUp : Form
    {
        private string perfumeID;
        private int origQty;
        private string currentSelectedPerfumeNote;
        private string currentSelectedPerfumeGender;
        public StaffEditPerfumePopUp(String id)
        {
            InitializeComponent();
            cbxEditPerfumeBranch.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            cbxEditPerfumeBranch.Items.Remove("All");
            cbxEditPerfumeType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeType)));
            cbxEditPerfumeGenderType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeGender)));
            perfumeID = id;
            lblEditPerfumeID.Text = perfumeID;
            loadDetails();
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
            String perfumeName = tbEditPerfumeName.Text;
            String type = cbxEditPerfumeType.Text;
            String branch = cbxEditPerfumeBranch.Text;
            String gender = cbxEditPerfumeGenderType.Text;
            String note = cbxEditPerfumeNoteType.Text;
            int quantity = int.Parse(numPerfumeQuantity.Text);
            String status = null;
            if (quantity > origQty)
            {
                status = $"Added {quantity - origQty} to perfume quantity";
            }
            else if (quantity < origQty)
            {
                status = $"Deducted {origQty - quantity} to perfume quantity";
            }
            else if (quantity == origQty)
            {
                status = "Stock unchanged";
            }

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

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "UPDATE perfumetable SET Perfume_Name = @name, Perfume_Type = @type, Note = @note, Gender = @gender, Branch = @branch, Quantity = @quantity WHERE Perfume_ID = @id",
                    new MySqlParameter("@id", perfumeID),
                    new MySqlParameter("@name", perfumeName),
                    new MySqlParameter("@type", type),
                    new MySqlParameter("@note", note),
                    new MySqlParameter("@gender", gender),
                    new MySqlParameter("@branch", branch),
                    new MySqlParameter("@quantity", quantity)
                );

            if (rowsAffected > 0)
            {
                MessageBox.Show($"Perfume successfully updated!");
                DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                    new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                    new MySqlParameter("@userId", CurrentUser.id),
                    new MySqlParameter("@action", $"Edited perfume information for {perfumeID}"),
                    new MySqlParameter("@module", "Perfume Edit Page"));
                this.Close();
            }
            else
            {
                MessageBox.Show("Perfume update error");
            }

            int rowsAffected2 = DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO reporttable (Perfume_ID, branch, quantity, status) SELECT Perfume_ID, branch, quantity, @status FROM perfumetable WHERE Perfume_ID = @id",
                new MySqlParameter("@status", status),
                new MySqlParameter("@id", perfumeID));

            if (rowsAffected2 < 0)
            {
                MessageBox.Show("Writing report error");
            }
        }

        private void loadDetails()
        {
            string query = "SELECT * FROM perfumetable WHERE Perfume_ID = @id";
            DatabaseHelper.ExecuteReader(query, reader =>
            {
                lblEditPerfumeID.Text = reader["Perfume_ID"].ToString();
                tbEditPerfumeName.Text = reader["Perfume_Name"].ToString();
                numPerfumeQuantity.Text = reader["Quantity"].ToString();
                cbxEditPerfumeBranch.Text = reader["Branch"].ToString();
                cbxEditPerfumeGenderType.Text = reader["Gender"].ToString();
                cbxEditPerfumeType.Text = reader["Perfume_Type"].ToString();
                cbxEditPerfumeNoteType.Text = reader["Note"].ToString();
                if (reader["Quantity"] != DBNull.Value)
                {
                    numPerfumeQuantity.Value = Convert.ToDecimal(reader["Quantity"]);
                    origQty = Convert.ToInt32(numPerfumeQuantity.Value);
                }
                else
                {
                    numPerfumeQuantity.Value = 0;
                }
            },
            new MySqlParameter("@id", perfumeID)
            );
        }

        private void changeFilter()
        {
            if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Female")
            {
                cbxEditPerfumeNoteType.Enabled = true;
                cbxEditPerfumeNoteType.Items.Clear();
                cbxEditPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumFemale)));
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Male")
            {
                cbxEditPerfumeNoteType.Enabled = true;
                cbxEditPerfumeNoteType.Items.Clear();
                cbxEditPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumMale)));
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxEditPerfumeNoteType.Enabled = true;
                cbxEditPerfumeNoteType.Items.Clear();
                cbxEditPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNotePremiumUnisex)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Female")
            {
                cbxEditPerfumeNoteType.Enabled = true;
                cbxEditPerfumeNoteType.Items.Clear();
                cbxEditPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicFemale)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Male")
            {
                cbxEditPerfumeNoteType.Enabled = true;
                cbxEditPerfumeNoteType.Items.Clear();
                cbxEditPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(PerfumeNoteClassicMale)));
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxEditPerfumeNoteType.Enabled = true;
                cbxEditPerfumeNoteType.Items.Clear();
            }
            else
            {
                cbxEditPerfumeNoteType.Enabled = false;
            }
        }

        private void cbxEditPerfumeNoteType_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeNote = cbxEditPerfumeType.Text;
            changeFilter();
        }

        private void cbxEditPerfumeGenderType_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeGender = cbxEditPerfumeGenderType.Text;
            changeFilter();
        }
    }
}
