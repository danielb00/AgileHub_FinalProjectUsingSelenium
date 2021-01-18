using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectUsingSelenium1.PageObjects
{
    partial class ContactUsPage
    {
        private IWebElement contactUs => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[3]/a"));
        private IWebElement subjectHeadingDropdown => _driver.FindElement(By.XPath("//*[@id='id_contact']"));
        private IWebElement subjectHeadingDropdownOption => _driver.FindElement(By.XPath("//*[@id='id_contact']/option[2]"));
        public IWebElement orderReferenceDropdown => _driver.FindElement(By.XPath("//*[@id='center_column']/form/fieldset/div[1]/div[1]/div[2]/div/select"));
        public IWebElement orderReferenceDropdownOption => _driver.FindElement(By.XPath("//*[@id='center_column']/form/fieldset/div[1]/div[1]/div[2]/div/select/option[2]"));
        public IWebElement productDropdown => _driver.FindElement(By.XPath("//*[@id='274399_order_products']"));
        public IWebElement productDropdownOption => _driver.FindElement(By.XPath("//*[@id='274399_order_products']/option[2]"));
        public IWebElement messageTextBox => _driver.FindElement(By.XPath("//*[@id='message']"));
        public IWebElement submitMessageButton => _driver.FindElement(By.XPath("//*[@id='submitMessage']"));
    }
}
