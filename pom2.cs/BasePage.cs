using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace pom2.cs
{
    class BasePage
    {
        public IWebDriver _Driver;

        public BasePage(IWebDriver Driver)
        {
            this._Driver = Driver;
        }

        public void HandelAlert()
        {
            IAlert alert = this._Driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
