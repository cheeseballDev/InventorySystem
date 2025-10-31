namespace InventorySystem.Forms_Admin
{
    partial class CreateAccountPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountPopUp));
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            tbAccountName = new RichTextBox();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label3 = new Label();
            tbAccountEmail = new RichTextBox();
            cbxAccountRole = new ComboBox();
            cbxAccountBranch = new ComboBox();
            tbPassword = new RichTextBox();
            label6 = new Label();
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
            label1.Font = new Font("Microsoft Sans Serif", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(308, 33);
            label1.TabIndex = 9;
            label1.Text = "Create New Account:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 11;
            label2.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(26, 121);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 13;
            label4.Text = "Email:";
            // 
            // tbAccountName
            // 
            tbAccountName.ForeColor = Color.FromArgb(135, 135, 135);
            tbAccountName.Location = new Point(120, 75);
            tbAccountName.MaxLength = 32;
            tbAccountName.Multiline = false;
            tbAccountName.Name = "tbAccountName";
            tbAccountName.Size = new Size(330, 24);
            tbAccountName.TabIndex = 14;
            tbAccountName.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(26, 203);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 15;
            label5.Text = "Branch:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(225, 212, 193);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(98, 299);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 31);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save Changes";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(225, 212, 193);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(258, 299);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 31);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel Changes";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(26, 251);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 19;
            label3.Text = "Role:";
            // 
            // tbAccountEmail
            // 
            tbAccountEmail.ForeColor = Color.FromArgb(135, 135, 135);
            tbAccountEmail.Location = new Point(120, 121);
            tbAccountEmail.MaxLength = 32;
            tbAccountEmail.Multiline = false;
            tbAccountEmail.Name = "tbAccountEmail";
            tbAccountEmail.Size = new Size(330, 24);
            tbAccountEmail.TabIndex = 20;
            tbAccountEmail.Text = "";
            // 
            // cbxAccountRole
            // 
            cbxAccountRole.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAccountRole.FormattingEnabled = true;
            cbxAccountRole.Items.AddRange(new object[] { "Inventory Guy", "Family Guy" });
            cbxAccountRole.Location = new Point(120, 249);
            cbxAccountRole.Name = "cbxAccountRole";
            cbxAccountRole.Size = new Size(330, 23);
            cbxAccountRole.TabIndex = 22;
            cbxAccountRole.Text = "Select role...";
            // 
            // cbxAccountBranch
            // 
            cbxAccountBranch.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAccountBranch.FormattingEnabled = true;
            cbxAccountBranch.Items.AddRange(new object[] { "Branch 1", "Branch 2", "Branch 3" });
            cbxAccountBranch.Location = new Point(120, 205);
            cbxAccountBranch.Name = "cbxAccountBranch";
            cbxAccountBranch.Size = new Size(330, 23);
            cbxAccountBranch.TabIndex = 23;
            cbxAccountBranch.Text = "Select branch...";
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.FromArgb(135, 135, 135);
            tbPassword.Location = new Point(120, 162);
            tbPassword.MaxLength = 32;
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(330, 24);
            tbPassword.TabIndex = 25;
            tbPassword.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(135, 135, 135);
            label6.Location = new Point(26, 162);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 24;
            label6.Text = "Password:";
            // 
            // CreateAccountPopUp
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 449);
            Controls.Add(tbPassword);
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
            Name = "CreateAccountPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccountPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox tbAccountName;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private RichTextBox tbAccountEmail;
        private ComboBox cbxAccountRole;
        private ComboBox cbxAccountBranch;
        private RichTextBox tbPassword;
        private Label label6;
    }
}