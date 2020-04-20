using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace CareersSearch.StepDefinitions
{
    [Binding]
    public class JobSearchSteps : IDisposable
    {
        private String searchKeyword;
        //private String searchPortal;

        private ChromeDriver chromeDriver;

        public JobSearchSteps() => chromeDriver = new ChromeDriver();

        [Given(@"I navigated to '(.*)' page")]
        public void GivenIHaveNavigatedToVeeamPage(String searchPortal)
        {
            chromeDriver.Navigate().GoToUrl(searchPortal);
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains("Vacancies"));
        }

        [When(@"I have entered (.*) as search keyword")]
        public void GivenIHaveEnteredIndiaAsSearchKeyword(String searchString)
        {
            this.searchKeyword = searchString.ToLower();
            var searchInputBox = chromeDriver.FindElementById("search");
            var wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("search")));
            searchInputBox.SendKeys(searchKeyword);
        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            var searchButton = chromeDriver.FindElementByCssSelector("button#search-icon-legacy");
            searchButton.Click();
        }

        [Then(@"I should be navigate to search results page")]
        public void ThenIShouldBeNavigateToSearchResultsPage()
        {

            System.Threading.Thread.Sleep(2000);
            // After search is complete the keyword should be present in url as well as page title`
            Assert.IsTrue(chromeDriver.Url.ToLower().Contains(searchKeyword));
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains(searchKeyword));
        }


        public void Dispose()
        {
            if (chromeDriver != null)
            {
                chromeDriver.Dispose();
                chromeDriver = null;
            }
        }


    }
}