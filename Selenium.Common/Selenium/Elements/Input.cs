using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Common.Selenium.Elements.Common
{
    public class Input: SeleniumTextElement
    {
        public Input(By locator, string name, string Iframe):base(locator, name, Iframe)
        {

        }
    }
}
