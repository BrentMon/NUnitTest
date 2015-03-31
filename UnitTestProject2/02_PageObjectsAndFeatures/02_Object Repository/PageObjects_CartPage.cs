using System;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject2
{
    class PageObjects_CartPage
    {

        private IWebDriver driver;

        //class constructor
        public PageObjects_CartPage(IWebDriver wD)
        {
            driver = wD;
        }

        //page functions
        public string[] sCartItems(string[] items)
        {
            int y = 0;
            string[] sCartItems = new string[items.Length];
            foreach (string a in items)
            {
                sCartItems[y] = wCartItem(a).Text;
                //mGetCartItems[y] = a;
                y = y + 1;
            };
            return sCartItems;
        }

        //page objects

        private double dCartPrice()
        {
            try
            {
                double dCartPrice = Convert.ToDouble(sCartPrice());
                return dCartPrice;
            }
            catch (NoSuchElementException ex)
            {
                System.Console.WriteLine(ex.Message);
                driver.Navigate().GoToUrl(sCartPageURL);
                double dCartPrice = Convert.ToDouble(sCartPrice());
                return dCartPrice;
            }
        }

        private string sCartPageURL = "http://www.amazon.com/gp/cart/view.html/ref=nav_cart";

 

         private string sCartPrice ()
        {
            string sCartPrice = wCartPrice().Text;
            sCartPrice = sCartPrice.TrimStart(DataSheet.cDollarSign());
            return sCartPrice;
        }       

        private string sProductTitle()
        {
            string sProductTitle = wProductTitle().Text;
            return sProductTitle;
        }
        
        
        private IWebElement wActiveCart()
        {
            By bActiveCartLocator = By.Id("sc-active-cart");
            IWebElement wActiveCart = driver.FindElement(bActiveCartLocator);
            return wActiveCart;
        }

        private IWebElement wCartItem(string a)
        {
            By bCartItemLocator = By.LinkText(a);
            IWebElement wCartItem = driver.FindElement(bCartItemLocator);
            return wCartItem;
        }

        private IWebElement wCartPrice()
        {
            By bCartPriceLocator = By.ClassName("sc-price-sign");
            IWebElement wCartPrice = driver.FindElement(bCartPriceLocator);
            return wCartPrice;
        }

        private IWebElement wProductTitle()
        {
            By bProductLocator = By.Id("productTitle");
            IWebElement wProductTitle = driver.FindElement(bProductLocator);
            return wProductTitle;
        }



    }
}