using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_HW1_Google
{
    public class SeleniumGoogle
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.google.com.ua/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void SearchSeleniumLink()
        {
            // Act
            SeleniumGooglePage seleniumGooglePage = new SeleniumGooglePage(driver);

            seleniumGooglePage.inputField.SendKeys("Selenium");
            seleniumGooglePage.searchButton.Click();
            seleniumGooglePage.seleniumLink.Click();

            // Assert
            Assert.True(IsElementPresent(seleniumGooglePage.findButtonReturnSeleniumHomePage),
                $"Element '{nameof(seleniumGooglePage.findButtonReturnSeleniumHomePage)}' is not present on the page as expected");
        }

        public bool IsElementPresent(IWebElement element)
        {
            try
            {
                var result = element.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

