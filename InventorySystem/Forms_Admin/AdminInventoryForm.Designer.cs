﻿namespace InventorySystem
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnScanQR = new Button();
            dgPerfume = new DataGridView();
            PERFUME_ID = new DataGridViewTextBoxColumn();
            PERFUME_NAME = new DataGridViewTextBoxColumn();
            PERFUME_NOTE = new DataGridViewTextBoxColumn();
            PERFUME_BRANCH = new DataGridViewTextBoxColumn();
            PERFUME_DATECREATED = new DataGridViewTextBoxColumn();
            PERFUME_QTY = new DataGridViewTextBoxColumn();
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
            // btnScanQR
            // 
            btnScanQR.BackColor = Color.FromArgb(225, 212, 193);
            btnScanQR.Cursor = Cursors.Hand;
            btnScanQR.FlatAppearance.BorderSize = 0;
            btnScanQR.FlatStyle = FlatStyle.Flat;
            btnScanQR.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScanQR.ForeColor = Color.Black;
            btnScanQR.Image = (Image)resources.GetObject("btnScanQR.Image");
            btnScanQR.Location = new Point(716, 15);
            btnScanQR.Name = "btnScanQR";
            btnScanQR.Size = new Size(93, 31);
            btnScanQR.TabIndex = 4;
            btnScanQR.Text = "Scan QR";
            btnScanQR.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnScanQR.UseVisualStyleBackColor = true;
            btnScanQR.Click += btnScanQR_Click;
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
            dgPerfume.Columns.AddRange(new DataGridViewColumn[] { PERFUME_ID, PERFUME_NAME, PERFUME_NOTE, PERFUME_BRANCH, PERFUME_DATECREATED, PERFUME_QTY });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle6.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgPerfume.DefaultCellStyle = dataGridViewCellStyle6;
            dgPerfume.Location = new Point(12, 61);
            dgPerfume.Name = "dgPerfume";
            dgPerfume.ReadOnly = true;
            dgPerfume.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgPerfume.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPerfume.Size = new Size(797, 383);
            dgPerfume.TabIndex = 5;
            // 
            // PERFUME_ID
            // 
            PERFUME_ID.FillWeight = 40F;
            PERFUME_ID.HeaderText = "ID";
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
            // PERFUME_NOTE
            // 
            PERFUME_NOTE.HeaderText = "Note";
            PERFUME_NOTE.Name = "PERFUME_NOTE";
            PERFUME_NOTE.ReadOnly = true;
            // 
            // PERFUME_BRANCH
            // 
            PERFUME_BRANCH.HeaderText = "Branch";
            PERFUME_BRANCH.Name = "PERFUME_BRANCH";
            PERFUME_BRANCH.ReadOnly = true;
            // 
            // PERFUME_DATECREATED
            // 
            PERFUME_DATECREATED.FillWeight = 107.817261F;
            PERFUME_DATECREATED.HeaderText = "Date Created";
            PERFUME_DATECREATED.Name = "PERFUME_DATECREATED";
            PERFUME_DATECREATED.ReadOnly = true;
            // 
            // PERFUME_QTY
            // 
            PERFUME_QTY.FillWeight = 90F;
            PERFUME_QTY.HeaderText = "Available Qty";
            PERFUME_QTY.Name = "PERFUME_QTY";
            PERFUME_QTY.ReadOnly = true;
            // 
            // btnAddSelectedPerfumeQuantity
            // 
            btnAddSelectedPerfumeQuantity.BackColor = Color.FromArgb(225, 212, 193);
            btnAddSelectedPerfumeQuantity.BackgroundImage = (Image)resources.GetObject("btnAddSelectedPerfumeQuantity.BackgroundImage");
            btnAddSelectedPerfumeQuantity.BackgroundImageLayout = ImageLayout.Center;
            btnAddSelectedPerfumeQuantity.Cursor = Cursors.Hand;
            btnAddSelectedPerfumeQuantity.FlatStyle = FlatStyle.Flat;
            btnAddSelectedPerfumeQuantity.ForeColor = Color.White;
            btnAddSelectedPerfumeQuantity.Location = new Point(225, 455);
            btnAddSelectedPerfumeQuantity.Name = "btnAddSelectedPerfumeQuantity";
            btnAddSelectedPerfumeQuantity.Size = new Size(82, 38);
            btnAddSelectedPerfumeQuantity.TabIndex = 6;
            btnAddSelectedPerfumeQuantity.UseVisualStyleBackColor = false;
            // 
            // btnDeductSelectedPerfumeQuantity
            // 
            btnDeductSelectedPerfumeQuantity.BackColor = Color.FromArgb(225, 212, 193);
            btnDeductSelectedPerfumeQuantity.BackgroundImage = (Image)resources.GetObject("btnDeductSelectedPerfumeQuantity.BackgroundImage");
            btnDeductSelectedPerfumeQuantity.BackgroundImageLayout = ImageLayout.Center;
            btnDeductSelectedPerfumeQuantity.Cursor = Cursors.Hand;
            btnDeductSelectedPerfumeQuantity.FlatStyle = FlatStyle.Flat;
            btnDeductSelectedPerfumeQuantity.ForeColor = Color.White;
            btnDeductSelectedPerfumeQuantity.Location = new Point(313, 455);
            btnDeductSelectedPerfumeQuantity.Name = "btnDeductSelectedPerfumeQuantity";
            btnDeductSelectedPerfumeQuantity.Size = new Size(82, 38);
            btnDeductSelectedPerfumeQuantity.TabIndex = 7;
            btnDeductSelectedPerfumeQuantity.UseVisualStyleBackColor = false;
            // 
            // btnEditSelectedPerfumeDetails
            // 
            btnEditSelectedPerfumeDetails.BackColor = Color.FromArgb(225, 212, 193);
            btnEditSelectedPerfumeDetails.BackgroundImage = (Image)resources.GetObject("btnEditSelectedPerfumeDetails.BackgroundImage");
            btnEditSelectedPerfumeDetails.BackgroundImageLayout = ImageLayout.Center;
            btnEditSelectedPerfumeDetails.Cursor = Cursors.Hand;
            btnEditSelectedPerfumeDetails.FlatStyle = FlatStyle.Flat;
            btnEditSelectedPerfumeDetails.ForeColor = Color.White;
            btnEditSelectedPerfumeDetails.Location = new Point(401, 455);
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
            btnRefresh.Location = new Point(489, 455);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 38);
            btnRefresh.TabIndex = 9;
            btnRefresh.UseVisualStyleBackColor = false;
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
            tbSearchPerfumeFilter.Text = "Search product";
            // 
            // cbxPerfumeBranchFilter
            // 
            cbxPerfumeBranchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfumeBranchFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPerfumeBranchFilter.FormattingEnabled = true;
            cbxPerfumeBranchFilter.Location = new Point(427, 19);
            cbxPerfumeBranchFilter.Name = "cbxPerfumeBranchFilter";
            cbxPerfumeBranchFilter.Size = new Size(137, 24);
            cbxPerfumeBranchFilter.TabIndex = 16;
            // 
            // cbxPerfumeNoteFilter
            // 
            cbxPerfumeNoteFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfumeNoteFilter.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPerfumeNoteFilter.FormattingEnabled = true;
            cbxPerfumeNoteFilter.Location = new Point(277, 19);
            cbxPerfumeNoteFilter.Name = "cbxPerfumeNoteFilter";
            cbxPerfumeNoteFilter.Size = new Size(137, 24);
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
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 504);
            Controls.Add(btnAddPerfume);
            Controls.Add(panel1);
            Controls.Add(cbxPerfumeBranchFilter);
            Controls.Add(cbxPerfumeNoteFilter);
            Controls.Add(btnRefresh);
            Controls.Add(btnEditSelectedPerfumeDetails);
            Controls.Add(btnDeductSelectedPerfumeQuantity);
            Controls.Add(btnAddSelectedPerfumeQuantity);
            Controls.Add(dgPerfume);
            Controls.Add(btnScanQR);
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
        private Button btnScanQR;
        private DataGridView dgPerfume;
        private Button btnAddSelectedPerfumeQuantity;
        private Button btnDeductSelectedPerfumeQuantity;
        private Button btnEditSelectedPerfumeDetails;
        private DataGridViewTextBoxColumn PERFUME_ID;
        private DataGridViewTextBoxColumn PERFUME_NAME;
        private DataGridViewTextBoxColumn PERFUME_NOTE;
        private DataGridViewTextBoxColumn PERFUME_BRANCH;
        private DataGridViewTextBoxColumn PERFUME_DATECREATED;
        private DataGridViewTextBoxColumn PERFUME_QTY;
        private Button btnRefresh;
        private Panel panel1;
        private PictureBox pictureBox1;
        private RichTextBox tbSearchPerfumeFilter;
        private ComboBox cbxPerfumeBranchFilter;
        private ComboBox cbxPerfumeNoteFilter;
    }
}