using System;
using GmailTest.Helpers;
using GmailTest.Pages;

namespace GmailTest.UserFlow
{
    public class NumberOfEmailFlow : DriverHelper
    {
        private int timeInSeconds = 15;

        public int ReturnNumberOfEmails()
        {
            EmailBoxPage emailBoxPage = new();
            return emailBoxPage.ReturnNumberOfEmails(timeInSeconds);

        }
    }
}
