using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace LekceDveSamples.steps
{
    [Binding]
    public class UserLoginStepDefinitions
    {
        public WebDriver webDriver = new ChromeDriver();
        string baseUrl = "";

        [Given(@"user open applicaiton on login page")]
        public void GivenUserOpenApplicaitonOnLoginPage()
        {
            webDriver.Navigate().GoToUrl(baseUrl);
        }

        [When(@"user fill valid username")]
        public void WhenUserFillValidUsername()
        {
            webDriver.FindElement(By.Id("LoginField")).SendKeys("Ucastnice");
        }

        [When(@"user fill valid password")]
        public void WhenUserFillValidPassword()
        {
            webDriver.FindElement(By.Id("PasswordField")).SendKeys("Heslo");
        }

        [When(@"user click on login")]
        public void WhenUserClickOnLogin()
        {
            webDriver.FindElement(By.Id("OkButton")).Click();
        }

        [Then(@"validate that login was successful")]
        public void ThenValidateThatLoginWasSuccessful()
        {
            webDriver.FindElement(By.Id("WelcomeBanner")).Text
                            .Should().Be("Prihlaseni problehlo uspesne");
        }
    }
}
