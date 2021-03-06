﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Selenium.Utils
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(
            Browser browser, string pathDriver, bool headless)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Firefox:
                    FirefoxOptions optionsFF = new FirefoxOptions();
                    if (headless)
                        optionsFF.AddArgument("--headless");
                    
                    webDriver = new FirefoxDriver(pathDriver, optionsFF);

                    break;
                case Browser.Chrome:
                    ChromeOptions optionsChr = new ChromeOptions();
                    if (headless)
                        optionsChr.AddArgument("--headless");

                    webDriver = new ChromeDriver(pathDriver, optionsChr);
                    
                    break;
            }

            return webDriver;
        }
    }
}