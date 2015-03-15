using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace pom2.cs
{
    class LoginPage:BasePage
    {
        [FindsBy(How = How.Name,Using = "UserName")]
        IWebElement txtUsername;

        [FindsBy(How = How.Name, Using = "Password")]
        IWebElement txtPassword;

        [FindsBy(How = How.CssSelector, Using = "input[Value='Login']")]
        IWebElement btnLogin;

        public LoginPage(IWebDriver Driver):base(Driver)
        {

        }

        public UserHomePage Login(string UserName,string Password)
        {
            
            txtUsername.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            btnLogin.Click();

            return new UserHomePage(base._Driver);
        }
       
    }
}
