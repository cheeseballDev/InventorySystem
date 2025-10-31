using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using InventorySystem.Forms_Admin;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace InventorySystem
{
    public partial class AccountForm : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;";

        public AccountForm()
        {
            InitializeComponent();
            displayAccounts();
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateAccountPopUp capp = new CreateAccountPopUp();
            capp.ShowDialog();
        }

        private void displayAccounts()
        {
            String query = "select ID, Name, Email, Branch, Role, Date_Created from employeeaccount";
            dgAccounts.DataSource = ExecuteQuery(query);
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
                MessageBox.Show("One row at a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (tbSearchUserFilter.Text == "Search user..." || string.IsNullOrWhiteSpace(tbSearchUserFilter.Text))
            {
                displayAccounts();
                return;
            }
            String query = "select ID, Name, Email, Branch, Role, Date_Created from employeeaccount where ID like @search or Name like @search or Email like @search or Branch like @search or Role like @search";
            MySqlParameter searchParameter = new MySqlParameter("@search", "%" + tbSearchUserFilter.Text + "%");

            dgAccounts.DataSource = ExecuteQuery(query, searchParameter);
        }

        private DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable tb = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tb);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tb;
        }

        private void tbSearchUserFilter_Enter(object sender, EventArgs e)
        {
            if (tbSearchUserFilter.Text == "Search user...")
            {
                tbSearchUserFilter.ForeColor = Color.FromArgb(135, 135, 135);
                tbSearchUserFilter.Text = "";
            }
        }

        private void tbSearchUserFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchUserFilter.Text))
            {
                tbSearchUserFilter.ForeColor = Color.FromArgb(135, 135, 135);
                tbSearchUserFilter.Text = "Search user...";
            }
        }

        private void tbSearchUserFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchUserFilter.Text == "Search user...")
            {
                tbSearchUserFilter.ForeColor = Color.FromArgb(135, 135, 135);
            } else
            {
                tbSearchUserFilter.ForeColor = Color.Black;
            }
        }
    }
}
