using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventorySystem.Forms_Admin
{
    public partial class AddNewPerfumePopUp : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;");
        public AddNewPerfumePopUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String perfumeName = tbPerfumeName.Text;
            String note = cbxAddNewPerfumeNoteType.Text;
            String branch = cbxAddNewPerfumeBranch.Text;
            int quantity = int.Parse(numPerfumeQuantity.Text);

            if (String.IsNullOrEmpty(perfumeName))
            {
                MessageBox.Show("Please fill up the name field.", "Warning", MessageBoxButtons.OK);
            }

            try
            {
                using (con)
                {
                    con.Open();
                    string lastIDquery = "select Product_ID from perfumetable order by Product_ID desc limit 1";
                    string lastID = null;

                    using (MySqlCommand cmd = new MySqlCommand(lastIDquery, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lastID = reader.GetString("Product_ID");
                            }
                        }

                        string newID;
                        if (lastID != null)
                        {
                            int numID = int.Parse(lastID.Substring(5));
                            numID++;
                            newID = $"PERF-{numID:D3}";
                        }
                        else
                        {
                            newID = "PERF-001";
                        }

                        String addNewProductQuery = "insert into perfumetable (Product_ID, Perfume, Note, Branch, Quantity) values (@id, @name, @note, @branch, @quantity)";
                        using(MySqlCommand addPerfumeCMD = new MySqlCommand(addNewProductQuery, con))
                        {
                            addPerfumeCMD.Parameters.AddWithValue("@id", newID);
                            addPerfumeCMD.Parameters.AddWithValue("@name", perfumeName);
                            addPerfumeCMD.Parameters.AddWithValue("@note", note);
                            addPerfumeCMD.Parameters.AddWithValue("@branch", branch);
                            addPerfumeCMD.Parameters.AddWithValue("@quantity", quantity);

                            int rowsAffected = addPerfumeCMD.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Product added to the inventory! Product ID is: {newID}");
                            }
                            else
                            {
                                MessageBox.Show("Product addition error");
                            }
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error");
            }
        }   
    }
}
