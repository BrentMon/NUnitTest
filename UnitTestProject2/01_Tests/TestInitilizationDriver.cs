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

    //# of times you call the test flow

    //The test flow
    //    - general steps
    //    - do these steps (case staements -> page object model: each page feature has its own case based on the expected outcome)
    //    - the full set of steps (wrapper functions) equals the test case

    //NUnit flow
    //  SetupFixture > SetUp(within SetUpFixture) > TestFixture > SetUp(within TestFixture) > Test/TestCase 1 > TearDown(within TestFixture) > SetUp(within TestFixture) > Test/TestCase 2 > TearDown SetUp(within TestFixture)  > TearDown (within SetUpFixture) > End


    //[SetUpFixture]
    class FrameworkInitilization
    {
        private IWebDriver wDriver;

        //class constructor with 1 argument
        //choose the browser when the initilization class is created
        public FrameworkInitilization (String browser)
        {
            if (browser == "IE" || browser == "ie")
            {
                driver = new InternetExplorerDriver();
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 10));
                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
                driver.Manage().Window.Maximize();   
            }
            if (browser == "firefox" || browser == "Firefox" || browser == "FireFox")
            {
            }
            if (browser == "chrome" || browser == "Chrome")
            {
                 driver = new ChromeDriver();
                 driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 10));
                 driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
                 driver.Manage().Window.Maximize();
            }
            
            //choose chrome if nothing is selcted
            else
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 10));
                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
                driver.Manage().Window.Maximize();
            }      
        }

        //class constructor w/ no arguments
        //choose chrome if nothing is selcted
        public FrameworkInitilization()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 10));
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
            driver.Manage().Window.Maximize();
        }


        public IWebDriver driver
        {
            get
            {
                return wDriver;
            }
            set
            {
                wDriver = value;
            }

        }

        //[SetUp]
        public void Setup()
        {

        }

       // [TearDown]
        public void TearDown()
        {

        }
    }//end class [testsetupfixture] initializeframework


}//end namespace




