using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumPractise;
using SeleniumPractise.Pages;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumPractise
{
    public class SeleniumPractise : DriverHelper
    {

        //Browser_Ops browser = new Browser_Ops();
        //string url = "https://demowf.aspnetawesome.com/";
        


        [SetUp]
        public void InitialiseBrowser()
        {
            //browser.InitBrowser();
            Driver = new ChromeDriver();
        }

        [Test]
        public void TestBrowser()
        {
            //browser.GoTo(url);
            //Thread.Sleep(400);
            //Driver = browser.GetDriver();
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            IWebElement dropdown = Driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
            dropdown.SendKeys("Tomato");
            dropdown.SendKeys(Keys.Return);
            Thread.Sleep(400);
            IWebElement cookie = Driver.FindElement(By.Id("btnCookie"));
            cookie.Click();
            IWebElement element2 = Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']"));
            element2.Click();
            IWebElement comboControl = Driver.FindElement(By.CssSelector("#ContentPlaceHolder1_AllMealsCombo-awed"));
            comboControl.Clear();
            comboControl.SendKeys("Almond");
            Driver.FindElement(By.CssSelector("li[data-val$= 'Almond']")).Click();
            //comboControl.SendKeys(Keys.Return);
            Console.WriteLine("test1");
        }

        [Test]
        public void LoginTest()
        {
            //browser.GoTo("http://eaapp.somee.com/");
           // Thread.Sleep(400);
            //Driver = browser.GetDriver();
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterLoginDetails("admin", "password");
            loginPage.ClickLogin();
            Assert.That(homePage.DoesLogOffExist, Is.True, "log off button is not displayed");
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Close();
        }
        
    }
}