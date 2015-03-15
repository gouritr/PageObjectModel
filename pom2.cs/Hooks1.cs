using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;


namespace pom2.cs
{
    [Binding]
    public class Hooks1:BaseStepDefinition
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
