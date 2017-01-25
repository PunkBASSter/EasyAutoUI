using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SWD_Training1
{
    [TestFixture]
    public class UnitTest1
    {
        [Ignore("shit")]
        [Test]
        public void BydloTest123()
        {
            var driver = new ChromeDriver();

            driver.Navigate();

            driver.Close();
        }
    }
}
