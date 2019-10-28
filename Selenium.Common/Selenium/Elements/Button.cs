using OpenQA.Selenium;
using Selenium.Common.Selenium.Elements.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Common.Selenium.Elements
{
    public class Button : SeleniumElement
    {
        public Button(By locator, string name) : base(locator, name) { }
        public Button(By locator, string name, string iFrame) : base(locator, name, iFrame) { }
    }
}
