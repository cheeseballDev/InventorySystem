namespace InventorySystem
{
    partial class AuditDetailsPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditDetailsPopUp));
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            lblAuditLogId = new Label();
            lblAuditUserId = new Label();
            lblAuditAction = new Label();
            lblAuditModule = new Label();
            lblAuditTimestamp = new Label();
            btnDeleteLog = new Button();
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
            label1.Size = new Size(362, 40);
            label1.TabIndex = 9;
            label1.Text = "Selected Audit Details:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(29, 94);
            label2.Name = "label2";
            label2.Size = new Size(65, 22);
            label2.TabIndex = 11;
            label2.Text = "Log ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(216, 94);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 13;
            label4.Text = "User ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(30, 184);
            label5.Name = "label5";
            label5.Size = new Size(74, 22);
            label5.TabIndex = 15;
            label5.Text = "Module:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(30, 140);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 20;
            label3.Text = "Action:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(135, 135, 135);
            label6.Location = new Point(418, 94);
            label6.Name = "label6";
            label6.Size = new Size(104, 22);
            label6.TabIndex = 21;
            label6.Text = "Timestamp:";
            // 
            // lblAuditLogId
            // 
            lblAuditLogId.AutoSize = true;
            lblAuditLogId.ForeColor = SystemColors.ActiveCaptionText;
            lblAuditLogId.Location = new Point(130, 94);
            lblAuditLogId.Name = "lblAuditLogId";
            lblAuditLogId.Size = new Size(65, 22);
            lblAuditLogId.TabIndex = 23;
            lblAuditLogId.Text = "#####";
            // 
            // lblAuditUserId
            // 
            lblAuditUserId.AutoSize = true;
            lblAuditUserId.ForeColor = SystemColors.ActiveCaptionText;
            lblAuditUserId.Location = new Point(317, 94);
            lblAuditUserId.Name = "lblAuditUserId";
            lblAuditUserId.Size = new Size(65, 22);
            lblAuditUserId.TabIndex = 24;
            lblAuditUserId.Text = "#####";
            // 
            // lblAuditAction
            // 
            lblAuditAction.AutoSize = true;
            lblAuditAction.ForeColor = SystemColors.ActiveCaptionText;
            lblAuditAction.Location = new Point(130, 140);
            lblAuditAction.Name = "lblAuditAction";
            lblAuditAction.Size = new Size(494, 22);
            lblAuditAction.TabIndex = 25;
            lblAuditAction.Text = "############################################";
            // 
            // lblAuditModule
            // 
            lblAuditModule.AutoSize = true;
            lblAuditModule.ForeColor = SystemColors.ActiveCaptionText;
            lblAuditModule.Location = new Point(130, 184);
            lblAuditModule.Name = "lblAuditModule";
            lblAuditModule.Size = new Size(494, 22);
            lblAuditModule.TabIndex = 26;
            lblAuditModule.Text = "############################################";
            // 
            // lblAuditTimestamp
            // 
            lblAuditTimestamp.AutoSize = true;
            lblAuditTimestamp.ForeColor = SystemColors.ActiveCaptionText;
            lblAuditTimestamp.Location = new Point(528, 94);
            lblAuditTimestamp.Name = "lblAuditTimestamp";
            lblAuditTimestamp.Size = new Size(171, 22);
            lblAuditTimestamp.TabIndex = 27;
            lblAuditTimestamp.Text = "##-##-####-#####";
            // 
            // btnDeleteLog
            // 
            btnDeleteLog.BackColor = Color.FromArgb(126, 16, 44);
            btnDeleteLog.BackgroundImageLayout = ImageLayout.Center;
            btnDeleteLog.Cursor = Cursors.Hand;
            btnDeleteLog.FlatAppearance.BorderSize = 0;
            btnDeleteLog.FlatStyle = FlatStyle.Flat;
            btnDeleteLog.Font = new Font("Montserrat", 9.749999F);
            btnDeleteLog.ForeColor = SystemColors.Control;
            btnDeleteLog.Image = (Image)resources.GetObject("btnDeleteLog.Image");
            btnDeleteLog.Location = new Point(29, 227);
            btnDeleteLog.Name = "btnDeleteLog";
            btnDeleteLog.Size = new Size(152, 31);
            btnDeleteLog.TabIndex = 19;
            btnDeleteLog.Text = "Delete Log";
            btnDeleteLog.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteLog.UseVisualStyleBackColor = false;
            // 
            // AuditDetailsPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 275);
            Controls.Add(lblAuditTimestamp);
            Controls.Add(lblAuditModule);
            Controls.Add(lblAuditAction);
            Controls.Add(lblAuditUserId);
            Controls.Add(lblAuditLogId);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(btnDeleteLog);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AuditDetailsPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuditDetailsPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label lblAuditLogId;
        private Label lblAuditUserId;
        private Label lblAuditAction;
        private Label lblAuditModule;
        private Label lblAuditTimestamp;
        private Button btnDeleteLog;
        private Label label8;
    }
}