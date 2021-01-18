using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace TestProjectUsingSelenium1.PageObjects
{
    partial class EditUserPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public EditUserPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }
        public void PersonalInformationUserForm(EditUserDto editUser)
        {
            System.Threading.Thread.Sleep(2000);
            firstNameTextBox.Clear();
            firstNameTextBox.SendKeys(editUser.editUserFirstName);
            lastNameTextBox.Clear();
            lastNameTextBox.SendKeys(editUser.editUserLastName);
            emailAddressTextBox.Clear();
            emailAddressTextBox.SendKeys(editUser.editUserEmail);
            daysDropdown.Click();
            daysDropdownOption.Click();
            monthsDropdown.Click();
            monthsDropdownOption.Click();
            yearsDropdown.Click();
            yearsDropdownOption.Click();
            currentPasswordTextBox.SendKeys(editUser.currentPassword);
            newPasswordTextBox.SendKeys(editUser.newPassword);
            confirmationTextBox.SendKeys(editUser.confirmationPassword);
        }
    }
}
