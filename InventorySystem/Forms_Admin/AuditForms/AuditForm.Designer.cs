namespace InventorySystem
{
    partial class AuditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnRefresh = new Button();
            dgAuditLog = new DataGridView();
            richTextBox1 = new RichTextBox();
            cbxAuditLogActionFilter = new ComboBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            lblDescription = new Label();
            lblTitle = new Label();
            dtpAuditLogDateTo = new DateTimePicker();
            dtpAuditLogDateFrom = new DateTimePicker();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbSearchUserFilter = new RichTextBox();
            btnOpenAuditDetails = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgAuditLog).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(225, 212, 193);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleRight;
            btnRefresh.Location = new Point(500, 102);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(142, 28);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgAuditLog
            // 
            dgAuditLog.AllowUserToAddRows = false;
            dgAuditLog.AllowUserToDeleteRows = false;
            dgAuditLog.AllowUserToResizeColumns = false;
            dgAuditLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dgAuditLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgAuditLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAuditLog.BackgroundColor = SystemColors.Control;
            dgAuditLog.BorderStyle = BorderStyle.None;
            dgAuditLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle4.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgAuditLog.DefaultCellStyle = dataGridViewCellStyle4;
            dgAuditLog.Location = new Point(12, 151);
            dgAuditLog.Name = "dgAuditLog";
            dgAuditLog.ReadOnly = true;
            dgAuditLog.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgAuditLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAuditLog.Size = new Size(797, 288);
            dgAuditLog.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.DetectUrls = false;
            richTextBox1.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.FromArgb(135, 135, 135);
            richTextBox1.Location = new Point(12, 58);
            richTextBox1.MaxLength = 20;
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(97, 22);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "Filter: Action:";
            // 
            // cbxAuditLogActionFilter
            // 
            cbxAuditLogActionFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAuditLogActionFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAuditLogActionFilter.FormattingEnabled = true;
            cbxAuditLogActionFilter.Items.AddRange(new object[] { "All", "Edited account information", "Edited perfume information", "Added new account", "Added new perfume", "Sent product request", "Approved product request", "Rejected product request" });
            cbxAuditLogActionFilter.Location = new Point(106, 56);
            cbxAuditLogActionFilter.Name = "cbxAuditLogActionFilter";
            cbxAuditLogActionFilter.Size = new Size(372, 24);
            cbxAuditLogActionFilter.TabIndex = 7;
            cbxAuditLogActionFilter.SelectedValueChanged += cbxAuditLogActionFilter_SelectedValueChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Control;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.DetectUrls = false;
            richTextBox2.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.ForeColor = Color.FromArgb(135, 135, 135);
            richTextBox2.Location = new Point(287, 23);
            richTextBox2.MaxLength = 20;
            richTextBox2.Multiline = false;
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(76, 19);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "Date From:";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.Control;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.DetectUrls = false;
            richTextBox3.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.ForeColor = Color.FromArgb(135, 135, 135);
            richTextBox3.Location = new Point(503, 20);
            richTextBox3.MaxLength = 20;
            richTextBox3.Multiline = false;
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(24, 22);
            richTextBox3.TabIndex = 9;
            richTextBox3.Text = "To:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(135, 135, 135);
            lblDescription.Location = new Point(36, 130);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(209, 18);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "List of all actions done by a user";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(12, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 37);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Audit Log Entries";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpAuditLogDateTo
            // 
            dtpAuditLogDateTo.CalendarFont = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAuditLogDateTo.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAuditLogDateTo.Format = DateTimePickerFormat.Short;
            dtpAuditLogDateTo.Location = new Point(540, 18);
            dtpAuditLogDateTo.Name = "dtpAuditLogDateTo";
            dtpAuditLogDateTo.Size = new Size(118, 23);
            dtpAuditLogDateTo.TabIndex = 31;
            // 
            // dtpAuditLogDateFrom
            // 
            dtpAuditLogDateFrom.CalendarFont = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAuditLogDateFrom.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAuditLogDateFrom.Format = DateTimePickerFormat.Short;
            dtpAuditLogDateFrom.Location = new Point(369, 18);
            dtpAuditLogDateFrom.Name = "dtpAuditLogDateFrom";
            dtpAuditLogDateFrom.Size = new Size(118, 23);
            dtpAuditLogDateFrom.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbSearchUserFilter);
            panel1.Location = new Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 24);
            panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 28);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tbSearchUserFilter
            // 
            tbSearchUserFilter.BorderStyle = BorderStyle.None;
            tbSearchUserFilter.DetectUrls = false;
            tbSearchUserFilter.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchUserFilter.Location = new Point(22, 3);
            tbSearchUserFilter.MaxLength = 20;
            tbSearchUserFilter.Multiline = false;
            tbSearchUserFilter.Name = "tbSearchUserFilter";
            tbSearchUserFilter.Size = new Size(226, 18);
            tbSearchUserFilter.TabIndex = 0;
            tbSearchUserFilter.Text = "Search user...";
            tbSearchUserFilter.TextChanged += tbSearchUserFilter_TextChanged;
            // 
            // btnOpenAuditDetails
            // 
            btnOpenAuditDetails.BackColor = Color.FromArgb(225, 212, 193);
            btnOpenAuditDetails.Cursor = Cursors.Hand;
            btnOpenAuditDetails.FlatAppearance.BorderSize = 0;
            btnOpenAuditDetails.FlatStyle = FlatStyle.Flat;
            btnOpenAuditDetails.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenAuditDetails.ForeColor = Color.Black;
            btnOpenAuditDetails.Image = (Image)resources.GetObject("btnOpenAuditDetails.Image");
            btnOpenAuditDetails.Location = new Point(36, 445);
            btnOpenAuditDetails.Name = "btnOpenAuditDetails";
            btnOpenAuditDetails.Size = new Size(144, 31);
            btnOpenAuditDetails.TabIndex = 35;
            btnOpenAuditDetails.Text = "Open Details";
            btnOpenAuditDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenAuditDetails.UseVisualStyleBackColor = true;
            btnOpenAuditDetails.Click += btnOpenAuditDetails_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(126, 16, 44);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(656, 101);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 29);
            btnClear.TabIndex = 36;
            btnClear.Text = "Clear Selection";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // AuditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 504);
            Controls.Add(btnClear);
            Controls.Add(btnOpenAuditDetails);
            Controls.Add(panel1);
            Controls.Add(dtpAuditLogDateTo);
            Controls.Add(dtpAuditLogDateFrom);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(cbxAuditLogActionFilter);
            Controls.Add(richTextBox1);
            Controls.Add(dgAuditLog);
            Controls.Add(btnRefresh);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AuditForm";
            Text = "InventoryForm1";
            ((System.ComponentModel.ISupportInitialize)dgAuditLog).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRefresh;
        private DataGridView dgAuditLog;
        private RichTextBox richTextBox1;
        private ComboBox cbxAuditLogActionFilter;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label lblDescription;
        private Label lblTitle;
        private DateTimePicker dtpAuditLogDateTo;
        private DateTimePicker dtpAuditLogDateFrom;
        private Panel panel1;
        private PictureBox pictureBox1;
        private RichTextBox tbSearchUserFilter;
        private Button btnOpenAuditDetails;
        private Button btnClear;
    }
}