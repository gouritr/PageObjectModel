using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace pom2.cs
{
    class UserHomePage:BasePage
    {
        [FindsBy(How = How.Name, Using = "TitleId")]
        IWebElement dropdownTitle;

          [FindsBy(How = How.Id, Using = "Initial")]
        IWebElement txtInitial;

          [FindsBy(How = How.Id, Using = "FirstName")]
        IWebElement txtFName;

          [FindsBy(How = How.Id, Using = "MiddleName")]
        IWebElement txtMName;

          [FindsBy(How = How.CssSelector, Using = "input[type='radio']")]
        IList<IWebElement> radioGender;

          [FindsBy(How = How.CssSelector, Using = "input[ type='checkbox']")]
        IList<IWebElement> chklLang;

          [FindsBy(How = How.Name, Using = "Save")]
          IWebElement btnsave;

          [FindsBy(How = How.Name, Using = "generate")]
          IWebElement btnGenerate;

        public UserHomePage(IWebDriver Driver):base (Driver)
        {

        }

        public void verifyUserHomePage()
        {
            try
            {
                base._Driver.FindElement(By.Name("Save"));
            }
            catch(NoSuchElementException ex){
                Assert.Fail();
                Console.WriteLine("Exception Occured {0}",ex.Message);
            }
        }

        public void GenerateBtn()
        {
            btnGenerate.Click();
            base.HandelAlert();
            base.HandelAlert();
        }

        public void EnterDetails(string title,string initial,string fname,string mname,string gender,string language){
            SelectElement selectelement = new SelectElement(dropdownTitle);
            selectelement.SelectByText(title);

            txtInitial.SendKeys(initial);
            txtFName.SendKeys(fname);
            txtMName.SendKeys(mname);

            foreach(IWebElement e in radioGender)
            {
                if(e.GetAttribute("value")== gender)
                {
                    e.Click();
                }
            }
            foreach(IWebElement e in chklLang)
            {
                if(e.GetAttribute("value")== language)
                {
                    e.Click();
                }
            }
            btnsave.Click();

        }











    }
}
