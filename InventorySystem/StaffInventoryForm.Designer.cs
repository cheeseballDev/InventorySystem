namespace InventorySystem
{
    partial class StaffInventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tbSearchProduct = new RichTextBox();
            cbxNote = new ComboBox();
            cbxBranch = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dgPerfume = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            PERFUME_ID = new DataGridViewTextBoxColumn();
            PERFUME_NAME = new DataGridViewTextBoxColumn();
            PERFUME_NOTE = new DataGridViewTextBoxColumn();
            PERFUME_BRANCH = new DataGridViewTextBoxColumn();
            PERFUME_DATECREATED = new DataGridViewTextBoxColumn();
            PERFUME_QTY = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgPerfume).BeginInit();
            SuspendLayout();
            // 
            // tbSearchProduct
            // 
            tbSearchProduct.Location = new Point(12, 12);
            tbSearchProduct.MaxLength = 20;
            tbSearchProduct.Multiline = false;
            tbSearchProduct.Name = "tbSearchProduct";
            tbSearchProduct.Size = new Size(240, 31);
            tbSearchProduct.TabIndex = 0;
            tbSearchProduct.Text = "";
            tbSearchProduct.TextChanged += tbSearchProduct_TextChanged;
            // 
            // cbxNote
            // 
            cbxNote.FormattingEnabled = true;
            cbxNote.Location = new Point(265, 14);
            cbxNote.Name = "cbxNote";
            cbxNote.Size = new Size(148, 30);
            cbxNote.TabIndex = 1;
            // 
            // cbxBranch
            // 
            cbxBranch.FormattingEnabled = true;
            cbxBranch.Location = new Point(419, 14);
            cbxBranch.Name = "cbxBranch";
            cbxBranch.Size = new Size(148, 30);
            cbxBranch.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(584, 13);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(689, 13);
            button2.Name = "button2";
            button2.Size = new Size(99, 31);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgPerfume
            // 
            dgPerfume.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPerfume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPerfume.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPerfume.Columns.AddRange(new DataGridViewColumn[] { PERFUME_ID, PERFUME_NAME, PERFUME_NOTE, PERFUME_BRANCH, PERFUME_DATECREATED, PERFUME_QTY });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgPerfume.DefaultCellStyle = dataGridViewCellStyle2;
            dgPerfume.Location = new Point(12, 61);
            dgPerfume.Name = "dgPerfume";
            dgPerfume.Size = new Size(776, 392);
            dgPerfume.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(100, 459);
            button3.Name = "button3";
            button3.Size = new Size(191, 29);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(297, 459);
            button4.Name = "button4";
            button4.Size = new Size(191, 29);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(494, 459);
            button5.Name = "button5";
            button5.Size = new Size(191, 29);
            button5.TabIndex = 8;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // PERFUME_ID
            // 
            PERFUME_ID.HeaderText = "ID";
            PERFUME_ID.MinimumWidth = 3;
            PERFUME_ID.Name = "PERFUME_ID";
            PERFUME_ID.ReadOnly = true;
            // 
            // PERFUME_NAME
            // 
            PERFUME_NAME.HeaderText = "Perfume";
            PERFUME_NAME.Name = "PERFUME_NAME";
            PERFUME_NAME.ReadOnly = true;
            PERFUME_NAME.Width = 180;
            // 
            // PERFUME_NOTE
            // 
            PERFUME_NOTE.HeaderText = "Note";
            PERFUME_NOTE.Name = "PERFUME_NOTE";
            PERFUME_NOTE.ReadOnly = true;
            PERFUME_NOTE.Width = 150;
            // 
            // PERFUME_BRANCH
            // 
            PERFUME_BRANCH.HeaderText = "Branch";
            PERFUME_BRANCH.Name = "PERFUME_BRANCH";
            PERFUME_BRANCH.Width = 120;
            // 
            // PERFUME_DATECREATED
            // 
            PERFUME_DATECREATED.HeaderText = "Date Created";
            PERFUME_DATECREATED.Name = "PERFUME_DATECREATED";
            PERFUME_DATECREATED.Width = 120;
            // 
            // PERFUME_QTY
            // 
            PERFUME_QTY.HeaderText = "Qty";
            PERFUME_QTY.Name = "PERFUME_QTY";
            PERFUME_QTY.Width = 60;
            // 
            // StaffInventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dgPerfume);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbxBranch);
            Controls.Add(cbxNote);
            Controls.Add(tbSearchProduct);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StaffInventoryForm";
            Text = "StaffInventoryForm";
            ((System.ComponentModel.ISupportInitialize)dgPerfume).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox tbSearchProduct;
        private ComboBox cbxNote;
        private ComboBox cbxBranch;
        private Button button1;
        private Button button2;
        private DataGridView dgPerfume;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn PERFUME_ID;
        private DataGridViewTextBoxColumn PERFUME_NAME;
        private DataGridViewTextBoxColumn PERFUME_NOTE;
        private DataGridViewTextBoxColumn PERFUME_BRANCH;
        private DataGridViewTextBoxColumn PERFUME_DATECREATED;
        private DataGridViewTextBoxColumn PERFUME_QTY;
    }
}