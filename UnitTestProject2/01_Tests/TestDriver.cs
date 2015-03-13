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



 //       [Test]
 //      public void A1_Begin()
//      {
//          myclass.LaunchIE();
//      }

        
        public void A3_AmazonPurchase()
        {
            myclass.LaunchIE();
            myclass.ClearCart_Action();        
        }

      [Test]
       public void AmazonTest(){

         for(int i = 1; i == 4; i++)
         {
             
          myclass.BuildAComputer_Action();
       
             //[Test]
       //public void A2_AmazonPurchase()
       // {
            //myclass.LaunchIE();
            
            //myclass.CloseIE();

       //}
         }
  }

 //       [Test]
 //       public void A3_End()
//        {
 //           myclass.CloseIE();
 //       }
        
    

    }
}



