using System;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject2
{
    class PageObjects_HomePage{



            private IWebDriver driver;
            
        //class constructor
            public PageObjects_HomePage(IWebDriver wD)
            {
               driver = wD;  
            }


            //page functions
            public void navigateToAmazonHomePage()
            {
                if (sHomeTitle().Equals(driver.Title.ToString()))
                {
                    System.Console.WriteLine("You are on the home page, lets begin");
                }
                else
                {
                    System.Console.WriteLine("You were not on the home page, going there now");
                    driver.Navigate().GoToUrl("http://www.amazon.com");
                }
            }



            //page objects
            private string sHomeTitle()
            {
                string sHomeTitle = "Amazon.com: Online Shopping for Electronics, Apparel, Computers, Books, DVDs &amp; more";
                return sHomeTitle;
            }




            }
}