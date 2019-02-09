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
    public  class ResultPage: BaseClass
    {
        IWebElement resultTitle;
        IList<IWebElement> searchResult;

        public void IsResultTitleDisplayed()
        {
            resultTitle = GetElementByCssSelector(".a-link-normal.a-text-normal");
            Assert.True(resultTitle.Displayed);
        }
         public void IsResultDisplayed()
        {
            searchResult = GetElementsByCssSelector(".a-size-medium.s-inline.s-access-title.a-text-normal");
            Assert.True(searchResult.Count > 0);
        }

        public void ClickOnTheFirstResult()
        {
            searchResult = GetElementsByCssSelector(".a-size-medium.s-inline.s-access-title.a-text-normal");
            searchResult.ElementAt(0).Click();
        }
    }
}
