namespace InventorySystem
{
    partial class AdminInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInventoryForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnSearch = new Button();
            dgPerfume = new DataGridView();
            btnAddSelectedPerfumeQuantity = new Button();
            btnDeductSelectedPerfumeQuantity = new Button();
            btnEditSelectedPerfumeDetails = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbSearchPerfumeFilter = new RichTextBox();
            cbxPerfumeBranchFilter = new ComboBox();
            cbxPerfumeNoteFilter = new ComboBox();
            btnAddPerfume = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPerfume).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnSearch.Location = new Point(716, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(93, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgPerfume
            // 
            dgPerfume.AllowUserToAddRows = false;
            dgPerfume.AllowUserToDeleteRows = false;
            dgPerfume.AllowUserToResizeColumns = false;
            dgPerfume.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dgPerfume.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgPerfume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPerfume.BackgroundColor = SystemColors.Control;
            dgPerfume.BorderStyle = BorderStyle.None;
            dgPerfume.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgPerfume.DefaultCellStyle = dataGridViewCellStyle4;
            dgPerfume.Location = new Point(12, 67);
            dgPerfume.Name = "dgPerfume";
            dgPerfume.ReadOnly = true;
            dgPerfume.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgPerfume.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPerfume.Size = new Size(797, 357);
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
            btnAddSelectedPerfumeQuantity.Location = new Point(232, 430);
            btnAddSelectedPerfumeQuantity.Name = "btnAddSelectedPerfumeQuantity";
            btnAddSelectedPerfumeQuantity.Size = new Size(82, 38);
            btnAddSelectedPerfumeQuantity.TabIndex = 6;
            btnAddSelectedPerfumeQuantity.UseVisualStyleBackColor = false;
            btnAddSelectedPerfumeQuantity.Click += btnAddSelectedPerfumeQuantity_Click;
            // 
            // btnDeductSelectedPerfumeQuantity
            // 
            btnDeductSelectedPerfumeQuantity.BackColor = Color.FromArgb(225, 212, 193);
            btnDeductSelectedPerfumeQuantity.BackgroundImage = (Image)resources.GetObject("btnDeductSelectedPerfumeQuantity.BackgroundImage");
            btnDeductSelectedPerfumeQuantity.BackgroundImageLayout = ImageLayout.Center;
            btnDeductSelectedPerfumeQuantity.Cursor = Cursors.Hand;
            btnDeductSelectedPerfumeQuantity.FlatStyle = FlatStyle.Flat;
            btnDeductSelectedPerfumeQuantity.ForeColor = Color.White;
            btnDeductSelectedPerfumeQuantity.Location = new Point(320, 430);
            btnDeductSelectedPerfumeQuantity.Name = "btnDeductSelectedPerfumeQuantity";
            btnDeductSelectedPerfumeQuantity.Size = new Size(82, 38);
            btnDeductSelectedPerfumeQuantity.TabIndex = 7;
            btnDeductSelectedPerfumeQuantity.UseVisualStyleBackColor = false;
            btnDeductSelectedPerfumeQuantity.Click += btnDeductSelectedPerfumeQuantity_Click;
            // 
            // btnEditSelectedPerfumeDetails
            // 
            btnEditSelectedPerfumeDetails.BackColor = Color.FromArgb(225, 212, 193);
            btnEditSelectedPerfumeDetails.BackgroundImage = (Image)resources.GetObject("btnEditSelectedPerfumeDetails.BackgroundImage");
            btnEditSelectedPerfumeDetails.BackgroundImageLayout = ImageLayout.Center;
            btnEditSelectedPerfumeDetails.Cursor = Cursors.Hand;
            btnEditSelectedPerfumeDetails.FlatStyle = FlatStyle.Flat;
            btnEditSelectedPerfumeDetails.ForeColor = Color.White;
            btnEditSelectedPerfumeDetails.Location = new Point(408, 430);
            btnEditSelectedPerfumeDetails.Name = "btnEditSelectedPerfumeDetails";
            btnEditSelectedPerfumeDetails.Size = new Size(82, 38);
            btnEditSelectedPerfumeDetails.TabIndex = 8;
            btnEditSelectedPerfumeDetails.UseVisualStyleBackColor = false;
            btnEditSelectedPerfumeDetails.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(225, 212, 193);
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(496, 430);
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
            panel1.Location = new Point(12, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 24);
            panel1.TabIndex = 17;
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
            tbSearchPerfumeFilter.Size = new Size(226, 18);
            tbSearchPerfumeFilter.TabIndex = 0;
            tbSearchPerfumeFilter.Text = "Search perfume...";
            tbSearchPerfumeFilter.TextChanged += tbSearchPerfumeFilter_TextChanged;
            // 
            // cbxPerfumeBranchFilter
            // 
            cbxPerfumeBranchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfumeBranchFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPerfumeBranchFilter.FormattingEnabled = true;
            cbxPerfumeBranchFilter.Location = new Point(427, 19);
            cbxPerfumeBranchFilter.Name = "cbxPerfumeBranchFilter";
            cbxPerfumeBranchFilter.Size = new Size(137, 26);
            cbxPerfumeBranchFilter.TabIndex = 16;
            // 
            // cbxPerfumeNoteFilter
            // 
            cbxPerfumeNoteFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfumeNoteFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPerfumeNoteFilter.FormattingEnabled = true;
            cbxPerfumeNoteFilter.Location = new Point(277, 19);
            cbxPerfumeNoteFilter.Name = "cbxPerfumeNoteFilter";
            cbxPerfumeNoteFilter.Size = new Size(137, 26);
            cbxPerfumeNoteFilter.TabIndex = 15;
            // 
            // btnAddPerfume
            // 
            btnAddPerfume.BackColor = Color.FromArgb(225, 212, 193);
            btnAddPerfume.Cursor = Cursors.Hand;
            btnAddPerfume.FlatAppearance.BorderSize = 0;
            btnAddPerfume.FlatStyle = FlatStyle.Flat;
            btnAddPerfume.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPerfume.ForeColor = Color.Black;
            btnAddPerfume.Image = (Image)resources.GetObject("btnAddPerfume.Image");
            btnAddPerfume.Location = new Point(580, 15);
            btnAddPerfume.Name = "btnAddPerfume";
            btnAddPerfume.Size = new Size(124, 31);
            btnAddPerfume.TabIndex = 18;
            btnAddPerfume.Text = "Add Perfume";
            btnAddPerfume.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddPerfume.UseVisualStyleBackColor = true;
            btnAddPerfume.Click += btnAddProduct_Click;
            // 
            // AdminInventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 480);
            Controls.Add(btnAddPerfume);
            Controls.Add(panel1);
            Controls.Add(cbxPerfumeBranchFilter);
            Controls.Add(cbxPerfumeNoteFilter);
            Controls.Add(btnRefresh);
            Controls.Add(btnEditSelectedPerfumeDetails);
            Controls.Add(btnDeductSelectedPerfumeQuantity);
            Controls.Add(btnAddSelectedPerfumeQuantity);
            Controls.Add(dgPerfume);
            Controls.Add(btnSearch);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminInventoryForm";
            Text = "InventoryForm1";
            ((System.ComponentModel.ISupportInitialize)dgPerfume).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddPerfume;
        private Button btnSearch;
        private DataGridView dgPerfume;
        private Button btnAddSelectedPerfumeQuantity;
        private Button btnDeductSelectedPerfumeQuantity;
        private Button btnEditSelectedPerfumeDetails;
        private Button btnRefresh;
        private Panel panel1;
        private PictureBox pictureBox1;
        private RichTextBox tbSearchPerfumeFilter;
        private ComboBox cbxPerfumeBranchFilter;
        private ComboBox cbxPerfumeNoteFilter;
    }
}