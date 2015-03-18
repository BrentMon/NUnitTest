using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject2
{

//# of times you call the test flow

//The test flow
//    - general steps
//    - do these steps (case staements -> page object model: each page feature has its own case based on the expected outcome)
//    - the full set of steps (wrapper functions) equals the test case


    [TestFixture]
    public class TestSet1
    {
       ReusableActions myclass = new ReusableActions();
       //In the driver 
       //initialize the framework (configure tool, connect to databases, import parameters)
       //initEnvironment
       //GetAndSetEnvironmentTestSet
       //ConfigureTool
       //initODBCConnections
       //ImportTestParameters
       //initController
       //initialze data set
 
        [SetUp]
        public void Setup()
        {
          //create a new IE instance
            myclass.LaunchIE();
        }

        [TearDown]
       public void TearDown()
        {
            //Close the current IE instance
            myclass.CloseIE();
        }



     // [Test]
        public void Test1()
        {
           myclass.getComputer_Action();

          // try
          // {
               Assert.AreEqual(DataSheet.sCartItemArray, DataSheet.sProductArray);
          // }
         //  catch (AssertionException ex)
         //  {
               //    System.Console.WriteLine(ex.Message);
            //   throw new AssertionException(ex.Message);
         //  }

        }

      [Test]
      public void Test2()
      {
          
          myclass.getCartTotal_Action();

          double val1 = DataSheet.dPrice;

          myclass.getComputer_Action();

          myclass.getCartTotal_Action();

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

     // [Test]
      public void Test3()
      {
          myclass.getCartPage_Action();
 

      }   
    

    }
}



