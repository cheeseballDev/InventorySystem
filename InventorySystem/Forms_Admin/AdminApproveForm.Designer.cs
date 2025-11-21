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
            label7 = new Label();
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
            btnRefresh = new Button();
            btnClear = new Button();
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
            dgExistingRequests.BackgroundColor = SystemColors.Control;
            dgExistingRequests.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 11.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgExistingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgExistingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle3.Font = new Font("Montserrat", 11.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgExistingRequests.DefaultCellStyle = dataGridViewCellStyle3;
            dgExistingRequests.Location = new Point(19, 149);
            dgExistingRequests.Name = "dgExistingRequests";
            dgExistingRequests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgExistingRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgExistingRequests.Size = new Size(786, 300);
            dgExistingRequests.TabIndex = 13;
            dgExistingRequests.DataBindingComplete += dgExistingRequests_DataBindingComplete;
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
            cbxRequestBranchFilter.SelectedValueChanged += cbxRequestBranchFilter_SelectedValueChanged;
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
            cbxRequestStatusFilter.SelectedValueChanged += cbxRequestStatusFilter_SelectedValueChanged;
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
            btnRejectRequest.Location = new Point(451, 469);
            btnRejectRequest.Name = "btnRejectRequest";
            btnRejectRequest.Size = new Size(144, 31);
            btnRejectRequest.TabIndex = 33;
            btnRejectRequest.Text = "Reject Request";
            btnRejectRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRejectRequest.UseVisualStyleBackColor = true;
            btnRejectRequest.Click += btnRejectRequest_Click;
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
            btnApproveRequest.Size = new Size(161, 31);
            btnApproveRequest.TabIndex = 32;
            btnApproveRequest.Text = "Approve Request";
            btnApproveRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApproveRequest.UseVisualStyleBackColor = true;
            btnApproveRequest.Click += btnApproveRequest_Click;
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
            btnRefresh.Location = new Point(505, 104);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(142, 29);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(126, 16, 44);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(663, 104);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 29);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear Selection";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // AdminApproveForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 512);
            Controls.Add(btnClear);
            Controls.Add(btnOpenRequestDetails);
            Controls.Add(btnRejectRequest);
            Controls.Add(btnApproveRequest);
            Controls.Add(cbxRequestStatusFilter);
            Controls.Add(label4);
            Controls.Add(dtpRequestDateTo);
            Controls.Add(dtpRequestDateFrom);
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxRequestBranchFilter);
            Controls.Add(label1);
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
        private Button btnClear;
        private Button btnRefresh;
    }
}