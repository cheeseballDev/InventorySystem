namespace InventorySystem
{
    partial class StaffHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHomePage));
            panel1 = new Panel();
            btnForecast = new Button();
            btnReport = new Button();
            btnRequest = new Button();
            btnInventory = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 28);
            panel1.Controls.Add(btnForecast);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 600);
            panel1.TabIndex = 0;
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
            // StaffHomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 600);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StaffHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffHomePage";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
    }
}