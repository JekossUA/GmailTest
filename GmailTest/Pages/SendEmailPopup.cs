using System;
using System.Collections.Generic;
using GmailTest.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace GmailTest.Pages
{
    public class SendEmailPopup : DriverHelper
    {
        CustomControls customControls = new();
        IWebElement txtSendTo = Driver.FindElement(By.XPath("//textarea[@name='to']"));
        IWebElement txtEmailTheme = Driver.FindElement(By.XPath("//input[@name='subjectbox']"));
        IWebElement txtEmailTextArea = Driver.FindElement(By.XPath("//div[@role='textbox']"));
        IList <IWebElement> btnSendEmailButton = Driver.FindElements(By.XPath("//div[@class='dC']"));
               
        public void PasteSendToEmail(string sendToEmail)
        {
            txtSendTo.Clear();
            txtSendTo.SendKeys(sendToEmail);
        }

        public void PasteEmailTheme(string emailTheme)
        {
            txtEmailTheme.Clear();
            txtEmailTheme.SendKeys(emailTheme);
        }

        public void PasteEmailText(string emailText)
        {
            txtEmailTextArea.Clear();
            txtEmailTextArea.SendKeys(emailText);
        }

        public void ClickSendEmail()
        {
            foreach (IWebElement elem in btnSendEmailButton)
            {
                elem.Click();

            }
        }

        // TODO need to write good method to check suuccessful email send text
        
        //("//div[@class='vh']//span[@class='aT']//span[contains(text(), 'Письмо отправлено.')]")
    }
}
