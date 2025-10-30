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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tbSearchProduct = new RichTextBox();
            cbxAuditLogUserFilter = new ComboBox();
            btnSearchAuditLog = new Button();
            dgPerfume = new DataGridView();
            AUDIT_ID = new DataGridViewTextBoxColumn();
            AUDIT_TIMESTAMP = new DataGridViewTextBoxColumn();
            AUDIT_USER = new DataGridViewTextBoxColumn();
            AUDIT_MODULE = new DataGridViewTextBoxColumn();
            AUDIT_ACTION = new DataGridViewTextBoxColumn();
            richTextBox1 = new RichTextBox();
            cbxAuditLogActionFilter = new ComboBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            lblDescription = new Label();
            lblTitle = new Label();
            dtpAuditLogDateTo = new DateTimePicker();
            dtpAuditLogDateFrom = new DateTimePicker();
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
            // cbxAuditLogUserFilter
            // 
            cbxAuditLogUserFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAuditLogUserFilter.FormattingEnabled = true;
            cbxAuditLogUserFilter.Location = new Point(115, 16);
            cbxAuditLogUserFilter.Name = "cbxAuditLogUserFilter";
            cbxAuditLogUserFilter.Size = new Size(148, 24);
            cbxAuditLogUserFilter.TabIndex = 1;
            cbxAuditLogUserFilter.Text = "Select user...";
            // 
            // btnSearchAuditLog
            // 
            btnSearchAuditLog.BackColor = Color.FromArgb(225, 212, 193);
            btnSearchAuditLog.Cursor = Cursors.Hand;
            btnSearchAuditLog.FlatAppearance.BorderSize = 0;
            btnSearchAuditLog.FlatStyle = FlatStyle.Flat;
            btnSearchAuditLog.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchAuditLog.ForeColor = Color.Black;
            btnSearchAuditLog.Image = (Image)resources.GetObject("btnSearchAuditLog.Image");
            btnSearchAuditLog.Location = new Point(699, 14);
            btnSearchAuditLog.Name = "btnSearchAuditLog";
            btnSearchAuditLog.Size = new Size(99, 28);
            btnSearchAuditLog.TabIndex = 4;
            btnSearchAuditLog.Text = "Search";
            btnSearchAuditLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchAuditLog.UseVisualStyleBackColor = true;
            // 
            // dgPerfume
            // 
            dgPerfume.AllowUserToAddRows = false;
            dgPerfume.AllowUserToDeleteRows = false;
            dgPerfume.AllowUserToResizeColumns = false;
            dgPerfume.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dgPerfume.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgPerfume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPerfume.BackgroundColor = Color.White;
            dgPerfume.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgPerfume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgPerfume.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPerfume.Columns.AddRange(new DataGridViewColumn[] { AUDIT_ID, AUDIT_TIMESTAMP, AUDIT_USER, AUDIT_MODULE, AUDIT_ACTION });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle6.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgPerfume.DefaultCellStyle = dataGridViewCellStyle6;
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
            // cbxAuditLogActionFilter
            // 
            cbxAuditLogActionFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAuditLogActionFilter.FormattingEnabled = true;
            cbxAuditLogActionFilter.Location = new Point(115, 56);
            cbxAuditLogActionFilter.Name = "cbxAuditLogActionFilter";
            cbxAuditLogActionFilter.Size = new Size(148, 24);
            cbxAuditLogActionFilter.TabIndex = 7;
            cbxAuditLogActionFilter.Text = "Select action...";
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
            // AuditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 504);
            Controls.Add(dtpAuditLogDateTo);
            Controls.Add(dtpAuditLogDateFrom);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(cbxAuditLogActionFilter);
            Controls.Add(richTextBox1);
            Controls.Add(tbSearchProduct);
            Controls.Add(dgPerfume);
            Controls.Add(btnSearchAuditLog);
            Controls.Add(cbxAuditLogUserFilter);
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
        private ComboBox cbxAuditLogUserFilter;
        private Button btnSearchAuditLog;
        private DataGridView dgPerfume;
        private RichTextBox richTextBox1;
        private ComboBox cbxAuditLogActionFilter;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label lblDescription;
        private Label lblTitle;
        private DataGridViewTextBoxColumn AUDIT_ID;
        private DataGridViewTextBoxColumn AUDIT_TIMESTAMP;
        private DataGridViewTextBoxColumn AUDIT_USER;
        private DataGridViewTextBoxColumn AUDIT_MODULE;
        private DataGridViewTextBoxColumn AUDIT_ACTION;
        private DateTimePicker dtpAuditLogDateTo;
        private DateTimePicker dtpAuditLogDateFrom;
    }
}