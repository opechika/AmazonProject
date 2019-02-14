using AmazonProject.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonProject.Pages
{
    public class AmazonProductDetailPage : BaseClass
    {
        IWebElement quantity;
        private IWebElement addbutton;
        private IWebElement closePopUp;


        public void SelectQuantity(string qty)
        {
            quantity = GetElementById("quantity");
            SelectByText(quantity,qty);
        }

        public EditBasketPage ClickOnButton()
        {
            addbutton = GetElementById("add-to-cart-button");
            addbutton.Click();

            try
            {
                CloseItemPopUp();
            }
            catch (NoSuchElementException e)
            {
               
            }
            return new EditBasketPage();
        }

        private void CloseItemPopUp()
        {
            closePopUp = GetElementByCssSelector("i.a-icon.a-icon-close");
            closePopUp.Click();
        }
       }


}
