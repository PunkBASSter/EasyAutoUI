using Microsoft.Practices.Unity;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EasyAutoUI.FrameworkCore
{
    [SetUpFixture]
    public static class TestEnvironment
    {
        static TestEnvironment()
        {
            Container = new ContainerInitializer().Init();
        }

        public static IUnityContainer Container { get; private set; }

        public static IWebDriver WebDriver
        {
            get
            {
                var driver = Container.Resolve<IWebDriver>();

                if (driver == null)
                    Assert.Fail("Failed to initialize web driver");

             //Uncomment the following to customize timeouts.
                //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
                //driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(5));
                //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));

                driver.Manage().Window.Maximize();

                return driver;
            }
        }
    }
}
