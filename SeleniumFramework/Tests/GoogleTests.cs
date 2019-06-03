using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    [TestFixture]
    class GoogleTests : BaseTest
    {
        [Test]
        public void GoToGoogleTest()
        {
            Driver.Url = @"https:\\google.com";

            MainGooglePage mainGooglePage = new MainGooglePage();

            mainGooglePage.FillSearchInput("page object pattern c#");
        }
    }
}
