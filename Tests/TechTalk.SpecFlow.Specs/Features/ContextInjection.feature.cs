﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Injecting context into step specifications")]
    public partial class InjectingContextIntoStepSpecificationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ContextInjection.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Injecting context into step specifications", "\tAs a developer\r\n\tI would like to have the system automatically inject an instanc" +
                    "e of any class as defined in the constructor of a step file\r\n\tSo that I don\'t ha" +
                    "ve to rely on the global shared state and can define the contexts required for e" +
                    "ach scenario.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
 testRunner.Given("the following binding class", @"public class SingleContext
{
public static int InstanceCount = 0;
public string ScenarioTitle;

public SingleContext()
{
ScenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
InstanceCount++;
}
}
public class OtherSingleContext
{
}
public class NestedContext
{
public readonly SingleContext SingleContext;

public NestedContext(SingleContext singleContext)
{
if (singleContext == null) throw new ArgumentNullException(""singleContext"");
this.SingleContext = singleContext;
}
}
public class DisposableContext : IDisposable
{
public static bool WasDisposed = false;

public void Dispose()
{
WasDisposed = true;
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 43
 testRunner.And("the following step definition", @"[Then(@""the instance count of SingleContext should be (\d+)"")]
public void ThenTheInstanceCountShouldBe(int expectedCount)
{
if (SingleContext.InstanceCount != expectedCount) throw new Exception(""Instance count should be "" + expectedCount + "" but was "" + SingleContext.InstanceCount);
}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Binding class can depend on a single context")]
        public virtual void BindingClassCanDependOnASingleContext()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Binding class can depend on a single context", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 53
 testRunner.Given("the following binding class", @"[Binding]
public class StepsWithSingleContext
{
private readonly SingleContext singleContext;

public StepsWithSingleContext(SingleContext singleContext)
{
if (singleContext == null) throw new ArgumentNullException(""singleContext"");
this.singleContext = singleContext;
}

[When(@""I do something"")]
public void WhenIDoSomething()
{
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 72
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\r\nThen the instance count of SingleContext should be 1", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table1.AddRow(new string[] {
                        "1"});
#line 78
 testRunner.Then("the execution summary should contain", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Binding class can depend on multiple contexts")]
        public virtual void BindingClassCanDependOnMultipleContexts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Binding class can depend on multiple contexts", ((string[])(null)));
#line 82
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 83
 testRunner.Given("the following binding class", @"[Binding]
public class StepsWithMultipleContexts
{
public StepsWithMultipleContexts(SingleContext singleContext, OtherSingleContext otherContext)
{
if (singleContext == null) throw new ArgumentNullException(""singleContext"");
if (otherContext == null) throw new ArgumentNullException(""otherContext"");
}

[When(@""I do something"")]
public void WhenIDoSomething()
{
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 100
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\r\nThen the instance count of SingleContext should be 1", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table2.AddRow(new string[] {
                        "1"});
#line 106
 testRunner.Then("the execution summary should contain", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Context classes can depend on other context classes recursively")]
        public virtual void ContextClassesCanDependOnOtherContextClassesRecursively()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Context classes can depend on other context classes recursively", ((string[])(null)));
#line 110
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 111
 testRunner.Given("the following binding class", @"[Binding]
public class StepsWithNestedContext
{
public StepsWithNestedContext(NestedContext nestedContext, SingleContext singleContext)
{
if (nestedContext == null) throw new ArgumentNullException(""nestedContext"");
if (singleContext == null) throw new ArgumentNullException(""singleContext"");
}

[When(@""I do something"")]
public void WhenIDoSomething()
{
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 128
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\r\nThen the instance count of SingleContext should be 1", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table3.AddRow(new string[] {
                        "1"});
#line 134
 testRunner.Then("the execution summary should contain", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Context classes are shared across binding classes")]
        public virtual void ContextClassesAreSharedAcrossBindingClasses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Context classes are shared across binding classes", ((string[])(null)));
#line 138
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 139
 testRunner.Given("the following binding class", @"[Binding]
public class StepsWithSingleContext
{
public StepsWithSingleContext(SingleContext singleContext)
{
if (singleContext == null) throw new ArgumentNullException(""singleContext"");
}

[When(@""I do something"")]
public void WhenIDoSomething()
{
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 155
 testRunner.Given("the following binding class", @"[Binding]
public class OtherStepsWithSingleContext
{
public OtherStepsWithSingleContext(SingleContext singleContext)
{
if (singleContext == null) throw new ArgumentNullException(""singleContext"");
}

[When(@""I do something else"")]
public void WhenIDoSomethingElse()
{
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 171
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\r\nAnd I do something else\r\nThen the instance count of SingleCo" +
                    "ntext should be 1", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table4.AddRow(new string[] {
                        "1"});
#line 178
 testRunner.Then("the execution summary should contain", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Context classes are recreated for every scenario")]
        public virtual void ContextClassesAreRecreatedForEveryScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Context classes are recreated for every scenario", ((string[])(null)));
#line 182
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 183
 testRunner.Given("the following binding class", @"[Binding]
public class StepsWithSingleContext
{
private SingleContext singleContext;

public StepsWithSingleContext(SingleContext singleContext)
{
if (singleContext == null) throw new ArgumentNullException(""singleContext"");
this.singleContext = singleContext;
}

[When(@""I do something"")]
public void WhenIDoSomething()
{
}


[Then(@""the SingleContext instance was created in scenario '(.+)'"")]
public void ThenTheInstanceCountShouldBe(string title)
{
if (singleContext.ScenarioTitle != title) throw new Exception(""Instance count should be created in "" + title + "" but was "" + singleContext.ScenarioTitle);
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 209
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\r\nThen the SingleContext instance was created in scenario \'Sim" +
                    "ple Scenario\'", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 214
 testRunner.And("a scenario \'Other Scenario\' as", "When I do something\r\nThen the SingleContext instance was created in scenario \'Oth" +
                    "er Scenario\'", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 219
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table5.AddRow(new string[] {
                        "2"});
#line 220
 testRunner.Then("the execution summary should contain", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Disposable dependencies should be disposed after scenario execution")]
        public virtual void DisposableDependenciesShouldBeDisposedAfterScenarioExecution()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Disposable dependencies should be disposed after scenario execution", ((string[])(null)));
#line 224
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
#line 225
 testRunner.Given("the following binding class", @"[Binding]
public class StepsWithSingleContext
{
public StepsWithSingleContext(DisposableContext context)
{
}

[When(@""I do something"")]
public void WhenIDoSomething()
{
if (DisposableContext.WasDisposed) throw new Exception(""context was disposed"");
}

[AfterFeature]
static public void AfterFeature()
{
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 246
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 250
 testRunner.And("a scenario \'Second Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 254
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded",
                        "Failed"});
            table6.AddRow(new string[] {
                        "1",
                        "1"});
#line 255
 testRunner.Then("the execution summary should contain", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
