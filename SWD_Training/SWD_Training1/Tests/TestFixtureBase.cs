using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SWD_Training1.Pages;
using System;

namespace SWD_Training1.Tests
{
    [TestFixture]
    public abstract class TestFixtureBase<T> where T:BasePage
    {
        protected IWebDriver WebDriver { get; set; }

        [OneTimeSetUp]
        public void InitDriver()
        {
            WebDriver = new ChromeDriver();

            if (WebDriver == null)
                throw new ArgumentNullException("Failed to initialize web driver");

            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            WebDriver.Manage().Window.Maximize();
        }

        protected virtual T PageUnderTest { get; set; }
    }

}
