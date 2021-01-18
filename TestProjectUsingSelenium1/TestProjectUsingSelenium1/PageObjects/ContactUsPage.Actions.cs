using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace TestProjectUsingSelenium1.PageObjects
{
    partial class ContactUsPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public ContactUsPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }
        public void ContactUsButton()
        {
            contactUs.Click();
        }

        public void ContactUsForm(CreateUserDto user)
        {
            subjectHeadingDropdown.Click();
            subjectHeadingDropdownOption.Click();
            orderReferenceDropdown.Click();
            orderReferenceDropdownOption.Click();
            productDropdown.Click();
            productDropdownOption.Click();
            messageTextBox.SendKeys(user.messageText);
        }

        public void SendMessageButton()
        {
            submitMessageButton.Click();
        }

    }
}
