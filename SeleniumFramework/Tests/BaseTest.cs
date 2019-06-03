using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Tests
{
    [TestFixture]
    public class BaseTest
    {
        public static IWebDriver Driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Quit();
        }
    }
}
