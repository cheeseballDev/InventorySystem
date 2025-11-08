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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            btnSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            cbxRequestBranchFilter = new ComboBox();
            label1 = new Label();
            dtpRequestDateFrom = new DateTimePicker();
            dtpRequestDateTo = new DateTimePicker();
            cbxRequestStatusFilter = new ComboBox();
            label4 = new Label();
            btnRejectRequest = new Button();
            btnApproveRequest = new Button();
            btnOpenRequestDetails = new Button();
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
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dgExistingRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgExistingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgExistingRequests.BackgroundColor = Color.White;
            dgExistingRequests.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgExistingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgExistingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExistingRequests.Columns.AddRange(new DataGridViewColumn[] { PERFUME_ID, PERFUME_NAME, PERFUME_QTY, PERFUME_BRANCH, PERFUME_DATECREATED, PERFUME_STATUS });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle6.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgExistingRequests.DefaultCellStyle = dataGridViewCellStyle6;
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
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(225, 212, 193);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(699, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 27);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
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
            // cbxRequestBranchFilter
            // 
            cbxRequestBranchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRequestBranchFilter.Font = new Font("Montserrat", 9F);
            cbxRequestBranchFilter.FormattingEnabled = true;
            cbxRequestBranchFilter.Location = new Point(104, 15);
            cbxRequestBranchFilter.Name = "cbxRequestBranchFilter";
            cbxRequestBranchFilter.Size = new Size(191, 24);
            cbxRequestBranchFilter.TabIndex = 22;
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
            // dtpRequestDateFrom
            // 
            dtpRequestDateFrom.CalendarFont = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRequestDateFrom.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRequestDateFrom.Format = DateTimePickerFormat.Short;
            dtpRequestDateFrom.Location = new Point(390, 15);
            dtpRequestDateFrom.Name = "dtpRequestDateFrom";
            dtpRequestDateFrom.Size = new Size(118, 23);
            dtpRequestDateFrom.TabIndex = 28;
            // 
            // dtpRequestDateTo
            // 
            dtpRequestDateTo.CalendarFont = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRequestDateTo.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRequestDateTo.Format = DateTimePickerFormat.Short;
            dtpRequestDateTo.Location = new Point(559, 15);
            dtpRequestDateTo.Name = "dtpRequestDateTo";
            dtpRequestDateTo.Size = new Size(118, 23);
            dtpRequestDateTo.TabIndex = 29;
            // 
            // cbxRequestStatusFilter
            // 
            cbxRequestStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRequestStatusFilter.Font = new Font("Montserrat", 9F);
            cbxRequestStatusFilter.FormattingEnabled = true;
            cbxRequestStatusFilter.Location = new Point(104, 57);
            cbxRequestStatusFilter.Name = "cbxRequestStatusFilter";
            cbxRequestStatusFilter.Size = new Size(191, 24);
            cbxRequestStatusFilter.TabIndex = 31;
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
            // btnOpenRequestDetails
            // 
            btnOpenRequestDetails.BackColor = Color.FromArgb(225, 212, 193);
            btnOpenRequestDetails.Cursor = Cursors.Hand;
            btnOpenRequestDetails.FlatAppearance.BorderSize = 0;
            btnOpenRequestDetails.FlatStyle = FlatStyle.Flat;
            btnOpenRequestDetails.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenRequestDetails.ForeColor = Color.Black;
            btnOpenRequestDetails.Image = (Image)resources.GetObject("btnOpenRequestDetails.Image");
            btnOpenRequestDetails.Location = new Point(93, 469);
            btnOpenRequestDetails.Name = "btnOpenRequestDetails";
            btnOpenRequestDetails.Size = new Size(144, 31);
            btnOpenRequestDetails.TabIndex = 34;
            btnOpenRequestDetails.Text = "Open Details";
            btnOpenRequestDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenRequestDetails.UseVisualStyleBackColor = true;
            btnOpenRequestDetails.Click += btnOpenDetails_Click;
            // 
            // AdminApproveForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 512);
            Controls.Add(btnOpenRequestDetails);
            Controls.Add(btnRejectRequest);
            Controls.Add(btnApproveRequest);
            Controls.Add(cbxRequestStatusFilter);
            Controls.Add(label4);
            Controls.Add(dtpRequestDateTo);
            Controls.Add(dtpRequestDateFrom);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxRequestBranchFilter);
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
        private Button btnSearch;
        private Label label3;
        private Label label2;
        private ComboBox cbxRequestBranchFilter;
        private Label label1;
        private DateTimePicker dtpRequestDateFrom;
        private DateTimePicker dtpRequestDateTo;
        private ComboBox cbxRequestStatusFilter;
        private Label label4;
        private Button btnRejectRequest;
        private Button btnApproveRequest;
        private Button btnOpenRequestDetails;
    }
}