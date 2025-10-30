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
            cbxReportTypeFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGenerateReport = new Button();
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
            btnPrint = new Button();
            dtpReportDateTo = new DateTimePicker();
            dtpReportDateFrom = new DateTimePicker();
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
            // cbxReportTypeFilter
            // 
            cbxReportTypeFilter.Font = new Font("Montserrat", 9F);
            cbxReportTypeFilter.FormattingEnabled = true;
            cbxReportTypeFilter.Location = new Point(135, 10);
            cbxReportTypeFilter.Name = "cbxReportTypeFilter";
            cbxReportTypeFilter.Size = new Size(178, 24);
            cbxReportTypeFilter.TabIndex = 15;
            cbxReportTypeFilter.Text = "Select report...";
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
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(225, 212, 193);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.Black;
            btnGenerateReport.Image = (Image)resources.GetObject("btnGenerateReport.Image");
            btnGenerateReport.Location = new Point(703, 8);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(105, 27);
            btnGenerateReport.TabIndex = 20;
            btnGenerateReport.Text = "Generate";
            btnGenerateReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerateReport.UseVisualStyleBackColor = true;
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
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(225, 212, 193);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Black;
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.Location = new Point(328, 467);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(85, 27);
            btnPrint.TabIndex = 25;
            btnPrint.Text = "Print";
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // dtpReportDateTo
            // 
            dtpReportDateTo.CalendarFont = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReportDateTo.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReportDateTo.Format = DateTimePickerFormat.Short;
            dtpReportDateTo.Location = new Point(570, 11);
            dtpReportDateTo.Name = "dtpReportDateTo";
            dtpReportDateTo.Size = new Size(118, 23);
            dtpReportDateTo.TabIndex = 31;
            // 
            // dtpReportDateFrom
            // 
            dtpReportDateFrom.CalendarFont = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReportDateFrom.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReportDateFrom.Format = DateTimePickerFormat.Short;
            dtpReportDateFrom.Location = new Point(401, 11);
            dtpReportDateFrom.Name = "dtpReportDateFrom";
            dtpReportDateFrom.Size = new Size(118, 23);
            dtpReportDateFrom.TabIndex = 30;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 512);
            Controls.Add(dtpReportDateTo);
            Controls.Add(dtpReportDateFrom);
            Controls.Add(btnPrint);
            Controls.Add(btnExportToPDF);
            Controls.Add(btnExportToExcel);
            Controls.Add(dgReportResults);
            Controls.Add(label4);
            Controls.Add(btnGenerateReport);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxReportTypeFilter);
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
        private ComboBox cbxReportTypeFilter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGenerateReport;
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
        private Button btnPrint;
        private DateTimePicker dtpReportDateTo;
        private DateTimePicker dtpReportDateFrom;
    }
}