using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Common.Selenium.Elements.Common
{
    public class SeleniumTextElement:SeleniumElement
    {
        public SeleniumTextElement(By locator, string name, string iFrame) : base(locator, name, iFrame) { }
        public SeleniumTextElement(By locator, string name) : base(locator, name) { }

        public void SendKeys(string value)
        {
            Element.SendKeys(value);
        }
    }
}
