using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SWD_Training1.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver WebDriver { get; set; }

        public BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}
