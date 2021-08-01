using System;
using GmailTest.Helpers;
using OpenQA.Selenium;

namespace GmailTest.Pages
{
    public class EmailEnterPage : DriverHelper
    {
        CustomControls customControls = new();
        IWebElement txtEmailInput = Driver.FindElement(By.XPath("//input[@id='identifierId']"));
        IWebElement btnNextButton = Driver.FindElement(By.XPath("//div[@id='identifierNext']"));
        
        public void ClickEmailInput()
        {
            txtEmailInput.Clear();
            txtEmailInput.Click();
        }

        public void PasteEmailAdress(string email)
        {
            txtEmailInput.SendKeys(email);
        }

        public void ClickNextButton()
        {
            btnNextButton.Click();
        }

        public void IsVisiblePasswordInput(int timeInSeconds)
        {
            customControls.WaitElementIsVisible(timeInSeconds, By.XPath("//input[@name='password']"));
        }

    }
}
