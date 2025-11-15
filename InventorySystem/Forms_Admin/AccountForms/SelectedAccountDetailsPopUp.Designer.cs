namespace InventorySystem.Forms_Admin
{
    partial class SelectedAccountDetailsPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedAccountDetailsPopUp));
            btnClose = new Button();
            label1 = new Label();
            cbxAccountBranch = new ComboBox();
            cbxAccountRole = new ComboBox();
            tbAccountEmail = new RichTextBox();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label5 = new Label();
            tbAccountName = new RichTextBox();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            tbAccountPassword = new RichTextBox();
            btnArchiveAccount = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(454, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 32);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.TopLeft;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(406, 40);
            label1.TabIndex = 9;
            label1.Text = "Selected Account Details:";
            // 
            // cbxAccountBranch
            // 
            cbxAccountBranch.Font = new Font("Montserrat", 8.999999F);
            cbxAccountBranch.FormattingEnabled = true;
            cbxAccountBranch.Items.AddRange(new object[] { "Branch 1", "Branch 2", "Branch 3" });
            cbxAccountBranch.Location = new Point(130, 194);
            cbxAccountBranch.Name = "cbxAccountBranch";
            cbxAccountBranch.Size = new Size(339, 24);
            cbxAccountBranch.TabIndex = 35;
            cbxAccountBranch.Text = "Select branch...";
            // 
            // cbxAccountRole
            // 
            cbxAccountRole.Font = new Font("Montserrat", 8.999999F);
            cbxAccountRole.FormattingEnabled = true;
            cbxAccountRole.Items.AddRange(new object[] { "Inventory Guy", "Family Guy" });
            cbxAccountRole.Location = new Point(130, 238);
            cbxAccountRole.Name = "cbxAccountRole";
            cbxAccountRole.Size = new Size(339, 24);
            cbxAccountRole.TabIndex = 34;
            cbxAccountRole.Text = "Select role...";
            // 
            // tbAccountEmail
            // 
            tbAccountEmail.Font = new Font("Montserrat", 9.749999F);
            tbAccountEmail.ForeColor = SystemColors.ControlText;
            tbAccountEmail.Location = new Point(130, 108);
            tbAccountEmail.MaxLength = 32;
            tbAccountEmail.Multiline = false;
            tbAccountEmail.Name = "tbAccountEmail";
            tbAccountEmail.Size = new Size(339, 24);
            tbAccountEmail.TabIndex = 33;
            tbAccountEmail.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F);
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(29, 240);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 32;
            label3.Text = "Role:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(225, 212, 193);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Montserrat", 9.749999F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(173, 284);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 31);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel Changes";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(225, 212, 193);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Montserrat", 9.749999F);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(26, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 31);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save Changes";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12F);
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(29, 192);
            label5.Name = "label5";
            label5.Size = new Size(70, 22);
            label5.TabIndex = 29;
            label5.Text = "Branch:";
            // 
            // tbAccountName
            // 
            tbAccountName.Font = new Font("Montserrat", 9.749999F);
            tbAccountName.ForeColor = SystemColors.ControlText;
            tbAccountName.Location = new Point(130, 64);
            tbAccountName.MaxLength = 32;
            tbAccountName.Multiline = false;
            tbAccountName.Name = "tbAccountName";
            tbAccountName.Size = new Size(339, 24);
            tbAccountName.TabIndex = 28;
            tbAccountName.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 12F);
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(29, 108);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 27;
            label4.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 12F);
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(29, 64);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 26;
            label2.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 12F);
            label6.ForeColor = Color.FromArgb(135, 135, 135);
            label6.Location = new Point(29, 150);
            label6.Name = "label6";
            label6.Size = new Size(90, 22);
            label6.TabIndex = 36;
            label6.Text = "Password:";
            // 
            // tbAccountPassword
            // 
            tbAccountPassword.Font = new Font("Montserrat", 9.749999F);
            tbAccountPassword.ForeColor = SystemColors.ControlText;
            tbAccountPassword.Location = new Point(130, 150);
            tbAccountPassword.MaxLength = 32;
            tbAccountPassword.Multiline = false;
            tbAccountPassword.Name = "tbAccountPassword";
            tbAccountPassword.Size = new Size(339, 24);
            tbAccountPassword.TabIndex = 37;
            tbAccountPassword.Text = "";
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
            btnArchiveAccount.Location = new Point(328, 284);
            btnArchiveAccount.Name = "btnArchiveAccount";
            btnArchiveAccount.Size = new Size(141, 31);
            btnArchiveAccount.TabIndex = 38;
            btnArchiveAccount.Text = "Archive Account";
            btnArchiveAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnArchiveAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchiveAccount.UseVisualStyleBackColor = false;
            btnArchiveAccount.Click += btnArchiveAccount_Click;
            // 
            // SelectedAccountDetailsPopUp
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 334);
            Controls.Add(btnArchiveAccount);
            Controls.Add(tbAccountPassword);
            Controls.Add(label6);
            Controls.Add(cbxAccountBranch);
            Controls.Add(cbxAccountRole);
            Controls.Add(tbAccountEmail);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(tbAccountName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SelectedAccountDetailsPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectedAccountDetailsPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cbxAccountBranch;
        private ComboBox cbxAccountRole;
        private RichTextBox tbAccountEmail;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private Label label5;
        private RichTextBox tbAccountName;
        private Label label4;
        private Label label2;
        private Label label6;
        private RichTextBox tbAccountPassword;
        private Button btnArchiveAccount;
    }
}