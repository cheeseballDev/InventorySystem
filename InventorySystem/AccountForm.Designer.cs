namespace InventorySystem
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            dgPerfume = new DataGridView();
            btnDeduct = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            tbSearchProduct = new RichTextBox();
            btnSearch = new Button();
            lblDescription = new Label();
            lblTitle = new Label();
            richTextBox1 = new RichTextBox();
            btnCreateNewAccount = new Button();
            USER_ID = new DataGridViewTextBoxColumn();
            USER_EMAIL = new DataGridViewTextBoxColumn();
            USER_NAME = new DataGridViewTextBoxColumn();
            USER_ROLE = new DataGridViewTextBoxColumn();
            USER_BRANCH = new DataGridViewTextBoxColumn();
            USER_DATE_CREATED = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgPerfume).BeginInit();
            SuspendLayout();
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
            dgPerfume.Columns.AddRange(new DataGridViewColumn[] { USER_ID, USER_EMAIL, USER_NAME, USER_ROLE, USER_BRANCH, USER_DATE_CREATED });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle6.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgPerfume.DefaultCellStyle = dataGridViewCellStyle6;
            dgPerfume.Location = new Point(26, 120);
            dgPerfume.Name = "dgPerfume";
            dgPerfume.ReadOnly = true;
            dgPerfume.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgPerfume.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPerfume.Size = new Size(783, 325);
            dgPerfume.TabIndex = 5;
            // 
            // btnDeduct
            // 
            btnDeduct.BackColor = Color.FromArgb(225, 212, 193);
            btnDeduct.BackgroundImageLayout = ImageLayout.Center;
            btnDeduct.Cursor = Cursors.Hand;
            btnDeduct.FlatAppearance.BorderSize = 0;
            btnDeduct.FlatStyle = FlatStyle.Flat;
            btnDeduct.Font = new Font("Montserrat", 9.749999F);
            btnDeduct.ForeColor = SystemColors.ControlText;
            btnDeduct.Location = new Point(188, 460);
            btnDeduct.Name = "btnDeduct";
            btnDeduct.Size = new Size(155, 28);
            btnDeduct.TabIndex = 7;
            btnDeduct.Text = "Reset Password";
            btnDeduct.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(126, 16, 44);
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Montserrat", 9.749999F);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(365, 460);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(147, 28);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Delete Account";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(225, 212, 193);
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Montserrat", 9.749999F);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(26, 460);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 28);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Edit Account";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbSearchProduct
            // 
            tbSearchProduct.BorderStyle = BorderStyle.None;
            tbSearchProduct.DetectUrls = false;
            tbSearchProduct.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchProduct.ForeColor = Color.FromArgb(135, 135, 135);
            tbSearchProduct.Location = new Point(12, 28);
            tbSearchProduct.MaxLength = 20;
            tbSearchProduct.Multiline = false;
            tbSearchProduct.Name = "tbSearchProduct";
            tbSearchProduct.Size = new Size(74, 15);
            tbSearchProduct.TabIndex = 10;
            tbSearchProduct.Text = "Filter: User:";
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
            btnSearch.Location = new Point(336, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 28);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(135, 135, 135);
            lblDescription.Location = new Point(26, 94);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(124, 18);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "List of all accounts";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(8, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 37);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Account List";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.DetectUrls = false;
            richTextBox1.Font = new Font("Montserrat", 9.7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(92, 22);
            richTextBox1.MaxLength = 20;
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(215, 27);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "Search product";
            // 
            // btnCreateNewAccount
            // 
            btnCreateNewAccount.BackColor = Color.FromArgb(225, 212, 193);
            btnCreateNewAccount.Cursor = Cursors.Hand;
            btnCreateNewAccount.FlatAppearance.BorderSize = 0;
            btnCreateNewAccount.FlatStyle = FlatStyle.Flat;
            btnCreateNewAccount.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateNewAccount.ForeColor = Color.Black;
            btnCreateNewAccount.Location = new Point(452, 22);
            btnCreateNewAccount.Name = "btnCreateNewAccount";
            btnCreateNewAccount.Size = new Size(165, 28);
            btnCreateNewAccount.TabIndex = 15;
            btnCreateNewAccount.Text = "Create New Account";
            btnCreateNewAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateNewAccount.UseVisualStyleBackColor = true;
            // 
            // USER_ID
            // 
            USER_ID.FillWeight = 60F;
            USER_ID.HeaderText = "User ID";
            USER_ID.MinimumWidth = 3;
            USER_ID.Name = "USER_ID";
            USER_ID.ReadOnly = true;
            // 
            // USER_EMAIL
            // 
            USER_EMAIL.FillWeight = 120F;
            USER_EMAIL.HeaderText = "Email";
            USER_EMAIL.Name = "USER_EMAIL";
            USER_EMAIL.ReadOnly = true;
            // 
            // USER_NAME
            // 
            USER_NAME.HeaderText = "Name";
            USER_NAME.Name = "USER_NAME";
            USER_NAME.ReadOnly = true;
            // 
            // USER_ROLE
            // 
            USER_ROLE.FillWeight = 80F;
            USER_ROLE.HeaderText = "Role";
            USER_ROLE.Name = "USER_ROLE";
            USER_ROLE.ReadOnly = true;
            // 
            // USER_BRANCH
            // 
            USER_BRANCH.FillWeight = 80F;
            USER_BRANCH.HeaderText = "Branch";
            USER_BRANCH.Name = "USER_BRANCH";
            USER_BRANCH.ReadOnly = true;
            // 
            // USER_DATE_CREATED
            // 
            USER_DATE_CREATED.FillWeight = 90F;
            USER_DATE_CREATED.HeaderText = "Date Created";
            USER_DATE_CREATED.Name = "USER_DATE_CREATED";
            USER_DATE_CREATED.ReadOnly = true;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 504);
            Controls.Add(btnCreateNewAccount);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(btnSearch);
            Controls.Add(richTextBox1);
            Controls.Add(tbSearchProduct);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeduct);
            Controls.Add(btnAdd);
            Controls.Add(dgPerfume);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AccountForm";
            Text = "InventoryForm1";
            ((System.ComponentModel.ISupportInitialize)dgPerfume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreateNewAccount;
        private DataGridView dgPerfume;
        private Button btnDeduct;
        private Button btnRefresh;
        private Button btnAdd;
        private RichTextBox tbSearchProduct;
        private Button btnSearch;
        private Label lblDescription;
        private Label lblTitle;
        private RichTextBox richTextBox1;
        private DataGridViewTextBoxColumn USER_ID;
        private DataGridViewTextBoxColumn USER_EMAIL;
        private DataGridViewTextBoxColumn USER_NAME;
        private DataGridViewTextBoxColumn USER_ROLE;
        private DataGridViewTextBoxColumn USER_BRANCH;
        private DataGridViewTextBoxColumn USER_DATE_CREATED;
    }
}