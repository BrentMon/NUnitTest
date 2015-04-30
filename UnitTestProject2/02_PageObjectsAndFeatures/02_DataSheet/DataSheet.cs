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

        




    }



}
