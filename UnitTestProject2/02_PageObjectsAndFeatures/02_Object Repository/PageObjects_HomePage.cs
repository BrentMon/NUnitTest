using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject2
{
    class PageObjects_HomePage{



            private IWebDriver driver;

            public PageObjects_HomePage(IWebDriver wD)
            {
               driver = wD;  
            }

            private string sHomeTitle()
            {
                string sHomeTitle = "Amazon.com: Online Shopping for Electronics, Apparel, Computers, Books, DVDs &amp; more";
                return sHomeTitle;
            }




            }
}