using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventorySystem.Forms_Admin
{
    public partial class CreateAccountPopUp : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=inventorysystemdatabase;Uid=username;Pwd=password123;SslMode=None;");
        public CreateAccountPopUp()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            String password = tbPassword.Text;
            String branch = cbxAccountBranch.Text;
            String role = cbxAccountRole.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill up all fields.", "Error");
                return;
            }

            try
            {
                using (con)
                {
                    con.Open();
                    string lastIDquery = "select id from employeeaccount order by id desc limit 1";
                    string lastID = null;

                    using (MySqlCommand cmd = new MySqlCommand(lastIDquery, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lastID = reader.GetString("id");
                            }
                        }

                        string newID;
                        if (lastID != null)
                        {
                            int numID = int.Parse(lastID.Substring(2));
                            numID++;
                            newID = $"E-{numID:D3}";
                        }
                        else
                        {
                            newID = "E-001";
                        }


                        String query = "insert into employeeaccount (ID, Email, password, Name, Branch, Role) values (@id, @email, @password, @name, @branch, @role)";
                        using (MySqlCommand accountCreationCMD = new MySqlCommand(query, con))
                        {
                            accountCreationCMD.Parameters.AddWithValue("@id", newID);
                            accountCreationCMD.Parameters.AddWithValue("@email", email);
                            accountCreationCMD.Parameters.AddWithValue("@password", password);
                            accountCreationCMD.Parameters.AddWithValue("@name", name);
                            accountCreationCMD.Parameters.AddWithValue("@branch", branch);
                            accountCreationCMD.Parameters.AddWithValue("@role", role);

                            int rowsAffected = accountCreationCMD.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Account created! Given ID is: {newID}");

                                AuditLogQuery adq = new AuditLogQuery();

                                adq.LogAction("Added new account", "Create Account Page");

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Account creation error");
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
