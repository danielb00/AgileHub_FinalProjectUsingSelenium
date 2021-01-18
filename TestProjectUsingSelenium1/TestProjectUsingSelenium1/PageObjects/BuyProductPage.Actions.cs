using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace TestProjectUsingSelenium1.PageObjects
{
    partial class BuyProductPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public BuyProductPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }
       
        public void ProceedToCheckout()
        {
            
            summaryProceedToCheckouButton.Click();
            addressProceedToCheckouButton.Click();
            inputAgreeTerms.Click();
            shippingProceedToCheckouButton.Click();
            payByCheckButton.Click();
            confirmMyOrderButton.Click();
        }
    }
}
