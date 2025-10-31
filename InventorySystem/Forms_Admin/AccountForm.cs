using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Forms_Admin;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AccountForm : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;");
        public AccountForm()
        {
            InitializeComponent();
            displayAccounts();
            con.Open();
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateAccountPopUp capp = new CreateAccountPopUp();
            capp.ShowDialog();
        }

        private void displayAccounts()
        {
            String query = "select ID, Name, Email, Branch, Role, Date_Created from employeeaccount";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable accs = new DataTable();
                        adapter.Fill(accs);
                        dgAccounts.DataSource = accs;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error");
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dgAccounts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgAccounts.SelectedRows[0];

                string id = row.Cells["ID"].Value.ToString();

                SelectedAccountDetailsPopUp sapd = new SelectedAccountDetailsPopUp(id);
                sapd.ShowDialog();

                displayAccounts();
            }
            else if (dgAccounts.SelectedRows.Count > 1)
            {
                MessageBox.Show("One row at a time.");
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnArchiveAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to archieve this account?", "Archiving of Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("There is no account archieve page yet, this account will stay here for now.");
            }
            else if (dialogResult == DialogResult.No)
            {
                //wala lang
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String query = "select ID, Name, Email, Branch, Role, Date_Created from employeeaccount where ID like @search or Name like @search or Email like @search or Branch like @search or Role like @search";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + tbSearchUserFilter.Text + "%");
                        DataTable accs = new DataTable();
                        adapter.Fill(accs);
                        dgAccounts.DataSource = accs;
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
