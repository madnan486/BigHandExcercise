using Selenium.Common.Selenium;
using TechTalk.SpecFlow;

namespace BigHandWebApp.Tests.TestRunner
{
    [Binding]
    public sealed class TestRunner
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            DriverHelper.CreateDriver(Browser.Chrome);
            DriverHelper.NavigateTo("https://www.bighand.com/en-gb");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            //DriverHelper.Driver.Close();
        }
    }
}
