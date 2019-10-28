using OpenQA.Selenium;
using System;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace Selenium.Common.Selenium
{
    public static class DriverHelper
    {
        public static IWebDriver Driver { get; private set; }
        private static TimeSpan DriverWait = TimeSpan.FromSeconds(30);

        public static void CreateDriver(Browser browser)
        {
            switch (browser)
            {
                case Browser.IE:
                    Driver = new InternetExplorerDriver();
                    break;
                case Browser.Chrome:
                    Driver = new ChromeDriver();
                    break;
                default:
                    throw new System.Exception("Unable to find desired browser implementation");
            }
            Driver.Manage().Timeouts().ImplicitWait = (DriverWait);
            Driver.Manage().Window.Maximize();
        }

        public static void Close()
        {
            Driver.Dispose();
            Driver.Close();
            Driver.Quit();
        }

        public static IJavaScriptExecutor GetJsExecutor()
        {
            return (IJavaScriptExecutor)Driver;
        }

        public static IWebDriver GetDriver()
        {
            return Driver;
        }

        public static void NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
