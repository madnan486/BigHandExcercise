using OpenQA.Selenium;
using Selenium.Common.Selenium.Elements;
using Selenium.Common.Selenium.Elements.Common;
using Selenium.Common.Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHandWebApp.Application.Pages
{
    public class ContactUs : Page
    {
        public Input FirstName => new Input(By.XPath("//div[contains(@class,'first_name')]/input"), "First Name", "iframe-pardot-form");
        public Button Submit => new Button(By.XPath("//input[@type='submit']"), "Submit", "iframe-pardot-form");
        public Label ErrorText => new Label(By.XPath("//p[@class='errors']"), "Error Text", "iframe-pardot-form");
        public ContactUs():base("Contact Us") { }
    }
}
