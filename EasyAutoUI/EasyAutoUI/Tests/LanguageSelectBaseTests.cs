using EasyAutoUI.Actions;
using EasyAutoUI.FrameworkCore;
using EasyAutoUI.Pages;
using NUnit.Framework;

namespace EasyAutoUI.Tests
{
    [Parallelizable]
    public class LanguageSelectBaseTests : BaseTestFixture
    {
        private MainPage _mainPage;

        public static object[] SelectLanguageCases;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _mainPage = new MainPage("https://translate.google.ru/");
        }

        [Test]
        [TestCase("русский")]
        [TestCase("английский")]
        public void SelectSourceLanguage(string language)
        {
            var menu = _mainPage.LeftLanguageSelectMenu;

            var selectedLanguageInDropdown = menu.SelectLanguage(language);
            var selectedLanguageOnPanel = menu.GetSelectedLanguage();

            Assert.That(selectedLanguageInDropdown, Is.EqualTo(language));
            Assert.That(selectedLanguageOnPanel, Is.EqualTo(language));
        }


        //todo apply data driven approach to select language menu
        [Test]
        [TestCase("русский")]
        [TestCase("английский")]
        public void SelectTargetLanguage(string language)
        {
            var menu = _mainPage.RightLanguageSelectMenu;

            var selectedLanguageInDropdown = menu.SelectLanguage(language);
            var selectedLanguageOnPanel = menu.GetSelectedLanguage();

            Assert.That(selectedLanguageInDropdown, Is.EqualTo(language));
            Assert.That(selectedLanguageOnPanel, Is.EqualTo(language));
        }

        [Test]
        public void SwapLanguages()
        {
            var leftPanel = _mainPage.LeftLanguageSelectMenu;
            var rightPanel = _mainPage.RightLanguageSelectMenu;

            var leftSelectedBefore = leftPanel.GetSelectedLanguage();
            var rightSelectedBefore = rightPanel.GetSelectedLanguage();

            Assert.True(_mainPage.SwapLanguagesAction(), "Failed to click swap languages button");

            Assert.That(leftPanel.GetSelectedLanguage(), Is.EqualTo(rightSelectedBefore));
            Assert.That(rightPanel.GetSelectedLanguage(), Is.EqualTo(leftSelectedBefore));
        }
    }
}
