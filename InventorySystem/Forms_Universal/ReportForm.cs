using InventorySystem.Helper_Classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace InventorySystem
{
    public partial class ReportForm : Form
    {
        private DateTime firstDay;
        private DateTime lastDay;
        public ReportForm()
        {
            InitializeComponent();
            loadReport();
            firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            lastDay = firstDay.AddMonths(1).AddDays(-1);

            dtpReportDateFrom.Value = firstDay;
            dtpReportDateTo.Value = lastDay;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxReportTypeFilter.Text))
            {
                loadReport();
                return;
            }
            String query = "select * from reporttable where Status like @report and date(date_created) between @startDate and @endDate";
            string keyword = cbxReportTypeFilter.Text.Contains("Added") ? "Added" : "Deducted";
            MySqlParameter actionParameter = new MySqlParameter("@report", "%" + keyword + "%");
            MySqlParameter startDateParameter = new MySqlParameter("@startDate", dtpReportDateFrom.Value.Date);
            MySqlParameter endDateParameter = new MySqlParameter("@endDate", dtpReportDateTo.Value.Date);

            dgReportResults.DataSource = DatabaseHelper.ExecuteQuery(query, actionParameter, startDateParameter, endDateParameter);
            dgReportResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgReportResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgReportResults.ScrollBars = ScrollBars.Both;
        }

        private void loadReport()
        {
            String query = "select * from reporttable";
            dgReportResults.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            if (dgReportResults.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgReportResults.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgReportResults.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgReportResults.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export", "Info");
            }
        }

        private void btnExportToExcel_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Inventory_Adjustment_Export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false;
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                Clipboard.Clear();
                dgReportResults.ClearSelection();
            }
        }

        private void copyAlltoClipboard()
        {
            dgReportResults.SelectAll();
            DataObject dataObj = dgReportResults.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
