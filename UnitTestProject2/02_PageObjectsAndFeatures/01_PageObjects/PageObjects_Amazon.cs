using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
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

            public void navigateToAmazon()
            {
                driver.Navigate().GoToUrl("http://www.amazon.com");
            }



            public void navigateToCart()
            {
                wCartButton().Click();
            }

            public void searchByProduct(string a)
            {
                wSearchbar().SendKeys(a);
                wSearchbar().Submit();
            }

            public void searchByURL(string a)
            {
                driver.Navigate().GoToUrl(a);
            }

        //page objects



        private IWebElement wSiteDirectoryButton ()
            {
                By bSiteDirectoryLocator = By.Id("nav-link-shopall");
                IWebElement wSiteDirectoryButton = driver.FindElement(bSiteDirectoryLocator);
                return wSiteDirectoryButton;
            }

            private IWebElement wCartButton()
            {
                By bCartButtonLocator = By.Id("nav-cart");
                IWebElement wCartButton = driver.FindElement(bCartButtonLocator);
                return wCartButton;
            }

        private IWebElement wSearchbar()
        {
            By bCartButtonLocator = By.Id("twotabsearchtextbox");
            IWebElement wSearchbar = driver.FindElement(bCartButtonLocator);
            return wSearchbar;
        }





    }

}