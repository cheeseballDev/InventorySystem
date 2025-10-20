namespace InventorySystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStaff = new Button();
            btnAdmin = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.FromArgb(225, 212, 193);
            btnStaff.Cursor = Cursors.Hand;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Location = new Point(411, 200);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(168, 34);
            btnStaff.TabIndex = 0;
            btnStaff.Text = "Login as Staff";
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(225, 212, 193);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Location = new Point(411, 262);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(168, 34);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Login as Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1008, 561);
            Controls.Add(btnClose);
            Controls.Add(btnAdmin);
            Controls.Add(btnStaff);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStaff;
        private Button btnAdmin;
        private Button btnClose;
    }
}
