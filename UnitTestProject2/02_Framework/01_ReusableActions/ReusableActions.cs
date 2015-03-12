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
  public class ReusableActions
   {
      IWebDriver driver;

       public void LaunchIE()
        {
            //create a new IE instance
           driver = new InternetExplorerDriver();
           driver.Navigate().GoToUrl("http://www.amazon.com");
       }

       public void CloseIE()
        {
            //Close the current IE instance
           driver.Quit();
        }

        public void BuildAComputer_Action()
        {
            int x;

            //AmazonObjects.mAmazonHomePage(driver);

            //create a product array that is the same size as the items aray
            DataSheet.sProductArray = new string[DataSheet.sItemsArray.Length];

            //Using a foreach loop we will add each item to the cart from our sItemsArray
            ProductPage.mMultipleItemsFindAndPurchase(driver, DataSheet.sItemsArray);

            //find the cart button on screen and click it to navigate to the users cart
            AmazonObjects.wCartButton(driver).Click();
            
            //create an array of cart items that contains the same number items that should have been added to the cart. 
            DataSheet.sCartItemArray =  new string[DataSheet.sProductArray.Length];

            try
            {
               //sCartItemArray = CartPage.mGetCartItems(driver, sProductArray);
               CartPage.mGetCartItems(driver, DataSheet.sProductArray).CopyTo(DataSheet.sCartItemArray, 0);
            }
            catch (NullReferenceException)
            {
                System.Console.WriteLine("threw exception, null reference for ");
            };


            //Assert that all the items are the same
            x = 0;
            foreach (string item in DataSheet.sProductArray)
            {
              Assert.AreEqual(DataSheet.sCartItemArray[x], item);
              x = x + 1;
            };
            

        }//End Build a computer

  




      public void ClearCart_Action()
        {
            CartPage.mRemoveFromCart(driver);

        }// End Clear Cart


    }//End Amazon

}//End Namespace
