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
    public class BingMainPage : BasePage<BingMainPageElementMap, BingMainPageValidator>
    {
        public BingMainPage()
            : base(@"http://www.bing.com/")
        {
        }
        
        public void Search(string keyword)
        {
            this.Map.SearchBox.Clear();
            this.Map.SearchBox.SendKeys(keyword);
            this.Map.GoButton.Click();
        }
    }
}
