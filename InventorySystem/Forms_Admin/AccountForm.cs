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
using InventorySystem.Helper_Classes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace InventorySystem
{
    public partial class AccountForm : Form
    {

        public AccountForm()
        {
            InitializeComponent();
            displayAccounts();
            PlaceholderHelper.ApplyPlaceholder(tbSearchUserFilter, "Search user...");
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateAccountPopUp capp = new CreateAccountPopUp();
            capp.ShowDialog();
        }

        private void displayAccounts()
        {
            String query = "select ID, Name, Email, Branch, Role, Date_Created from employeeaccount";
            dgAccounts.DataSource = DatabaseHelper.ExecuteQuery(query);
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

            dgAccounts.DataSource = DatabaseHelper.ExecuteQuery(query, searchParameter);
        }
    }
}
