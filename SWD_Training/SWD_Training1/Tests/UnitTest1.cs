using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SWD_Training1.Pages;


namespace SWD_Training1.Tests
{
    [TestFixture]
    public class UnitTest1 : TestFixtureBase<MainPage>
    {
        
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            PageUnderTest = new MainPage(WebDriver);
        }

        [Test]
        public void SelectLanguageLeft()
        {
            
        }

    }
}
