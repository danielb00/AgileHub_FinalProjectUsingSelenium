using NUnit.Framework;
using OpenQA.Selenium;
using System;
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
        BuyProductPage buyProductPage => new BuyProductPage(Driver);

        [Given(@"I authenticate with valid user")]
        public void GivenIAuthenticateWithValidUser(Table table)
        {
            Navigate("http://automationpractice.com/index.php/");
            loginLogoutPage.LoginButton();
            var user = table.CreateInstance<CreateUserDto>();
            loginLogoutPage.AuthentificateUser(user);
        }

        [When(@"I select a products")]
        public void WhenISelectAProduct()
        {
            buyProductPage.SelectProducts();
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

        [Then(@"I validated if the total price of the products is correct")]
        public void ThenIValidatedIfTheTotalPriceOfTheProductsIsCorrect()
        {
            var totalPrice = buyProductPage.TotalPriceCheck();
            var totalProduct = Driver.FindElement(By.XPath("//*[@id='total_product']")).Text.Split('$');
            Assert.AreEqual(totalPrice, Convert.ToDouble(totalProduct[1]));
        }

        [When(@"I completed the payment steps")]
        public void WhenICompletedThePaymentSteps()
        {
            buyProductPage.PaymentSteps();
        }

        [Then(@"I validated if the terms of service popup is displayed")]
        public void ThenIValidatedIfTheTermsOfServicePopupIsDisplayed()
        {
            Assert.IsTrue(buyProductPage.termsOfServicePopup.Displayed);
        }
    }
}
