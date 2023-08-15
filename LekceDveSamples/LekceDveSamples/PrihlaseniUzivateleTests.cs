using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LekceDveSamples
{
    public class PrihlaseniUzivateleTests
    {
        public WebDriver webDriver = new ChromeDriver();
        string baseUrl = "";


        [Test]
        public void GivenPrihlasovaciStrankaJeZobrazena_WhenUzivatelSePrihlasiValidnimiUdaji_ThenUzivatelJePrihlasen()
        {
            webDriver.Navigate().GoToUrl(baseUrl);
            webDriver.FindElement(By.Id("LoginField")).SendKeys("Ucastnice");
            webDriver.FindElement(By.Id("PasswordField")).SendKeys("Heslo");
            webDriver.FindElement(By.Id("OkButton")).Click();
            webDriver.FindElement(By.Id("WelcomeBanner")).Text
                .Should().Be("Prihlaseni problehlo uspesne");
        }

        [Test]
        public void PlatnyUzivatelSeMuzePrihlasit()
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