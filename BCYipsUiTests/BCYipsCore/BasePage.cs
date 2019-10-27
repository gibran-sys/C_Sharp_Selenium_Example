using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace BCYipsCore
{
   abstract public class BasePage
    {
        protected RemoteWebDriver _driver;

        public BasePage(RemoteWebDriver driver)
        {
            _driver = driver;

         



        }

        protected IWebElement Element(By locator)
        {
            return _driver.FindElement(locator);
        }
    }
}
