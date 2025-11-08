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
using InventorySystem.Helper_Classes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
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
            string query = "SELECT COUNT(*) FROM adminaccount WHERE email=@email AND password=@password";

            int count = DatabaseHelper.ExecuteScalar(query, 
                new MySqlParameter("@email", email),
                new MySqlParameter("@password", password)
                );

            if (count > 0)
            {
                this.Tag = "AdminHomeForm";
                this.Close();
                String id = DatabaseHelper.getID(email, "adminaccount");
                CurrentUser.id = id;
            }
            else
            {
                MessageBox.Show("Invalid Email or Password.", "Login Failed");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Tag = "Back";
            this.Close();
        }
    }
}
