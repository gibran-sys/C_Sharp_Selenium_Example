using System;
using NUnit.Framework;
using BCYipsCore;


namespace BCYipsUiTests
{

    [TestFixture]
    public class UiTests
    {
     
        private BCYips _bCYips;
      



        [SetUp]      
        public void SetUp()
        {
        
        _bCYips = new BCYips();
        
        }

        [TearDown]
        public void TearDown()
        {
            _bCYips.Quit();
        }

        [Test]
        public void SignIn_SignOut_ShouldWork()
        {
           

           LoginPage Start_Log =  _bCYips.StartAndLogin();
   

          

            Start_Log.Input_UserName("user");
           Start_Log.Input_Password("password");

          HomePage homepage = Start_Log.ClickSubmitButton();

       
          string expected = "Home Page - BC Yips!";
          Assert.AreEqual(expected, homepage.HomePageClassAttributeValue());




         



         




      
        
        
        }

        [Test]
        public void SignIn_SignOut_ShouldWork2()
        {


            LoginPage Start_Log = _bCYips.StartAndLogin();
          



            Start_Log.Input_UserName("pinkfloyd");
            Start_Log.Input_Password("password");

            HomePage homepage = Start_Log.ClickSubmitButton();


            string expected = "Home Page - BC Yips!";
            Assert.AreEqual(expected, homepage.HomePageClassAttributeValue());
















        }
        [Test]
        public void Blank_User_Should_Not_Work()
    {
        LoginPage Start_Log = _bCYips.StartAndLogin();
      



        Start_Log.Input_UserName("");
        Start_Log.Input_Password("password");

        HomePage homepage = Start_Log.ClickSubmitButton();


        string expected = "The User name field is required.";
        Assert.AreEqual(expected, Start_Log.Blank_User_Error_Message()); 
         

    }

        [Test]
        public void Blank_Password_Should_Not_Work()
        {
            LoginPage Start_Log = _bCYips.StartAndLogin();
         



            Start_Log.Input_UserName("user");
            Start_Log.Input_Password("");

            HomePage homepage = Start_Log.ClickSubmitButton();


            string expected = "The Password field is required.";
            Assert.AreEqual(expected, Start_Log.Blank_Password_Error_Message()); 
         

        }

        [Test]
        public void Blank_UserName_And_Password_Should_Not_Work()
        {
            LoginPage Start_Log = _bCYips.StartAndLogin();
           



            Start_Log.Input_UserName("");
            Start_Log.Input_Password("");

            HomePage homepage = Start_Log.ClickSubmitButton();

            string expected1 = "The Password field is required.";
            string expected2 = "The User name field is required.";
            Assert.AreEqual(expected1, Start_Log.Blank_Password_Error_Message());
            Assert.AreEqual(expected2, Start_Log.Blank_User_Error_Message());


        }
        [Test]
        public void Space_Before_Username_Should_Not_Work()
        {
            LoginPage Start_Log = _bCYips.StartAndLogin();
     



            Start_Log.Input_UserName(" user");
            Start_Log.Input_Password("password");

            HomePage homepage = Start_Log.ClickSubmitButton();

            string expected = "The user name or password provided is incorrect.";
            Assert.AreEqual(expected, Start_Log.Invalid_UserName_Password_submitted());

        }

        [Test]
        public void Space_Before_Password_Should_Not_Work()
        {
            LoginPage Start_Log = _bCYips.StartAndLogin();
          



            Start_Log.Input_UserName("user");
            Start_Log.Input_Password(" password");

            HomePage homepage = Start_Log.ClickSubmitButton();

            string expected = "The user name or password provided is incorrect.";
            Assert.AreEqual(expected, Start_Log.Invalid_UserName_Password_submitted());

        }

        [Test]
        public void invalid_Username_Should_Not_Work()
        {
            LoginPage Start_Log = _bCYips.StartAndLogin();
    



            Start_Log.Input_UserName("greg");
            Start_Log.Input_Password("password");

            HomePage homepage = Start_Log.ClickSubmitButton();

            string expected = "The user name or password provided is incorrect.";
            Assert.AreEqual(expected, Start_Log.Invalid_UserName_Password_submitted());

        }

        [Test]
        public void invalid_Password_Should_Not_Work()
        {
            LoginPage Start_Log = _bCYips.StartAndLogin();
         



            Start_Log.Input_UserName("user");
            Start_Log.Input_Password("pie");

            HomePage homepage = Start_Log.ClickSubmitButton();

            string expected = "The user name or password provided is incorrect.";
            Assert.AreEqual(expected, Start_Log.Invalid_UserName_Password_submitted());

        }

        [Test]
        public void invalid_Username_Password_Should_Not_Work()
        {
            LoginPage Start_Log = _bCYips.StartAndLogin();
        



            Start_Log.Input_UserName("peter");
            Start_Log.Input_Password("paul23");

            HomePage homepage = Start_Log.ClickSubmitButton();

            string expected = "The user name or password provided is incorrect.";
            Assert.AreEqual(expected, Start_Log.Invalid_UserName_Password_submitted());

        }


    }
}
