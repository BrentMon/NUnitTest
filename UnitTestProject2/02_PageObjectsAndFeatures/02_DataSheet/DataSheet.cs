using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Microsoft.CSharp.RuntimeBinder;



namespace UnitTestProject2
{
    class DataSheet
    {

     public static string[] sItemsArray = new string[] {      
                  "http://www.amazon.com/gp/product/B005L38QLQ/ref=ox_sc_act_title_3?ie=UTF8&psc=1&smid=A2CN1URH4P01KB",
                 // "http://www.amazon.com/gp/product/B009ZN2NH6/ref=ox_sc_act_title_2?ie=UTF8&psc=1&smid=A14NA3XYNZWQC5",
                 // "http://www.amazon.com/gp/product/B00N2H1EAI/ref=gno_cart_title_0?ie=UTF8&psc=1&smid=ATVPDKIKX0DER"
                //"SteelSeries Sensei Laser Gaming Mouse - 62150",
                //"Corsair Hydro Series Extreme Performance Liquid CPU Cooler H100i",
               // "MSI X99S SLI PLUS ATX DDR4 NA Motherboards X99S SLI PLUS"                
     };

     //http://www.amazon.com/gp/site-directory/ref=nav_shopall_btn

     public static string[] sProductArray;

     public static string sProductArrayCurrent;

     public static string[] sCartItemArray;

     public static char[] cDollarSign()
     {
         char[] cDollarSign = new char[]
            {
                '$'
            };

         return cDollarSign;
     }

     public static double dPrice;

        

        //Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
       
        public static void ExcelMethod()
        {

            //Open Excel
            string sDatatable = @"C:\Users\brent.monger\Source\Repos\NUnitTest\UnitTestProject2\02_PageObjectsAndFeatures\02_DataSheet\DataTable.xlsx";
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = true;
            System.Console.WriteLine(sDatatable);

            //open the appropriate document
            Workbook workbook = excelapp.Workbooks.Open(sDatatable);
            
            //set the whroskeet to the active sheet
            Worksheet worksheet =  workbook.ActiveSheet;
           
            //set the current row to the workseets index [1]
            int CurrentRow = worksheet.Index;
            int HeaderRow = worksheet.Index;
            
            //Create a list for each column
            List<dynamic> RUN_ROW = new List<dynamic>();
            List<dynamic> ACCOUNT = new List<dynamic>();
            List<dynamic> AE = new List<dynamic>();

            //set the column number for each column, not required but makes things more readable down the line
            int RUN_ROWColumn = 1;
            int ACCOUNTColumn = 2;
            int AEColumn = 3;

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
                
                System.Console.WriteLine(RUN_ROW[CurrentRow]);
                System.Console.WriteLine(ACCOUNT[CurrentRow]);
                System.Console.WriteLine(AE[CurrentRow]);

            
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




           // System.Console.WriteLine(ACCOUNT[0]);
           // System.Console.WriteLine(ACCOUNT[1].ToString());
            

           

            /*
             worksheet.Cells[1, 2] = "Updated";
             worksheet.Cells[1, 3] = "Bid";

             worksheet.Cells[2, 2] = "name";
             worksheet.Cells[2, 3] = "idk";
            */

           // workbook.Save();
            excelapp.Quit();

        }


    }



}
