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
    public partial class SelectedAccountDetailsPopUp : Form
    {
        private String empID;
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;");
        public SelectedAccountDetailsPopUp(String id)
        {
            InitializeComponent();
            empID = id;
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
            /*
            String name = tbAccountName.Text;
            String email;
            if (!tbAccountEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Invalid email address!");
                return;
            }
            else
            {
                email = tbAccountEmail.Text;
            }
            String branch = cbxAccountBranch.Text;
            String role = cbxAccountRole.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill up all fields.", "Error");
                return;
            }

            try
            {
                using (con)
                {
                    con.Open();
                    String query = "update employeeaccount set Email = @email, Name = @name, Branch = @branch, Role = @role where ID = @id";
                    using (MySqlCommand accountEditCMD = new MySqlCommand(query, con))
                    {
                        accountEditCMD.Parameters.AddWithValue("@id", empID);
                        accountEditCMD.Parameters.AddWithValue("@email", email);
                        accountEditCMD.Parameters.AddWithValue("@name", name);
                        accountEditCMD.Parameters.AddWithValue("@branch", branch);
                        accountEditCMD.Parameters.AddWithValue("@role", role);

                        int rowsAffected = accountEditCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Account successfully updated!");
                        }
                        else
                        {
                            MessageBox.Show("Account update error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error");
            }
            */

            String name = tbAccountName.Text;
            String email;
            if (!tbAccountEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Invalid email address!");
                return;
            }
            else
            {
                email = tbAccountEmail.Text;
            }
            String branch = cbxAccountBranch.Text;
            String role = cbxAccountRole.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill up all fields.", "Error");
                return;
            }
            String query = "update employeeaccount set Email = @email, Name = @name, Branch = @branch, Role = @role where ID = @id";

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query,
                    new MySqlParameter("@email", email),
                    new MySqlParameter("@name", name),
                    new MySqlParameter("@branch", branch),
                    new MySqlParameter("@role", role)
                );

            if (rowsAffected > 0)
            {
                MessageBox.Show($"Account successfully updated!");
            }
            else
            {
                MessageBox.Show("Account update error");
            }
        }
    }
}
