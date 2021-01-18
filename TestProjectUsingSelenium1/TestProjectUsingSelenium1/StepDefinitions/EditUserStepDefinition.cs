using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectUsingSelenium1.PageObjects;

namespace TestProjectUsingSelenium1.StepDefinitions
{
    [Binding]
    public sealed class EditUserStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public EditUserStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        LoginLogoutPage loginLogoutPage => new LoginLogoutPage(Driver);
        EditUserPage editUserPage => new EditUserPage(Driver);

        [Given(@"I navigate to website and I login with following credentials")]
        public void GivenINavigateToWebsiteAndILoginWithFollowingCredentials(Table table)
        {
            Navigate("http://automationpractice.com/index.php/");
            loginLogoutPage.LoginButton();
            var user = table.CreateInstance<CreateUserDto>();
            loginLogoutPage.AuthentificateUser(user);
        }

        [Given(@"I click on the my personal information button")]
        public void GivenIClickOnTheMyPersonalInformationButton()
        {
            editUserPage.personalInformationButton.Click();
        }

        [When(@"I edit the text boxex with following data")]
        public void WhenIEditTheTextBoxexWithFollowingData(Table table)
        {
            var editUser = table.CreateInstance<EditUserDto>();
            editUserPage.PersonalInformationUserForm(editUser);
        }

        [When(@"I click on the save button")]
        public void WhenIClickOnTheSaveButton()
        {
            editUserPage.saveEditButton.Click();
        }

        [Then(@"I validated if the flyout succes alert is displayed")]
        public void ThenIValidatedIfTheFlyoutSuccesAlertIsDisplayed()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='center_column']/div/p")).Text == "Your personal information has been successfully updated.");
        }
    }
}
