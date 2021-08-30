using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {

        string url = "http://eaapp.somee.com/";

        private IWebDriver _driver;

        [TestMethod]
        public void NavigateToPage()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(url);

            Login();
        }

        public void Login()
        {
            _driver.FindElement(By.LinkText("Login")).Click();

            _driver.FindElement(By.Id("UserName")).SendKeys("admin");
            _driver.FindElement(By.Id("Password")).SendKeys("password");

            _driver.FindElement(By.CssSelector("input.btn")).Submit();
        }


    }
}
