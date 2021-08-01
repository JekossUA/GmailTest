using System;
using GmailTest.Helpers;
using OpenQA.Selenium;

namespace GmailTest.Pages
{
    public  class MainPage : DriverHelper
    {
        CustomControls customControls = new();              

        public void ClickEnterButton()
        {
            IWebElement btnEnterButton = Driver.FindElement(By.XPath("//a[@class='gb_3 gb_4 gb_9d gb_3c']"));
            btnEnterButton.Click();
        }

        public void IsVisibleEnterButton(int timeInSeconds)
        {
            By byEnterButton = By.XPath("//a[@class='gb_3 gb_4 gb_9d gb_3c']");
            customControls.WaitElementIsVisible(timeInSeconds, byEnterButton);
        }

        public void IsVisibleEmailInput(int timeInSeconds)
        {
            customControls.WaitElementIsVisible(timeInSeconds, By.XPath("//input[@id='identifierId']"));
        }

        public bool IsDisplayedChangeAccountLink()
        {
            
            return customControls.VerifyElementIsDisplayed(By.XPath("//div[@jsname='rwl3qc']"));
        }

        public void ClickOnChangeAccountButton()
        {
            IWebElement byChangeAccountButton = Driver.FindElement(By.XPath("//div[@jsname='rwl3qc']"));
            byChangeAccountButton.Click();
        }

    }
}
