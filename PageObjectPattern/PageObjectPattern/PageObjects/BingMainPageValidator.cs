using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageObjectPattern.PageObjects
{
    public class BingMainPageValidator
    {
        private readonly IWebDriver browser;

        public BingMainPageValidator(IWebDriver browser)
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

        public void AutomateThePlanetExist()
        {
            Assert.IsTrue(this.Map.ResultLink.Displayed, "Automate The Planet hyperlink is not displayed");
        }
    }
}
