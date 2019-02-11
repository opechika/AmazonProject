using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonProject.Helper;
using OpenQA.Selenium;

namespace AmazonProject.Pages
{
    public class ShoppingBasketPage: BaseClass

    {
        private IWebElement deleteLink;

        public void DeleteItem()
        {
            deleteLink = GetElementByCssSelector("value=\"Delete\"");
            deleteLink.Click();
        }
    }
}
