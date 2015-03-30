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
    class PageObjects_Amazon
    {

        private IWebDriver driver;

        //class constructor
            public PageObjects_Amazon(IWebDriver wD)
            {
                this.driver = wD;  
            }


        //page functions
            public void searchByProduct(string a)
            {
                wSearchbar().SendKeys(a);
                wSearchbar().Submit();
            }

        //page objects
        private IWebElement wSearchbar()
        {
            By bCartButtonLocator = By.Id("twotabsearchtextbox");
            IWebElement wSearchbar = driver.FindElement(bCartButtonLocator);
            return wSearchbar;
        }


    }

}