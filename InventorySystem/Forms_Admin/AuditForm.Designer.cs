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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tbSearchProduct = new RichTextBox();
            cbxUser = new ComboBox();
            btnScanQR = new Button();
            dgPerfume = new DataGridView();
            AUDIT_ID = new DataGridViewTextBoxColumn();
            AUDIT_TIMESTAMP = new DataGridViewTextBoxColumn();
            AUDIT_USER = new DataGridViewTextBoxColumn();
            AUDIT_MODULE = new DataGridViewTextBoxColumn();
            AUDIT_ACTION = new DataGridViewTextBoxColumn();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            lblDescription = new Label();
            lblTitle = new Label();
            dtpDateTo = new DateTimePicker();
            dtpDateFrom = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgPerfume).BeginInit();
            SuspendLayout();
            // 
            // tbSearchProduct
            // 
            tbSearchProduct.BorderStyle = BorderStyle.None;
            tbSearchProduct.DetectUrls = false;
            tbSearchProduct.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchProduct.ForeColor = Color.FromArgb(135, 135, 135);
            tbSearchProduct.Location = new Point(12, 23);
            tbSearchProduct.MaxLength = 20;
            tbSearchProduct.Multiline = false;
            tbSearchProduct.Name = "tbSearchProduct";
            tbSearchProduct.Size = new Size(97, 15);
            tbSearchProduct.TabIndex = 0;
            tbSearchProduct.Text = "Filter: User:";
            tbSearchProduct.TextChanged += tbSearchProduct_TextChanged;
            // 
            // cbxUser
            // 
            cbxUser.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxUser.FormattingEnabled = true;
            cbxUser.Location = new Point(115, 16);
            cbxUser.Name = "cbxUser";
            cbxUser.Size = new Size(148, 24);
            cbxUser.TabIndex = 1;
            cbxUser.Text = "Select user...";
            // 
            // btnScanQR
            // 
            btnScanQR.BackColor = Color.FromArgb(225, 212, 193);
            btnScanQR.Cursor = Cursors.Hand;
            btnScanQR.FlatAppearance.BorderSize = 0;
            btnScanQR.FlatStyle = FlatStyle.Flat;
            btnScanQR.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScanQR.ForeColor = Color.Black;
            btnScanQR.Image = (Image)resources.GetObject("btnScanQR.Image");
            btnScanQR.Location = new Point(699, 14);
            btnScanQR.Name = "btnScanQR";
            btnScanQR.Size = new Size(99, 28);
            btnScanQR.TabIndex = 4;
            btnScanQR.Text = "Search";
            btnScanQR.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnScanQR.UseVisualStyleBackColor = true;
            // 
            // dgPerfume
            // 
            dgPerfume.AllowUserToAddRows = false;
            dgPerfume.AllowUserToDeleteRows = false;
            dgPerfume.AllowUserToResizeColumns = false;
            dgPerfume.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dgPerfume.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgPerfume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPerfume.BackgroundColor = Color.White;
            dgPerfume.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgPerfume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgPerfume.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPerfume.Columns.AddRange(new DataGridViewColumn[] { AUDIT_ID, AUDIT_TIMESTAMP, AUDIT_USER, AUDIT_MODULE, AUDIT_ACTION });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle12.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgPerfume.DefaultCellStyle = dataGridViewCellStyle12;
            dgPerfume.Location = new Point(12, 151);
            dgPerfume.Name = "dgPerfume";
            dgPerfume.ReadOnly = true;
            dgPerfume.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgPerfume.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPerfume.Size = new Size(797, 328);
            dgPerfume.TabIndex = 5;
            // 
            // AUDIT_ID
            // 
            AUDIT_ID.FillWeight = 60F;
            AUDIT_ID.HeaderText = "Log ID";
            AUDIT_ID.MinimumWidth = 3;
            AUDIT_ID.Name = "AUDIT_ID";
            AUDIT_ID.ReadOnly = true;
            // 
            // AUDIT_TIMESTAMP
            // 
            AUDIT_TIMESTAMP.FillWeight = 110F;
            AUDIT_TIMESTAMP.HeaderText = "Timestamp";
            AUDIT_TIMESTAMP.Name = "AUDIT_TIMESTAMP";
            AUDIT_TIMESTAMP.ReadOnly = true;
            // 
            // AUDIT_USER
            // 
            AUDIT_USER.HeaderText = "User";
            AUDIT_USER.Name = "AUDIT_USER";
            AUDIT_USER.ReadOnly = true;
            // 
            // AUDIT_MODULE
            // 
            AUDIT_MODULE.HeaderText = "Module";
            AUDIT_MODULE.Name = "AUDIT_MODULE";
            AUDIT_MODULE.ReadOnly = true;
            // 
            // AUDIT_ACTION
            // 
            AUDIT_ACTION.FillWeight = 150.817261F;
            AUDIT_ACTION.HeaderText = "Action done by user";
            AUDIT_ACTION.Name = "AUDIT_ACTION";
            AUDIT_ACTION.ReadOnly = true;
            // 
            // richTextBox1
            // 
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(115, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 24);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Select action...";
            // 
            // richTextBox2
            // 
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
            // dtpDateTo
            // 
            dtpDateTo.CalendarFont = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateTo.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(540, 18);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(118, 23);
            dtpDateTo.TabIndex = 31;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.CalendarFont = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateFrom.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(369, 18);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(118, 23);
            dtpDateFrom.TabIndex = 30;
            // 
            // AuditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 504);
            Controls.Add(dtpDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(tbSearchProduct);
            Controls.Add(dgPerfume);
            Controls.Add(btnScanQR);
            Controls.Add(cbxUser);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AuditForm";
            Text = "InventoryForm1";
            ((System.ComponentModel.ISupportInitialize)dgPerfume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox tbSearchProduct;
        private ComboBox cbxUser;
        private Button btnScanQR;
        private DataGridView dgPerfume;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label lblDescription;
        private Label lblTitle;
        private DataGridViewTextBoxColumn AUDIT_ID;
        private DataGridViewTextBoxColumn AUDIT_TIMESTAMP;
        private DataGridViewTextBoxColumn AUDIT_USER;
        private DataGridViewTextBoxColumn AUDIT_MODULE;
        private DataGridViewTextBoxColumn AUDIT_ACTION;
        private DateTimePicker dtpDateTo;
        private DateTimePicker dtpDateFrom;
    }
}