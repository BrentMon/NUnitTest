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
  class ReusableActions
   {
      IWebDriver driver;
      //static double dPrice;

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



       public void buildComputer_Action()
        {
            AmazonObjects.mAmazonHomePage(driver);

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
               CartPage.mGetCartItems(driver, DataSheet.sProductArray).CopyTo(DataSheet.sCartItemArray, 0);
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine(ex.Message);
            };
 
        }//End Build a computer






       public void getCartTotal_Action()
        {
            DataSheet.dPrice = CartPage.dCartPrice(driver);
            
            System.Console.WriteLine("Cart Total = " + DataSheet.dPrice);

        }// End getCartTotal_Action



       public void getCartPage_Action()
        {
            //AmazonObjects.wCartButton(driver).Click();
            driver.Navigate().GoToUrl(CartPage.sCartPageURL);
        }//end get cart page


       public void getCartManipuation_Action()
      {
          DataSheet.dPrice = DataSheet.dPrice + 2;

          

      }// End getCartTotal_Action

    }//End Class Reusable action

}//End Namespace
