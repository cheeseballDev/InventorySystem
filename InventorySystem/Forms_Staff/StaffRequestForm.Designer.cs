namespace InventorySystem
{
    partial class StaffRequestForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffRequestForm));
            label1 = new Label();
            cbxRequestCurrentBranchFilter = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbxRequestParfumFilter = new ComboBox();
            label4 = new Label();
            numPerfumeAmountToRequest = new NumericUpDown();
            label5 = new Label();
            tbRequestMessage = new RichTextBox();
            btnSubmitRequest = new Button();
            btnClear = new Button();
            label6 = new Label();
            dgExistingRequests = new DataGridView();
            label7 = new Label();
            btnRefresh = new Button();
            dtpDateToRequest = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numPerfumeAmountToRequest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgExistingRequests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(135, 135, 135);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(139, 16);
            label1.TabIndex = 0;
            label1.Text = "Select current branch:";
            // 
            // cbxRequestCurrentBranchFilter
            // 
            cbxRequestCurrentBranchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRequestCurrentBranchFilter.Font = new Font("Montserrat", 9F);
            cbxRequestCurrentBranchFilter.FormattingEnabled = true;
            cbxRequestCurrentBranchFilter.Location = new Point(180, 14);
            cbxRequestCurrentBranchFilter.Name = "cbxRequestCurrentBranchFilter";
            cbxRequestCurrentBranchFilter.Size = new Size(199, 24);
            cbxRequestCurrentBranchFilter.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(409, 17);
            label2.Name = "label2";
            label2.Size = new Size(141, 16);
            label2.TabIndex = 2;
            label2.Text = "Select date to request:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(166, 16);
            label3.TabIndex = 4;
            label3.Text = "Select perfume to request:";
            // 
            // cbxRequestParfumFilter
            // 
            cbxRequestParfumFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRequestParfumFilter.Font = new Font("Montserrat", 9F);
            cbxRequestParfumFilter.FormattingEnabled = true;
            cbxRequestParfumFilter.Location = new Point(180, 53);
            cbxRequestParfumFilter.Name = "cbxRequestParfumFilter";
            cbxRequestParfumFilter.Size = new Size(199, 24);
            cbxRequestParfumFilter.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(409, 56);
            label4.Name = "label4";
            label4.Size = new Size(126, 16);
            label4.TabIndex = 6;
            label4.Text = "Amount to request:";
            // 
            // numPerfumeAmountToRequest
            // 
            numPerfumeAmountToRequest.Font = new Font("Montserrat", 9F);
            numPerfumeAmountToRequest.Location = new Point(556, 56);
            numPerfumeAmountToRequest.Margin = new Padding(4);
            numPerfumeAmountToRequest.Name = "numPerfumeAmountToRequest";
            numPerfumeAmountToRequest.Size = new Size(165, 22);
            numPerfumeAmountToRequest.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 9F);
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(12, 94);
            label5.Name = "label5";
            label5.Size = new Size(62, 16);
            label5.TabIndex = 8;
            label5.Text = "Message:";
            // 
            // tbRequestMessage
            // 
            tbRequestMessage.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbRequestMessage.Location = new Point(80, 90);
            tbRequestMessage.MaxLength = 256;
            tbRequestMessage.Multiline = false;
            tbRequestMessage.Name = "tbRequestMessage";
            tbRequestMessage.Size = new Size(641, 29);
            tbRequestMessage.TabIndex = 9;
            tbRequestMessage.Text = "";
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.BackColor = Color.FromArgb(225, 212, 193);
            btnSubmitRequest.Cursor = Cursors.Hand;
            btnSubmitRequest.FlatAppearance.BorderSize = 0;
            btnSubmitRequest.FlatStyle = FlatStyle.Flat;
            btnSubmitRequest.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmitRequest.ForeColor = Color.Black;
            btnSubmitRequest.Location = new Point(12, 134);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(139, 27);
            btnSubmitRequest.TabIndex = 10;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSubmitRequest.UseVisualStyleBackColor = true;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(225, 212, 193);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(157, 134);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 27);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1, 164);
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
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dgExistingRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgExistingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgExistingRequests.BackgroundColor = SystemColors.Control;
            dgExistingRequests.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgExistingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgExistingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle9.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgExistingRequests.DefaultCellStyle = dataGridViewCellStyle9;
            dgExistingRequests.Location = new Point(22, 224);
            dgExistingRequests.Name = "dgExistingRequests";
            dgExistingRequests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgExistingRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgExistingRequests.Size = new Size(786, 276);
            dgExistingRequests.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(135, 135, 135);
            label7.Location = new Point(12, 201);
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
            btnRefresh.Location = new Point(756, 179);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(52, 38);
            btnRefresh.TabIndex = 15;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dtpDateToRequest
            // 
            dtpDateToRequest.CalendarFont = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateToRequest.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateToRequest.Format = DateTimePickerFormat.Short;
            dtpDateToRequest.Location = new Point(556, 15);
            dtpDateToRequest.Name = "dtpDateToRequest";
            dtpDateToRequest.Size = new Size(165, 23);
            dtpDateToRequest.TabIndex = 29;
            // 
            // StaffRequestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 512);
            Controls.Add(dtpDateToRequest);
            Controls.Add(btnRefresh);
            Controls.Add(label7);
            Controls.Add(dgExistingRequests);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnSubmitRequest);
            Controls.Add(tbRequestMessage);
            Controls.Add(label5);
            Controls.Add(numPerfumeAmountToRequest);
            Controls.Add(label4);
            Controls.Add(cbxRequestParfumFilter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxRequestCurrentBranchFilter);
            Controls.Add(label1);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StaffRequestForm";
            Text = "StaffRequestForm";
            ((System.ComponentModel.ISupportInitialize)numPerfumeAmountToRequest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgExistingRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxRequestCurrentBranchFilter;
        private Label label2;
        private Label label3;
        private ComboBox cbxRequestParfumFilter;
        private Label label4;
        private NumericUpDown numPerfumeAmountToRequest;
        private Label label5;
        private RichTextBox tbRequestMessage;
        private Button btnSubmitRequest;
        private Button btnClear;
        private Label label6;
        private DataGridView dgExistingRequests;
        private Label label7;
        private Button btnRefresh;
        private DateTimePicker dtpDateToRequest;
    }
}