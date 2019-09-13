using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;      // EXCEL APPLICATION.


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();

            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@"D:\СИШАРП\WindowsFormsApp1\WindowsFormsApp1\example.xlsx");
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;

            dataGridView1.RowCount = rows;
            dataGridView1.ColumnCount = cols;

            for (int i = 1; i <= rows; i++)
            {
                // read new line
                for (int j = 1; j <= cols; j++)
                {

                    //write to cell
                    if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                        dataGridView1.Rows[i - 1].Cells[j - 1].Value = excelRange.Cells[i, j].Value2.ToString();

                }
            }
            //after reading, relaase the excel project
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }



        // CREATE EXCEL OBJECTS.
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        string sFileName;
        int iRow, iCol = 2;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        // GET NAMES FROM EXCEL AND POPULATE COMB0 BOX.
        public void readExcel(string sFile)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFile);
            xlWorkSheet = xlWorkBook.Worksheets["Лист1"];          // NAME OF THE SHEET.

            // START FROM THE SECOND ROW.
            for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)
            {
                if (xlWorkSheet.Cells[iRow, 1].value == null)
                {
                    break;              // BREAK LOOP.
                }
                else
                {                       // POPULATE COMBO BOX.
                    comboBox1.Items.Add(xlWorkSheet.Cells[iRow, 1].value);
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Excel File to Edit";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFileName = openFileDialog1.FileName;

                if (sFileName.Trim() != "")
                {
                    readExcel(sFileName);               // READ EXCEL DATA.
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sFileName.Trim() != "")
            {
                modifyExcel(sFileName);         // MODIFY DETAILS IN THE FILE.
            }
        }

        // NOW, MODIFY EMPLOYEE DETAILS WITH NEW DETAILS IN THE EXCEL FILE.
        private void modifyExcel(string sFile)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFile);
            xlWorkSheet = xlWorkBook.Worksheets["Лист1"];        // NAME OF THE SHEET.

            for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)      // START FROM THE SECOND ROW.
            {
                if (xlWorkSheet.Cells[iRow, 1].value == null)
                {
                    break;          // BREAK, IF IT REACHED THE LAST ROW.
                }

                if (xlWorkSheet.Cells[iRow, 1].value == comboBox1.Text)
                {
                    xlWorkSheet.Cells[iRow, iCol].value = tbMobile.Text;        // MODIFY MOBILE (IN CELL 2).
                    xlWorkSheet.Cells[iRow, iCol + 1].value = tbAddress.Text;   // MODIFY ADDRESS (IN CELL 3).
                }
            }
            xlWorkBook.Close();
            xlApp.Quit();

        }
    } }
