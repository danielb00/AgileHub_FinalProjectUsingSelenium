using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace TestProjectUsingSelenium1.PageObjects
{
    partial class HomePage
    {
        private IWebElement dressButton => _driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[2]/a"));
        private IWebElement summerDressButton => _driver.FindElement(By.XPath("//*[@id='categories_block_left']/div/ul/li[3]/a"));
        public IWebElement printedSummerButton => _driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[1]/div/a[1]/img"));
        private IWebElement sizeButton => _driver.FindElement(By.XPath("//*[@id='group_1']"));
        private IWebElement sizeOptionButton => _driver.FindElement(By.XPath("//*[@id='group_1']/option[2]"));
        private IWebElement colorButton => _driver.FindElement(By.XPath("//*[@id='color_14']"));
        private IWebElement addToCartButton => _driver.FindElement(By.XPath("//*[@id='add_to_cart']/button"));
        private IWebElement proceedToCheckouButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a")));
        public IWebElement searchTextBox => _driver.FindElement(By.XPath("//*[@id='search_query_top']"));
        public IWebElement searchButton => _driver.FindElement(By.XPath("//*[@id='searchbox']/button"));
    }
}
