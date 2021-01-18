using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectUsingSelenium1.PageObjects
{
    partial class LoginLogoutPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public LoginLogoutPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void LoginButton()
        {
            signInButton.Click();
        }
        public void LogoutButton()
        {
            signOutButton.Click();
        }


        public void AuthentificateUser(CreateUserDto user)
        {
            emailTextBox.SendKeys(user.userEmail);
            passwordTextBox.SendKeys(user.userPassword);
            submitButton.Click();
        }
    }
}
