namespace InventorySystem
{
    partial class AdminEditPerfumePopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEditPerfumePopUp));
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblPerfumeID = new Label();
            label4 = new Label();
            tbPerfumeName = new RichTextBox();
            label5 = new Label();
            numPerfumeQuantity = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            btnArchivePerfume = new Button();
            label3 = new Label();
            cbxAddNewPerfumeBranch = new ComboBox();
            cbxAddNewPerfumeNoteType = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPerfumeQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(340, 12);
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
            label1.Size = new Size(220, 45);
            label1.TabIndex = 9;
            label1.Text = "Edit Perfume";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(28, 229);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 11;
            label2.Text = "PERFUME ID:";
            // 
            // lblPerfumeID
            // 
            lblPerfumeID.AutoSize = true;
            lblPerfumeID.ForeColor = Color.FromArgb(135, 135, 135);
            lblPerfumeID.Location = new Point(154, 229);
            lblPerfumeID.Name = "lblPerfumeID";
            lblPerfumeID.Size = new Size(45, 25);
            lblPerfumeID.TabIndex = 12;
            lblPerfumeID.Text = "###";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(28, 275);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 13;
            label4.Text = "Perfume:";
            // 
            // tbPerfumeName
            // 
            tbPerfumeName.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPerfumeName.ForeColor = Color.FromArgb(135, 135, 135);
            tbPerfumeName.Location = new Point(122, 275);
            tbPerfumeName.MaxLength = 32;
            tbPerfumeName.Multiline = false;
            tbPerfumeName.Name = "tbPerfumeName";
            tbPerfumeName.Size = new Size(234, 24);
            tbPerfumeName.TabIndex = 14;
            tbPerfumeName.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(29, 404);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 15;
            label5.Text = "Quantity:";
            // 
            // numPerfumeQuantity
            // 
            numPerfumeQuantity.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPerfumeQuantity.ForeColor = Color.FromArgb(135, 135, 135);
            numPerfumeQuantity.Location = new Point(123, 404);
            numPerfumeQuantity.Name = "numPerfumeQuantity";
            numPerfumeQuantity.Size = new Size(128, 23);
            numPerfumeQuantity.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(225, 212, 193);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(28, 452);
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
            btnCancel.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(247, 452);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 31);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnArchivePerfume
            // 
            btnArchivePerfume.BackColor = Color.FromArgb(126, 16, 44);
            btnArchivePerfume.Cursor = Cursors.Hand;
            btnArchivePerfume.FlatAppearance.BorderSize = 0;
            btnArchivePerfume.FlatStyle = FlatStyle.Flat;
            btnArchivePerfume.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchivePerfume.ForeColor = SystemColors.Control;
            btnArchivePerfume.Image = (Image)resources.GetObject("btnArchivePerfume.Image");
            btnArchivePerfume.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchivePerfume.Location = new Point(28, 498);
            btnArchivePerfume.Name = "btnArchivePerfume";
            btnArchivePerfume.Size = new Size(328, 31);
            btnArchivePerfume.TabIndex = 19;
            btnArchivePerfume.Text = "Archive Perfume";
            btnArchivePerfume.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchivePerfume.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(28, 360);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 29;
            label3.Text = "Branch:";
            // 
            // cbxAddNewPerfumeBranch
            // 
            cbxAddNewPerfumeBranch.AutoCompleteCustomSource.AddRange(new string[] { "Branch 1", "Branch 2", "Branch 3" });
            cbxAddNewPerfumeBranch.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAddNewPerfumeBranch.FormattingEnabled = true;
            cbxAddNewPerfumeBranch.Items.AddRange(new object[] { "Branch 1", "Branch 2", "Branch 3" });
            cbxAddNewPerfumeBranch.Location = new Point(122, 360);
            cbxAddNewPerfumeBranch.Name = "cbxAddNewPerfumeBranch";
            cbxAddNewPerfumeBranch.Size = new Size(221, 28);
            cbxAddNewPerfumeBranch.TabIndex = 28;
            cbxAddNewPerfumeBranch.Text = "Select note type...";
            // 
            // cbxAddNewPerfumeNoteType
            // 
            cbxAddNewPerfumeNoteType.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAddNewPerfumeNoteType.FormattingEnabled = true;
            cbxAddNewPerfumeNoteType.Items.AddRange(new object[] { "Note 1", "Note 2", "Note 3" });
            cbxAddNewPerfumeNoteType.Location = new Point(122, 313);
            cbxAddNewPerfumeNoteType.Name = "cbxAddNewPerfumeNoteType";
            cbxAddNewPerfumeNoteType.Size = new Size(221, 28);
            cbxAddNewPerfumeNoteType.TabIndex = 27;
            cbxAddNewPerfumeNoteType.Text = "Select note type...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(135, 135, 135);
            label6.Location = new Point(28, 316);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 26;
            label6.Text = "Note:";
            // 
            // AdminEditPerfumePopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 550);
            Controls.Add(label3);
            Controls.Add(cbxAddNewPerfumeBranch);
            Controls.Add(cbxAddNewPerfumeNoteType);
            Controls.Add(label6);
            Controls.Add(btnArchivePerfume);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numPerfumeQuantity);
            Controls.Add(label5);
            Controls.Add(tbPerfumeName);
            Controls.Add(label4);
            Controls.Add(lblPerfumeID);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminEditPerfumePopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminEditProductPopUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPerfumeQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblPerfumeID;
        private Label label4;
        private RichTextBox tbPerfumeName;
        private Label label5;
        private NumericUpDown numPerfumeQuantity;
        private Button btnSave;
        private Button btnCancel;
        private Button btnArchivePerfume;
        private Label label3;
        private ComboBox cbxAddNewPerfumeBranch;
        private ComboBox cbxAddNewPerfumeNoteType;
        private Label label6;
    }
}