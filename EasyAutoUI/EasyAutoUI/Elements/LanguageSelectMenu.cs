using System.Collections.Generic;
using System.Linq;
using EasyAutoUI.FrameworkCore;
using EasyAutoUI.FrameworkCore.SeleniumExtensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EasyAutoUI.Elements
{
    public class LanguageSelectMenu : BaseElement
    {
        private readonly By _buttonLocator;
        private readonly By _dropdownLocator;
        private IDictionary<string, IWebElement> _languagesCache;

        public LanguageSelectMenu(By mainLocator, By buttonLocator, By dropdownLocator) : base(mainLocator)
        {
            _buttonLocator = buttonLocator;
            _dropdownLocator = dropdownLocator;
        }

        private IWebElement[] _langPanel;
        public IWebElement[] LangPanel
        {
            get
            {
                _langPanel = _langPanel ?? MainLocator.WaitFor(ExpectedConditions.ElementToBeClickable)
                    .FindElements(By.TagName("div")).ToArray();
                return _langPanel;
            }
        }
        
        private IWebElement _button;
        public IWebElement Button
        {
            get
            {
                _button = _button ?? _buttonLocator.WaitFor(ExpectedConditions.ElementToBeClickable);
                return _button;
            }
        }

        private IWebElement _dropdown;
        public IWebElement Dropdown
        {
            get
            {
                if (_dropdown == null)
                {
                    Button?.Click();
                    _dropdown = _dropdownLocator.WaitFor(ExpectedConditions.ElementToBeClickable);
                }

                return _dropdown;
            }
        }

        public void Show()
        {
            if (!Dropdown.Displayed)
                Button.Click();

            _dropdownLocator.WaitFor(ExpectedConditions.ElementToBeClickable);
        }

        public void Hide()
        {
            if (Dropdown.Displayed)
                Button.Click();
        }

        public IDictionary<string, IWebElement> GetLanguages()
        {
            Show();

            var languages =
                Dropdown.FindElements(By.CssSelector(@"div[class=""goog-menuitem-content""]"))
                .ToDictionary(t => t.Text);

            return languages;
        }

        public string SelectLanguage(string pattern)
        {
            IWebElement res;

            if(_languagesCache == null)
                _languagesCache = GetLanguages();
            else
                Show();

            var found = _languagesCache.TryGetValue(pattern, out res);

            if (!found) return null;

            Show();
            res.Click();
            return pattern;
        }

        public string GetSelectedLanguage()
        {
            return LangPanel.FirstOrDefault(l => l.GetAttribute("aria-pressed") == "true")?.Text ;
        }

        public string[] GetSelectedLanguages()
        {
            return LangPanel.Select(l => l.Text).ToArray();
        }

    }
}
