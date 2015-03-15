using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace pom2.cs
{
    public class Class1
    {
        public IWebDriver Driver;

        [SetUp]
        public void Initialise()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
        }
        [Test]
        public void TestCase1()
        {
            LoginPage L = new LoginPage(Driver);
            PageFactory.InitElements(Driver,L);
            
           
          UserHomePage u= L.Login("abc", "abc");
          PageFactory.InitElements(Driver, u);
          u.verifyUserHomePage();
        }
        [Test]
        public void Testcase2()
        {
            LoginPage l = new LoginPage(Driver);
            PageFactory.InitElements(Driver, l);


            UserHomePage a = l.Login("abc", "abc");
            PageFactory.InitElements(Driver, a);
            a.verifyUserHomePage();
            a.GenerateBtn();

        }
        [Test]
        public void TestCase3()
        {
            LoginPage l = new LoginPage(Driver);
            PageFactory.InitElements(Driver, l);


            UserHomePage a = l.Login("abc", "abc");
            PageFactory.InitElements(Driver, a);

            a.EnterDetails("Mr.", "s", "xyz", "sfd", "female", "hindi");
        }
        [TearDown]
        public void quit()
        {
            Driver.Close();
        }

    }
}
