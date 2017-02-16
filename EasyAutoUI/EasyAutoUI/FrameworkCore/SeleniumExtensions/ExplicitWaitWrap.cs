using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EasyAutoUI.FrameworkCore.SeleniumExtensions
{
    public static class ExplicitWaitWrap
    {
        public static IWebElement WaitFor(this By by, Func<By, Func<IWebDriver, IWebElement>> expectedConditionDelegate, int timeoutMs = 2000)
        {
            var driver = TestEnvironment.WebDriver;

            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeoutMs));
            return wait.Until(expectedConditionDelegate.Invoke(by));
        }

        public static IWebElement WaitFor(this IWebElement element, Func<IWebElement, Func<IWebDriver, IWebElement>> expectedConditionDelegate, int timeoutMs = 2000)
        {
            var driver = TestEnvironment.WebDriver;

            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeoutMs));
            return wait.Until(expectedConditionDelegate.Invoke(element));
        }

        public static bool FitsCondition(this IWebElement element, string text, Func<IWebElement, string, Func<IWebDriver, bool>> expectedConditionDelegate, int timeoutMs = 2000)
        {
            var driver = TestEnvironment.WebDriver;

            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeoutMs));
            return wait.Until(expectedConditionDelegate.Invoke(element,text));
        }

        //public static IWebElement FitsCondition(this IWebElement element, By by, Func<By, Func<IWebDriver, IWebElement>> expectedConditionDelegate, int timeoutMs = 2000)
    }
}
