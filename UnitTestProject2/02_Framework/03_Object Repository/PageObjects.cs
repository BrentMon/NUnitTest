using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject2
{

    class AmazonObjects
    {

        public static IWebElement wSearchbar(IWebDriver driver)
        {
            By bCartButtonLocator = By.Id("twotabsearchtextbox");
            IWebElement wSearchbar = driver.FindElement(bCartButtonLocator);
            return wSearchbar;
        }

        public static IWebElement wCartButton(IWebDriver driver)
        {
            By bCartButtonLocator = By.Id("nav-cart");
            IWebElement wCartButton = driver.FindElement(bCartButtonLocator);
            return wCartButton;
        }

        public static void mAmazonHomePage(IWebDriver driver)
        {
            if (HomePage.sHomeTitle().Equals(driver.Title))
            {
                System.Console.WriteLine("Are are on the home page, lets begin");
            }
            else
            {
                System.Console.WriteLine("Are were not on the home page, going there now");
                driver.Navigate().GoToUrl("http://www.amazon.com");
            }
        }

        public static void mProductSearch(IWebDriver driver, string a)
        {
            AmazonObjects.wSearchbar(driver).SendKeys(a);
            AmazonObjects.wSearchbar(driver).Submit();
        }
        
        public static void mURLSearch(IWebDriver driver, string a)
        {
            driver.Navigate().GoToUrl(a);
        }

    }

    class HomePage
    {
        
        public static string sHomeTitle()
        {
            string sHomeTitle = "Amazon.com: Online Shopping for Electronics, Apparel, Computers, Books, DVDs &amp; more";
            return sHomeTitle;
        }

    }
    

    class ProductPage
    {

            public static IWebElement wProductTitle(IWebDriver driver)  {
                By bProductLocator = By.Id("productTitle");
                IWebElement wProductTitle = driver.FindElement(bProductLocator);
                return wProductTitle;
            }

            public static IWebElement wAddToCartButton(IWebDriver driver)   {
                By bAddToCartButtonLocator = By.Id("add-to-cart-button");
                IWebElement wAddToCartButton = driver.FindElement(bAddToCartButtonLocator);
                return wAddToCartButton;
            }

            public static void mAddToCartWithPopup(IWebDriver driver)    {
                try
                {
                    ProductPage.wAddToCartButton(driver).Click();
                    ProductPage.wProtectionPopup.wProtectionNoThanks(driver).Click();
                    //set the no thanks button to null for the next item
                    //ProductPage.wProtectionNoThanks(driver).Equals(null);
                }
                catch (NoSuchElementException ex)
                {
                    //ProductPage.wAddToCartButton(driver).Click();
                    string exception = "The Protection Plan popup did not display";
                    System.Console.WriteLine(exception);
                    System.Console.WriteLine(ex.Message);
                }
            }

           public static void mMultipleItemsFindAndPurchase(IWebDriver driver, String[] URL)
           {
               int i = 0;
               foreach (string item in URL)
               {
                   //navigate to the first item in items array
                   AmazonObjects.mURLSearch(driver, item);
                   //AmazonObjects.mProductSearch(driver, item);

                   //find the product title web element and give the current index of product array the same value as the curent product title
                   DataSheet.sProductArray[i] = ProductPage.wProductTitle(driver).Text;
                
                   //call the mAddToCart method to add the item to our cart. 
                   ProductPage.mAddToCartWithPopup(driver);
                 
                   //increment the index of our loop by 1 
                   i = i + 1;                   
              }
           }

            public static class wProtectionPopup
            {
                public static IWebElement wProtectionNoThanks(IWebDriver driver)    {
                    By bProtectionNoThanksLocator = By.Id("siNoCoverage-announce");
                    IWebElement wProtectionNoThanks = driver.FindElement(bProtectionNoThanksLocator);
                    return wProtectionNoThanks;
                }
            }  
    }



    class CartPage
    {
        public static IWebElement wProductTitle (IWebDriver driver) {
            By bProductLocator = By.Id("productTitle");
            IWebElement wProductTitle = driver.FindElement(bProductLocator);
            return wProductTitle;
        }

        public static IWebElement wActiveCart (IWebDriver driver) {
            By bActiveCartLocator = By.Id("sc-active-cart");
            IWebElement wActiveCart = driver.FindElement(bActiveCartLocator);
            return wActiveCart;
        }

        public static IWebElement wCartItem(IWebDriver driver, string a)
        {
            By bCartItemLocator = By.LinkText(a);
            IWebElement wCartItem = driver.FindElement(bCartItemLocator);
            return wCartItem;
        }

        public static string[] mGetCartItems(IWebDriver driver, string[] items)
        {
            int y = 0;
            string[] mGetCartItems = new string[items.Length];

            foreach (string a in items)
            {                
            mGetCartItems[y] = CartPage.wCartItem(driver, a).Text;
            //mGetCartItems[y] = a;
            y = y + 1;
            };

            return mGetCartItems;
        }

        public static string sProductTitle (IWebDriver driver)  {
            string sProductTitle = CartPage.wProductTitle(driver).Text;
            return sProductTitle;
        }

        public static IWebElement wCartDeleteButton(IWebDriver driver)   {
            By bDelete = By.LinkText("");
            By bDeleteButtonLocator = By.Name("submit.delete.");
            IWebElement wCartDeleteButton = driver.FindElement(bDeleteButtonLocator);
            return wCartDeleteButton;
        }

        public static void mRemoveFromCart(IWebDriver driver)
        {
            CartPage.wCartDeleteButton(driver).Click();
        }


    }

}
