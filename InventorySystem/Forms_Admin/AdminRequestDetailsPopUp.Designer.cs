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
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblRequestID = new Label();
            lblPerfume = new Label();
            lblBranch = new Label();
            lblQuantity = new Label();
            lblDate = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(687, 12);
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
            label2.Location = new Point(29, 94);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 11;
            label2.Text = "REQ ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(29, 140);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 13;
            label4.Text = "Perfume:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(301, 140);
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
            btnApproveRequest.Location = new Point(17, 209);
            btnApproveRequest.Name = "btnApproveRequest";
            btnApproveRequest.Size = new Size(211, 31);
            btnApproveRequest.TabIndex = 17;
            btnApproveRequest.Text = "Approve Request";
            btnApproveRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApproveRequest.UseVisualStyleBackColor = true;
            btnApproveRequest.Click += btnApproveRequest_Click;
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
            btnRejectRequest.Location = new Point(255, 209);
            btnRejectRequest.Name = "btnRejectRequest";
            btnRejectRequest.Size = new Size(211, 31);
            btnRejectRequest.TabIndex = 18;
            btnRejectRequest.Text = "Reject Request";
            btnRejectRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRejectRequest.UseVisualStyleBackColor = true;
            btnRejectRequest.Click += btnRejectRequest_Click;
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
            btnArchiveRequest.Location = new Point(490, 209);
            btnArchiveRequest.Name = "btnArchiveRequest";
            btnArchiveRequest.Size = new Size(211, 31);
            btnArchiveRequest.TabIndex = 19;
            btnArchiveRequest.Text = "Archive Request";
            btnArchiveRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnArchiveRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchiveRequest.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(301, 94);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 20;
            label3.Text = "Branch:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(135, 135, 135);
            label6.Location = new Point(544, 94);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 21;
            label6.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(135, 135, 135);
            label7.Location = new Point(544, 140);
            label7.Name = "label7";
            label7.Size = new Size(63, 22);
            label7.TabIndex = 22;
            label7.Text = "Status:";
            // 
            // lblRequestID
            // 
            lblRequestID.AutoSize = true;
            lblRequestID.ForeColor = SystemColors.ActiveCaptionText;
            lblRequestID.Location = new Point(130, 94);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(43, 22);
            lblRequestID.TabIndex = 23;
            lblRequestID.Text = "###";
            // 
            // lblPerfume
            // 
            lblPerfume.AutoSize = true;
            lblPerfume.ForeColor = SystemColors.ActiveCaptionText;
            lblPerfume.Location = new Point(130, 140);
            lblPerfume.Name = "lblPerfume";
            lblPerfume.Size = new Size(131, 22);
            lblPerfume.TabIndex = 24;
            lblPerfume.Text = "###########";
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.ForeColor = SystemColors.ActiveCaptionText;
            lblBranch.Location = new Point(386, 94);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(131, 22);
            lblBranch.TabIndex = 25;
            lblBranch.Text = "###########";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblQuantity.Location = new Point(386, 140);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(43, 22);
            lblQuantity.TabIndex = 26;
            lblQuantity.Text = "###";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = SystemColors.ActiveCaptionText;
            lblDate.Location = new Point(605, 94);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(110, 22);
            lblDate.TabIndex = 27;
            lblDate.Text = "##-##-####";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(613, 140);
            label8.Name = "label8";
            label8.Size = new Size(88, 22);
            label8.TabIndex = 28;
            label8.Text = "PENDING";
            // 
            // AdminRequestDetailsPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 266);
            Controls.Add(label8);
            Controls.Add(lblDate);
            Controls.Add(lblQuantity);
            Controls.Add(lblBranch);
            Controls.Add(lblPerfume);
            Controls.Add(lblRequestID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
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
        private Label label3;
        private Label label6;
        private Label label7;
        private Label lblRequestID;
        private Label lblPerfume;
        private Label lblBranch;
        private Label lblQuantity;
        private Label lblDate;
        private Label label8;
    }
}