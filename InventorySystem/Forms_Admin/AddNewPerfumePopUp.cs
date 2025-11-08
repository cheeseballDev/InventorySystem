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

namespace InventorySystem.Forms_Admin
{
    public partial class AddNewPerfumePopUp : Form
    {
        public AddNewPerfumePopUp()
        {
            InitializeComponent();
            cbxAddNewPerfumeBranch.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            cbxAddNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeNote)));
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
            string newID = DatabaseHelper.CheckForExistingId("select Product_ID from perfumetable order by Product_ID desc limit 1", "PERF");

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "insert into perfumetable (Product_ID, Perfume, Note, Branch, Quantity) values (@id, @name, @note, @branch, @quantity)",
                    new MySqlParameter("@id", newID),
                    new MySqlParameter("@name", perfumeName),
                    new MySqlParameter("@note", note),
                    new MySqlParameter("@branch", branch),
                    new MySqlParameter("@quantity", quantity)
                );

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
