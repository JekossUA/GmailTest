using System;
using GmailTest.Helpers;
using OpenQA.Selenium;

namespace GmailTest.Pages
{
    public class PasswordEnterPage : DriverHelper
    {
        CustomControls customControls = new();
        IWebElement txtPasswordInput = Driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement btnNextButton = Driver.FindElement(By.XPath("//div[@id='passwordNext']"));
        
        public void ClickPasswordInput()
        {
            txtPasswordInput.Clear();
            txtPasswordInput.Click();
        }

        public void PastePassword(string password)
        {
            txtPasswordInput.SendKeys(password);
        }

        public void ClickNextButton()
        {
            btnNextButton.Click();
        }

        public void IsVisibleSearchInput(int timeInSeconds)
        {
            customControls.WaitElementIsVisible(timeInSeconds, By.XPath("//div[@jscontroller='unV4T']"));
        }
    }
}
