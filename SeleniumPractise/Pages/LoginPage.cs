using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractise.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement UsernameField => Driver.FindElement(By.Name("UserName"));
        IWebElement PasswordField => Driver.FindElement(By.Id("Password"));
        IWebElement LoginBtn => Driver.FindElement(By.CssSelector("input[value='Log in']"));

        public void EnterLoginDetails(string userName, string password)
        {
            UsernameField.SendKeys(userName);
            PasswordField.SendKeys(password);

        }

        public void ClickLogin()
        {
            LoginBtn.Click();
        }

    }
}
