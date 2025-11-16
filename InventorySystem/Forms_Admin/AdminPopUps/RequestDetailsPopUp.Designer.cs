namespace InventorySystem
{
    partial class RequestDetailsPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestDetailsPopUp));
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnApproveRequest = new Button();
            btnRejectRequest = new Button();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblRequestID = new Label();
            lblPerfumeId = new Label();
            lblBranch = new Label();
            lblQuantity = new Label();
            lblRequestDate = new Label();
            lblStatus = new Label();
            label9 = new Label();
            lblPerfume = new Label();
            label10 = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(754, 12);
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
            label2.Size = new Size(103, 22);
            label2.TabIndex = 11;
            label2.Text = "Request ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(30, 135);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 13;
            label4.Text = "Product ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(428, 178);
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
            btnApproveRequest.ImageAlign = ContentAlignment.MiddleRight;
            btnApproveRequest.Location = new Point(162, 269);
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
            btnRejectRequest.ImageAlign = ContentAlignment.MiddleRight;
            btnRejectRequest.Location = new Point(417, 269);
            btnRejectRequest.Name = "btnRejectRequest";
            btnRejectRequest.Size = new Size(211, 31);
            btnRejectRequest.TabIndex = 18;
            btnRejectRequest.Text = "Reject Request";
            btnRejectRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRejectRequest.UseVisualStyleBackColor = true;
            btnRejectRequest.Click += btnRejectRequest_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(30, 178);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 20;
            label3.Text = "Branch:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(135, 135, 135);
            label6.Location = new Point(429, 94);
            label6.Name = "label6";
            label6.Size = new Size(123, 22);
            label6.TabIndex = 21;
            label6.Text = "Request Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(135, 135, 135);
            label7.Location = new Point(224, 94);
            label7.Name = "label7";
            label7.Size = new Size(63, 22);
            label7.TabIndex = 22;
            label7.Text = "Status:";
            // 
            // lblRequestID
            // 
            lblRequestID.AutoSize = true;
            lblRequestID.ForeColor = SystemColors.ActiveCaptionText;
            lblRequestID.Location = new Point(138, 94);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(65, 22);
            lblRequestID.TabIndex = 23;
            lblRequestID.Text = "#####";
            // 
            // lblPerfumeId
            // 
            lblPerfumeId.AutoSize = true;
            lblPerfumeId.ForeColor = SystemColors.ActiveCaptionText;
            lblPerfumeId.Location = new Point(138, 135);
            lblPerfumeId.Name = "lblPerfumeId";
            lblPerfumeId.Size = new Size(65, 22);
            lblPerfumeId.TabIndex = 24;
            lblPerfumeId.Text = "#####";
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.ForeColor = SystemColors.ActiveCaptionText;
            lblBranch.Location = new Point(106, 178);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(164, 22);
            lblBranch.TabIndex = 25;
            lblBranch.Text = "##############";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblQuantity.Location = new Point(516, 178);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(43, 22);
            lblQuantity.TabIndex = 26;
            lblQuantity.Text = "###";
            // 
            // lblRequestDate
            // 
            lblRequestDate.AutoSize = true;
            lblRequestDate.ForeColor = SystemColors.ActiveCaptionText;
            lblRequestDate.Location = new Point(558, 94);
            lblRequestDate.Name = "lblRequestDate";
            lblRequestDate.Size = new Size(110, 22);
            lblRequestDate.TabIndex = 27;
            lblRequestDate.Text = "##-##-####";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = SystemColors.ActiveCaptionText;
            lblStatus.Location = new Point(293, 94);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 22);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "PENDING";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(135, 135, 135);
            label9.Location = new Point(223, 135);
            label9.Name = "label9";
            label9.Size = new Size(136, 22);
            label9.TabIndex = 29;
            label9.Text = "Perfume Name:";
            // 
            // lblPerfume
            // 
            lblPerfume.AutoSize = true;
            lblPerfume.ForeColor = SystemColors.ActiveCaptionText;
            lblPerfume.Location = new Point(374, 135);
            lblPerfume.Name = "lblPerfume";
            lblPerfume.Size = new Size(252, 22);
            lblPerfume.TabIndex = 30;
            lblPerfume.Text = "######################";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(135, 135, 135);
            label10.Location = new Point(30, 221);
            label10.Name = "label10";
            label10.Size = new Size(84, 22);
            label10.TabIndex = 31;
            label10.Text = "Message:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = SystemColors.ActiveCaptionText;
            lblMessage.Location = new Point(120, 221);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(604, 22);
            lblMessage.TabIndex = 32;
            lblMessage.Text = "######################################################";
            // 
            // RequestDetailsPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 319);
            Controls.Add(lblMessage);
            Controls.Add(label10);
            Controls.Add(lblPerfume);
            Controls.Add(label9);
            Controls.Add(lblStatus);
            Controls.Add(lblRequestDate);
            Controls.Add(lblQuantity);
            Controls.Add(lblBranch);
            Controls.Add(lblPerfumeId);
            Controls.Add(lblRequestID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
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
            Name = "RequestDetailsPopUp";
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
        private Label label3;
        private Label label6;
        private Label label7;
        private Label lblRequestID;
        private Label lblPerfumeId;
        private Label lblBranch;
        private Label lblQuantity;
        private Label lblRequestDate;
        private Label lblStatus;
        private Label label9;
        private Label lblPerfume;
        private Label label10;
        private Label lblMessage;
    }
}