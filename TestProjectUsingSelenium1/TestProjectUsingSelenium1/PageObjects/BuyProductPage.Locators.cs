using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace TestProjectUsingSelenium1.PageObjects
{
    partial class BuyProductPage
    {
        private IWebElement dressButton => _driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[2]/a"));
        private IWebElement primarySummerDressButton => _driver.FindElement(By.XPath("//*[@id='categories_block_left']/div/ul/li[3]/a"));
        public IWebElement printedSummerButton => _driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[1]/div/a[1]/img"));
        public IWebElement printedChiffonButton => _driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[3]/div/div[1]/div/a[1]/img"));
        private IWebElement sizeButton => _driver.FindElement(By.XPath("//*[@id='group_1']"));
        private IWebElement sizeOptionButton => _driver.FindElement(By.XPath("//*[@id='group_1']/option[2]"));
        private IWebElement blueDressColor => _driver.FindElement(By.XPath("//*[@id='color_14']"));
        private IWebElement greenDressColor => _driver.FindElement(By.XPath("//*[@id='color_15']"));
        private IWebElement continueShoppingButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span")));
        private IWebElement secondarySummerDressButton => _driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a[4]"));
        private IWebElement addToCartButton => _driver.FindElement(By.XPath("//*[@id='add_to_cart']/button"));
        private IWebElement proceedToCheckouButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a")));
        private IWebElement summaryProceedToCheckouButton => _driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]"));
        private IWebElement addressProceedToCheckouButton => _driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button"));
        private IWebElement inputAgreeTerms => _driver.FindElement(By.XPath("//*[@id='cgv']"));
        public IWebElement termsOfServicePopup => _driver.FindElement(By.XPath("//*[@id='order']/div[2]/div/div/div/div/p"));
        private IWebElement shippingProceedToCheckouButton => _driver.FindElement(By.XPath("//*[@id='form']/p/button"));
        private IWebElement payByCheckButton => _driver.FindElement(By.XPath("//*[@id='HOOK_PAYMENT']/div[2]/div/p/a"));
        private IWebElement confirmMyOrderButton => _driver.FindElement(By.XPath("//*[@id='cart_navigation']/button"));
    }
}