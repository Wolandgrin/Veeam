﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CareerSearch.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class VeeamCareersSearchFeature : Xunit.IClassFixture<VeeamCareersSearchFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "JobSearch.feature"
#line hidden
        
        public VeeamCareersSearchFeature(VeeamCareersSearchFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Veeam careers search", "\tIn order to hire new employees\n\tAs a Manager\n\tI want to have careers website sea" +
                    "rch working", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Veeam careers search results")]
        [Xunit.TraitAttribute("FeatureTitle", "Veeam careers search")]
        [Xunit.TraitAttribute("Description", "Veeam careers search results")]
        [Xunit.TraitAttribute("Category", "smoke")]
        public virtual void VeeamCareersSearchResults()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Veeam careers search results", null, new string[] {
                        "smoke"});
#line 7
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
  testRunner.Given("I am on \"https://careers.veeam.com\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.When("I select \"Romania\" in the Countries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
  testRunner.And("I select \"English\" in the Languages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.Then("\"30\" jobs should be found", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                VeeamCareersSearchFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                VeeamCareersSearchFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
