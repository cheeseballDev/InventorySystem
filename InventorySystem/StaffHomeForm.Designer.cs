namespace InventorySystem
{
    partial class StaffHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHomeForm));
            panel1 = new Panel();
            pnlNavigation = new Panel();
            btnForecast = new Button();
            btnReport = new Button();
            btnRequest = new Button();
            btnInventory = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            helpProvider1 = new HelpProvider();
            lblTitle = new Label();
            lblDescription = new Label();
            panel3 = new Panel();
            imgBtnUser = new PictureBox();
            btnNotification = new Button();
            cbxUser = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBtnUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 28);
            panel1.Controls.Add(pnlNavigation);
            panel1.Controls.Add(btnForecast);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 600);
            panel1.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(225, 212, 193);
            pnlNavigation.Location = new Point(168, 177);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(12, 100);
            pnlNavigation.TabIndex = 1;
            // 
            // btnForecast
            // 
            btnForecast.BackgroundImageLayout = ImageLayout.Center;
            btnForecast.Dock = DockStyle.Top;
            btnForecast.FlatAppearance.BorderSize = 0;
            btnForecast.FlatStyle = FlatStyle.Flat;
            btnForecast.ForeColor = SystemColors.Control;
            btnForecast.Image = (Image)resources.GetObject("btnForecast.Image");
            btnForecast.Location = new Point(0, 277);
            btnForecast.Name = "btnForecast";
            btnForecast.Size = new Size(180, 59);
            btnForecast.TabIndex = 4;
            btnForecast.Text = "Forecast";
            btnForecast.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnForecast.UseVisualStyleBackColor = true;
            btnForecast.Click += btnForecast_Click;
            btnForecast.Leave += btnForecast_Leave;
            // 
            // btnReport
            // 
            btnReport.BackgroundImageLayout = ImageLayout.Center;
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.ForeColor = SystemColors.Control;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.Location = new Point(0, 218);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(180, 59);
            btnReport.TabIndex = 3;
            btnReport.Text = "Report";
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            btnReport.Leave += btnReport_Leave;
            // 
            // btnRequest
            // 
            btnRequest.BackgroundImageLayout = ImageLayout.Center;
            btnRequest.Dock = DockStyle.Top;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.ForeColor = SystemColors.Control;
            btnRequest.Image = (Image)resources.GetObject("btnRequest.Image");
            btnRequest.Location = new Point(0, 159);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(180, 59);
            btnRequest.TabIndex = 2;
            btnRequest.Text = "Request";
            btnRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            btnRequest.Leave += btnRequest_Leave;
            // 
            // btnInventory
            // 
            btnInventory.BackgroundImageLayout = ImageLayout.Center;
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.ForeColor = SystemColors.Control;
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.Location = new Point(0, 100);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(180, 59);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Inventory";
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            btnInventory.Leave += btnInventory_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 100);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(28, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 61);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(135, 135, 135);
            label1.Location = new Point(40, 67);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Main Menu";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(199, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(154, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(135, 135, 135);
            lblDescription.Location = new Point(203, 55);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(273, 18);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Overview of all available parfum products";
            // 
            // panel3
            // 
            panel3.Location = new Point(199, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 497);
            panel3.TabIndex = 3;
            // 
            // imgBtnUser
            // 
            imgBtnUser.BackColor = Color.White;
            imgBtnUser.BackgroundImage = (Image)resources.GetObject("imgBtnUser.BackgroundImage");
            imgBtnUser.BackgroundImageLayout = ImageLayout.Center;
            imgBtnUser.Location = new Point(886, 22);
            imgBtnUser.Name = "imgBtnUser";
            imgBtnUser.Size = new Size(43, 39);
            imgBtnUser.TabIndex = 5;
            imgBtnUser.TabStop = false;
            imgBtnUser.Click += pictureBox2_Click;
            // 
            // btnNotification
            // 
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.ForeColor = Color.White;
            btnNotification.Image = (Image)resources.GetObject("btnNotification.Image");
            btnNotification.Location = new Point(853, 27);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(27, 30);
            btnNotification.TabIndex = 4;
            btnNotification.UseVisualStyleBackColor = false;
            btnNotification.Click += btnNotification_Click;
            // 
            // cbxUser
            // 
            cbxUser.BackColor = Color.White;
            cbxUser.FlatStyle = FlatStyle.Flat;
            cbxUser.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxUser.ForeColor = Color.FromArgb(25, 25, 25);
            cbxUser.FormattingEnabled = true;
            cbxUser.Location = new Point(935, 27);
            cbxUser.Name = "cbxUser";
            cbxUser.Size = new Size(72, 30);
            cbxUser.TabIndex = 6;
            cbxUser.Text = "Staff";
            // 
            // StaffHomeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 600);
            Controls.Add(cbxUser);
            Controls.Add(imgBtnUser);
            Controls.Add(btnNotification);
            Controls.Add(panel3);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StaffHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffHomePage";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBtnUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnInventory;
        private Button btnForecast;
        private Button btnReport;
        private Button btnRequest;
        private HelpProvider helpProvider1;
        private Panel pnlNavigation;
        private Label lblTitle;
        private Label lblDescription;
        private Panel panel3;
        private PictureBox imgBtnUser;
        private Button btnNotification;
        private ComboBox cbxUser;
    }
}