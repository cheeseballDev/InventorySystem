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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInventoryForm));
            dgPerfume = new DataGridView();
            PERFUME_ID = new DataGridViewTextBoxColumn();
            PERFUME_NAME = new DataGridViewTextBoxColumn();
            PERFUME_NOTE = new DataGridViewTextBoxColumn();
            PERFUME_BRANCH = new DataGridViewTextBoxColumn();
            PERFUME_DATECREATED = new DataGridViewTextBoxColumn();
            PERFUME_QTY = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDeduct = new Button();
            btnEdit = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbSearchProduct = new RichTextBox();
            btnScanQR = new Button();
            cbxBranch = new ComboBox();
            cbxNote = new ComboBox();
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
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgPerfume.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgPerfume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPerfume.BackgroundColor = Color.White;
            dgPerfume.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgPerfume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgPerfume.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPerfume.Columns.AddRange(new DataGridViewColumn[] { PERFUME_ID, PERFUME_NAME, PERFUME_NOTE, PERFUME_BRANCH, PERFUME_DATECREATED, PERFUME_QTY });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgPerfume.DefaultCellStyle = dataGridViewCellStyle3;
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(225, 212, 193);
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(225, 455);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 38);
            btnAdd.TabIndex = 6;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDeduct
            // 
            btnDeduct.BackColor = Color.FromArgb(225, 212, 193);
            btnDeduct.BackgroundImage = (Image)resources.GetObject("btnDeduct.BackgroundImage");
            btnDeduct.BackgroundImageLayout = ImageLayout.Center;
            btnDeduct.Cursor = Cursors.Hand;
            btnDeduct.FlatStyle = FlatStyle.Flat;
            btnDeduct.ForeColor = Color.White;
            btnDeduct.Location = new Point(313, 455);
            btnDeduct.Name = "btnDeduct";
            btnDeduct.Size = new Size(82, 38);
            btnDeduct.TabIndex = 7;
            btnDeduct.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(225, 212, 193);
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.BackgroundImageLayout = ImageLayout.Center;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(401, 455);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 38);
            btnEdit.TabIndex = 8;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            panel1.Controls.Add(tbSearchProduct);
            panel1.Location = new Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 24);
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
            // tbSearchProduct
            // 
            tbSearchProduct.BorderStyle = BorderStyle.None;
            tbSearchProduct.DetectUrls = false;
            tbSearchProduct.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchProduct.Location = new Point(22, 3);
            tbSearchProduct.MaxLength = 20;
            tbSearchProduct.Multiline = false;
            tbSearchProduct.Name = "tbSearchProduct";
            tbSearchProduct.Size = new Size(245, 21);
            tbSearchProduct.TabIndex = 0;
            tbSearchProduct.Text = "Search product";
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
            btnScanQR.Location = new Point(686, 13);
            btnScanQR.Name = "btnScanQR";
            btnScanQR.Size = new Size(123, 31);
            btnScanQR.TabIndex = 13;
            btnScanQR.Text = "Scan QR";
            btnScanQR.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnScanQR.UseVisualStyleBackColor = true;
            // 
            // cbxBranch
            // 
            cbxBranch.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxBranch.FormattingEnabled = true;
            cbxBranch.Location = new Point(478, 17);
            cbxBranch.Name = "cbxBranch";
            cbxBranch.Size = new Size(148, 24);
            cbxBranch.TabIndex = 12;
            cbxBranch.Text = "Filter: Branch";
            // 
            // cbxNote
            // 
            cbxNote.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNote.FormattingEnabled = true;
            cbxNote.Location = new Point(313, 17);
            cbxNote.Name = "cbxNote";
            cbxNote.Size = new Size(148, 24);
            cbxNote.TabIndex = 11;
            cbxNote.Text = "Filter: Note Type";
            // 
            // StaffInventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 504);
            Controls.Add(panel1);
            Controls.Add(btnScanQR);
            Controls.Add(cbxBranch);
            Controls.Add(cbxNote);
            Controls.Add(btnRefresh);
            Controls.Add(btnEdit);
            Controls.Add(btnDeduct);
            Controls.Add(btnAdd);
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
        private Button btnAdd;
        private Button btnDeduct;
        private Button btnEdit;
        private DataGridViewTextBoxColumn PERFUME_ID;
        private DataGridViewTextBoxColumn PERFUME_NAME;
        private DataGridViewTextBoxColumn PERFUME_NOTE;
        private DataGridViewTextBoxColumn PERFUME_BRANCH;
        private DataGridViewTextBoxColumn PERFUME_DATECREATED;
        private DataGridViewTextBoxColumn PERFUME_QTY;
        private Button btnRefresh;
        private Panel panel1;
        private PictureBox pictureBox1;
        private RichTextBox tbSearchProduct;
        private Button btnScanQR;
        private ComboBox cbxBranch;
        private ComboBox cbxNote;
    }
}