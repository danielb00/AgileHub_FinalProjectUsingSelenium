using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectUsingSelenium1.PageObjects;

namespace TestProjectUsingSelenium1.StepDefinitions
{
    [Binding]
    public sealed class CreateAccountStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CreateAccountStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        LoginLogoutPage loginLogoutPage => new LoginLogoutPage(Driver);
        CreateAccountPage createAccountPage => new CreateAccountPage(Driver);

        [Given(@"I navigate to website and click sign in")]
        public void GivenINavigateToWebsiteAndClickSignIn()
        {
            Navigate("http://automationpractice.com/index.php/");
            loginLogoutPage.LoginButton();
        }

        [Given(@"I fill in the email and click register")]
        public void ThenIFillInTheEmailAndClickRegister(Table table)
        {
            var user = table.CreateInstance<CreateUserDto>();
            createAccountPage.emailAddressTextBox.SendKeys(user.userEmail);
            createAccountPage.createAccountButton.Click();
        }

        [When(@"I fill in the text boxex with following data")]
        public void WhenIFillInTheTextBoxexWithFollowingData(Table table)
        {
            var user = table.CreateInstance<CreateUserDto>();
            createAccountPage.RegiserUserForm(user);
        }

        [When(@"I click on the register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            createAccountPage.submitButton.Click();
        }

        [Then(@"I validated if the logout button is displayed")]
        public void ThenIValidatedIfTheLogoutButtonIsDisplayed()
        {
            Assert.IsTrue(loginLogoutPage.signOutButton.Displayed);
        }

        [When(@"I fill in the email and click register")]
        public void WhenIFillInTheEmailAndClickRegister(Table table)
        {
            var user = table.CreateInstance<CreateUserDto>();
            createAccountPage.emailAddressTextBox.SendKeys(user.userEmail);
            createAccountPage.createAccountButton.Click();
        }

        [Then(@"I validated if the flyout with alert message is displayed")]
        public void ThenIValidatedIfTheFlyoutWithAlertMessageIsDisplayed()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='create_account_error']/ol/li")).Text == "An account using this email address has already been registered. Please enter a valid password or request a new one.");
        }

    }
}

