namespace InventorySystem
{
    partial class AddNewPerfumePopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPerfumePopUp));
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            tbNewPerfumeName = new RichTextBox();
            label5 = new Label();
            numPerfumeQuantity = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            label3 = new Label();
            cbxNewPerfumeBranch = new ComboBox();
            cbxNewPerfumeType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cbxNewPerfumeNoteType = new ComboBox();
            label8 = new Label();
            cbxNewPerfumeGenderType = new ComboBox();
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
            label1.Size = new Size(294, 40);
            label1.TabIndex = 9;
            label1.Text = "Add New Perfume";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(28, 231);
            label4.Name = "label4";
            label4.Size = new Size(136, 22);
            label4.TabIndex = 13;
            label4.Text = "Perfume Name:";
            // 
            // tbNewPerfumeName
            // 
            tbNewPerfumeName.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNewPerfumeName.ForeColor = SystemColors.ControlText;
            tbNewPerfumeName.Location = new Point(170, 232);
            tbNewPerfumeName.MaxLength = 32;
            tbNewPerfumeName.Multiline = false;
            tbNewPerfumeName.Name = "tbNewPerfumeName";
            tbNewPerfumeName.Size = new Size(437, 24);
            tbNewPerfumeName.TabIndex = 14;
            tbNewPerfumeName.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(135, 135, 135);
            label5.Location = new Point(28, 362);
            label5.Name = "label5";
            label5.Size = new Size(82, 22);
            label5.TabIndex = 15;
            label5.Text = "Quantity:";
            // 
            // numPerfumeQuantity
            // 
            numPerfumeQuantity.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPerfumeQuantity.ForeColor = SystemColors.ControlText;
            numPerfumeQuantity.Location = new Point(122, 362);
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
            btnSave.Location = new Point(192, 418);
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
            btnCancel.Location = new Point(356, 418);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 31);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(28, 316);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 29;
            label3.Text = "Gender:";
            // 
            // cbxNewPerfumeBranch
            // 
            cbxNewPerfumeBranch.AutoCompleteCustomSource.AddRange(new string[] { "Branch 1", "Branch 2", "Branch 3" });
            cbxNewPerfumeBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNewPerfumeBranch.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNewPerfumeBranch.ForeColor = SystemColors.ControlText;
            cbxNewPerfumeBranch.FormattingEnabled = true;
            cbxNewPerfumeBranch.Location = new Point(421, 316);
            cbxNewPerfumeBranch.Name = "cbxNewPerfumeBranch";
            cbxNewPerfumeBranch.Size = new Size(186, 26);
            cbxNewPerfumeBranch.TabIndex = 28;
            // 
            // cbxNewPerfumeType
            // 
            cbxNewPerfumeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNewPerfumeType.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNewPerfumeType.ForeColor = SystemColors.ControlText;
            cbxNewPerfumeType.FormattingEnabled = true;
            cbxNewPerfumeType.Location = new Point(122, 273);
            cbxNewPerfumeType.Name = "cbxNewPerfumeType";
            cbxNewPerfumeType.Size = new Size(186, 26);
            cbxNewPerfumeType.TabIndex = 27;
            cbxNewPerfumeType.SelectedValueChanged += cbxNewPerfumeNoteType_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(135, 135, 135);
            label6.Location = new Point(28, 274);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 26;
            label6.Text = "Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(135, 135, 135);
            label7.Location = new Point(323, 274);
            label7.Name = "label7";
            label7.Size = new Size(52, 22);
            label7.TabIndex = 30;
            label7.Text = "Note:";
            // 
            // cbxNewPerfumeNoteType
            // 
            cbxNewPerfumeNoteType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNewPerfumeNoteType.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNewPerfumeNoteType.ForeColor = SystemColors.ControlText;
            cbxNewPerfumeNoteType.FormattingEnabled = true;
            cbxNewPerfumeNoteType.Location = new Point(421, 273);
            cbxNewPerfumeNoteType.Name = "cbxNewPerfumeNoteType";
            cbxNewPerfumeNoteType.Size = new Size(186, 26);
            cbxNewPerfumeNoteType.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(135, 135, 135);
            label8.Location = new Point(323, 316);
            label8.Name = "label8";
            label8.Size = new Size(70, 22);
            label8.TabIndex = 32;
            label8.Text = "Branch:";
            // 
            // cbxNewPerfumeGenderType
            // 
            cbxNewPerfumeGenderType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNewPerfumeGenderType.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNewPerfumeGenderType.ForeColor = SystemColors.ControlText;
            cbxNewPerfumeGenderType.FormattingEnabled = true;
            cbxNewPerfumeGenderType.Location = new Point(122, 312);
            cbxNewPerfumeGenderType.Name = "cbxNewPerfumeGenderType";
            cbxNewPerfumeGenderType.Size = new Size(186, 26);
            cbxNewPerfumeGenderType.TabIndex = 33;
            cbxNewPerfumeGenderType.SelectedValueChanged += cbxNewPerfumeGenderType_SelectedValueChanged;
            // 
            // AddNewPerfumePopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 471);
            Controls.Add(cbxNewPerfumeGenderType);
            Controls.Add(label8);
            Controls.Add(cbxNewPerfumeNoteType);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(cbxNewPerfumeBranch);
            Controls.Add(cbxNewPerfumeType);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numPerfumeQuantity);
            Controls.Add(label5);
            Controls.Add(tbNewPerfumeName);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AddNewPerfumePopUp";
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
        private Label label4;
        private RichTextBox tbNewPerfumeName;
        private Label label5;
        private NumericUpDown numPerfumeQuantity;
        private Button btnSave;
        private Button btnCancel;
        private Label label3;
        private ComboBox cbxNewPerfumeBranch;
        private ComboBox cbxNewPerfumeType;
        private Label label6;
        private Label label7;
        private ComboBox cbxNewPerfumeNoteType;
        private Label label8;
        private ComboBox cbxNewPerfumeGenderType;
    }
}