using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObjectPattern.PageObjects
{
    public class BingMainPageElementMap : BasePageElementMap
    {
        public IWebElement SearchBox
        {
            get
            {
                return this.browser.FindElement(By.Id("sb_form_q"));
            }
        }

        public IWebElement GoButton
        {
            get
            {
                return this.browser.FindElement(By.Id("sb_form_go"));
            }
        }

        public IWebElement ResultLink
        {
            get
            {
                return this.browser.FindElement(By.XPath("//a[.=\"Automate The Planet\"]"));
            }
        }
    }
}
