using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;


namespace BCYipsCore
{
    public class BCYips
    {
        private ChromeDriver _driver;
        private string homePageUrl = @"http://localhost:50783/Account/Login?ReturnUrl=%2f";
        public LoginPage StartAndLogin()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl(homePageUrl);

        

            return new LoginPage(_driver);
        }

        public void Quit()
        {
            _driver.Quit();
        }

    }
}
