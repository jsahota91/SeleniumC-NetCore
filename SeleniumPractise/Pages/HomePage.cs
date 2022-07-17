using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace SeleniumPractise.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement LoginLnk => Driver.FindElement(By.Id("loginLink"));
        IWebElement LogOffLnk => Driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => LoginLnk.Click();

        public bool DoesLogOffExist() => LogOffLnk.Displayed;
    }
}
