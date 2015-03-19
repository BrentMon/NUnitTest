using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;


namespace UnitTestProject2
{

    //# of times you call the test flow

    //The test flow
    //    - general steps
    //    - do these steps (case staements -> page object model: each page feature has its own case based on the expected outcome)
    //    - the full set of steps (wrapper functions) equals the test case

    //the [setupfixture] class will execute the [setup] method once before the the tests and [teardown] methond once after tests have completed.
    [SetUpFixture]
    public class FrameworkInitilization
    {
        //declaring my class as static makes it accessable to the [testfixture] class and it's methods
        //static TestRepository myclass = new TestRepository();

        //Init the driver? I have mine init inside of Reusable Actions class and created inside of the [testsetupfixture's setup] method
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
        //    myclass.LaunchIE();
        }

        [TearDown]
        public void TearDown()
        {
            //Close the current IE instance
         //   myclass.CloseIE();
        }

        //the [testfixture] class will execute its [setup] method once before EACH test and [teardown] methond once after EACH test.
        //the [testfixture] class is required for NUnit to identify [test] or [testcase] methods
        [TestFixture]
        public class TestDriver
        {

            [SetUp]
            public void Setup()
            {
                //do nothing before each test
            }

            [TearDown]
            public void TearDown()
            {
               //do nothing after each test
            }


            
  
            [Test]
            [Category("Dino")]
            public static void DinoTests()
            {

            }
  



        }//end class [testfixture] TestDriverClass
    }//end class [testsetupfixture] initializeframework
}//end namespace




