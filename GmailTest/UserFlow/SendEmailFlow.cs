using System;
using System.Threading;
using GmailTest.Pages;

namespace GmailTest.Helpers
{
    public class SendEmailFlow
    {
        private int waitTimeInSeconds = 15;
        //private string expectedTextRu = "Письмо отправлено.";
        //private string expectedTextEn = "";

        internal void SendEmail(string sendEmailTo, string emailTheme, string emailText)
        {
            EmailBoxPage emailBoxPage = new();
            emailBoxPage.ClickCreateEmail(waitTimeInSeconds);
            emailBoxPage.IsVisibleSendToInput(waitTimeInSeconds);

            SendEmailPopup sendEmailPopup = new();
            sendEmailPopup.PasteSendToEmail(sendEmailTo);
            sendEmailPopup.PasteEmailTheme(emailTheme);
            sendEmailPopup.PasteEmailText(emailText);
            sendEmailPopup.ClickSendEmail();
            Thread.Sleep(5000);
            //sendEmailPopup.IsEmailSendedSuccessfully(waitTimeInSeconds);
        }

    }
}
