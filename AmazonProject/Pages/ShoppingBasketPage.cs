using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonProject.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonProject.Pages
{
    public class ShoppingBasketPage: BaseClass

    {
        private IWebElement deleteLink;
        private IWebElement emptyShoppingBasket;

        public void DeleteItem()
        {
            deleteLink = GetElementByCssSelector(".a-size-small.sc-action-delete");
            deleteLink.Click();
        }

        public void IsShoppingBasketEmpty()
        {
            emptyShoppingBasket = GetElementByCssSelector(".a-row.sc-cart-header h1");
            var emptyBasketText = emptyShoppingBasket.Text;
            Assert.True(emptyBasketText.ToLower().Contains("your shopping basket is empty"));
        }
    }
}
