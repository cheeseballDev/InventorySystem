﻿namespace InventorySystem
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            dgAccounts = new DataGridView();
            USER_ID = new DataGridViewTextBoxColumn();
            USER_EMAIL = new DataGridViewTextBoxColumn();
            USER_NAME = new DataGridViewTextBoxColumn();
            USER_ROLE = new DataGridViewTextBoxColumn();
            USER_BRANCH = new DataGridViewTextBoxColumn();
            USER_DATE_CREATED = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dgAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAccounts.BackgroundColor = Color.White;
            dgAccounts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAccounts.Columns.AddRange(new DataGridViewColumn[] { USER_ID, USER_EMAIL, USER_NAME, USER_ROLE, USER_BRANCH, USER_DATE_CREATED });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle15.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgAccounts.DefaultCellStyle = dataGridViewCellStyle15;
            dgAccounts.Location = new Point(26, 120);
            dgAccounts.Name = "dgAccounts";
            dgAccounts.ReadOnly = true;
            dgAccounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAccounts.Size = new Size(783, 325);
            dgAccounts.TabIndex = 5;
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
            // tbSearchUserFilter
            // 
            tbSearchUserFilter.BorderStyle = BorderStyle.FixedSingle;
            tbSearchUserFilter.DetectUrls = false;
            tbSearchUserFilter.Font = new Font("Montserrat", 9.7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchUserFilter.Location = new Point(92, 22);
            tbSearchUserFilter.MaxLength = 20;
            tbSearchUserFilter.Multiline = false;
            tbSearchUserFilter.Name = "tbSearchUserFilter";
            tbSearchUserFilter.Size = new Size(215, 27);
            tbSearchUserFilter.TabIndex = 11;
            tbSearchUserFilter.Text = "Search user....";
            // 
            // btnCreateNewAccount
            // 
            btnCreateNewAccount.BackColor = Color.FromArgb(225, 212, 193);
            btnCreateNewAccount.Cursor = Cursors.Hand;
            btnCreateNewAccount.FlatAppearance.BorderSize = 0;
            btnCreateNewAccount.FlatStyle = FlatStyle.Flat;
            btnCreateNewAccount.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateNewAccount.ForeColor = Color.Black;
            btnCreateNewAccount.Image = (Image)resources.GetObject("btnCreateNewAccount.Image");
            btnCreateNewAccount.Location = new Point(452, 22);
            btnCreateNewAccount.Name = "btnCreateNewAccount";
            btnCreateNewAccount.Size = new Size(165, 28);
            btnCreateNewAccount.TabIndex = 15;
            btnCreateNewAccount.Text = "Create New Account";
            btnCreateNewAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateNewAccount.UseVisualStyleBackColor = true;
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
            Controls.Add(tbSearchUserFilter);
            Controls.Add(tbSearchProduct);
            Controls.Add(btnArchiveAccount);
            Controls.Add(btnResetAccountPassword);
            Controls.Add(btnEditAccount);
            Controls.Add(dgAccounts);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private DataGridViewTextBoxColumn USER_ID;
        private DataGridViewTextBoxColumn USER_EMAIL;
        private DataGridViewTextBoxColumn USER_NAME;
        private DataGridViewTextBoxColumn USER_ROLE;
        private DataGridViewTextBoxColumn USER_BRANCH;
        private DataGridViewTextBoxColumn USER_DATE_CREATED;
    }
}