// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CV2HR.IntegrationTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AccessingTheJobOfferDetailsFeature : Xunit.IClassFixture<AccessingTheJobOfferDetailsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "JobOfferDetails.feature"
#line hidden
        
        public AccessingTheJobOfferDetailsFeature(AccessingTheJobOfferDetailsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Accessing the job offer details", "       In order to know more about a job offer\r\n       As a user\r\n       I want t" +
                    "o see its details", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.FactAttribute(DisplayName="Job offer 0 details")]
        [Xunit.TraitAttribute("FeatureTitle", "Accessing the job offer details")]
        [Xunit.TraitAttribute("Description", "Job offer 0 details")]
        [Xunit.TraitAttribute("Category", "JobOfferController")]
        public virtual void JobOffer0Details()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job offer 0 details", null, new string[] {
                        "JobOfferController"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CompanyId",
                        "Created",
                        "ValidUntil",
                        "Description",
                        "JobTitle",
                        "Location",
                        "UserId",
                        "SalaryFrom",
                        "SalaryTo"});
            table1.AddRow(new string[] {
                        "0",
                        "1",
                        "2012-01-26",
                        "2020-01-26",
                        "the best job ever",
                        "Programmer",
                        "Poland",
                        "user1",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "1",
                        "1",
                        "2012-01-30",
                        "2020-01-30",
                        "the best job ever 2",
                        "Programmer 2",
                        "Poland",
                        "user1",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "2",
                        "2",
                        "2012-01-01",
                        "",
                        "the worst job ever",
                        "Teacher",
                        "Poland",
                        "user2",
                        "",
                        ""});
#line 8
       testRunner.Given("when there are following offers in the database", ((string)(null)), table1, "Given ");
#line 13
       testRunner.When("I want to see details of job offer 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CompanyId",
                        "Created",
                        "ValidUntil",
                        "Description",
                        "JobTitle",
                        "Location",
                        "UserId",
                        "SalaryFrom",
                        "SalaryTo"});
            table2.AddRow(new string[] {
                        "0",
                        "1",
                        "2012-01-26",
                        "2020-01-26",
                        "the best job ever",
                        "Programmer",
                        "Poland",
                        "user1",
                        "",
                        ""});
#line 14
       testRunner.Then("I get following offer on the screen", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Job offer 1 details")]
        [Xunit.TraitAttribute("FeatureTitle", "Accessing the job offer details")]
        [Xunit.TraitAttribute("Description", "Job offer 1 details")]
        public virtual void JobOffer1Details()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job offer 1 details", null, ((string[])(null)));
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CompanyId",
                        "Created",
                        "ValidUntil",
                        "Description",
                        "JobTitle",
                        "Location",
                        "UserId",
                        "SalaryFrom",
                        "SalaryTo"});
            table3.AddRow(new string[] {
                        "0",
                        "1",
                        "2012-01-26",
                        "2020-01-26",
                        "the best job ever",
                        "Programmer",
                        "Poland",
                        "user1",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "1",
                        "1",
                        "2012-01-30",
                        "2020-01-30",
                        "the best job ever 2",
                        "Programmer 2",
                        "Poland",
                        "user1",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "2",
                        "2",
                        "2012-01-01",
                        "",
                        "the worst job ever",
                        "Teacher",
                        "Poland",
                        "user2",
                        "",
                        ""});
#line 19
       testRunner.Given("when there are following offers in the database", ((string)(null)), table3, "Given ");
#line 24
       testRunner.When("I want to see details of job offer 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CompanyId",
                        "Created",
                        "ValidUntil",
                        "Description",
                        "JobTitle",
                        "Location",
                        "UserId",
                        "SalaryFrom",
                        "SalaryTo"});
            table4.AddRow(new string[] {
                        "1",
                        "1",
                        "2012-01-30",
                        "2020-01-30",
                        "the best job ever 2",
                        "Programmer 2",
                        "Poland",
                        "user1",
                        "",
                        ""});
#line 25
       testRunner.Then("I get following offer on the screen", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Job offer 2 details")]
        [Xunit.TraitAttribute("FeatureTitle", "Accessing the job offer details")]
        [Xunit.TraitAttribute("Description", "Job offer 2 details")]
        public virtual void JobOffer2Details()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job offer 2 details", null, ((string[])(null)));
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CompanyId",
                        "Created",
                        "ValidUntil",
                        "Description",
                        "JobTitle",
                        "Location",
                        "UserId",
                        "SalaryFrom",
                        "SalaryTo"});
            table5.AddRow(new string[] {
                        "0",
                        "1",
                        "2012-01-26",
                        "2020-01-26",
                        "the best job ever",
                        "Programmer",
                        "Poland",
                        "user1",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "1",
                        "1",
                        "2012-01-30",
                        "2020-01-30",
                        "the best job ever 2",
                        "Programmer 2",
                        "Poland",
                        "user1",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "2",
                        "2",
                        "2012-01-01",
                        "",
                        "the worst job ever",
                        "Teacher",
                        "Poland",
                        "user2",
                        "",
                        ""});
#line 30
       testRunner.Given("when there are following offers in the database", ((string)(null)), table5, "Given ");
#line 35
       testRunner.When("I want to see details of job offer 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CompanyId",
                        "Created",
                        "ValidUntil",
                        "Description",
                        "JobTitle",
                        "Location",
                        "UserId",
                        "SalaryFrom",
                        "SalaryTo"});
            table6.AddRow(new string[] {
                        "2",
                        "2",
                        "2012-01-01",
                        "",
                        "the worst job ever",
                        "Teacher",
                        "Poland",
                        "user2",
                        "",
                        ""});
#line 36
       testRunner.Then("I get following offer on the screen", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Job offer 3 details")]
        [Xunit.TraitAttribute("FeatureTitle", "Accessing the job offer details")]
        [Xunit.TraitAttribute("Description", "Job offer 3 details")]
        public virtual void JobOffer3Details()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job offer 3 details", null, ((string[])(null)));
#line 40
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CompanyId",
                        "Created",
                        "ValidUntil",
                        "Description",
                        "JobTitle",
                        "Location",
                        "UserId",
                        "SalaryFrom",
                        "SalaryTo"});
            table7.AddRow(new string[] {
                        "0",
                        "1",
                        "2012-01-26",
                        "2020-01-26",
                        "the best job ever",
                        "Programmer",
                        "Poland",
                        "user1",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "1",
                        "1",
                        "2012-01-30",
                        "2020-01-30",
                        "the best job ever 2",
                        "Programmer 2",
                        "Poland",
                        "user1",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "2",
                        "2",
                        "2012-01-01",
                        "",
                        "the worst job ever",
                        "Teacher",
                        "Poland",
                        "user2",
                        "",
                        ""});
#line 41
       testRunner.Given("when there are following offers in the database", ((string)(null)), table7, "Given ");
#line 46
       testRunner.When("I want to see details of job offer 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
       testRunner.Then("I get NotFound error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AccessingTheJobOfferDetailsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AccessingTheJobOfferDetailsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
