using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace CareerSearch.Factories
{
    public class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var browser = Environment.GetEnvironmentVariable("BROWSER") ?? "CHROME";
            var chromeVersion = Environment.GetEnvironmentVariable("CHROMEVERSION") ?? "81.0.4044.69";
            var chromeUri = $"https://chromedriver.storage.googleapis.com/{chromeVersion}/chromedriver_";
            var debugFolder = Environment.CurrentDirectory;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (!File.Exists($"{debugFolder}\\MicrosoftWebDriver.exe") && browser == "EDGE")
                {
                    File.Move($"{debugFolder}\\msedgedriver.exe", $"{debugFolder}\\MicrosoftWebDriver.exe");
                }
            }

            return browser.ToUpperInvariant() switch
            {
                "CHROME" => new ChromeDriver(),
                "EDGE" => new EdgeDriver(),
                "FIREFOX" => new FirefoxDriver(),
                "SAFARI" => new SafariDriver(),
                _ => throw new ArgumentException($"Browser not yet implemented: {browser}")
            };
        }
    }
}