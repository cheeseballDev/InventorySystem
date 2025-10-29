namespace InventorySystem
{
    partial class AdminApproveForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminApproveForm));
            label6 = new Label();
            dgExistingRequests = new DataGridView();
            PERFUME_ID = new DataGridViewTextBoxColumn();
            PERFUME_NAME = new DataGridViewTextBoxColumn();
            PERFUME_QTY = new DataGridViewTextBoxColumn();
            PERFUME_BRANCH = new DataGridViewTextBoxColumn();
            PERFUME_DATECREATED = new DataGridViewTextBoxColumn();
            PERFUME_STATUS = new DataGridViewTextBoxColumn();
            label7 = new Label();
            btnRefresh = new Button();
            btnGenerate = new Button();
            label3 = new Label();
            label2 = new Label();
            cbxCurrentBranch = new ComboBox();
            label1 = new Label();
            dtpDateFrom = new DateTimePicker();
            dtpDateTo = new DateTimePicker();
            cbxStatus = new ComboBox();
            label4 = new Label();
            btnRejectRequest = new Button();
            btnApproveRequest = new Button();
            btnOpenDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgExistingRequests).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 93);
            label6.Name = "label6";
            label6.Size = new Size(270, 37);
            label6.TabIndex = 12;
            label6.Text = "Existing Requests";
            // 
            // dgExistingRequests
            // 
            dgExistingRequests.AllowUserToAddRows = false;
            dgExistingRequests.AllowUserToDeleteRows = false;
            dgExistingRequests.AllowUserToResizeColumns = false;
            dgExistingRequests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgExistingRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgExistingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgExistingRequests.BackgroundColor = Color.White;
            dgExistingRequests.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgExistingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgExistingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExistingRequests.Columns.AddRange(new DataGridViewColumn[] { PERFUME_ID, PERFUME_NAME, PERFUME_QTY, PERFUME_BRANCH, PERFUME_DATECREATED, PERFUME_STATUS });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgExistingRequests.DefaultCellStyle = dataGridViewCellStyle3;
            dgExistingRequests.Location = new Point(29, 153);
            dgExistingRequests.Name = "dgExistingRequests";
            dgExistingRequests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgExistingRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgExistingRequests.Size = new Size(786, 300);
            dgExistingRequests.TabIndex = 13;
            // 
            // PERFUME_ID
            // 
            PERFUME_ID.FillWeight = 60F;
            PERFUME_ID.HeaderText = "REQ ID";
            PERFUME_ID.MinimumWidth = 3;
            PERFUME_ID.Name = "PERFUME_ID";
            PERFUME_ID.ReadOnly = true;
            // 
            // PERFUME_NAME
            // 
            PERFUME_NAME.FillWeight = 110F;
            PERFUME_NAME.HeaderText = "Perfume";
            PERFUME_NAME.Name = "PERFUME_NAME";
            PERFUME_NAME.ReadOnly = true;
            // 
            // PERFUME_QTY
            // 
            PERFUME_QTY.HeaderText = "Qty";
            PERFUME_QTY.Name = "PERFUME_QTY";
            // 
            // PERFUME_BRANCH
            // 
            PERFUME_BRANCH.HeaderText = "Branch";
            PERFUME_BRANCH.Name = "PERFUME_BRANCH";
            // 
            // PERFUME_DATECREATED
            // 
            PERFUME_DATECREATED.FillWeight = 107.817261F;
            PERFUME_DATECREATED.HeaderText = "Date Created";
            PERFUME_DATECREATED.Name = "PERFUME_DATECREATED";
            // 
            // PERFUME_STATUS
            // 
            PERFUME_STATUS.HeaderText = "Status";
            PERFUME_STATUS.Name = "PERFUME_STATUS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(135, 135, 135);
            label7.Location = new Point(19, 130);
            label7.Name = "label7";
            label7.Size = new Size(218, 16);
            label7.TabIndex = 14;
            label7.Text = "List of all previous existing requests";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(225, 212, 193);
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(756, 108);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(52, 38);
            btnRefresh.TabIndex = 15;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(225, 212, 193);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Image = (Image)resources.GetObject("btnGenerate.Image");
            btnGenerate.Location = new Point(699, 13);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(109, 27);
            btnGenerate.TabIndex = 27;
            btnGenerate.Text = "Search";
            btnGenerate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(523, 18);
            label3.Name = "label3";
            label3.Size = new Size(21, 16);
            label3.TabIndex = 25;
            label3.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(312, 18);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 23;
            label2.Text = "Date from:";
            // 
            // cbxCurrentBranch
            // 
            cbxCurrentBranch.Font = new Font("Montserrat", 9F);
            cbxCurrentBranch.FormattingEnabled = true;
            cbxCurrentBranch.Location = new Point(104, 15);
            cbxCurrentBranch.Name = "cbxCurrentBranch";
            cbxCurrentBranch.Size = new Size(191, 24);
            cbxCurrentBranch.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(135, 135, 135);
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(90, 16);
            label1.TabIndex = 21;
            label1.Text = "Filter: Branch:";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.CalendarFont = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateFrom.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(390, 15);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(118, 23);
            dtpDateFrom.TabIndex = 28;
            // 
            // dtpDateTo
            // 
            dtpDateTo.CalendarFont = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateTo.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(559, 15);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(118, 23);
            dtpDateTo.TabIndex = 29;
            // 
            // cbxStatus
            // 
            cbxStatus.Font = new Font("Montserrat", 9F);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(104, 57);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(191, 24);
            cbxStatus.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(8, 60);
            label4.Name = "label4";
            label4.Size = new Size(85, 16);
            label4.TabIndex = 30;
            label4.Text = "Filter: Status:";
            // 
            // btnRejectRequest
            // 
            btnRejectRequest.BackColor = Color.FromArgb(225, 212, 193);
            btnRejectRequest.Cursor = Cursors.Hand;
            btnRejectRequest.FlatAppearance.BorderSize = 0;
            btnRejectRequest.FlatStyle = FlatStyle.Flat;
            btnRejectRequest.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRejectRequest.ForeColor = Color.Black;
            btnRejectRequest.Image = (Image)resources.GetObject("btnRejectRequest.Image");
            btnRejectRequest.Location = new Point(430, 469);
            btnRejectRequest.Name = "btnRejectRequest";
            btnRejectRequest.Size = new Size(144, 31);
            btnRejectRequest.TabIndex = 33;
            btnRejectRequest.Text = "Reject Request";
            btnRejectRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRejectRequest.UseVisualStyleBackColor = true;
            // 
            // btnApproveRequest
            // 
            btnApproveRequest.BackColor = Color.FromArgb(225, 212, 193);
            btnApproveRequest.Cursor = Cursors.Hand;
            btnApproveRequest.FlatAppearance.BorderSize = 0;
            btnApproveRequest.FlatStyle = FlatStyle.Flat;
            btnApproveRequest.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApproveRequest.ForeColor = Color.Black;
            btnApproveRequest.Image = (Image)resources.GetObject("btnApproveRequest.Image");
            btnApproveRequest.Location = new Point(263, 469);
            btnApproveRequest.Name = "btnApproveRequest";
            btnApproveRequest.Size = new Size(144, 31);
            btnApproveRequest.TabIndex = 32;
            btnApproveRequest.Text = "Approve Request";
            btnApproveRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApproveRequest.UseVisualStyleBackColor = true;
            // 
            // btnOpenDetails
            // 
            btnOpenDetails.BackColor = Color.FromArgb(225, 212, 193);
            btnOpenDetails.Cursor = Cursors.Hand;
            btnOpenDetails.FlatAppearance.BorderSize = 0;
            btnOpenDetails.FlatStyle = FlatStyle.Flat;
            btnOpenDetails.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenDetails.ForeColor = Color.Black;
            btnOpenDetails.Image = (Image)resources.GetObject("btnOpenDetails.Image");
            btnOpenDetails.Location = new Point(93, 469);
            btnOpenDetails.Name = "btnOpenDetails";
            btnOpenDetails.Size = new Size(144, 31);
            btnOpenDetails.TabIndex = 34;
            btnOpenDetails.Text = "Open Details";
            btnOpenDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenDetails.UseVisualStyleBackColor = true;
            btnOpenDetails.Click += btnOpenDetails_Click;
            // 
            // AdminApproveForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 512);
            Controls.Add(btnOpenDetails);
            Controls.Add(btnRejectRequest);
            Controls.Add(btnApproveRequest);
            Controls.Add(cbxStatus);
            Controls.Add(label4);
            Controls.Add(dtpDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(btnGenerate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxCurrentBranch);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(label7);
            Controls.Add(dgExistingRequests);
            Controls.Add(label6);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminApproveForm";
            Text = "AdminRequestPage";
            ((System.ComponentModel.ISupportInitialize)dgExistingRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private DataGridView dgExistingRequests;
        private Label label7;
        private DataGridViewTextBoxColumn PERFUME_ID;
        private DataGridViewTextBoxColumn PERFUME_NAME;
        private DataGridViewTextBoxColumn PERFUME_QTY;
        private DataGridViewTextBoxColumn PERFUME_BRANCH;
        private DataGridViewTextBoxColumn PERFUME_DATECREATED;
        private DataGridViewTextBoxColumn PERFUME_STATUS;
        private Button btnRefresh;
        private Button btnGenerate;
        private Label label3;
        private Label label2;
        private ComboBox cbxCurrentBranch;
        private Label label1;
        private DateTimePicker dtpDateFrom;
        private DateTimePicker dtpDateTo;
        private ComboBox cbxStatus;
        private Label label4;
        private Button btnRejectRequest;
        private Button btnApproveRequest;
        private Button btnOpenDetails;
    }
}