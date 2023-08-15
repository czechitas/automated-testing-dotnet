using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace LekceDveSamples.steps
{
    [Binding]
    public class PrihlaseniUzivateleStepDefinitions
    {
        public WebDriver webDriver = new ChromeDriver();
        string baseUrl = "";

        [Given(@"otevru aplikaci na prihlasovaci strance")]
        public void GivenOtevruAplikaciNaPrihlasovaciStrance()
        {
            webDriver.Navigate().GoToUrl(baseUrl);
        }

        [When(@"zadam validni jmeno")]
        public void WhenZadamValidniJmeno()
        {
            webDriver.FindElement(By.Id("LoginField")).SendKeys("Ucastnice");
        }

        [When(@"zadam validni heslo")]
        public void WhenZadamValidniHeslo()
        {
            webDriver.FindElement(By.Id("PasswordField")).SendKeys("Heslo");
        }

        [When(@"klinu na prihlasit")]
        public void WhenKlinuNaPrihlasit()
        {
            webDriver.FindElement(By.Id("OkButton")).Click();
        }

        [Then(@"overim ze prihlasni bylo uspesnes")]
        public void ThenOverimZePrihlasniByloUspesnes()
        {
            webDriver.FindElement(By.Id("WelcomeBanner")).Text
                            .Should().Be("Prihlaseni problehlo uspesne");
        }
    }
}
