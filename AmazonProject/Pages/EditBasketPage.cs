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
    public class EditBasketPage : BaseClass
    {
        private IWebElement itemToBasket;
        private IWebElement basketContent;

        public void IsItemInBasket(string item)
        {
            itemToBasket = GetElementByClassName("hlb-item-title");
            Assert.True(itemToBasket.Text.ToLower().Contains(item.ToLower()));
        }

        public ShoppingBasketPage ClickOnBasket()
        {
            basketContent = GetElementById("nav-cart-count");
            basketContent.Click();
            return new ShoppingBasketPage();
        }
    }
}
