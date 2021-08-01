using System;
using GmailTest.Helpers;
using GmailTest.Pages;

namespace GmailTest.UserFlow
{
    public class LogOutFlow : DriverHelper
    {
        private int waitTimeInSeconds = 15;

        public void LogOut()
        {
            LogOutPopup logOutPopup = new();
            logOutPopup.ClickOnUserIcon();
            logOutPopup.WaitLogOutButtonIsVisible(waitTimeInSeconds);
            logOutPopup.ClickLogOutButton();
            logOutPopup.IsVisibleChangeAccountLink(waitTimeInSeconds);
        }

    }
}
