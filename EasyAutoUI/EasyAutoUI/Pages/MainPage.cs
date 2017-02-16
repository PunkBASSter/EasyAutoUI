using EasyAutoUI.Elements;
using EasyAutoUI.FrameworkCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EasyAutoUI.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(string url) : base(url)
        {
        }

        [FindsBy(How = How.Id, Using = "gt-swap")]
        public IWebElement LanguageSwapButton;

        [FindsBy(How = How.Id, Using = "gt-submit")]
        public IWebElement SubmitButton;

        private LanguageSelectMenu _leftLanguageSelectMenu;
        public LanguageSelectMenu LeftLanguageSelectMenu
        {
            get
            {
                _leftLanguageSelectMenu = _leftLanguageSelectMenu ?? new LanguageSelectMenu(By.Id("gt-lang-src"), By.Id("gt-sl-gms"), By.Id("gt-sl-gms-menu"));
                return _leftLanguageSelectMenu;
            }
        }

        private LanguageSelectMenu _rightLanguageSelectMenu;
        public LanguageSelectMenu RightLanguageSelectMenu
        {
            get
            {
                _rightLanguageSelectMenu = _rightLanguageSelectMenu ?? new LanguageSelectMenu(By.Id("gt-lang-tgt"), By.Id("gt-tl-gms"), By.Id("gt-tl-gms-menu"));
                return _rightLanguageSelectMenu;
            }
        }

        private ResultTextBox _result;
        public ResultTextBox Result
        {
            get
            {
                _result = _result ?? new ResultTextBox(By.Id("gt-res-wrap"));
                return _result;
            }
        }

        private SourceTextBox _sourceTextBox;
        public SourceTextBox Source
        {
            get
            {
                _sourceTextBox = _sourceTextBox ?? new SourceTextBox(By.Id("gt-src-wrap"));
                return _sourceTextBox;
            }
        }
    }
}
