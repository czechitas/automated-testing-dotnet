using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace LessonTwoSamples.steps
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

        [When(@"user fills valid username")]
        public void WhenUserFillsValidUsername()
        {
            webDriver.FindElement(By.Id("LoginField")).SendKeys("Ucastnice");
        }

        [When(@"user fills valid password")]
        public void WhenUserFillsValidPassword()
        {
            webDriver.FindElement(By.Id("PasswordField")).SendKeys("Heslo");
        }

        [When(@"user clicks on login")]
        public void WhenUserClicksOnLogin()
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
