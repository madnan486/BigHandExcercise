using OpenQA.Selenium;
using Selenium.Common.Selenium.Elements.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Common.Selenium.Elements
{
    public class Label: SeleniumElement
    {
        public Label(By locator, string name, string iFrame) : base(locator, name, iFrame) { }
    }
}
