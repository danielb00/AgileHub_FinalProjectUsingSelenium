using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectUsingSelenium1.PageObjects
{
    partial class LoginLogoutPage
    {
        private IWebElement signInButton => _driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));
        public IWebElement signOutButton => _driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[2]/a"));
        private IWebElement emailTextBox => _driver.FindElement(By.XPath("//*[@id='email']"));
        private IWebElement passwordTextBox => _driver.FindElement(By.XPath("//*[@id='passwd']"));
        private IWebElement submitButton => _driver.FindElement(By.XPath("//*[@id='SubmitLogin']"));
        
    }
}
