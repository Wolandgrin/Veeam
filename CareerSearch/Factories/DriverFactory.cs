using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
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
            var browser = Environment.GetEnvironmentVariable("BROWSER") ?? "FIREFOX";
            var chromeVersion = Environment.GetEnvironmentVariable("CHROMEVERSION") ?? "81.0.4044.69";
            var chromeUri = $"https://chromedriver.storage.googleapis.com/{chromeVersion}/chromedriver_";
            var debugFolder = Environment.CurrentDirectory;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (!File.Exists($"{debugFolder}/chromedriver.exe") && browser == "CHROME")
                {
                    const string archive = "../../chromedriver.zip";
                    var cli = new WebClient();
                    cli.DownloadFile($"{chromeUri}win32.zip", archive);
                    ZipFile.ExtractToDirectory(archive, debugFolder);
                }
                
                if (!File.Exists($"{debugFolder}\\MicrosoftWebDriver.exe") && browser == "EDGE")
                {
                    File.Move($"{debugFolder}\\msedgedriver.exe", $"{debugFolder}\\MicrosoftWebDriver.exe");
                }
            }
            else
            {
                Console.WriteLine();
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
            var result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return result;
        }
    }
}