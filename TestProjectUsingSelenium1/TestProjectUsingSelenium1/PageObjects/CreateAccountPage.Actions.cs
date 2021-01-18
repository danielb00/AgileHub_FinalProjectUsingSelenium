using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace TestProjectUsingSelenium1.PageObjects
{
    partial class CreateAccountPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public CreateAccountPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            _driverWait.IgnoreExceptionTypes();

        }

        public void RegiserUserForm(CreateUserDto user)
        {
            System.Threading.Thread.Sleep(2000);
            inputRadio.Click();
            firstNameTextBox.SendKeys(user.userFirstName);
            lastNameTextBox.SendKeys(user.userLastName);
            passwordTextBox.SendKeys(user.userPassword);
            daysDropdown.Click();
            daysDropdownOption.Click();
            monthsDropdown.Click();
            monthsDropdownOption.Click();
            yearsDropdown.Click();
            yearsDropdownOption.Click();
            inputCheckBoxNewsletter.Click();
            inputCheckBoxSpecialOffers.Click();
            addressFirstNameTextBox.Clear();
            addressFirstNameTextBox.SendKeys(user.userAddressFirstName);
            addressLastNameTextBox.Clear();
            addressLastNameTextBox.SendKeys(user.userAddressLastName);
            addressTextBox.SendKeys(user.userAddress);
            cityTextBox.SendKeys(user.userCity);
            stateDropdown.Click();
            stateDropdownOption.Click();
            zipCodeTextBox.SendKeys(user.userZipCode);
            countryDropdown.Click();
            countryDropdownOption.Click();
            mobilePhoneTextBox.Click();
            mobilePhoneTextBox.SendKeys(user.userMobilePhone);
        }
    }
}
