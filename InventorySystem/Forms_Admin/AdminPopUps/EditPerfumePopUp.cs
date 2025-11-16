using InventorySystem.Enums;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class EditPerfumePopUp : Form
    {
        private string prodID;
        private int origQty;
        private string currentSelectedPerfumeNote;
        private string currentSelectedPerfumeGender;
        public EditPerfumePopUp(String id)
        {
            InitializeComponent();
            cbxEditPerfumeBranch.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            cbxEditPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeNote)));
            cbxEditPerfumeGenderType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeGender)));
            prodID = id;
            lblEditPerfumeID.Text = prodID;
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
            String note = cbxEditPerfumeNoteType.Text;
            String branch = cbxEditPerfumeBranch.Text;
            String gender = cbxEditPerfumeGenderType.Text;
            String fragrance = cbxEditPerfumeFragranceType.Text;
            int quantity = int.Parse(numPerfumeQuantity.Text);
            String status = null;
            if (quantity > origQty)
            {
                status = $"Added {quantity - origQty} to product quantity";
            }
            else if (quantity < origQty)
            {
                status = $"Deducted {origQty - quantity} to product quantity";
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

            int rowsAffected1 = DatabaseHelper.ExecuteNonQuery(
                "update perfumetable set Perfume = @name, Note = @note, Branch = @branch, Gender = @gender, Fragrance = @fragrance, Quantity = @quantity where Product_ID = @id",
                    new MySqlParameter("@id", prodID),
                    new MySqlParameter("@name", perfumeName),
                    new MySqlParameter("@note", note),
                    new MySqlParameter("@branch", branch),
                    new MySqlParameter("@gender", gender),
                    new MySqlParameter("@fragrance", fragrance),
                    new MySqlParameter("@quantity", quantity)
                );

            if (rowsAffected1 > 0)
            {
                MessageBox.Show($"Product successfully updated!");
                DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                    new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                    new MySqlParameter("@userId", CurrentUser.id),
                    new MySqlParameter("@action", $"Edited perfume information for {prodID}"),
                    new MySqlParameter("@module", "Perfume Edit Page"));
            }
            else
            {
                MessageBox.Show("Product update error");
            }

            int rowsAffected2 = DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO reporttable (product_id, perfume, note, branch, quantity, status) SELECT product_id, perfume, note, branch, quantity, @status FROM perfumetable WHERE product_id = @id",
                new MySqlParameter("@status", status),
                new MySqlParameter("@id", prodID),
                new MySqlParameter("@name", perfumeName),
                new MySqlParameter("@note", note),
                new MySqlParameter("@branch", branch),
                new MySqlParameter("@quantity", quantity));

            if (rowsAffected2 < 0)
            {
                MessageBox.Show("Writing report error");
            }
        }

        private void loadDetails()
        {
            string query = "SELECT * FROM perfumetable WHERE product_id = @id";
            DatabaseHelper.ExecuteReader(query, reader =>
            {
                lblEditPerfumeID.Text = reader["Product_ID"].ToString();
                tbEditPerfumeName.Text = reader["Perfume"].ToString();
                numPerfumeQuantity.Text = reader["Quantity"].ToString();
                cbxEditPerfumeBranch.Text = reader["Branch"].ToString();
                cbxEditPerfumeGenderType.Text = reader["Gender"].ToString();
                cbxEditPerfumeFragranceType.Text = reader["Fragrance"].ToString();
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
            new MySqlParameter("@id", prodID)
            );
        }

        private void changeFilter()
        {
            if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "All")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "All" && currentSelectedPerfumeGender == "Female")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "All" && currentSelectedPerfumeGender == "Male")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeGender == "Unisex" && currentSelectedPerfumeNote == "All")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "All")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Female")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Male")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Premium" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Female")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Male")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
            else if (currentSelectedPerfumeNote == "Classic" && currentSelectedPerfumeGender == "Unisex")
            {
                cbxEditPerfumeFragranceType.Items.Clear();
            }
            else
            {
                cbxEditPerfumeFragranceType.Items.Clear();
                cbxEditPerfumeFragranceType.Items.Add("All");
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumFemale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicFemale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumMale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragranceClassicMale)));
                cbxEditPerfumeFragranceType.Items.AddRange(Enum.GetNames(typeof(PerfumeFragrancePremiumUnisex)));
                cbxEditPerfumeFragranceType.SelectedIndex = 0;
            }
        }


        private void cbxEditPerfumeNoteType_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeNote = cbxEditPerfumeNoteType.Text;
            changeFilter();
        }

        private void cbxEditPerfumeGenderType_SelectedValueChanged(object sender, EventArgs e)
        {
            currentSelectedPerfumeGender = cbxEditPerfumeGenderType.Text;
            changeFilter();
        }

        private void btnArchivePerfume_Click(object sender, EventArgs e)
        {
            String perfumeName = tbEditPerfumeName.Text;
            String note = cbxEditPerfumeNoteType.Text;
            String branch = cbxEditPerfumeBranch.Text;
            String gender = cbxEditPerfumeGenderType.Text;
            String fragrance = cbxEditPerfumeFragranceType.Text;

            DialogResult wot = MessageBox.Show("Are you sure you want to archive this product?", "Archive confirmation", MessageBoxButtons.YesNo);

            if (wot == DialogResult.Yes)
            {
                String query = "insert into archiveperfumestable values (@id, @perfume, @note, @gender, @fragrance, @branch, NOW())";

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query,
                        new MySqlParameter("@perfume", perfumeName),
                        new MySqlParameter("@note", note),
                        new MySqlParameter("@gender", gender),
                        new MySqlParameter("@fragrance", fragrance),
                        new MySqlParameter("@branch", branch),
                        new MySqlParameter("@id", prodID)
                    );

                if (rowsAffected > 0)
                {
                    DatabaseHelper.ExecuteNonQuery("Delete from perfumetable where product_id = @id", new MySqlParameter("@id", prodID));
                    MessageBox.Show("Product archived");
                    DatabaseHelper.ExecuteNonQuery("INSERT INTO auditlogtable (log_id, user_id, action, module, timestamp) VALUES (@logID, @userID, @action, @module, NOW())",
                       new MySqlParameter("@logID", DatabaseHelper.CheckForExistingId("select log_id FROM auditlogtable order by log_id desc limit 1", "AL")),
                       new MySqlParameter("@userId", CurrentUser.id),
                       new MySqlParameter("@action", $"Archived product ({prodID})"),
                       new MySqlParameter("@module", "Perfume Edit Page"));
                    this.Close();
                }
            }
        }
    }
}
