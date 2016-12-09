using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PageObjectPattern
{
    public static class Driver
    {
        private static WebDriverWait browserWait;
        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException ("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if(browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 30)
        {
            switch(browserType)
            {
                case BrowserTypes.Chrome:
                    Driver.Browser = new ChromeDriver();
                    break;
                case BrowserTypes.IE:
                    break;
                case BrowserTypes.Firefox:
                    break;
                default:
                    break;
            }
            BrowserWait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(defaultTimeOut));
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
