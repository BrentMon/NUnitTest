using System;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject2
{
    class PageObjects_ProductPage
    {

        private IWebDriver driver;

        //class constructor
        public PageObjects_ProductPage(IWebDriver wD)
        {
            driver = wD;
        }


        //page functions
        public void mMultipleItemsFindAndPurchase(String[] URL)
        {
            PageObjects_Amazon amazon = new PageObjects_Amazon(driver);
            int i = 0;
            foreach (string item in URL)
            {
                //navigate to the first item in items array
                amazon.searchByURL(item);
                //AmazonObjects.mProductSearch(driver, item);
                //find the product title web element and give the current index of product array the same value as the curent product title
                DataSheet.sProductArray[i] = wProductTitle().Text;
                DataSheet.sProductArrayCurrent = DataSheet.sProductArray[i];
                //call the mAddToCart method to add the item to our cart.
                addToCartWithPopup();
                //increment the index of our loop by 1
                i = i + 1;
            }
        }


        public void addToCartWithPopup()
        {
            try
            {
                wAddToCartButton().Click();

                wProtectionNoThanks().Click();
                //set the no thanks button to null for the next item
                //ProductPage.wProtectionNoThanks(driver).Equals(null);
            }
            catch (NoSuchElementException)
            {
                //ProductPage.wAddToCartButton(driver).Click();
                string exception = "The Protection Plan popup did not display";
                System.Console.WriteLine(exception + " for " + DataSheet.sProductArrayCurrent);
                // System.Console.WriteLine(ex.Message);
            }
        }

        //page objects

        private IWebElement wAddToCartButton()
        {
            By bAddToCartButtonLocator = By.Id("add-to-cart-button");
            IWebElement wAddToCartButton = driver.FindElement(bAddToCartButtonLocator);
            return wAddToCartButton;
        }

        private IWebElement wProductTitle()
        {
            By bProductLocator = By.Id("productTitle");
            IWebElement wProductTitle = driver.FindElement(bProductLocator);
            return wProductTitle;
        }

        private IWebElement wProtectionNoThanks()
        {
            By bProtectionNoThanksLocator = By.Id("siNoCoverage-announce");
            IWebElement wProtectionNoThanks = driver.FindElement(bProtectionNoThanksLocator);
            return wProtectionNoThanks;
        }

    }
}