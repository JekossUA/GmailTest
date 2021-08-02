using System;
using GmailTest.Helpers;
using GmailTest.UserFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace GmailTest
{
    public class Tests : DriverHelper
    {
        public int numberOfEmailsBefore;
        public int numberOfEmailsAfter;

        [SetUp]
        public void Setup()
        {

            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-notifications");
                Driver = new ChromeDriver(options);
                Driver.Navigate().GoToUrl(Variables.mainPageUrl);
                Driver.Manage().Window.Maximize();

                LoginFlow loginFlow = new();
                loginFlow.LoginToAccount(Variables.secondUserEmail, Variables.firstAndSecondUserPassword);

                NumberOfEmailFlow numberOfEmail = new();
                numberOfEmailsBefore = numberOfEmail.ReturnNumberOfEmails();

                LogOutFlow logOutFlow = new();
                logOutFlow.LogOut();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            
            
        }

        [Test]
        public void Test1()
        {
            try
            {
                LoginFlow loginFlow = new();
                loginFlow.LoginToAccount(Variables.firstUserEmail, Variables.firstAndSecondUserPassword);

                SendEmailFlow sendEmailFlow = new();
                sendEmailFlow.SendEmail(Variables.secondUserEmail, Variables.emailTheme, Variables.emailText);

                LogOutFlow logOutFlow = new();
                logOutFlow.LogOut();

                loginFlow.LoginToAccount(Variables.secondUserEmail, Variables.firstAndSecondUserPassword);

                NumberOfEmailFlow numberOfEmail = new();
                numberOfEmailsAfter = numberOfEmail.ReturnNumberOfEmails();

                Assert.Less(numberOfEmailsBefore, numberOfEmailsAfter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Driver.Close();
            }
            
            
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Close();
        }
    }
}
