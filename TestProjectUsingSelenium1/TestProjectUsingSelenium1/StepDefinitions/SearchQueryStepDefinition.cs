using NUnit.Framework;
using TechTalk.SpecFlow;
using TestProjectUsingSelenium1.PageObjects;

namespace TestProjectUsingSelenium1.StepDefinitions
{
    [Binding]
    public sealed class SearchQueryStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SearchQueryStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        HomePage homePage => new HomePage(Driver);
        CreateAccountPage createAccountPage => new CreateAccountPage(Driver);

        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            Navigate("http://automationpractice.com/index.php/");
        }

        [Given(@"I write '(.*)' in the search bar")]
        public void GivenIWriteInTheSearchBar(string p0)
        {
            homePage.searchTextBox.Click();
            homePage.searchTextBox.SendKeys(p0);
        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            homePage.searchButton.Click();
        }

        [Then(@"I validated if the product is displayed")]
        public void ThenIValidatedIfTheProductIsDisplayed()
        {
            Assert.IsTrue(homePage.printedSummerButton.Displayed);
        }

    }
}
