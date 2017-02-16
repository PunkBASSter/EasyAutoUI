using OpenQA.Selenium;

namespace EasyAutoUI.FrameworkCore
{
    public abstract class BaseElement
    {
        protected readonly By MainLocator; 
        public readonly IWebDriver Driver;

        protected BaseElement(By mainLocator)
        {
            MainLocator = mainLocator;
            Driver = TestEnvironment.WebDriver;
        }
    }
}
