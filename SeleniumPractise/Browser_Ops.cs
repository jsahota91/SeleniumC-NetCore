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
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public string Title()
        {
            return driver.Title;
        }

        public void GoTo(string url)
        {
            driver.Url = url;
        }

        public void Close()
        {
            driver.Quit();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }
    }

}
