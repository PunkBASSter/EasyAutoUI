using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SWD_Training1.Elements;

namespace SWD_Training1.Pages
{
    public class MainPage : BasePage
    {
        public override string Url { get; set; } = "https://translate.google.com/#en/ru/";

        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "#gt-sl-gms")]
        public LanguageDropdown LeftLanguageDropdown;
    }
}
