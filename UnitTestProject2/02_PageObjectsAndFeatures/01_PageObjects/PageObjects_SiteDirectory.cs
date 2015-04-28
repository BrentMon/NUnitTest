using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject2
{
    class PageObjects_SiteDirectory
    {

        private IWebDriver driver;

        //class constructor
         public PageObjects_SiteDirectory(IWebDriver wD)
         {
             this.driver = wD;
         }

        //page functions
         
        public void navigateToSiteDirectory()
         {
             driver.Navigate().GoToUrl(sSiteDirectory);
         }

        public void returnLinkCount(List<IWebElement> list)
         {
             int myint;

             navigateToSiteDirectory();

             getLinks(list);

             myint = list.Count();

             System.Console.WriteLine(myint);

             UnlimitedInstantVideos.Clear();
         }

        public void returnLinks(List<IWebElement> list)
        {
            string mystring;

            navigateToSiteDirectory();

            getLinks(list);

            foreach (IWebElement item in list)
            {
               mystring = item.Text;

               System.Console.WriteLine(mystring);
            }
            UnlimitedInstantVideos.Clear();
        }

        public void navigateTo (List<IWebElement> list)
        {
            navigateToSiteDirectory();

            getLinks(list);

            list[1].Click();

            UnlimitedInstantVideos.Clear();
        }


        //page objects

        public List<IWebElement> UnlimitedInstantVideos = new List<IWebElement>();
        public List<IWebElement> FireTV = new List<IWebElement>();

        private String sSiteDirectory = "http://www.amazon.com/gp/site-directory/ref=nav_shopall_btn";

        private By AmazonFireTVLocator = By.LinkText("Amazon Fire TV");
        private By VideoShortsLocator = By.LinkText("Video Shorts");
        private By ShopInstantVideoLocator = By.LinkText("Shop Instant Video");
        private By PrimeInstantVideoLocator = By.LinkText("Prime Instant Video");
        private By AmazonInstatntVideoLocator = By.LinkText("Amazon Instant Video");



        private List<IWebElement> getLinks(List<IWebElement> listname)
        {
        listname.Add(AmazonInstantVideo());
        listname.Add(PrimeInstantVideo());
        return listname;
       }

        private IWebElement AmazonInstantVideoProperty
        {
            get { return AmazonInstantVideo(); }
            set { AmazonInstantVideoProperty = value; }
        }

        private IWebElement AmazonInstantVideo()
        {
            IWebElement AmazonInstantVideo = driver.FindElement(AmazonInstatntVideoLocator);
            return AmazonInstantVideo;
        }

        private IWebElement PrimeInstantVideo()
        {
            IWebElement PrimeInstantVideo = driver.FindElement(PrimeInstantVideoLocator);
            return PrimeInstantVideo;
        }

        private IWebElement ShopInstantVideo()
        {
            IWebElement ShopInstantVideo = driver.FindElement(ShopInstantVideoLocator);
            return ShopInstantVideo;
        }

        private IWebElement VideoShorts()
        {
            IWebElement VideoShorts = driver.FindElement(VideoShortsLocator);
            return VideoShorts;
        }

        private IWebElement AmazonFireTV()
        {
            IWebElement VideoShorts = driver.FindElement(AmazonFireTVLocator);
            return VideoShorts;
        }

    }
}
