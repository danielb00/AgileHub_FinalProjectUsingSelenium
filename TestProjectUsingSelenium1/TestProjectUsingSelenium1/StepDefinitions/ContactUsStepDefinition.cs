using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectUsingSelenium1.PageObjects;

namespace TestProjectUsingSelenium1.StepDefinitions
{
    [Binding]
    public sealed class ContactUsStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public ContactUsStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        LoginLogoutPage loginLogoutPage => new LoginLogoutPage(Driver);
        ContactUsPage contactUsPage => new ContactUsPage(Driver);

        [Given(@"I navigate to website and I authenticate with valid user")]
        public void GivenINavigateToWebsiteAndIAuthenticateWithValidUser(Table table)
        {
            Navigate("http://automationpractice.com/index.php/");
            loginLogoutPage.LoginButton();
            var user = table.CreateInstance<CreateUserDto>();
            loginLogoutPage.AuthentificateUser(user);
        }

        [Given(@"I click on contact us button")]
        public void GivenIClickOnContactUsButton()
        {
            contactUsPage.ContactUsButton();
        }

        [When(@"I fill in the message text box with following data")]
        public void WhenIFillInTheMessageTextBoxWithFollowingData(Table table)
        {
            var user = table.CreateInstance<CreateUserDto>();
            contactUsPage.ContactUsForm(user);
        }

        [When(@"I click on send message button")]
        public void WhenIClickOnSendMessageButton()
        {
            contactUsPage.SendMessageButton();
        }

        [Then(@"I validated if the flyout with message it was successfull sent is displayed")]
        public void ThenIValidatedIfTheFlyoutWithMessageItWasSuccessfullSentIsDisplayed()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='center_column']/p")).Text == "Your message has been successfully sent to our team.");
        }
    }
}
