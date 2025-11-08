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
using InventorySystem.Helper_Classes;


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

            FormLoaderHelper.LoadForm(
               pnlFormLoader,
               new StaffInventoryForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true },
               lblTitle,
               lblDescription,
               "Inventory",
               "Overview of all available parfum products"
               );
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnRequest.Height;
            pnlNavigation.Top = btnRequest.Top;
            btnRequest.BackColor = Color.FromArgb(50, 225, 212, 193);

            FormLoaderHelper.LoadForm(
              pnlFormLoader,
              new StaffRequestForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true },
              lblTitle,
              lblDescription,
              "Request",
              "Submit a request for restocking parfum products"
              );

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnReport.Height;
            pnlNavigation.Top = btnReport.Top;
            btnReport.BackColor = Color.FromArgb(50, 225, 212, 193);

            FormLoaderHelper.LoadForm(
              pnlFormLoader,
              new ReportForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true },
              lblTitle,
              lblDescription,
              "Report",
              "View the report and statuses of inventory, requests, and deliveries"
              );

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
                this.Tag = "Back";
                this.Close();
            }

            if(cbxUser.SelectedIndex == 2)
            {
                Application.Exit();
            }
        }
    }
}
