using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace SWD_Training1.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver WebDriver { get; set; }

        public abstract string Url { get; set; }

        public BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        
    }
}
