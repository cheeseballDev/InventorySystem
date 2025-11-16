namespace InventorySystem
{
    partial class EditPerfumePopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPerfumePopUp));
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblEditPerfumeID = new Label();
            label4 = new Label();
            tbEditPerfumeName = new RichTextBox();
            label5 = new Label();
            numPerfumeQuantity = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            btnArchivePerfume = new Button();
            label3 = new Label();
            cbxEditPerfumeBranch = new ComboBox();
            cbxEditPerfumeNoteType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cbxEditPerfumeFragranceType = new ComboBox();
            label8 = new Label();
            cbxEditPerfumeGenderType = new ComboBox();
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
            btnClose.Location = new Point(610, 12);
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
            label1.Size = new Size(356, 40);
            label1.TabIndex = 9;
            label1.Text = "Edit Selected Perfume";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 79);
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
            label2.Size = new Size(67, 22);
            label2.TabIndex = 11;
            label2.Text = "Perf ID:";
            // 
            // lblEditPerfumeID
            // 
            lblEditPerfumeID.AutoSize = true;
            lblEditPerfumeID.ForeColor = SystemColors.ControlText;
            lblEditPerfumeID.Location = new Point(122, 229);
            lblEditPerfumeID.Name = "lblEditPerfumeID";
            lblEditPerfumeID.Size = new Size(43, 22);
            lblEditPerfumeID.TabIndex = 12;
            lblEditPerfumeID.Text = "###";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(28, 275);
            label4.Name = "label4";
            label4.Size = new Size(136, 22);
            label4.TabIndex = 13;
            label4.Text = "Perfume Name:";
            // 
            // tbEditPerfumeName
            // 
            tbEditPerfumeName.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEditPerfumeName.ForeColor = SystemColors.ControlText;
            tbEditPerfumeName.Location = new Point(170, 276);
            tbEditPerfumeName.MaxLength = 32;
            tbEditPerfumeName.Multiline = false;
            tbEditPerfumeName.Name = "tbEditPerfumeName";
            tbEditPerfumeName.Size = new Size(437, 24);
            tbEditPerfumeName.TabIndex = 14;
            tbEditPerfumeName.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(28, 407);
            label5.Name = "label5";
            label5.Size = new Size(82, 22);
            label5.TabIndex = 15;
            label5.Text = "Quantity:";
            // 
            // numPerfumeQuantity
            // 
            numPerfumeQuantity.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPerfumeQuantity.ForeColor = SystemColors.ControlText;
            numPerfumeQuantity.Location = new Point(122, 407);
            numPerfumeQuantity.Name = "numPerfumeQuantity";
            numPerfumeQuantity.Size = new Size(128, 26);
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
            btnSave.Location = new Point(28, 452);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 31);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save Changes";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
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
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(203, 452);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 31);
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
            btnArchivePerfume.ImageAlign = ContentAlignment.MiddleRight;
            btnArchivePerfume.Location = new Point(421, 452);
            btnArchivePerfume.Name = "btnArchivePerfume";
            btnArchivePerfume.Size = new Size(186, 31);
            btnArchivePerfume.TabIndex = 19;
            btnArchivePerfume.Text = "Archive Perfume";
            btnArchivePerfume.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchivePerfume.UseVisualStyleBackColor = false;
            btnArchivePerfume.Click += btnArchivePerfume_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(28, 360);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 29;
            label3.Text = "Gender:";
            // 
            // cbxEditPerfumeBranch
            // 
            cbxEditPerfumeBranch.AutoCompleteCustomSource.AddRange(new string[] { "Branch 1", "Branch 2", "Branch 3" });
            cbxEditPerfumeBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEditPerfumeBranch.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxEditPerfumeBranch.ForeColor = SystemColors.ControlText;
            cbxEditPerfumeBranch.FormattingEnabled = true;
            cbxEditPerfumeBranch.Location = new Point(421, 360);
            cbxEditPerfumeBranch.Name = "cbxEditPerfumeBranch";
            cbxEditPerfumeBranch.Size = new Size(186, 26);
            cbxEditPerfumeBranch.TabIndex = 28;
            // 
            // cbxEditPerfumeNoteType
            // 
            cbxEditPerfumeNoteType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEditPerfumeNoteType.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxEditPerfumeNoteType.ForeColor = SystemColors.ControlText;
            cbxEditPerfumeNoteType.FormattingEnabled = true;
            cbxEditPerfumeNoteType.Location = new Point(122, 317);
            cbxEditPerfumeNoteType.Name = "cbxEditPerfumeNoteType";
            cbxEditPerfumeNoteType.Size = new Size(186, 26);
            cbxEditPerfumeNoteType.TabIndex = 27;
            cbxEditPerfumeNoteType.SelectedValueChanged += cbxEditPerfumeNoteType_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(135, 135, 135);
            label6.Location = new Point(28, 318);
            label6.Name = "label6";
            label6.Size = new Size(52, 22);
            label6.TabIndex = 26;
            label6.Text = "Note:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(135, 135, 135);
            label7.Location = new Point(323, 318);
            label7.Name = "label7";
            label7.Size = new Size(92, 22);
            label7.TabIndex = 30;
            label7.Text = "Fragrance:";
            // 
            // cbxEditPerfumeFragranceType
            // 
            cbxEditPerfumeFragranceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEditPerfumeFragranceType.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxEditPerfumeFragranceType.ForeColor = SystemColors.ControlText;
            cbxEditPerfumeFragranceType.FormattingEnabled = true;
            cbxEditPerfumeFragranceType.Location = new Point(421, 317);
            cbxEditPerfumeFragranceType.Name = "cbxEditPerfumeFragranceType";
            cbxEditPerfumeFragranceType.Size = new Size(186, 26);
            cbxEditPerfumeFragranceType.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(135, 135, 135);
            label8.Location = new Point(323, 360);
            label8.Name = "label8";
            label8.Size = new Size(70, 22);
            label8.TabIndex = 32;
            label8.Text = "Branch:";
            // 
            // cbxEditPerfumeGenderType
            // 
            cbxEditPerfumeGenderType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEditPerfumeGenderType.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxEditPerfumeGenderType.ForeColor = SystemColors.ControlText;
            cbxEditPerfumeGenderType.FormattingEnabled = true;
            cbxEditPerfumeGenderType.Location = new Point(122, 356);
            cbxEditPerfumeGenderType.Name = "cbxEditPerfumeGenderType";
            cbxEditPerfumeGenderType.Size = new Size(186, 26);
            cbxEditPerfumeGenderType.TabIndex = 33;
            cbxEditPerfumeGenderType.SelectedValueChanged += cbxEditPerfumeGenderType_SelectedValueChanged;
            // 
            // EditPerfumePopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 503);
            Controls.Add(cbxEditPerfumeGenderType);
            Controls.Add(label8);
            Controls.Add(cbxEditPerfumeFragranceType);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(cbxEditPerfumeBranch);
            Controls.Add(cbxEditPerfumeNoteType);
            Controls.Add(label6);
            Controls.Add(btnArchivePerfume);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numPerfumeQuantity);
            Controls.Add(label5);
            Controls.Add(tbEditPerfumeName);
            Controls.Add(label4);
            Controls.Add(lblEditPerfumeID);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EditPerfumePopUp";
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
        private Label lblEditPerfumeID;
        private Label label4;
        private RichTextBox tbEditPerfumeName;
        private Label label5;
        private NumericUpDown numPerfumeQuantity;
        private Button btnSave;
        private Button btnCancel;
        private Button btnArchivePerfume;
        private Label label3;
        private ComboBox cbxEditPerfumeBranch;
        private ComboBox cbxEditPerfumeNoteType;
        private Label label6;
        private Label label7;
        private ComboBox cbxEditPerfumeFragranceType;
        private Label label8;
        private ComboBox cbxEditPerfumeGenderType;
    }
}