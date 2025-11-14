using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class StaffEditPerfumePopUp : Form
    {
        private String prodID;
        private int origQty;
        public StaffEditPerfumePopUp(String id)
        {
            InitializeComponent();
            prodID = id;
            lblPerfumeID.Text = prodID;
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
            if(quantity > origQty)
            {
                status = $"Added {quantity - origQty} to product quantity";
            }
            else if(quantity < origQty)
            {
                status = $"Deducted {origQty - quantity} to product quantity";
            }

            if (String.IsNullOrEmpty(perfumeName))
            {
                MessageBox.Show("Please fill up the name field.", "Warning", MessageBoxButtons.OK);
            }

            int rowsAffected1 = DatabaseHelper.ExecuteNonQuery(
                "update perfumetable set Perfume = @name, Quantity = @quantity where Product_ID = @id",
                    new MySqlParameter("@id", prodID),
                    new MySqlParameter("@name", perfumeName),
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
                new MySqlParameter("@id", prodID));

            if (rowsAffected2 > 0)
            {
                //blank
            }
            else
            {
                MessageBox.Show("Writing report error");
            }
        }

        private void loadDetails()
        {
            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;"))
            {
                con.Open();
                string query = "SELECT * FROM perfumetable WHERE product_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", prodID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbPerfumeName.Text = reader["Perfume"].ToString();
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
                        }
                    }
                }
            }
        }
    }
}
