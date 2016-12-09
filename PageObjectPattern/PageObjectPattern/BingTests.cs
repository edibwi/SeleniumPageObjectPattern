using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PageObjectPattern.PageObjects;

namespace PageObjectPattern
{
    [TestClass]
    public class BingTests
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();            
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void SearchTextInBing_First()
        {
            BingMainPage bingMainPage = new BingMainPage();
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.Validate().AutomateThePlanetExist();
        }
    }
}
