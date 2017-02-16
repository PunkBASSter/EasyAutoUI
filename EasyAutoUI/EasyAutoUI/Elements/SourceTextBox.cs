using EasyAutoUI.FrameworkCore;
using EasyAutoUI.FrameworkCore.SeleniumExtensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EasyAutoUI.Elements
{
    public class SourceTextBox : BaseElement
    {
        public SourceTextBox(By mainLocator) : base(mainLocator)
        {
        }

        public IWebElement Input => Driver.FindElement(MainLocator)
            .FindElement(By.Id("source")).WaitFor(ExpectedConditions.ElementToBeClickable);
    }
}
