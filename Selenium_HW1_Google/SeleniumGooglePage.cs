using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium_HW1_Google
{
    public class SeleniumGooglePage
    {
        public IWebDriver driver;
        public SeleniumGooglePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='tsf']/div[2]//div[1]/input")]
        public IWebElement inputField;

        [FindsBy(How = How.XPath, Using = "//*[@id='tsf']//div[@class='VlcLAe']//input[1]")]
        public IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'https://www.seleniumhq.org')]/h3[@class='LC20lb']")]
        public IWebElement seleniumLink;

        [FindsBy(How = How.XPath, Using = "//*[@title='Return to Selenium home page']")]
        public IWebElement findButtonReturnSeleniumHomePage;
    }
}
