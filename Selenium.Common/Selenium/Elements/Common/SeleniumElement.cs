using OpenQA.Selenium;
using NUnit.Framework;

namespace Selenium.Common.Selenium.Elements.Common
{
    public abstract class SeleniumElement
    {
        public By Locator { get; private set; }
        public string Name { get; private set; }
        public string IFrame { get; set; }

        public SeleniumElement(By locator, string name)
        {
            Locator = locator;
            Name = name;
        }

        public SeleniumElement(By locator, string name, string iFrame)
        {
            Locator = locator;
            Name = name;
            IFrame = iFrame;
        }

        public IWebElement Element
        {
            get 
            {
                SwitchToCorrectFrame();
                return DriverHelper.Driver.FindElement(Locator);
            } 
        }

        private void SwitchToCorrectFrame()
        {
            SwitchToDefaultFrame();
            if (IFrame != null && !IFrame.Equals(string.Empty))
                SwitchToIFrame();
        }

        private void SwitchToIFrame()
        {
            DriverHelper.Driver.SwitchTo().Frame(IFrame);
        }

        private void SwitchToDefaultFrame()
        {
            DriverHelper.Driver.SwitchTo().DefaultContent();  
        }

        public void Click()
        {
            Element.Click();
        }

        public void AssertIsDisplayed()
        {
            Assert.That(Element.Displayed, Is.True, "Assert Element is Displayed.");
        }
    }
}
