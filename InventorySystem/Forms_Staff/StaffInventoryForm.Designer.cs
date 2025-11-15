namespace InventorySystem
{
    partial class StaffInventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInventoryForm));
            dgPerfume = new DataGridView();
            btnAddSelectedPerfumeQuantity = new Button();
            btnDeductSelectedPerfumeQuantity = new Button();
            btnEditSelectedPerfume = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbSearchPerfumeFilter = new RichTextBox();
            btnScanQR = new Button();
            cbxPerfumeFragranceFilter = new ComboBox();
            cbxPerfumeNoteFilter = new ComboBox();
            cbxPerfumeBranchFilter = new ComboBox();
            cbxPerfumeGenderFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgPerfume).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgPerfume
            // 
            dgPerfume.AllowUserToAddRows = false;
            dgPerfume.AllowUserToDeleteRows = false;
            dgPerfume.AllowUserToResizeColumns = false;
            dgPerfume.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dgPerfume.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgPerfume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPerfume.BackgroundColor = SystemColors.Control;
            dgPerfume.BorderStyle = BorderStyle.None;
            dgPerfume.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle6.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgPerfume.DefaultCellStyle = dataGridViewCellStyle6;
            dgPerfume.Location = new Point(12, 84);
            dgPerfume.Name = "dgPerfume";
            dgPerfume.ReadOnly = true;
            dgPerfume.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgPerfume.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPerfume.Size = new Size(797, 330);
            dgPerfume.TabIndex = 5;
            // 
            // btnAddSelectedPerfumeQuantity
            // 
            btnAddSelectedPerfumeQuantity.BackColor = Color.FromArgb(225, 212, 193);
            btnAddSelectedPerfumeQuantity.BackgroundImage = (Image)resources.GetObject("btnAddSelectedPerfumeQuantity.BackgroundImage");
            btnAddSelectedPerfumeQuantity.BackgroundImageLayout = ImageLayout.Center;
            btnAddSelectedPerfumeQuantity.Cursor = Cursors.Hand;
            btnAddSelectedPerfumeQuantity.FlatStyle = FlatStyle.Flat;
            btnAddSelectedPerfumeQuantity.ForeColor = Color.White;
            btnAddSelectedPerfumeQuantity.Location = new Point(230, 420);
            btnAddSelectedPerfumeQuantity.Name = "btnAddSelectedPerfumeQuantity";
            btnAddSelectedPerfumeQuantity.Size = new Size(82, 38);
            btnAddSelectedPerfumeQuantity.TabIndex = 6;
            btnAddSelectedPerfumeQuantity.UseVisualStyleBackColor = false;
            btnAddSelectedPerfumeQuantity.Click += btnAdd_Click;
            // 
            // btnDeductSelectedPerfumeQuantity
            // 
            btnDeductSelectedPerfumeQuantity.BackColor = Color.FromArgb(225, 212, 193);
            btnDeductSelectedPerfumeQuantity.BackgroundImage = (Image)resources.GetObject("btnDeductSelectedPerfumeQuantity.BackgroundImage");
            btnDeductSelectedPerfumeQuantity.BackgroundImageLayout = ImageLayout.Center;
            btnDeductSelectedPerfumeQuantity.Cursor = Cursors.Hand;
            btnDeductSelectedPerfumeQuantity.FlatStyle = FlatStyle.Flat;
            btnDeductSelectedPerfumeQuantity.ForeColor = Color.White;
            btnDeductSelectedPerfumeQuantity.Location = new Point(318, 420);
            btnDeductSelectedPerfumeQuantity.Name = "btnDeductSelectedPerfumeQuantity";
            btnDeductSelectedPerfumeQuantity.Size = new Size(82, 38);
            btnDeductSelectedPerfumeQuantity.TabIndex = 7;
            btnDeductSelectedPerfumeQuantity.UseVisualStyleBackColor = false;
            btnDeductSelectedPerfumeQuantity.Click += btnDeductSelectedPerfumeQuantity_Click;
            // 
            // btnEditSelectedPerfume
            // 
            btnEditSelectedPerfume.BackColor = Color.FromArgb(225, 212, 193);
            btnEditSelectedPerfume.BackgroundImage = (Image)resources.GetObject("btnEditSelectedPerfume.BackgroundImage");
            btnEditSelectedPerfume.BackgroundImageLayout = ImageLayout.Center;
            btnEditSelectedPerfume.Cursor = Cursors.Hand;
            btnEditSelectedPerfume.FlatStyle = FlatStyle.Flat;
            btnEditSelectedPerfume.ForeColor = Color.White;
            btnEditSelectedPerfume.Location = new Point(406, 420);
            btnEditSelectedPerfume.Name = "btnEditSelectedPerfume";
            btnEditSelectedPerfume.Size = new Size(82, 38);
            btnEditSelectedPerfume.TabIndex = 8;
            btnEditSelectedPerfume.UseVisualStyleBackColor = false;
            btnEditSelectedPerfume.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(225, 212, 193);
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(494, 420);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 38);
            btnRefresh.TabIndex = 9;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbSearchPerfumeFilter);
            panel1.Location = new Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 24);
            panel1.TabIndex = 14;
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
            // tbSearchPerfumeFilter
            // 
            tbSearchPerfumeFilter.BorderStyle = BorderStyle.None;
            tbSearchPerfumeFilter.DetectUrls = false;
            tbSearchPerfumeFilter.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchPerfumeFilter.Location = new Point(22, 3);
            tbSearchPerfumeFilter.MaxLength = 20;
            tbSearchPerfumeFilter.Multiline = false;
            tbSearchPerfumeFilter.Name = "tbSearchPerfumeFilter";
            tbSearchPerfumeFilter.Size = new Size(474, 21);
            tbSearchPerfumeFilter.TabIndex = 0;
            tbSearchPerfumeFilter.Text = "Search perfume...";
            tbSearchPerfumeFilter.TextChanged += tbSearchProductFilter_TextChanged;
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
            btnScanQR.Location = new Point(686, 15);
            btnScanQR.Name = "btnScanQR";
            btnScanQR.Size = new Size(123, 29);
            btnScanQR.TabIndex = 4;
            btnScanQR.Text = "Search";
            btnScanQR.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnScanQR.UseVisualStyleBackColor = true;
            btnScanQR.Click += btnSearch;
            // 
            // cbxPerfumeFragranceFilter
            // 
            cbxPerfumeFragranceFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfumeFragranceFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPerfumeFragranceFilter.FormattingEnabled = true;
            cbxPerfumeFragranceFilter.Location = new Point(230, 47);
            cbxPerfumeFragranceFilter.Name = "cbxPerfumeFragranceFilter";
            cbxPerfumeFragranceFilter.Size = new Size(201, 24);
            cbxPerfumeFragranceFilter.TabIndex = 3;
            // 
            // cbxPerfumeNoteFilter
            // 
            cbxPerfumeNoteFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfumeNoteFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPerfumeNoteFilter.FormattingEnabled = true;
            cbxPerfumeNoteFilter.Location = new Point(12, 49);
            cbxPerfumeNoteFilter.Name = "cbxPerfumeNoteFilter";
            cbxPerfumeNoteFilter.Size = new Size(201, 24);
            cbxPerfumeNoteFilter.TabIndex = 2;
            // 
            // cbxPerfumeBranchFilter
            // 
            cbxPerfumeBranchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfumeBranchFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPerfumeBranchFilter.FormattingEnabled = true;
            cbxPerfumeBranchFilter.Location = new Point(528, 16);
            cbxPerfumeBranchFilter.Name = "cbxPerfumeBranchFilter";
            cbxPerfumeBranchFilter.Size = new Size(152, 24);
            cbxPerfumeBranchFilter.TabIndex = 1;
            // 
            // cbxPerfumeGenderFilter
            // 
            cbxPerfumeGenderFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfumeGenderFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPerfumeGenderFilter.FormattingEnabled = true;
            cbxPerfumeGenderFilter.Location = new Point(449, 47);
            cbxPerfumeGenderFilter.Name = "cbxPerfumeGenderFilter";
            cbxPerfumeGenderFilter.Size = new Size(201, 24);
            cbxPerfumeGenderFilter.TabIndex = 15;
            // 
            // StaffInventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 470);
            Controls.Add(cbxPerfumeGenderFilter);
            Controls.Add(cbxPerfumeBranchFilter);
            Controls.Add(panel1);
            Controls.Add(btnScanQR);
            Controls.Add(cbxPerfumeFragranceFilter);
            Controls.Add(cbxPerfumeNoteFilter);
            Controls.Add(btnRefresh);
            Controls.Add(btnEditSelectedPerfume);
            Controls.Add(btnDeductSelectedPerfumeQuantity);
            Controls.Add(btnAddSelectedPerfumeQuantity);
            Controls.Add(dgPerfume);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StaffInventoryForm";
            Text = "StaffInventoryForm";
            ((System.ComponentModel.ISupportInitialize)dgPerfume).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgPerfume;
        private Button btnAddSelectedPerfumeQuantity;
        private Button btnDeductSelectedPerfumeQuantity;
        private Button btnEditSelectedPerfume;
        private Button btnRefresh;
        private Panel panel1;
        private PictureBox pictureBox1;
        private RichTextBox tbSearchPerfumeFilter;
        private Button btnScanQR;
        private ComboBox cbxPerfumeFragranceFilter;
        private ComboBox cbxPerfumeNoteFilter;
        private ComboBox cbxPerfumeBranchFilter;
        private ComboBox cbxPerfumeGenderFilter;
    }
}