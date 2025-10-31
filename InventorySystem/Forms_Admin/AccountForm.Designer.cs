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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            dgAccounts = new DataGridView();
            btnResetAccountPassword = new Button();
            btnArchiveAccount = new Button();
            btnEditAccount = new Button();
            tbSearchProduct = new RichTextBox();
            btnSearch = new Button();
            lblDescription = new Label();
            lblTitle = new Label();
            tbSearchUserFilter = new RichTextBox();
            btnCreateNewAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)dgAccounts).BeginInit();
            SuspendLayout();
            // 
            // dgAccounts
            // 
            dgAccounts.AllowUserToAddRows = false;
            dgAccounts.AllowUserToDeleteRows = false;
            dgAccounts.AllowUserToResizeColumns = false;
            dgAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAccounts.BackgroundColor = Color.White;
            dgAccounts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            dgAccounts.Location = new Point(26, 120);
            dgAccounts.Name = "dgAccounts";
            dgAccounts.ReadOnly = true;
            dgAccounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAccounts.Size = new Size(783, 325);
            dgAccounts.TabIndex = 5;
            // 
            // btnResetAccountPassword
            // 
            btnResetAccountPassword.BackColor = Color.FromArgb(225, 212, 193);
            btnResetAccountPassword.BackgroundImageLayout = ImageLayout.Center;
            btnResetAccountPassword.Cursor = Cursors.Hand;
            btnResetAccountPassword.FlatAppearance.BorderSize = 0;
            btnResetAccountPassword.FlatStyle = FlatStyle.Flat;
            btnResetAccountPassword.Font = new Font("Montserrat", 9.749999F);
            btnResetAccountPassword.ForeColor = SystemColors.ControlText;
            btnResetAccountPassword.Image = (Image)resources.GetObject("btnResetAccountPassword.Image");
            btnResetAccountPassword.Location = new Point(188, 460);
            btnResetAccountPassword.Name = "btnResetAccountPassword";
            btnResetAccountPassword.Size = new Size(155, 28);
            btnResetAccountPassword.TabIndex = 7;
            btnResetAccountPassword.Text = "Reset Password";
            btnResetAccountPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetAccountPassword.UseVisualStyleBackColor = false;
            // 
            // btnArchiveAccount
            // 
            btnArchiveAccount.BackColor = Color.FromArgb(126, 16, 44);
            btnArchiveAccount.BackgroundImageLayout = ImageLayout.Center;
            btnArchiveAccount.Cursor = Cursors.Hand;
            btnArchiveAccount.FlatAppearance.BorderSize = 0;
            btnArchiveAccount.FlatStyle = FlatStyle.Flat;
            btnArchiveAccount.Font = new Font("Montserrat", 9.749999F);
            btnArchiveAccount.ForeColor = SystemColors.Control;
            btnArchiveAccount.Image = (Image)resources.GetObject("btnArchiveAccount.Image");
            btnArchiveAccount.Location = new Point(365, 460);
            btnArchiveAccount.Name = "btnArchiveAccount";
            btnArchiveAccount.Size = new Size(147, 28);
            btnArchiveAccount.TabIndex = 9;
            btnArchiveAccount.Text = "Archive Account";
            btnArchiveAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchiveAccount.UseVisualStyleBackColor = false;
            btnArchiveAccount.Click += btnArchiveAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.BackColor = Color.FromArgb(225, 212, 193);
            btnEditAccount.BackgroundImageLayout = ImageLayout.Center;
            btnEditAccount.Cursor = Cursors.Hand;
            btnEditAccount.FlatAppearance.BorderSize = 0;
            btnEditAccount.FlatStyle = FlatStyle.Flat;
            btnEditAccount.Font = new Font("Montserrat", 9.749999F);
            btnEditAccount.ForeColor = SystemColors.ControlText;
            btnEditAccount.Image = (Image)resources.GetObject("btnEditAccount.Image");
            btnEditAccount.Location = new Point(26, 460);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(142, 28);
            btnEditAccount.TabIndex = 6;
            btnEditAccount.Text = "Edit Account";
            btnEditAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditAccount.UseVisualStyleBackColor = false;
            btnEditAccount.Click += btnEditAccount_Click;
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
            btnSearch.Font = new Font("Montserrat", 9.749999F);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(336, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 28);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
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
            // tbSearchUserFilter
            // 
            tbSearchUserFilter.BorderStyle = BorderStyle.FixedSingle;
            tbSearchUserFilter.DetectUrls = false;
            tbSearchUserFilter.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchUserFilter.Location = new Point(92, 22);
            tbSearchUserFilter.MaxLength = 20;
            tbSearchUserFilter.Multiline = false;
            tbSearchUserFilter.Name = "tbSearchUserFilter";
            tbSearchUserFilter.Size = new Size(215, 27);
            tbSearchUserFilter.TabIndex = 11;
            tbSearchUserFilter.Text = "Search user...";
            tbSearchUserFilter.TextChanged += tbSearchUserFilter_TextChanged;
            tbSearchUserFilter.Enter += tbSearchUserFilter_Enter;
            tbSearchUserFilter.Leave += tbSearchUserFilter_Leave;
            // 
            // btnCreateNewAccount
            // 
            btnCreateNewAccount.BackColor = Color.FromArgb(225, 212, 193);
            btnCreateNewAccount.Cursor = Cursors.Hand;
            btnCreateNewAccount.FlatAppearance.BorderSize = 0;
            btnCreateNewAccount.FlatStyle = FlatStyle.Flat;
            btnCreateNewAccount.Font = new Font("Montserrat", 9.749999F);
            btnCreateNewAccount.ForeColor = Color.Black;
            btnCreateNewAccount.Image = (Image)resources.GetObject("btnCreateNewAccount.Image");
            btnCreateNewAccount.Location = new Point(452, 22);
            btnCreateNewAccount.Name = "btnCreateNewAccount";
            btnCreateNewAccount.Size = new Size(165, 28);
            btnCreateNewAccount.TabIndex = 15;
            btnCreateNewAccount.Text = "Create New Account";
            btnCreateNewAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateNewAccount.UseVisualStyleBackColor = true;
            btnCreateNewAccount.Click += btnCreateNewAccount_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 504);
            Controls.Add(btnCreateNewAccount);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(btnSearch);
            Controls.Add(tbSearchUserFilter);
            Controls.Add(tbSearchProduct);
            Controls.Add(btnArchiveAccount);
            Controls.Add(btnResetAccountPassword);
            Controls.Add(btnEditAccount);
            Controls.Add(dgAccounts);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AccountForm";
            Text = "InventoryForm1";
            ((System.ComponentModel.ISupportInitialize)dgAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreateNewAccount;
        private DataGridView dgAccounts;
        private Button btnResetAccountPassword;
        private Button btnArchiveAccount;
        private Button btnEditAccount;
        private RichTextBox tbSearchProduct;
        private Button btnSearch;
        private Label lblDescription;
        private Label lblTitle;
        private RichTextBox tbSearchUserFilter;
    }
}