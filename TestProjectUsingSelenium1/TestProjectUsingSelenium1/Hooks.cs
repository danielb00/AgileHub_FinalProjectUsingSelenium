using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestProjectUsingSelenium1
{
    [Binding]
    public class Hooks
    {
        protected static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            if (Driver is null)
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();
            }
        }
        public void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (!(Driver is null))
            {
                Driver.Quit();
                Driver = null;
            }
        }
    }
}
