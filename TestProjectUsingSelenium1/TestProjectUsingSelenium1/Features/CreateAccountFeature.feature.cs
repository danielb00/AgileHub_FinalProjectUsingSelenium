﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestProjectUsingSelenium1.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AccountUserFeatures")]
    public partial class AccountUserFeaturesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CreateAccountFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "AccountUserFeatures", @"	In order to validate create new account on automationpractice.com/index.php website.
	Navigate on the automationpractice.com/index.php website.
	Click on the sign in button.
    Fill in the email address and click on the create an account button.
	Fill in the text boxes and click on the register button.
	Fill in the registered address again and receive a message alert, duplicate email address.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("001 CreateNewAccount")]
        [NUnit.Framework.CategoryAttribute("CreateNewAccount")]
        [NUnit.Framework.TestCaseAttribute("Daniel", "Test", "testdaniel@gmail.com", "test12345", "DanielAdress", "TestAdress", "Brasov, 13 Decembrie", "Brasov", "33555", "0722-455-253", null)]
        public virtual void _001CreateNewAccount(string userFirstNameValue, string userLastNameValue, string userEmailValue, string userPasswordValue, string userAddressFirstNameValue, string userAddressLastNameValue, string userAddressValue, string userCityValue, string userZipCodeValue, string userMobilePhoneValue, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "CreateNewAccount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("userFirstNameValue", userFirstNameValue);
            argumentsOfScenario.Add("userLastNameValue", userLastNameValue);
            argumentsOfScenario.Add("userEmailValue", userEmailValue);
            argumentsOfScenario.Add("userPasswordValue", userPasswordValue);
            argumentsOfScenario.Add("userAddressFirstNameValue", userAddressFirstNameValue);
            argumentsOfScenario.Add("userAddressLastNameValue", userAddressLastNameValue);
            argumentsOfScenario.Add("userAddressValue", userAddressValue);
            argumentsOfScenario.Add("userCityValue", userCityValue);
            argumentsOfScenario.Add("userZipCodeValue", userZipCodeValue);
            argumentsOfScenario.Add("userMobilePhoneValue", userMobilePhoneValue);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("001 CreateNewAccount", null, tagsOfScenario, argumentsOfScenario);
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 11
 testRunner.Given("I navigate to website and click sign in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail"});
                table6.AddRow(new string[] {
                            string.Format("{0}", userEmailValue)});
#line 12
 testRunner.And("I fill in the email and click register", ((string)(null)), table6, "And ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "userFirstName",
                            "userLastName",
                            "userEmail",
                            "userPassword",
                            "userAddressFirstName",
                            "userAddressLastName",
                            "userAddress",
                            "userCity",
                            "userZipCode",
                            "userMobilePhone"});
                table7.AddRow(new string[] {
                            string.Format("{0}", userFirstNameValue),
                            string.Format("{0}", userLastNameValue),
                            string.Format("{0}", userEmailValue),
                            string.Format("{0}", userPasswordValue),
                            string.Format("{0}", userAddressFirstNameValue),
                            string.Format("{0}", userAddressLastNameValue),
                            string.Format("{0}", userAddressValue),
                            string.Format("{0}", userCityValue),
                            string.Format("{0}", userZipCodeValue),
                            string.Format("{0}", userMobilePhoneValue)});
#line 15
 testRunner.When("I fill in the text boxex with following data", ((string)(null)), table7, "When ");
#line hidden
#line 18
 testRunner.And("I click on the register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.Then("I validated if the logout button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("002 AlertDuplicateEmail")]
        [NUnit.Framework.CategoryAttribute("AlertDuplicateEmail")]
        [NUnit.Framework.TestCaseAttribute("testdaniel@gmail.com", null)]
        public virtual void _002AlertDuplicateEmail(string userEmailValue, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AlertDuplicateEmail"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("userEmailValue", userEmailValue);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("002 AlertDuplicateEmail", null, tagsOfScenario, argumentsOfScenario);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 27
 testRunner.Given("I navigate to website and click sign in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail"});
                table8.AddRow(new string[] {
                            string.Format("{0}", userEmailValue)});
#line 28
 testRunner.When("I fill in the email and click register", ((string)(null)), table8, "When ");
#line hidden
#line 31
 testRunner.Then("I validated if the flyout with alert message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
