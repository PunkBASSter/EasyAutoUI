using EasyAutoUI.FrameworkCore;
using EasyAutoUI.FrameworkCore.SeleniumExtensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EasyAutoUI.Elements
{
    public class ResultTextBox : BaseElement
    {
        public ResultTextBox(By mainLocator) : base(mainLocator)
        {
        }

        public IWebElement Text => 
            By.CssSelector("#result_box > span").WaitFor(ExpectedConditions.ElementExists);

    }
}
