using System;
using System.Threading;
using GmailTest.Pages;

namespace GmailTest.Helpers
{
    public class LoginFlow : DriverHelper
    {
        private int waitTimeInSeconds = 15;

        public void LoginToAccount(string email, string password)
        {
            MainPage mainPage = new();

            if (mainPage.IsDisplayedChangeAccountLink())
            {
                mainPage.ClickOnChangeAccountButton();
            }
            else
            {
                mainPage.IsVisibleEnterButton(waitTimeInSeconds);
                mainPage.ClickEnterButton();
                
            }

            mainPage.IsVisibleEmailInput(waitTimeInSeconds);
            EmailEnterPage emailEnterPage = new();
            emailEnterPage.ClickEmailInput();
            emailEnterPage.PasteEmailAdress(email);
            emailEnterPage.ClickNextButton();
            emailEnterPage.IsVisiblePasswordInput(waitTimeInSeconds);

            //TODO change IsVisibleSearchInput for second time(case 2 time login to gmail account)
            PasswordEnterPage passwordPage = new();
            passwordPage.ClickPasswordInput();
            passwordPage.PastePassword(password);
            passwordPage.ClickNextButton();
            Thread.Sleep(2000);
            //passwordPage.IsVisibleSearchInput(waitTimeInSeconds);
            Driver.Navigate().GoToUrl(Variables.gmailPageUrl);
        }
    }
}
