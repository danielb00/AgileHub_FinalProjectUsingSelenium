using OpenQA.Selenium;


namespace TestProjectUsingSelenium1.PageObjects
{
    partial class EditUserPage
    {
        public IWebElement personalInformationButton => _driver.FindElement(By.XPath("//*[@id='center_column']/div/div[1]/ul/li[4]/a"));
        private IWebElement firstNameTextBox => _driver.FindElement(By.XPath("//*[@id='firstname']"));
        private IWebElement lastNameTextBox => _driver.FindElement(By.XPath("//*[@id='lastname']"));
        public IWebElement emailAddressTextBox => _driver.FindElement(By.XPath("//*[@id='email']"));
        private IWebElement daysDropdown => _driver.FindElement(By.XPath("//*[@id='days']"));
        private IWebElement daysDropdownOption => _driver.FindElement(By.XPath("//*[@id='days']/option[4]")); 
        private IWebElement monthsDropdown => _driver.FindElement(By.XPath("//*[@id='months']"));
        private IWebElement monthsDropdownOption => _driver.FindElement(By.XPath("//*[@id='months']/option[4]"));
        private IWebElement yearsDropdown => _driver.FindElement(By.XPath("//*[@id='years']"));
        private IWebElement yearsDropdownOption => _driver.FindElement(By.XPath("//*[@id='years']/option[30]"));
        private IWebElement currentPasswordTextBox => _driver.FindElement(By.XPath("//*[@id='old_passwd']"));
        private IWebElement newPasswordTextBox => _driver.FindElement(By.XPath("//*[@id='passwd']"));
        private IWebElement confirmationTextBox => _driver.FindElement(By.XPath("//*[@id='confirmation']"));
        public IWebElement saveEditButton => _driver.FindElement(By.XPath("//*[@id='center_column']/div/form/fieldset/div[11]/button"));
    }
}
