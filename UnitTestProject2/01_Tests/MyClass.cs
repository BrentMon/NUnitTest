using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject2
{
    class MyClass
    {
        private IWebDriver driver;

        public MyClass()
        {

        }
        public void main(String[] args)
        {
            FrameworkInitilization chrome = new FrameworkInitilization("chrome");
            this.driver = chrome.driver;
            driver.Navigate().GoToUrl("http://www.amazon.com");




        }


    }
}
