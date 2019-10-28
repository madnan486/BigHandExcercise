using BigHandWebApp.Tests.StepDefinations.Common;
using System;
using TechTalk.SpecFlow;

namespace BigHandWebApp.Tests.StepDefinations
{
    [Binding]
    public class BigHandExcerciseTestSteps : CommonSteps
    {
        [Given]
        public void Given_I_am_on_the_homepage()
        {
            WebApp.Home.ContactUs.AssertIsDisplayed();
        }
        
        [Given]
        public void Given_I_click_on_ContactUs()
        {
            WebApp.Home.ContactUs.Click();
        }
        
        [Given]
        public void Given_ContactUs_form_is_displayed()
        {
            WebApp.ContactUs.FirstName.AssertIsDisplayed();
        }
        
        [Given]
        public void Given_I_type_P0_in_first_name_field(string p0)
        {
            WebApp.ContactUs.FirstName.SendKeys("Hello World");
        }
        
        [When]
        public void When_I_click_submit()
        {
            WebApp.ContactUs.Submit.Click();
        }
        
        [Then]
        public void Then_the_error_message_is_displayed()
        {
            WebApp.ContactUs.ErrorText.AssertIsDisplayed();
        }
    }
}
