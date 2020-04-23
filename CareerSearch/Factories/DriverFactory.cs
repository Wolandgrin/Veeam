using System;
using System.Diagnostics;
using System.IO;
using System.Net;
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
            var chromeVersion = Environment.GetEnvironmentVariable("CHROMEVERSION") ?? "81.0.4044.69";
            var p = (int) Environment.OSVersion.Platform;
            
            if (!File.Exists("../../bin/Debug/chromedriver") && ((p == 4) || (p == 128)) && browser == "CHROME")
            {
                const string archive = "../../chromedriver.zip";
                var cli = new WebClient();
                cli.DownloadFile(
                    "https://chromedriver.storage.googleapis.com/" + chromeVersion + "/chromedriver_mac64.zip",
                    archive);
                var output = Bash("unzip " + archive + " -d ./../../bin/Debug");
            }

            return browser.ToUpperInvariant() switch
            {
                "CHROME" => new ChromeDriver(),
                "FIREFOX" => new FirefoxDriver(),
                "SAFARI" => new SafariDriver(),
                "IE" => new InternetExplorerDriver(),
                _ => throw new ArgumentException($"Browser not yet implemented: {browser}")
            };
        }

        private static string Bash(string cmd)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");
            
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return result;
        }
    }
}