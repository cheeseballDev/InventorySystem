using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class StaffEditPerfumePopUp : Form
    {
        private String perfumeID;
        private int origQty;
        public StaffEditPerfumePopUp(String id)
        {
            InitializeComponent();
            perfumeID = id;
            lblPerfumeID.Text = perfumeID;
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
            String perfumeName = tbPerfumeName.Text;
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

            if (string.IsNullOrEmpty(perfumeName))
            {
                MessageBox.Show("Please fill up the name field.", "Warning", MessageBoxButtons.OK);
            }

            int rowsAffected1 = DatabaseHelper.ExecuteNonQuery(
                "update perfumetable set Perfume_Name = @name, Quantity = @quantity where Perfume_ID = @id",
                    new MySqlParameter("@id", perfumeID),
                    new MySqlParameter("@name", perfumeName),
                    new MySqlParameter("@quantity", quantity));

            if (rowsAffected1 > 0)
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
                MessageBox.Show("Product update error");
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
                tbPerfumeName.Text = reader["Perfume_Name"].ToString();
                numPerfumeQuantity.Text = reader["Quantity"].ToString();
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
    }
}
