using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace TestProjectUsingSelenium1.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();
        }

        
    }
}
