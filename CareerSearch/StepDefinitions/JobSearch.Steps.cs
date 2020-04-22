using System;
using OpenQA.Selenium;
using CareerSearch.PageObjects;
using TechTalk.SpecFlow;

namespace CareerSearch.StepDefinitions
{
	[Binding]
	public class StepDefinitions
	{
		private readonly JobPortal _page;
		
		public StepDefinitions(IWebDriver driver)
		{
			_page = new JobPortal(driver);
		}
		
		[Given(@"I am on ""(.*)""")]
		public void GivenIAmOn(string url)
		{
			_page.Navigate(url);
		}
		
		// demonstrates running the same steps but for scenarios with different tags
		[Given(@"I am on ""(.*)"""), Scope(Tag = "web")]
		public void GivenOn(string url)
		{
			_page.Navigate(url);
		}
        
		[When(@"I select ""(.*)"" in the Countries")]
		public void WhenISelectInTheCountries(string library)
		{
			_page.SelectCountry(library);
		}
        
		[When(@"I select ""(.*)"" in the Languages")]
		public void WhenISelectInTheLanguages(string library)
		{
			_page.SelectLanguage(library);
		}
        
		[Then(@"""(.*)"" jobs should be found")]
		public void ThenJobsShouldBeFound(int library)
		{
			_page.TextExists(library == 1 ? "1 job found" : $"{library} jobs found");
		}
	}
}