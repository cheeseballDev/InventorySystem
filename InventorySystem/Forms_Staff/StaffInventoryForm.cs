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
    public partial class StaffInventoryForm : Form
    {
        public StaffInventoryForm()
        {
            InitializeComponent();
            PlaceholderHelper.ApplyPlaceholder(tbSearchProductFilter, "Search perfume...");
            loadProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Product_ID"].Value.ToString();

                StaffEditPerfumePopUp editProductPopUp = new StaffEditPerfumePopUp(id);
                editProductPopUp.ShowDialog();

                loadProducts();
            }
            else if (dgPerfume.SelectedRows.Count > 1)
            {
                MessageBox.Show("One row at a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbSearchProductFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchProductFilter.Text == "Search product" || string.IsNullOrWhiteSpace(tbSearchProductFilter.Text))
            {
                loadProducts();
                return;
            }
            String query = "select Product_ID, Perfume, Note, Branch, Quantity, Date_Created from perfumetable where Product_ID like @search or Perfume like @search or Note like @search or Branch like @search";
            MySqlParameter searchParameter = new MySqlParameter("@search", "%" + tbSearchProductFilter.Text + "%");

            dgPerfume.DataSource = DatabaseHelper.ExecuteQuery(query, searchParameter);
        }

        private void loadProducts()
        {
            String query = "select * from perfumetable";
            dgPerfume.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Product_ID"].Value.ToString();

                String incrementQuery = "UPDATE perfumetable SET quantity = quantity + 1 WHERE PRODUCT_ID = @id";

                DatabaseHelper.ExecuteNonQuery(incrementQuery, new MySqlParameter("@id", id));
                loadProducts();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeductSelectedPerfumeQuantity_Click(object sender, EventArgs e)
        {
            if (dgPerfume.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPerfume.SelectedRows[0];

                string id = row.Cells["Product_ID"].Value.ToString();

                String decrementQuery = "UPDATE perfumetable SET quantity = quantity - 1 WHERE PRODUCT_ID = @id";

                DatabaseHelper.ExecuteNonQuery(id, new MySqlParameter("@id", id));

                loadProducts();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProducts();
        }
    }
}
