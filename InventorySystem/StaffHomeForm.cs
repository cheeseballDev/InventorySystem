using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.CodeDom;


namespace InventorySystem
{
    public partial class StaffHomeForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public StaffHomeForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            btnInventory_Click(new object(), new EventArgs());
            
            cbxUser.Items.AddRange(new object[] {"Staff", "Logout", "Exit"});
            cbxUser.SelectedItem = "Staff";
            cbxUser.SelectedIndexChanged += new System.EventHandler(cbxUser_SelectedIndexChanged);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnInventory.Height;
            pnlNavigation.Top = btnInventory.Top;
            pnlNavigation.Left = btnInventory.Left + 168;
            btnInventory.BackColor = Color.FromArgb(50, 225, 212, 193);

            lblTitle.Text = "Inventory";
            lblDescription.Text = "Overview of all available parfum products";
            this.pnlFormLoader.Controls.Clear();
            StaffInventoryForm staffInventoryForm = new StaffInventoryForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            staffInventoryForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(staffInventoryForm);
            staffInventoryForm.Show();

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnRequest.Height;
            pnlNavigation.Top = btnRequest.Top;
            btnRequest.BackColor = Color.FromArgb(50, 225, 212, 193);

            lblTitle.Text = "Request";
            lblDescription.Text = "Submit a request for restocking parfum products";
            this.pnlFormLoader.Controls.Clear();
            StaffRequestForm staffRequestForm = new StaffRequestForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            staffRequestForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(staffRequestForm);
            staffRequestForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnReport.Height;
            pnlNavigation.Top = btnReport.Top;
            btnReport.BackColor = Color.FromArgb(50, 225, 212, 193);

            lblTitle.Text = "Report";
            lblDescription.Text = "View the report and statuses of inventory, requests, and deliveries";
            this.pnlFormLoader.Controls.Clear();
            StaffReportForm staffReportForm = new StaffReportForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            staffReportForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(staffReportForm);
            staffReportForm.Show();
        }
        private void btnForecast_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnForecast.Height;
            pnlNavigation.Top = btnForecast.Top;
            btnForecast.BackColor = Color.FromArgb(50, 225, 212, 193);

            lblTitle.Text = "WORK IN PROGRESS !";
            lblDescription.Text = "Not enough INT to learn forecasting!";
            this.pnlFormLoader.Controls.Clear();
        }

        private void btnInventory_Leave(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void btnRequest_Leave(object sender, EventArgs e)
        {
            btnRequest.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void btnReport_Leave(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void btnForecast_Leave(object sender, EventArgs e)
        {
            btnForecast.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUser.SelectedIndex == 1)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }

            if(cbxUser.SelectedIndex == 2)
            {
                Application.Exit();
            }
        }
    }
}
