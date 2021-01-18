using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectUsingSelenium1.PageObjects;

namespace TestProjectUsingSelenium1.StepDefinitions
{
    [Binding]
    public sealed class LoginLogoutStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public LoginLogoutStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        LoginLogoutPage loginLogoutPage => new LoginLogoutPage(Driver);
        EditUserPage editUserPage => new EditUserPage(Driver);

        [Given(@"I navigate to website and click signin button")]
        public void GivenINavigateToWebsiteAndClickSigninButton()
        {
            Navigate("http://automationpractice.com/index.php/");
            loginLogoutPage.LoginButton();
        }


        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<CreateUserDto>();
            loginLogoutPage.AuthentificateUser(user);
        }

        [Then(@"I validated if the my personal information button is displayed")]
        public void ThenIValidatedIfTheMyPersonalInformationButtonIsDisplayed()
        {
            Assert.IsTrue(editUserPage.personalInformationButton.Displayed);
        }

        [When(@"I logout of the account")]
        public void WhenILogoutOfTheAccount()
        {
            loginLogoutPage.LogoutButton();
        }

        [Then(@"I validated if the login button is displayed")]
        public void ThenIValidatedIfTheLoginButtonIsDisplayed()
        {
            Assert.IsTrue(loginLogoutPage.signOutButton.Displayed);
        }

    }
}
