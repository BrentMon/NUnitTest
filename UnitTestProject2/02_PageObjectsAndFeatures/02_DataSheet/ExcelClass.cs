using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Microsoft.CSharp.RuntimeBinder;

namespace UnitTestProject2
{
    class ExcelClass
    {
        private Microsoft.Office.Interop.Excel.Application excel;
        
    
         //class constructor
        public ExcelClass(Microsoft.Office.Interop.Excel.Application eA)
         {
             this.excel = eA;
             
         }

        private string sDatatable = @"C:\Users\brent.monger\Source\Repos\NUnitTest\UnitTestProject2\02_PageObjectsAndFeatures\02_DataSheet\DataTable.xlsx";
        private Workbook workbook;
        private Worksheet worksheet;
        //Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();

        public void ExcelSetUp()
        {
           // excel.Visible = true;
            //Open Excel
            // string sDatatable = @"C:\Users\brent.monger\Source\Repos\NUnitTest\UnitTestProject2\02_PageObjectsAndFeatures\02_DataSheet\DataTable.xlsx";
            //open the appropriate document
            workbook = excel.Workbooks.Open(sDatatable);
            System.Console.WriteLine(sDatatable);

            // workbook.Save();
        }

        public void ExcelGetData()
        {

            //set the whroskeet to the active sheet
            worksheet = workbook.ActiveSheet;

            //set the current row to the workseets index [1]
            int CurrentRow = worksheet.Index;
            int HeaderRow = worksheet.Index;
            int ColumnNumber = worksheet.Index;

            //Create a list for each column
            List<dynamic> RUN_ROW = new List<dynamic>();
            List<dynamic> ACCOUNT = new List<dynamic>();
            List<dynamic> AE = new List<dynamic>();

            //set the column number for each column, not required but makes things more readable down the line
            int RUN_ROWColumn = ColumnNumber;
            ColumnNumber++;
            int ACCOUNTColumn = ColumnNumber;
            ColumnNumber++;
            int AEColumn = ColumnNumber;
            ColumnNumber++;

            //Grab column names from the document. This is required to keep things from blowing up
            RUN_ROW.Add(worksheet.Cells[HeaderRow, RUN_ROWColumn].Text);
            ACCOUNT.Add(worksheet.Cells[HeaderRow, ACCOUNTColumn].Text);
            AE.Add(worksheet.Cells[HeaderRow, AEColumn].Text);


            //Dim my exit condition variable
            int Exit = 0;

            //while loop that grabs the data for each row/column for every populated row in the document. If the 1st column is blank,
            //it will stop grabbing records.
            while (Exit == 0)
            {

                RUN_ROW.Add(worksheet.Cells[CurrentRow, RUN_ROWColumn].Text);
                ACCOUNT.Add(worksheet.Cells[CurrentRow, ACCOUNTColumn].Text);
                AE.Add(worksheet.Cells[CurrentRow, AEColumn].Text);

                System.Console.WriteLine(CurrentRow + ": " + RUN_ROW[CurrentRow] + " " + ACCOUNT[CurrentRow] + " " + AE[CurrentRow]);
                //System.Console.WriteLine(ACCOUNT[CurrentRow]);
                //System.Console.WriteLine(AE[CurrentRow]);
    
                //if the run row cell on the current row is blank, it will exit the loop.
                if (RUN_ROW[CurrentRow] == "" || RUN_ROW[CurrentRow] == null)
                {
                    Exit = 1;
                }
                else
                {

                }

                //increment the current row by one
                CurrentRow++;


            }
        }


        public void ExcelTearDown()
        {
            excel.Quit();
        }

    }
}
