using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    [TestFixture]
    public class BaseTest
    {
        IWebDriver Driver;

        [Test]
        public void GoToGoogleTest()
        {
            Driver = new ChromeDriver();
            Driver.Url = @"https:\\google.com";
            Driver.Quit();
        }
    }
}
