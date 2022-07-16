using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumPractise;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumPractise
{
    public class SeleniumPractise
    {

        Browser_Ops browser = new Browser_Ops();
        string url = "https://demowf.aspnetawesome.com/";
        public IWebDriver driver;

        [SetUp]
        public void InitialiseBrowser()
        {
            browser.InitBrowser();          
        }

        [Test]
        public void TestBrowser()
        {
            browser.GoTo(url);
            Thread.Sleep(400);
            driver = browser.GetDriver();
            IWebElement dropdown = driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
            dropdown.SendKeys("Tomato");
            dropdown.SendKeys(Keys.Return);
            Thread.Sleep(400);
            IWebElement element2 = driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']"));
            element2.Click();
            IWebElement comboControl = driver.FindElement(By.CssSelector("#ContentPlaceHolder1_AllMealsCombo-awed"));
            comboControl.Clear();
            comboControl.SendKeys("Almond");
            driver.FindElement(By.CssSelector("li[data-val$= 'Almond']")).Click();
            //comboControl.SendKeys(Keys.Return);
            Console.WriteLine("test1");
        }

        [TearDown]
        public void CloseBrowser()
        {
            browser.Close();
        }
        
    }
}