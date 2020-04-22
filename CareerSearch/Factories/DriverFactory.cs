using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace CareerSearch.Factories
{
    public class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var browser = Environment.GetEnvironmentVariable("BROWSER") ?? "CHROME";

            return browser.ToUpperInvariant() switch
            {
                "CHROME" => new ChromeDriver(),
                "FIREFOX" => new FirefoxDriver(),
                "SAFARI" => new SafariDriver(),
                "IE" => new InternetExplorerDriver(),
                _ => throw new ArgumentException($"Browser not yet implemented: {browser}")
            };
        }
    }
}