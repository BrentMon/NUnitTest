using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//using NUnit.Core;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject2
{
    [SetUpFixture]
     class TestRepository_Amazon
    {

       //static FrameworkInitilization init = new FrameworkInitilization();

        [SetUp]
        public void Setup()
        {
        //    init.Setup();
        }

        [TearDown]
        public void TearDown()
        {
        //    init.TearDown();
        }

        //the [testfixture] class will execute its [setup] method once before EACH test and [teardown] methond once after EACH test.
        //the [testfixture] class is required for NUnit to identify [test] or [testcase] methods
        [TestFixture]
        [Category("Amazon")]
        public class TestSet_Amazon
        {
            //FrameworkInitilization init = new FrameworkInitilization();
            ReusableActions Amazon = new ReusableActions();
            IWebDriver driver =  FrameworkInitilization.driver;
           

            [SetUp]
            public void Setup()
            {
               // init.Setup();
            }

            [TearDown]
            public void TearDown()
            {
               // init.TearDown();
            }


            [Test]
            public void Test1()
            {
                Amazon.buildComputer_Action(driver);

                try
                {
                    Assert.AreEqual(DataSheet.sCartItemArray, DataSheet.sProductArray);
                }
                catch (AssertionException ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw new AssertionException(ex.Message);
                }
            }

            [Test]
            public void Test2()
            {
                Amazon.getCartTotal_Action(driver);

                double val1 = DataSheet.dPrice;

                Amazon.buildComputer_Action(driver);

                Amazon.getCartTotal_Action(driver);

                double val2 = DataSheet.dPrice;

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



            [TestCase(2, 3, Result = 5)]
            [TestCase(2, 3, Result = 2)]
            [TestCase(2, 3, Result = 6)]
            public double Test3(int x, int y)
            {
                //myclass.getCartManipuation_Action();
                //myclass.LaunchIE();
                return (x + y);
                //myclass.CloseIE();
            }

            [Test] [Combinatorial]
            public void Test4(
                [Values(1, 2)] int x,
                [Values("gen", "steve")]string name)
            {
                System.Console.WriteLine(x + name);

            }

            [Test, Category("Dino"), Description("my Dinasaur tests")]
            public void Test5()
            {
                TestRepository_Dino.TestSet_Dinasaur mydino = new TestRepository_Dino.TestSet_Dinasaur();
                mydino.Dino1();


            }




        }
    }

}
