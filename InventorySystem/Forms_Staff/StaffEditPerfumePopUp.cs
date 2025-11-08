using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class StaffEditPerfumePopUp : Form
    {
        private String prodID;
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;");

        public StaffEditPerfumePopUp(String id)
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
            int quantity = int.Parse(numPerfumeQuantity.Text);

            if (String.IsNullOrEmpty(perfumeName))
            {
                MessageBox.Show("Please fill up the name field.", "Warning", MessageBoxButtons.OK);
            }

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "update perfumetable set Perfume = @name, Quantity = @quantity where Product_ID = @id",
                    new MySqlParameter("@id", prodID),
                    new MySqlParameter("@name", perfumeName),
                    new MySqlParameter("@quantity", quantity)
                );

            if (rowsAffected > 0)
            {
                AuditLogQuery alq = new AuditLogQuery();
                MessageBox.Show($"Product successfully updated!");
                alq.LogAction("Edited perfume information", "Inventory page");
            }
            else
            {
                MessageBox.Show("Product update error");
            }
        }
    }
}
