using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace BCYipsCore
{
    public class HomePage : BasePage
    {
        private By _signOutButton = By.XPath(@"//input[@id = 'logoutForm']");
        

         public HomePage(RemoteWebDriver driver) : base(driver)
      {

       
      
      }

         public void ClickSignOutButton()
         {

             _driver.FindElementByXPath("//input[@id = 'logoutForm']").Click();

         }


         public string HomePageClassAttributeValue()
         {

             
             return _driver.Title; 

         } 
    }
}
