using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Tests;

namespace SeleniumFramework.Pages
{
    [TestFixture]
    class MainGooglePage : BasePage
    {
        IWebElement SearchInput => BaseTest.Driver.FindElement(By.CssSelector(".gLFyf"));

        public MainGooglePage FillSearchInput(string textToInsert)
        {
            SearchInput.SendKeys(textToInsert);
            SearchInput.Submit();

            return this;
        }
    }
}
