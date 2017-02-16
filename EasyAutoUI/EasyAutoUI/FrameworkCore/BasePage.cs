using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EasyAutoUI.FrameworkCore
{
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; set; }

        public readonly string Url;

        protected BasePage(string url)
        {
            Driver = TestEnvironment.WebDriver;

            Url = url;

            Driver.Navigate().GoToUrl(url);

            //todo wait for page load if necessary

            PageFactory.InitElements(Driver, this);
        }
    }
}
