using System;
using System.Collections.Generic;
using GmailTest.Helpers;
using OpenQA.Selenium;

namespace GmailTest.Pages
{
    public class EmailBoxPage : DriverHelper
    {
        CustomControls customControls = new();
        
        public void ClickCreateEmail(int timeInSeconds)
        {
            customControls.WaitElementIsVisible(timeInSeconds, By.XPath("//div[@gh='cm']"));
            IWebElement btnWriteEmailButton = Driver.FindElement(By.XPath("//div[@gh='cm']"));
            btnWriteEmailButton.Click();
        }

        public void IsVisibleSendToInput(int timeInSeconds)
        {
            customControls.WaitElementIsVisible(timeInSeconds, By.XPath("//textarea[@name='to']"));
        }

        public int CheckNumberOfEmails()
        {
            IList<IWebElement> tbEmailBox = Driver.FindElements(By.XPath("//table[@id=':23']//tbody//tr"));
            return tbEmailBox.Count;

        }

        public int ReturnNumberOfEmails(int timeInSeconds)
        {
            CustomControls customControls = new();
            EmailBoxPage emailBoxPage = new();

            if (!customControls.VerifyElementIsDisplayed(By.XPath("//table[@id=':23']//tbody//tr")))
            {
                return 0;
            }
            else
            {
                customControls.WaitElementIsVisible(timeInSeconds, By.XPath("//table[@id=':23']//tbody//tr"));
                return emailBoxPage.CheckNumberOfEmails();
            }
            
        }
    }
}
