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

        public void SelectProducts()
        {
            dressButton.Click();
            primarySummerDressButton.Click();
            //((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");
            printedSummerButton.Click();
            sizeButton.Click();
            sizeOptionButton.Click();
            blueDressColor.Click();
            addToCartButton.Click();
            continueShoppingButton.Click();
            secondarySummerDressButton.Click();
            //((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");
            printedChiffonButton.Click();
            sizeButton.Click();
            sizeOptionButton.Click();
            greenDressColor.Click();
            addToCartButton.Click();
            proceedToCheckouButton.Click();
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
        public double TotalPriceCheck()
        {
            var priceDress = _driver.FindElements(By.XPath("//*[contains(@id, 'total_product_price')]"));

            double totalPriceDress = 0;
            foreach (var totalPrice in priceDress)
            {
                var totalValue = totalPrice.Text.Split('$');
                totalPriceDress += Convert.ToDouble(totalValue[1]);
            }
            return Math.Round(totalPriceDress, 2);
        }
        public void PaymentSteps()
        {
            summaryProceedToCheckouButton.Click();
            addressProceedToCheckouButton.Click();
            shippingProceedToCheckouButton.Click();
        }
    }
}
