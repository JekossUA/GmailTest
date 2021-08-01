using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace GmailTest.Helpers
{
    public class CustomControls : DriverHelper
    {
        
        public static WebDriverWait ChromeWaiter(int timeInSeconds) => new WebDriverWait(Driver, TimeSpan.FromSeconds(timeInSeconds));
        
        
        public void WaitElementIsVisible(int timeInSeconds, By elementByPath)
        {
            ChromeWaiter(timeInSeconds).Until(ExpectedConditions.ElementIsVisible(elementByPath));
        }

        public void WaitElementInvisibility(int timeInSeconds, By elementByPath)
        {
            ChromeWaiter(timeInSeconds).Until(ExpectedConditions.InvisibilityOfElementLocated(elementByPath));
        }

        public void WaitElementIsClickable(int timeInSeconds, By elementByPath)
        {
            ChromeWaiter(timeInSeconds).Until(ExpectedConditions.ElementToBeClickable(elementByPath));
        }

        //TODO change VerifyElementIsInvisible without Thread.Sleep(2000);
        public bool VerifyElementIsDisplayed(By elementByPath)
        {
            Thread.Sleep(4000);
            try
            {
                return Driver.FindElement(elementByPath).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }         
                        
        }

        // TODO need to write good method to check suuccessful email send text

    }
}
