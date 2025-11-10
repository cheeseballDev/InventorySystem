using System.Runtime.InteropServices;
using InventorySystem.Helper_Classes;


namespace InventorySystem
{
    public partial class StaffHomeForm : Form
    {
        private Color defaultButtonColor = Color.FromArgb(28, 28, 28);
        private Color hoverButtonColor = Color.FromArgb(50, 225, 212, 193);

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

            cbxUser.Items.AddRange(new object[] { CurrentUser.id, "Logout", "Exit" });
            cbxUser.SelectedItem = CurrentUser.id;
            cbxUser.SelectedIndexChanged += new System.EventHandler(cbxUser_SelectedIndexChanged);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btnInventory.BackColor = hoverButtonColor;

            pnlNavigation.Height = btnInventory.Height;
            pnlNavigation.Top = btnInventory.Top;
            pnlNavigation.Left = btnInventory.Left + 168;

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
            ResetButtons();
            btnRequest.BackColor = hoverButtonColor;

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
            ResetButtons();
            btnReport.BackColor = hoverButtonColor;

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
            ResetButtons();
            btnForecast.BackColor = hoverButtonColor;

            pnlNavigation.Height = btnForecast.Height;
            pnlNavigation.Top = btnForecast.Top;
            btnForecast.BackColor = Color.FromArgb(50, 225, 212, 193);

            lblTitle.Text = "WORK IN PROGRESS !";
            lblDescription.Text = "Not enough INT to learn forecasting!";
            this.pnlFormLoader.Controls.Clear();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            // temp
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // temp
        }

        private void ResetButtons()
        {
            btnInventory.BackColor = defaultButtonColor;
            btnRequest.BackColor = defaultButtonColor;
            btnReport.BackColor = defaultButtonColor;
            btnForecast.BackColor = defaultButtonColor;
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUser.SelectedIndex == 1)
            {
                this.Tag = "Back";
                this.Close();
            }

            if (cbxUser.SelectedIndex == 2)
            {
                Application.Exit();
            }
        }
    }
}
