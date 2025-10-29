namespace InventorySystem
{
    partial class AdminLoginForm
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
            label1 = new Label();
            btnLogin = new Button();
            tbPassword = new RichTextBox();
            tbEmail = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            btnClose = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 44);
            label1.TabIndex = 0;
            label1.Text = "Login as Admin";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(225, 212, 193);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(356, 278);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(279, 32);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(356, 218);
            tbPassword.MaxLength = 24;
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(279, 32);
            tbPassword.TabIndex = 2;
            tbPassword.Text = "";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(356, 160);
            tbEmail.MaxLength = 64;
            tbEmail.Multiline = false;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(279, 32);
            tbEmail.TabIndex = 1;
            tbEmail.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 195);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 135);
            label3.Name = "label3";
            label3.Size = new Size(58, 22);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(980, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 32);
            btnClose.TabIndex = 7;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.TopLeft;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(32, 32);
            btnBack.TabIndex = 8;
            btnBack.Text = "<";
            btnBack.TextAlign = ContentAlignment.TopLeft;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 561);
            Controls.Add(btnBack);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(label1);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private RichTextBox tbPassword;
        private RichTextBox tbEmail;
        private Label label2;
        private Label label3;
        private Button btnClose;
        private Button btnBack;
    }
}