using OpenQA.Selenium;
using Selenium.Common.Selenium.Elements;
using Selenium.Common.Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHandWebApp.Application.Pages
{
    public class Home
    {
        public Button ContactUs => new Button(By.CssSelector(".mx-1"), "Contact Us");

    }
}
