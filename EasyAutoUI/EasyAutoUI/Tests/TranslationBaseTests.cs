using EasyAutoUI.FrameworkCore;
using EasyAutoUI.FrameworkCore.SeleniumExtensions;
using EasyAutoUI.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace EasyAutoUI.Tests
{
    [Parallelizable]
    public class TranslationBaseTests : BaseTestFixture
    {
        private MainPage _mainPage;

        [OneTimeSetUp]
        public void Setup()
        {
            _mainPage = new MainPage("https://translate.google.ru/#en/ru");    
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Navigate().Refresh();
        }

        [Test]
        public void TranslationTest()
        {
            _mainPage.Source.Input.SendKeys("dog");
            _mainPage.SubmitButton.Click();
            var translated = _mainPage.Result.Text
                .FitsCondition("собака", ExpectedConditions.TextToBePresentInElement);

            Assert.True(translated);
        }
    }
}