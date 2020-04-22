﻿using System;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Xunit;

namespace CareerSearch.PageObjects
{
    public abstract class PageObject
    {
        private readonly IWebDriver _driver;

        public PageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void TextExists(string text)
        {
            System.Threading.Thread.Sleep(1000); // Test is much faster for Chrome than page re-rendering
            var tag = _driver.FindElement(By.TagName("article")).FindElements(By.TagName("h3"))[1];
            tag.Text.Should().Be(text);
        }
    }
}