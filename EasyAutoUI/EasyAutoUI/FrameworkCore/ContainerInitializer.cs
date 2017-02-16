using Microsoft.Practices.Unity;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EasyAutoUI.FrameworkCore
{
    public class ContainerInitializer
    {
        public IUnityContainer Init()
        {
            var container = new UnityContainer();

            //Register dependencies here
            container.RegisterType(typeof(IWebDriver), new PerThreadLifetimeManager(), new InjectionFactory(f => CreateWebDriver()));

            return container;
        }

        private static IWebDriver CreateWebDriver()
        {
            //todo implement a full driver factory
#if true
            return new ChromeDriver();
#else
            //use remote web driver
#endif
        }
    }
}
