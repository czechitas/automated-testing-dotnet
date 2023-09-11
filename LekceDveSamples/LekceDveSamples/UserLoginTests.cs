using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LessonTwoSamples
{
    public class UserLoginTests
    {
        public WebDriver webDriver = new ChromeDriver();
        string baseUrl = "";


        [Test]
        public void GivenLoginPageIsLoaded_WhenUserLoginWithValidCredentials_ThenIsLoggedIn()
        {
            webDriver.Navigate().GoToUrl(baseUrl);
            webDriver.FindElement(By.Id("LoginField")).SendKeys("Ucastnice");
            webDriver.FindElement(By.Id("PasswordField")).SendKeys("Heslo");
            webDriver.FindElement(By.Id("OkButton")).Click();
            webDriver.FindElement(By.Id("WelcomeBanner")).Text
                .Should().Be("Prihlaseni problehlo uspesne");
        }

        [Test]
        public void ValidUserCanLoginIn()
        {
            webDriver.Navigate().GoToUrl(baseUrl);
            webDriver.FindElement(By.Id("LoginField")).SendKeys("Ucastnice");
            webDriver.FindElement(By.Id("PasswordField")).SendKeys("Heslo");
            webDriver.FindElement(By.Id("OkButton")).Click();
            webDriver.FindElement(By.Id("WelcomeBanner")).Text
                .Should().Be("Prihlaseni problehlo uspesne");
        }
    }
}