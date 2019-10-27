using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace BCYipsCore
{
    public class LoginPage : BasePage
    {
        private string _formsInputUserName = "//input[@id = 'UserName']";
        private string _formsInputPassWord = "//input[@id = 'Password']";
        private string _userNamelabel = "//span[@class='' and @for='UserName' and @generated='true']";
        private string _passwordLabel = "//span[@class='' and @for='Password' and @generated='true']";
        private string _submitButton = "//input[@type='submit' and @value='Sign in']";
        private string _ErrorLabel = "//*[@class='validation-summary-errors']//li[text()='The user name or password provided is incorrect.']";



      public LoginPage(RemoteWebDriver driver) : base(driver)
      {

         

        
      
      }



        public void Input_UserName(string usrName)
        {

            _driver.FindElementByXPath(_formsInputUserName).SendKeys(usrName);

            
        
        }

        public void Input_Password(string passWord)
        {

            _driver.FindElementByXPath(_formsInputPassWord).SendKeys(passWord);
        
        }

        public string Blank_User_Error_Message()
        {

            return _driver.FindElementByXPath(_userNamelabel).Text; 
            
        }

        public string Blank_Password_Error_Message()
        {
            return _driver.FindElementByXPath(_passwordLabel).Text; 
        }

        public string Invalid_UserName_Password_submitted()
        {
            return _driver.FindElementByXPath(_ErrorLabel).Text; 
        }
        

        public HomePage ClickSubmitButton()
        {
         


            _driver.FindElementByXPath(_submitButton).Click(); 
            return new HomePage(_driver); 
            
            
        }

      

    }
}
