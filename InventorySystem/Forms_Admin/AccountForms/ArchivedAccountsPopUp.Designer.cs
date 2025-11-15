namespace InventorySystem
{
    partial class ArchivedAccountsPopUp
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgArchivedAccounts = new DataGridView();
            tbSearchProduct = new RichTextBox();
            lblTitle = new Label();
            tbSearchUserFilter = new RichTextBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgArchivedAccounts).BeginInit();
            SuspendLayout();
            // 
            // dgArchivedAccounts
            // 
            dgArchivedAccounts.AllowUserToAddRows = false;
            dgArchivedAccounts.AllowUserToDeleteRows = false;
            dgArchivedAccounts.AllowUserToResizeColumns = false;
            dgArchivedAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dgArchivedAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgArchivedAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgArchivedAccounts.BackgroundColor = SystemColors.Control;
            dgArchivedAccounts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgArchivedAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgArchivedAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle6.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgArchivedAccounts.DefaultCellStyle = dataGridViewCellStyle6;
            dgArchivedAccounts.Location = new Point(12, 66);
            dgArchivedAccounts.Name = "dgArchivedAccounts";
            dgArchivedAccounts.ReadOnly = true;
            dgArchivedAccounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgArchivedAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgArchivedAccounts.Size = new Size(793, 325);
            dgArchivedAccounts.TabIndex = 5;
            // 
            // tbSearchProduct
            // 
            tbSearchProduct.BackColor = SystemColors.Control;
            tbSearchProduct.BorderStyle = BorderStyle.None;
            tbSearchProduct.DetectUrls = false;
            tbSearchProduct.Font = new Font("Montserrat", 8.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchProduct.ForeColor = Color.FromArgb(135, 135, 135);
            tbSearchProduct.Location = new Point(366, 36);
            tbSearchProduct.MaxLength = 20;
            tbSearchProduct.Multiline = false;
            tbSearchProduct.Name = "tbSearchProduct";
            tbSearchProduct.Size = new Size(74, 15);
            tbSearchProduct.TabIndex = 10;
            tbSearchProduct.Text = "Filter: User:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(346, 37);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Archived Accounts List";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbSearchUserFilter
            // 
            tbSearchUserFilter.BorderStyle = BorderStyle.FixedSingle;
            tbSearchUserFilter.DetectUrls = false;
            tbSearchUserFilter.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchUserFilter.Location = new Point(446, 29);
            tbSearchUserFilter.MaxLength = 20;
            tbSearchUserFilter.Multiline = false;
            tbSearchUserFilter.Name = "tbSearchUserFilter";
            tbSearchUserFilter.Size = new Size(263, 27);
            tbSearchUserFilter.TabIndex = 11;
            tbSearchUserFilter.Text = "Search user...";
            tbSearchUserFilter.TextChanged += tbSearchUserFilter_TextChanged;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(777, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 32);
            btnClose.TabIndex = 14;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.TopLeft;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ArchivedAccounts
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 403);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(tbSearchProduct);
            Controls.Add(dgArchivedAccounts);
            Controls.Add(tbSearchUserFilter);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ArchivedAccounts";
            Text = "InventoryForm1";
            ((System.ComponentModel.ISupportInitialize)dgArchivedAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgArchivedAccounts;
        private RichTextBox tbSearchProduct;
        private Label lblTitle;
        private RichTextBox tbSearchUserFilter;
        private Button btnClose;
    }
}