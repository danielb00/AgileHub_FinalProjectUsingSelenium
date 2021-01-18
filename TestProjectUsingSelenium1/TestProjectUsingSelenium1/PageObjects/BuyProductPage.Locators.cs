using OpenQA.Selenium;


namespace TestProjectUsingSelenium1.PageObjects
{
    partial class BuyProductPage
    {
       
        private IWebElement summaryProceedToCheckouButton => _driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]"));
        private IWebElement addressProceedToCheckouButton => _driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button"));
        private IWebElement inputAgreeTerms => _driver.FindElement(By.XPath("//*[@id='cgv']"));
        private IWebElement shippingProceedToCheckouButton => _driver.FindElement(By.XPath("//*[@id='form']/p/button"));
        private IWebElement payByCheckButton => _driver.FindElement(By.XPath("//*[@id='HOOK_PAYMENT']/div[2]/div/p/a"));
        private IWebElement confirmMyOrderButton => _driver.FindElement(By.XPath("//*[@id='cart_navigation']/button"));
    }
}
