using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractise
{
    public class Browser_Ops
    {
        IWebDriver Driver;

        public void InitBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public string Title()
        {
            return Driver.Title;
        }

        public void GoTo(string url)
        {
            Driver.Url = url;
        }

        public void Close()
        {
            Driver.Quit();
        }

        public IWebDriver GetDriver()
        {
            return Driver;
        }
    }

}
