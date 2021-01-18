using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace TestProjectUsingSelenium1.PageObjects
{
   partial class CreateAccountPage
    {
        public IWebElement createAccountButton => _driver.FindElement(By.XPath("//*[@id='SubmitCreate']"));
        private IWebElement inputRadio => _driver.FindElement(By.XPath("//*[@id='id_gender1']"));
        private IWebElement firstNameTextBox => _driver.FindElement(By.XPath("//*[@id='customer_firstname']")); 
        private IWebElement lastNameTextBox => _driver.FindElement(By.XPath("//*[@id='customer_lastname']"));
        public IWebElement emailAddressTextBox => _driver.FindElement(By.XPath("//*[@id='email_create']"));
        private IWebElement passwordTextBox => _driver.FindElement(By.XPath("//*[@id='passwd']"));
        private IWebElement daysDropdown => _driver.FindElement(By.XPath("//*[@id='days']"));
        private IWebElement daysDropdownOption => _driver.FindElement(By.XPath("//*[@id='days']/option[6]"));
        private IWebElement monthsDropdown => _driver.FindElement(By.XPath("//*[@id='months']"));
        private IWebElement monthsDropdownOption => _driver.FindElement(By.XPath("//*[@id='months']/option[6]"));
        private IWebElement yearsDropdown => _driver.FindElement(By.XPath("//*[@id='years']"));
        private IWebElement yearsDropdownOption => _driver.FindElement(By.XPath("//*[@id='years']/option[37]"));
        private IWebElement inputCheckBoxNewsletter => _driver.FindElement(By.XPath("//*[@id='newsletter']"));
        private IWebElement inputCheckBoxSpecialOffers => _driver.FindElement(By.XPath("//*[@id='optin']"));
        private IWebElement addressFirstNameTextBox => _driver.FindElement(By.XPath("//*[@id='firstname']"));
        private IWebElement addressLastNameTextBox => _driver.FindElement(By.XPath("//*[@id='lastname']"));
        private IWebElement addressTextBox => _driver.FindElement(By.XPath("//*[@id='address1']"));
        private IWebElement cityTextBox => _driver.FindElement(By.XPath("//*[@id='city']"));
        private IWebElement stateDropdown => _driver.FindElement(By.XPath("//*[@id='id_state']"));
        private IWebElement stateDropdownOption => _driver.FindElement(By.XPath("//*[@id='id_state']/option[6]"));
        private IWebElement zipCodeTextBox => _driver.FindElement(By.XPath("//*[@id='postcode']"));
        private IWebElement countryDropdown => _driver.FindElement(By.XPath("//*[@id='id_country']"));
        private IWebElement countryDropdownOption => _driver.FindElement(By.XPath("//*[@id='id_country']/option[2]"));
        private IWebElement mobilePhoneTextBox => _driver.FindElement(By.XPath("//*[@id='phone_mobile']"));
        public IWebElement submitButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[4]/button")));
    }
}
