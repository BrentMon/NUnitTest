using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject2
{
    [TestFixture]
    [Category("Amazon")]
    class TestSet_Amazon
    {

        private IWebDriver driver;
        private string browser;
        
        //class constructor
        public TestSet_Amazon()
        {
                     //create the driver
           // FrameworkInitilization chrome = new FrameworkInitilization("chrome");
            //this.driver = chrome.driver;
            
            //   FrameworkInitilization framework = new FrameworkInitilization();
        //    this.driver = framework.driver;

        }

     
            [SetUp]
            public void Setup()
            {
                //do something before each test
                //FrameworkInitilization IE = new FrameworkInitilization("IE");
                //FrameworkInitilization firefox = new FrameworkInitilization("firefox");
                //FrameworkInitilization chrome = new FrameworkInitilization("chrome");
              //  this.driver = chrome.driver; 

                

            }

            [TearDown]
            public void TearDown()
            {
               //do something after each test
              // driver.Quit();
            }

      //  [Test]
        public void Test1()
        {
            //create the driver
            FrameworkInitilization Browser = new FrameworkInitilization(browser);
            this.driver = Browser.driver;

            //create page objects
            PageObjects_Amazon amazon = new PageObjects_Amazon(driver);
            PageObjects_CartPage cartPage = new PageObjects_CartPage(driver);
            PageObjects_ProductPage productPage = new PageObjects_ProductPage(driver);
        
            //build a computer

            //create a product array that is the same size as the items aray
            DataSheet.sProductArray = new string[DataSheet.sItemsArray.Length];
            //Using a foreach loop we will add each item to the cart from our sItemsArray
  
            productPage.mMultipleItemsFindAndPurchase(DataSheet.sItemsArray);
            //find the cart button on screen and click it to navigate to the users cart

            amazon.navigateToCart();
            //create an array of cart items that contains the same number items that should have been added to the cart.
            DataSheet.sCartItemArray = new string[DataSheet.sProductArray.Length];

            //copy sProductArray into sCartItemArray items to the cart item array
            try
            {
                cartPage.sCartItems(DataSheet.sProductArray).CopyTo(DataSheet.sCartItemArray, 0);
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine(ex.Message);
            };

            //validation
             try
            {
                Assert.AreEqual(DataSheet.sCartItemArray, DataSheet.sProductArray);
            }       
            catch (AssertionException ex)
            {
                System.Console.WriteLine(ex.Message);
                throw new AssertionException(ex.Message);
            }

            //close the driver
             driver.Quit();

        }


      //  [Test]
        public void Test2()
        {
            //create the driver
            FrameworkInitilization Browser = new FrameworkInitilization(browser);
            this.driver = Browser.driver;
            
            //create page objects
            PageObjects_Amazon amazon = new PageObjects_Amazon(driver);
            PageObjects_CartPage cartPage = new PageObjects_CartPage(driver);
            PageObjects_ProductPage productPage = new PageObjects_ProductPage(driver);

            //build a computer

                 //create a product array that is the same size as the items aray
                DataSheet.sProductArray = new string[DataSheet.sItemsArray.Length];
                //Using a foreach loop we will add each item to the cart from our sItemsArray

                productPage.mMultipleItemsFindAndPurchase(DataSheet.sItemsArray);
                //find the cart button on screen and click it to navigate to the users cart

                amazon.navigateToCart();
                //create an array of cart items that contains the same number items that should have been added to the cart.
                DataSheet.sCartItemArray = new string[DataSheet.sProductArray.Length];

                //copy sProductArray into sCartItemArray items to the cart item array
                try
                {
                    cartPage.sCartItems(DataSheet.sProductArray).CopyTo(DataSheet.sCartItemArray, 0);
                }
                catch (NullReferenceException ex)
                {
                    System.Console.WriteLine(ex.Message);
                };

            //get cart total
            cartPage.getCartTotal(); 

            double val1 = DataSheet.dPrice;


            //build a computer again

            //create a product array that is the same size as the items aray
            DataSheet.sProductArray = new string[DataSheet.sItemsArray.Length];
            //Using a foreach loop we will add each item to the cart from our sItemsArray

            productPage.mMultipleItemsFindAndPurchase(DataSheet.sItemsArray);
            //find the cart button on screen and click it to navigate to the users cart

            amazon.navigateToCart();
            //create an array of cart items that contains the same number items that should have been added to the cart.
            DataSheet.sCartItemArray = new string[DataSheet.sProductArray.Length];

            //copy sProductArray into sCartItemArray items to the cart item array
            try
            {
                //PageObjects_CartPage cartPage = new PageObjects_CartPage(driver);
                cartPage.sCartItems(DataSheet.sProductArray).CopyTo(DataSheet.sCartItemArray, 0);
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine(ex.Message);
            };
            
            //get cart total
            cartPage.getCartTotal();

            double val2 = DataSheet.dPrice;
          
            //validation
            try
            {
                Assert.Less(val1, val2);
            }
            catch (AssertionException)
            {
                throw new AssertionException("Value 1 was not less than or equal to value 2. \nThe Cart value did not go up");
                //System.Console.WriteLine(ex.Message);
                //throw new AssertionException(ex.Message);
            }
        }   




       //[Test]
       //[Combinatorial]
        public void Test4(
        [Values("IE", "chrome")] string browser,
        [Values("I", "C")] string text   
           )
        {
            //create the driver
            FrameworkInitilization Browser = new FrameworkInitilization(browser);
            this.driver = Browser.driver;
 

            driver.Navigate().GoToUrl("http://www.amazon.com");

            PageObjects_Amazon amazon = new PageObjects_Amazon(driver);

            amazon.searchByProduct(text);

           

            //close the driver
            driver.Quit();
        }


        //[Test]
        public void Test5  ()
        {
            PageObjects_Amazon amazon = new PageObjects_Amazon(driver);
            //PageObjects_Video video = new PageObjects_Video(driver);
            PageObjects_SiteDirectory sites = new PageObjects_SiteDirectory(driver);

            amazon.navigateToAmazon();
            sites.navigateToSiteDirectory();
            sites.returnLinkCount(sites.UnlimitedInstantVideos);
            sites.returnLinks(sites.UnlimitedInstantVideos);
            sites.navigateTo(sites.UnlimitedInstantVideos);

            System.Console.WriteLine(driver.Title);

            DataSheet.ExcelMethod();
            
            


        }

        [Test]
        public void Test6()
        {


            DataSheet.ExcelMethod();
            



        }




    }




}