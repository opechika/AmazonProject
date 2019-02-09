using AmazonProject.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProject.Pages
{
   public class AmazonHomePage : BaseClass
    {
        IWebElement logo;
        IWebElement searchbar;
        IWebElement button;

        public void IsHomePageDisplayed()
        {
            logo = GetElementByCssSelector(".nav-sprite.nav-logo-base");
            Assert.True(logo.Displayed);
        }

        public void EnteraAnItemToSearchBar(string item)
        {
            searchbar = GetElementById("twotabsearchtextbox");
            searchbar.SendKeys(item);
        }
        public ResultPage ClickOnButton()
        {
            button = GetElementByClassName("nav-input");
            button.Click();
            return new ResultPage();
        }
    }
}
