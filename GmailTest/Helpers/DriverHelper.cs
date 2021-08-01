using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GmailTest.Helpers
{
    public class DriverHelper
    {
        public static IWebDriver Driver { get; set; }
        public static WebDriverWait Wait { get; set; }
    }
}
