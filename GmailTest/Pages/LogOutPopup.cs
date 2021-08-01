using System;
using GmailTest.Helpers;
using OpenQA.Selenium;

namespace GmailTest.Pages
{
    public class LogOutPopup : DriverHelper
    {
        CustomControls customControls = new();
        IWebElement imgUser = Driver.FindElement(By.XPath("//img[@class='gb_Ca gbii']"));
        
        public void ClickOnUserIcon()
        {
            imgUser.Click();
        }

        public void WaitLogOutButtonIsVisible(int timeInSeconds)
        {
            By byLogOutButton = By.XPath("//a[@id='gb_71']");
            customControls.WaitElementIsVisible(timeInSeconds, byLogOutButton);
        }

        public void ClickLogOutButton()
        {
            IWebElement btnLogOutButton = Driver.FindElement(By.XPath("//a[@id='gb_71']"));
            btnLogOutButton.Click();
        }

        public void IsVisibleChangeAccountLink(int timeInSeconds)
        {
            customControls.WaitElementIsVisible(timeInSeconds, By.XPath("//div[@jsname='rwl3qc']"));
        }

    }
}
