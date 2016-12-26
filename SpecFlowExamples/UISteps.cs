using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;

namespace SpecFlowExamples
{
    [Binding]
    public sealed class UISteps
    {
        private static IWebDriver driver;
        IWebElement searchInput;

        UISteps()
        {                     
        }

        [BeforeScenario("regression")]
        public static void start()
        {
            string path = @"C:\WebDrivers";
            driver = new ChromeDriver(path);
        }

        [Given(@"I go to Wikipedia English Main Page")]
        public void GivenIGoToWikipediaEnglishMainPage()
        {
            driver.Url = "https://en.wikipedia.org/wiki/Main_Page";
        }

        [Given(@"I have entered Limerick into the search box")]
        public void GivenIHaveEnteredLimerickIntoTheSearchBox()
        {
            searchInput = driver.FindElement(By.CssSelector("#searchInput"));
            searchInput.Click();
            searchInput.SendKeys("Limerick");
        }

        [Given(@"I have entered '(.*)' into the search box")]
        public void GivenIHaveEnteredIntoTheSearchBox(string word)
        {
            searchInput = driver.FindElement(By.CssSelector("#searchInput"));
            searchInput.Click();
            searchInput.SendKeys(word);
        }


        [When(@"I press search")]
        public void WhenIPressSearch()
        {
            IWebElement searchButton = driver.FindElement(By.CssSelector("#searchButton"));
            searchButton.Click();
        }

        [Then(@"the result should be the Limerick article")]
        public void ThenTheResultShouldBeTheLimerickArticle()
        {
            Assert.AreEqual("Limerick - Wikipedia", driver.Title);            
        }

        [Then(@"the result should be the '(.*)' article")]
        public void ThenTheResultShouldBeTheArticle(string word)
        {
            var title = driver.Title.ToString();
            var result = title.Contains(word);
            Assert.IsTrue(result, "Title did not match");            
        }

        [AfterScenario("UIcleanup")]
        public static void close()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}
