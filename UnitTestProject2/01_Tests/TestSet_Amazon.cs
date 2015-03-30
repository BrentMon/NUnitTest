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
    [TestFixture]
    [Category("Amazon")]
    class TestSet_Amazon
    {

        private IWebDriver driver;
        
        //class constructor
        public TestSet_Amazon()
        {
         //   FrameworkInitilization framework = new FrameworkInitilization();
        //    this.driver = framework.driver;
        }


            [SetUp]
            public void Setup()
            {
                //do something before each test
                //FrameworkInitilization IE = new FrameworkInitilization("IE");
                //FrameworkInitilization firefox = new FrameworkInitilization("firefox");
                FrameworkInitilization chrome = new FrameworkInitilization("chrome");
                this.driver = chrome.driver; 

            }

            [TearDown]
            public void TearDown()
            {
               //do something after each test
                driver.Quit();
            }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://www.amazon.com");

            PageObjects_Amazon amazon = new PageObjects_Amazon(driver);

            amazon.searchByProduct("keyboard");

        }


    }




}