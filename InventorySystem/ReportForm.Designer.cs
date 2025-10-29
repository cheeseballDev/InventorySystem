namespace InventorySystem
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label6 = new Label();
            cbxCurrentBranch = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGenerate = new Button();
            label4 = new Label();
            dgReportResults = new DataGridView();
            PERFUME_ID = new DataGridViewTextBoxColumn();
            PERFUME_NAME = new DataGridViewTextBoxColumn();
            PERFUME_QTY = new DataGridViewTextBoxColumn();
            PERFUME_BRANCH = new DataGridViewTextBoxColumn();
            PERFUME_DATECREATED = new DataGridViewTextBoxColumn();
            PERFUME_STATUS = new DataGridViewTextBoxColumn();
            btnExportToExcel = new Button();
            btnExportToPDF = new Button();
            button1 = new Button();
            dtpDateTo = new DateTimePicker();
            dtpDateFrom = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgReportResults).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 47);
            label6.Name = "label6";
            label6.Size = new Size(228, 37);
            label6.TabIndex = 13;
            label6.Text = "Report Results";
            // 
            // cbxCurrentBranch
            // 
            cbxCurrentBranch.Font = new Font("Montserrat", 9F);
            cbxCurrentBranch.FormattingEnabled = true;
            cbxCurrentBranch.Location = new Point(135, 10);
            cbxCurrentBranch.Name = "cbxCurrentBranch";
            cbxCurrentBranch.Size = new Size(178, 24);
            cbxCurrentBranch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(135, 135, 135);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(117, 16);
            label1.TabIndex = 14;
            label1.Text = "Select report type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(319, 16);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 16;
            label2.Text = "Date from:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(135, 135, 135);
            label3.Location = new Point(531, 16);
            label3.Name = "label3";
            label3.Size = new Size(21, 16);
            label3.TabIndex = 18;
            label3.Text = "To";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(225, 212, 193);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Image = (Image)resources.GetObject("btnGenerate.Image");
            btnGenerate.Location = new Point(703, 8);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(105, 27);
            btnGenerate.TabIndex = 20;
            btnGenerate.Text = "Generate";
            btnGenerate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(135, 135, 135);
            label4.Location = new Point(35, 89);
            label4.Name = "label4";
            label4.Size = new Size(153, 16);
            label4.TabIndex = 21;
            label4.Text = "Generated report results";
            // 
            // dgReportResults
            // 
            dgReportResults.AllowUserToAddRows = false;
            dgReportResults.AllowUserToDeleteRows = false;
            dgReportResults.AllowUserToResizeColumns = false;
            dgReportResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dgReportResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgReportResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgReportResults.BackgroundColor = Color.White;
            dgReportResults.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgReportResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgReportResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReportResults.Columns.AddRange(new DataGridViewColumn[] { PERFUME_ID, PERFUME_NAME, PERFUME_QTY, PERFUME_BRANCH, PERFUME_DATECREATED, PERFUME_STATUS });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgReportResults.DefaultCellStyle = dataGridViewCellStyle6;
            dgReportResults.Location = new Point(22, 114);
            dgReportResults.Name = "dgReportResults";
            dgReportResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgReportResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReportResults.Size = new Size(786, 337);
            dgReportResults.TabIndex = 22;
            // 
            // PERFUME_ID
            // 
            PERFUME_ID.FillWeight = 60F;
            PERFUME_ID.HeaderText = "REQ ID";
            PERFUME_ID.MinimumWidth = 3;
            PERFUME_ID.Name = "PERFUME_ID";
            PERFUME_ID.ReadOnly = true;
            // 
            // PERFUME_NAME
            // 
            PERFUME_NAME.FillWeight = 110F;
            PERFUME_NAME.HeaderText = "Perfume";
            PERFUME_NAME.Name = "PERFUME_NAME";
            PERFUME_NAME.ReadOnly = true;
            // 
            // PERFUME_QTY
            // 
            PERFUME_QTY.HeaderText = "Qty";
            PERFUME_QTY.Name = "PERFUME_QTY";
            // 
            // PERFUME_BRANCH
            // 
            PERFUME_BRANCH.HeaderText = "Branch";
            PERFUME_BRANCH.Name = "PERFUME_BRANCH";
            // 
            // PERFUME_DATECREATED
            // 
            PERFUME_DATECREATED.FillWeight = 107.817261F;
            PERFUME_DATECREATED.HeaderText = "Date Created";
            PERFUME_DATECREATED.Name = "PERFUME_DATECREATED";
            // 
            // PERFUME_STATUS
            // 
            PERFUME_STATUS.HeaderText = "Status";
            PERFUME_STATUS.Name = "PERFUME_STATUS";
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.FromArgb(225, 212, 193);
            btnExportToExcel.Cursor = Cursors.Hand;
            btnExportToExcel.FlatAppearance.BorderSize = 0;
            btnExportToExcel.FlatStyle = FlatStyle.Flat;
            btnExportToExcel.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportToExcel.ForeColor = Color.Black;
            btnExportToExcel.Image = (Image)resources.GetObject("btnExportToExcel.Image");
            btnExportToExcel.Location = new Point(22, 467);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(141, 27);
            btnExportToExcel.TabIndex = 23;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportToExcel.UseVisualStyleBackColor = true;
            // 
            // btnExportToPDF
            // 
            btnExportToPDF.BackColor = Color.FromArgb(225, 212, 193);
            btnExportToPDF.Cursor = Cursors.Hand;
            btnExportToPDF.FlatAppearance.BorderSize = 0;
            btnExportToPDF.FlatStyle = FlatStyle.Flat;
            btnExportToPDF.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportToPDF.ForeColor = Color.Black;
            btnExportToPDF.Image = (Image)resources.GetObject("btnExportToPDF.Image");
            btnExportToPDF.Location = new Point(177, 467);
            btnExportToPDF.Name = "btnExportToPDF";
            btnExportToPDF.Size = new Size(136, 27);
            btnExportToPDF.TabIndex = 24;
            btnExportToPDF.Text = "Export to PDF";
            btnExportToPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportToPDF.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(225, 212, 193);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(328, 467);
            button1.Name = "button1";
            button1.Size = new Size(85, 27);
            button1.TabIndex = 25;
            button1.Text = "Print";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // dtpDateTo
            // 
            dtpDateTo.CalendarFont = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateTo.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(570, 11);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(118, 23);
            dtpDateTo.TabIndex = 31;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.CalendarFont = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateFrom.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(401, 11);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(118, 23);
            dtpDateFrom.TabIndex = 30;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 512);
            Controls.Add(dtpDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(button1);
            Controls.Add(btnExportToPDF);
            Controls.Add(btnExportToExcel);
            Controls.Add(dgReportResults);
            Controls.Add(label4);
            Controls.Add(btnGenerate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxCurrentBranch);
            Controls.Add(label1);
            Controls.Add(label6);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ReportForm";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)dgReportResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cbxCurrentBranch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGenerate;
        private Label label4;
        private DataGridView dgReportResults;
        private DataGridViewTextBoxColumn PERFUME_ID;
        private DataGridViewTextBoxColumn PERFUME_NAME;
        private DataGridViewTextBoxColumn PERFUME_QTY;
        private DataGridViewTextBoxColumn PERFUME_BRANCH;
        private DataGridViewTextBoxColumn PERFUME_DATECREATED;
        private DataGridViewTextBoxColumn PERFUME_STATUS;
        private Button btnExportToExcel;
        private Button btnExportToPDF;
        private Button button1;
        private DateTimePicker dtpDateTo;
        private DateTimePicker dtpDateFrom;
    }
}