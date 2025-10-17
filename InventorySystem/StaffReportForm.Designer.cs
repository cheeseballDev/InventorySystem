namespace InventorySystem
{
    partial class StaffReportForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label6 = new Label();
            cbxCurrentBranch = new ComboBox();
            label1 = new Label();
            cbxDateFrom = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dgReportResults).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 66);
            label6.Name = "label6";
            label6.Size = new Size(228, 37);
            label6.TabIndex = 13;
            label6.Text = "Report Results";
            // 
            // cbxCurrentBranch
            // 
            cbxCurrentBranch.Font = new Font("Montserrat", 9F);
            cbxCurrentBranch.FormattingEnabled = true;
            cbxCurrentBranch.Location = new Point(135, 24);
            cbxCurrentBranch.Name = "cbxCurrentBranch";
            cbxCurrentBranch.Size = new Size(178, 24);
            cbxCurrentBranch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(135, 135, 135);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(117, 16);
            label1.TabIndex = 14;
            label1.Text = "Select report type:";
            // 
            // cbxDateFrom
            // 
            cbxDateFrom.Font = new Font("Montserrat", 9F);
            cbxDateFrom.FormattingEnabled = true;
            cbxDateFrom.Location = new Point(397, 24);
            cbxDateFrom.Name = "cbxDateFrom";
            cbxDateFrom.Size = new Size(128, 24);
            cbxDateFrom.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(135, 135, 135);
            label2.Location = new Point(319, 30);
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
            label3.Location = new Point(531, 30);
            label3.Name = "label3";
            label3.Size = new Size(21, 16);
            label3.TabIndex = 18;
            label3.Text = "To";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Montserrat", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(558, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(128, 24);
            comboBox1.TabIndex = 19;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(225, 212, 193);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Location = new Point(703, 22);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(91, 27);
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
            label4.Location = new Point(35, 103);
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
            dgReportResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgReportResults.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgReportResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgReportResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReportResults.Columns.AddRange(new DataGridViewColumn[] { PERFUME_ID, PERFUME_NAME, PERFUME_QTY, PERFUME_BRANCH, PERFUME_DATECREATED, PERFUME_STATUS });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgReportResults.DefaultCellStyle = dataGridViewCellStyle4;
            dgReportResults.Location = new Point(22, 122);
            dgReportResults.Name = "dgReportResults";
            dgReportResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgReportResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReportResults.Size = new Size(772, 315);
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
            btnExportToExcel.Location = new Point(22, 457);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(166, 27);
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
            btnExportToPDF.Location = new Point(210, 457);
            btnExportToPDF.Name = "btnExportToPDF";
            btnExportToPDF.Size = new Size(166, 27);
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
            button1.Location = new Point(397, 457);
            button1.Name = "button1";
            button1.Size = new Size(108, 27);
            button1.TabIndex = 25;
            button1.Text = "Print";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // StaffReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 512);
            Controls.Add(button1);
            Controls.Add(btnExportToPDF);
            Controls.Add(btnExportToExcel);
            Controls.Add(dgReportResults);
            Controls.Add(label4);
            Controls.Add(btnGenerate);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(cbxDateFrom);
            Controls.Add(label2);
            Controls.Add(cbxCurrentBranch);
            Controls.Add(label1);
            Controls.Add(label6);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StaffReportForm";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)dgReportResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cbxCurrentBranch;
        private Label label1;
        private ComboBox cbxDateFrom;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
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
    }
}