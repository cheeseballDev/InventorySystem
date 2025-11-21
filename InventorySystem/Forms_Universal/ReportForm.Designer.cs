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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label6 = new Label();
            cbxReportTypeFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGenerateReport = new Button();
            label4 = new Label();
            dgReportResults = new DataGridView();
            btnExportToExcel = new Button();
            btnExportToPDF = new Button();
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
            cbxReportTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxReportTypeFilter.Font = new Font("Montserrat", 9F);
            cbxReportTypeFilter.FormattingEnabled = true;
            cbxReportTypeFilter.Items.AddRange(new object[] { "Added Quantity", "Deducted Quantity" });
            cbxReportTypeFilter.Location = new Point(135, 10);
            cbxReportTypeFilter.Name = "cbxReportTypeFilter";
            cbxReportTypeFilter.Size = new Size(178, 24);
            cbxReportTypeFilter.TabIndex = 15;
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
            btnGenerateReport.Click += btnGenerateReport_Click;
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
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgReportResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgReportResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgReportResults.BackgroundColor = SystemColors.Control;
            dgReportResults.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgReportResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgReportResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 219, 219);
            dataGridViewCellStyle3.Font = new Font("Montserrat", 11.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgReportResults.DefaultCellStyle = dataGridViewCellStyle3;
            dgReportResults.Location = new Point(22, 114);
            dgReportResults.Name = "dgReportResults";
            dgReportResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgReportResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReportResults.Size = new Size(786, 306);
            dgReportResults.TabIndex = 22;
            dgReportResults.DataBindingComplete += dgReportResults_DataBindingComplete;
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
            btnExportToExcel.Location = new Point(22, 438);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(141, 27);
            btnExportToExcel.TabIndex = 23;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click_1;
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
            btnExportToPDF.Location = new Point(177, 438);
            btnExportToPDF.Name = "btnExportToPDF";
            btnExportToPDF.Size = new Size(136, 27);
            btnExportToPDF.TabIndex = 24;
            btnExportToPDF.Text = "Export to PDF";
            btnExportToPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportToPDF.UseVisualStyleBackColor = true;
            btnExportToPDF.Click += btnExportToPDF_Click;
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
            ClientSize = new Size(820, 483);
            Controls.Add(dtpReportDateTo);
            Controls.Add(dtpReportDateFrom);
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
        private Button btnExportToExcel;
        private Button btnExportToPDF;
        private DateTimePicker dtpReportDateTo;
        private DateTimePicker dtpReportDateFrom;
    }
}