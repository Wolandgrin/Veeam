using System;
using OpenQA.Selenium;

namespace CareerSearch.PageObjects
{
    public class JobPortal : PageObject
    {
        private readonly IWebDriver _driver;

        public JobPortal(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void SelectCountry(string country)
        {
            var countryElement = _driver.FindElement(By.CssSelector("#country-element"));
            countryElement.Click();
            try
            {
                var spanElements = countryElement.FindElements(By.ClassName("selecter-item"));
                foreach (var element in spanElements)
                {
                    if (element.GetAttribute("innerHTML") != country) continue;
                    element.Click();
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new ElementNotInteractableException($"Cannot handle country related element(s): {e.StackTrace}");
            }
        }

        public void SelectLanguage(string language)
        {
            var languageElement = _driver.FindElement(By.CssSelector("#language"));
            languageElement.Click();
            try
            {
                var labelElements = languageElement.FindElements(By.TagName("label"));
                foreach (var element in labelElements)
                {
                    if (element.Text != language) continue;
                    element.Click();
                    languageElement.Click();
                    break;
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot handle language related element(s): {e.StackTrace}");
            }
        }
    }
}