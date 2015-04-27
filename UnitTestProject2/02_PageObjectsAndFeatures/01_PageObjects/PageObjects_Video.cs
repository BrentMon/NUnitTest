using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject2
{
    class PageObjects_Video
    {
        private IWebDriver driver;

        //class constructor
         public PageObjects_Video(IWebDriver wD)
         {
             this.driver = wD;  
         }

        //page functions

        public void navigateToAmazonInstantVideo()
         {
             AmazonInstantVideoLink().Click();
             
         }

        //page objects

        //private string AmazonInstantVideoURL = "www.amazon.com/Instant-Video/b/ref=sd_allcat_aiv?ie=UTF8&amp;node=2858778011";

        private IWebElement AmazonInstantVideoLink()
        {
            By AmazonInstatntVideoLocator = By.LinkText("Amazon Instant Video");
            IWebElement  AmazonInstantVideoLink = driver.FindElement(AmazonInstatntVideoLocator);
            return AmazonInstantVideoLink;
        }



        
    }
}
