namespace InventorySystem
{
    partial class AdminRequestDetailsPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRequestDetailsPopUp));
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnApproveRequest = new Button();
            btnRejectRequest = new Button();
            btnArchiveRequest = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(683, 12);
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
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(403, 40);
            label1.TabIndex = 9;
            label1.Text = "Selected Request Details:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(27, 93);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 11;
            label2.Text = "REQ ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(27, 139);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 13;
            label4.Text = "Perfume:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(27, 189);
            label5.Name = "label5";
            label5.Size = new Size(82, 22);
            label5.TabIndex = 15;
            label5.Text = "Quantity:";
            // 
            // btnApproveRequest
            // 
            btnApproveRequest.BackColor = Color.FromArgb(225, 212, 193);
            btnApproveRequest.Cursor = Cursors.Hand;
            btnApproveRequest.FlatAppearance.BorderSize = 0;
            btnApproveRequest.FlatStyle = FlatStyle.Flat;
            btnApproveRequest.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApproveRequest.ForeColor = Color.Black;
            btnApproveRequest.Image = (Image)resources.GetObject("btnApproveRequest.Image");
            btnApproveRequest.Location = new Point(27, 251);
            btnApproveRequest.Name = "btnApproveRequest";
            btnApproveRequest.Size = new Size(172, 31);
            btnApproveRequest.TabIndex = 17;
            btnApproveRequest.Text = "Approve Request";
            btnApproveRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApproveRequest.UseVisualStyleBackColor = true;
            // 
            // btnRejectRequest
            // 
            btnRejectRequest.BackColor = Color.FromArgb(225, 212, 193);
            btnRejectRequest.Cursor = Cursors.Hand;
            btnRejectRequest.FlatAppearance.BorderSize = 0;
            btnRejectRequest.FlatStyle = FlatStyle.Flat;
            btnRejectRequest.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRejectRequest.ForeColor = Color.Black;
            btnRejectRequest.Image = (Image)resources.GetObject("btnRejectRequest.Image");
            btnRejectRequest.Location = new Point(233, 251);
            btnRejectRequest.Name = "btnRejectRequest";
            btnRejectRequest.Size = new Size(153, 31);
            btnRejectRequest.TabIndex = 18;
            btnRejectRequest.Text = "Reject Request";
            btnRejectRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRejectRequest.UseVisualStyleBackColor = true;
            btnRejectRequest.Click += btnCancel_Click;
            // 
            // btnArchiveRequest
            // 
            btnArchiveRequest.BackColor = Color.FromArgb(126, 16, 44);
            btnArchiveRequest.BackgroundImageLayout = ImageLayout.Center;
            btnArchiveRequest.Cursor = Cursors.Hand;
            btnArchiveRequest.FlatAppearance.BorderSize = 0;
            btnArchiveRequest.FlatStyle = FlatStyle.Flat;
            btnArchiveRequest.Font = new Font("Montserrat", 9.749999F);
            btnArchiveRequest.ForeColor = SystemColors.Control;
            btnArchiveRequest.Image = (Image)resources.GetObject("btnArchiveRequest.Image");
            btnArchiveRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchiveRequest.Location = new Point(418, 254);
            btnArchiveRequest.Name = "btnArchiveRequest";
            btnArchiveRequest.Size = new Size(210, 28);
            btnArchiveRequest.TabIndex = 19;
            btnArchiveRequest.Text = "Archive Request";
            btnArchiveRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnArchiveRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchiveRequest.UseVisualStyleBackColor = false;
            // 
            // AdminRequestDetailsPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 323);
            Controls.Add(btnArchiveRequest);
            Controls.Add(btnRejectRequest);
            Controls.Add(btnApproveRequest);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminRequestDetailsPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminRequestDetailsPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btnApproveRequest;
        private Button btnRejectRequest;
        private Button btnArchiveRequest;
    }
}