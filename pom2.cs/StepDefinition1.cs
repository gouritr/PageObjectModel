using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Support.PageObjects;


namespace pom2.cs
{
    [Binding]
    public class StepDefinition1:BaseStepDefinition
    {
         UserHomePage a;
         LoginPage l;
         

        [Given(@"User On a home page")]
        public void GivenUserOnAHomePage()
        {
             l = new LoginPage(Driver);
            PageFactory.InitElements(Driver, l);


            a = l.Login("abc", "abc");
            PageFactory.InitElements(Driver, a);
        }

        [When(@"User Enter below details and click save")]
        public void WhenUserEnterBelowDetailsAndClickSave(Table table)
        {
            var details = table.CreateInstance<userdetails>();
            Console.WriteLine(details.Title,details.initial, details.FirstNAme, details.MiddleNAme, details.Gender, details.Language);
            
            a.EnterDetails(details.Title,details.initial, details.FirstNAme, details.MiddleNAme, details.Gender, details.Language);
            
        }

        [Then(@"Userdetails should be saved")]
        public void ThenUserdetailsShouldBeSaved()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
