using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventorySystem
{
    public partial class AdminEditPerfumePopUp : Form
    {
        private String prodID;
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;");
        public AdminEditPerfumePopUp(String id)
        {
            InitializeComponent();
            prodID = id;
            lblPerfumeID.Text = prodID;
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
                    String query = "update perfumetable set Perfume = @name, Note = @note, Branch = @branch, Quantity = @quantity where Product_ID = @id";
                    using (MySqlCommand accountEditCMD = new MySqlCommand(query, con))
                    {
                        accountEditCMD.Parameters.AddWithValue("@id", prodID);
                        accountEditCMD.Parameters.AddWithValue("@name", perfumeName);
                        accountEditCMD.Parameters.AddWithValue("@note", note);
                        accountEditCMD.Parameters.AddWithValue("@branch", branch);
                        accountEditCMD.Parameters.AddWithValue("@quantity", quantity);

                        int rowsAffected = accountEditCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Product successfully updated!");
                        }
                        else
                        {
                            MessageBox.Show("Product update error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error");
            }
        }
    }
}
