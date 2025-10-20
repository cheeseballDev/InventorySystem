using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace InventorySystem
{
    public partial class StaffLoginForm : Form
    {
        MySqlConnection con = new MySqlConnection("Server=sql12.freesqldatabase.com;Port=3306;Database=sql12803779;Uid=sql12803779;Pwd=3DiTUASBpH;SslMode=None;");
        public StaffLoginForm()
        {
            InitializeComponent();
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            con.Open();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email = tbEmail.Text;
            String password = tbPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password.", "Error");
                return;
            }

            try
            {
                string query = "SELECT COUNT(*) FROM employeeAccount WHERE email=@email AND password=@password";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        this.Close();
                        StaffHomeForm staffHomePage = new StaffHomeForm();
                        staffHomePage.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password.", "Login Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}
