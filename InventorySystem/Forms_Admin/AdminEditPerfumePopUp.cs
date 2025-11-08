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
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventorySystem
{
    public partial class AdminEditPerfumePopUp : Form
    {
        private String prodID;
        public AdminEditPerfumePopUp(String id)
        {
            InitializeComponent();
            cbxAddNewPerfumeBranch.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeBranch)));
            cbxAddNewPerfumeNoteType.Items.AddRange(Enum.GetNames(typeof(Enums.PerfumeNote)));
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
            AuditLogQuery alq = new AuditLogQuery();
            String perfumeName = tbPerfumeName.Text;
            String note = cbxAddNewPerfumeNoteType.Text;
            String branch = cbxAddNewPerfumeBranch.Text;
            int quantity = int.Parse(numPerfumeQuantity.Text);

            if (String.IsNullOrEmpty(perfumeName))
            {
                MessageBox.Show("Please fill up the name field.", "Warning", MessageBoxButtons.OK);
            }

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(
                "update perfumetable set Perfume = @name, Note = @note, Branch = @branch, Quantity = @quantity where Product_ID = @id",
                    new MySqlParameter("@id", prodID),
                    new MySqlParameter("@name", perfumeName),
                    new MySqlParameter("@note", note),
                    new MySqlParameter("@branch", branch),
                    new MySqlParameter("@quantity", quantity)
                );

            if (rowsAffected > 0)
            {
                MessageBox.Show($"Product successfully updated!");
                alq.LogAction("Perfume Edit", "Perfume Edit Page");
            }
            else
            {
                MessageBox.Show("Product update error");
            }
        }
    }
}
