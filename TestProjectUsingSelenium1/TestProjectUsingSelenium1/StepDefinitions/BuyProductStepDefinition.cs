using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectUsingSelenium1.PageObjects;

namespace TestProjectUsingSelenium1.StepDefinitions
{
    [Binding]
    public sealed class BuyProductStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public BuyProductStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        LoginLogoutPage loginLogoutPage => new LoginLogoutPage(Driver);
        HomePage homePage => new HomePage(Driver);
        BuyProductPage buyProductPage => new BuyProductPage(Driver);

        [Given(@"I authenticate with valid user")]
        public void GivenIAuthenticateWithValidUser(Table table)
        {
            Navigate("http://automationpractice.com/index.php/");
            loginLogoutPage.LoginButton();
            var user = table.CreateInstance<CreateUserDto>();
            loginLogoutPage.AuthentificateUser(user);
        }

        [When(@"I select a product")]
        public void WhenISelectAProduct()
        {
            homePage.SelectProduct();
        }

        [When(@"I finish the checkout steps")]
        public void WhenIFinishTheCheckoutSteps()
        {
            buyProductPage.ProceedToCheckout();
        }

        [Then(@"I validated if the flyout the order is placed is displayed")]
        public void ThenIValidatedIfTheFlyoutTheOrderIsPlacedIsDisplayed()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='center_column']/p[1]")).Text == "Your order on My Store is complete.");
        }

    }
}
