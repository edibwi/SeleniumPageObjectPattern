using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjectPattern.PageObjects
{
    public class BingMainPage
    {
        private readonly IWebDriver browser;
        private readonly string url = @"http://www.bing.com/";

        public BingMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        
        protected BingMainPageElementMap Map
        {
            get
            {
                return new BingMainPageElementMap(this.browser);
            }
        }

        public BingMainPageValidator Validates()
        {
            return new BingMainPageValidator(this.browser);
        }

        public void Navigate()
        {
            this.browser.Navigate().GoToUrl(this.url);
        }

        public void Search(string keyword)
        {
            this.Map.SearchBox.Clear();
            this.Map.SearchBox.SendKeys(keyword);
            this.Map.GoButton.Click();
        }
    }
}
