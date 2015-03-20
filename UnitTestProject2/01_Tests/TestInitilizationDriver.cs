using System;
using System.Collections.Generic;
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

    //the [setupfixture] class will execute the [setup] method once before the  tests and [teardown] methond once after tests have completed.
    //you only need one [setupfixture] in your solution. NUnit will find it no matter what .cs file is in and run it first. 
    //Hoever, you can have multiple [setupfixtures]. I'm not sure yet the order it chooses to run each [setupfixture].
    [SetUpFixture]
    public class FrameworkInitilization
    {
        //declaring my class as static makes it accessable to the [testfixture] class and it's methods
        //static TestRepository testrepository = new TestRepository();
        //static ReusableActions BrowserInitilization = new ReusableActions();
        public static IWebDriver driver;


        //Init the driver? I have mine init inside of FrameworkInitilization class and created inside of the [testsetupfixture's setup] method
        //init the framework (configure tool, connect to databases, import parameters)
        //initEnvironment
        //GetAndSetEnvironmentTestSet
        //ConfigureTool
        //initODBCConnections
        //ImportTestParameters
        //initController
        //init data set

        [SetUp]
        public void Setup()
        {
            //create a new IE instance
            //driver = new InternetExplorerDriver();
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.amazon.com");
        }

        [TearDown]
        public void TearDown()
        {
            //Close the current IE instance
            driver.Quit();
        }

        //the [testfixture] class will execute its [setup] method once before EACH test and [teardown] methond once after EACH test.
        //the [testfixture] class is required for NUnit to identify [test] or [testcase] methods
        //NUnit will only run the [testfixture] class [setup] and [teardown] for the [test]s in the SAME class. 
        //So for example, my TestSet_Amazon class's [testfixture] will only run before the [test] methods in the TestSet_Amazon class.
        [TestFixture]
        [Category("Full Suite")]
        public class TestDriver
        {
            //static ReusableActions BrowserInitilization = new ReusableActions();
            // static IWebDriver driver;

            [SetUp]
            public void Setup()
            {
                //do something before each test
              //  driver = new InternetExplorerDriver();
               // driver.Navigate().GoToUrl("http://www.amazon.com");
                //BrowserInitilization.LaunchIE();
            }

            [TearDown]
            public void TearDown()
            {
               //do something after each test
                //BrowserInitilization.CloseIE();
               // driver.Quit();
            }


            
  
            [Test]
            [Category("Null")]
            public static void AllDinoTests()
            {
                System.Console.WriteLine("Dino Driver GO!!");
                
                TestRepository_Dino.TestSet_Dinasaur mydino = new TestRepository_Dino.TestSet_Dinasaur();
                mydino.Dino1();
                
            }

            //[Test]
            [Category("Null")]
            public static void AllAmazonTests()
            {
                System.Console.WriteLine("Amazon Driver GO!!");
                TestRepository_Amazon.TestSet_Amazon myamazon = new TestRepository_Amazon.TestSet_Amazon();
                myamazon.Test1();
                myamazon.Test2();
                //myamazon.Test3();
                //myamazon.Test4();
                myamazon.Test5();
            }
  



        }//end class [testfixture] TestDriverClass
    }//end class [testsetupfixture] initializeframework
}//end namespace




