using NUnit.Framework;
using OpenQA.Selenium;

namespace EasyAutoUI.FrameworkCore
{
    [TestFixture]
    public abstract class BaseTestFixture
    {
        protected IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void InitDriver()
        {
            Driver = TestEnvironment.WebDriver;
        }

        [OneTimeTearDown]
        public void DeinitDriver()
        {
            Driver.Close();
            Driver.Quit();
        }
    }

}
