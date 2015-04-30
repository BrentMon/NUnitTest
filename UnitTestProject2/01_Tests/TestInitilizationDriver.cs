using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.Office.Interop.Excel;
using Microsoft.CSharp.RuntimeBinder;


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
        private Microsoft.Office.Interop.Excel.Application excelApp;
        
        public IWebDriver driver
        { 
            get {return wDriver; }
            set{ wDriver = value; }
        }
        public Microsoft.Office.Interop.Excel.Application excel
        { 
            get {return excelApp; }
            set{ excelApp = value; }
        }

        //class constructor with 1 argument
        //choose the browser when the initilization class is created
        public FrameworkInitilization (string browser)
        {



            if (browser == "IE" || browser == "ie")
            {
                driver = new InternetExplorerDriver();
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 25));
                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 25));
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
            //else
            //{
            //    driver = new ChromeDriver();
            //    driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 10));
            //    driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
            //    driver.Manage().Window.Maximize();
            //}      
        }

        /*
        //class constructor w/ no arguments
        //choose chrome if nothing is selcted
        public FrameworkInitilization()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0,0,10));
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
            driver.Manage().Window.Maximize();
        }
        */

        public FrameworkInitilization()
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.Visible = true;
            excel.Visible = false;
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




