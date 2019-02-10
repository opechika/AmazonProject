
using AmazonProject.Helper;
using AmazonProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AmazonProject.StepDefinition
{
    [Binding]
    public sealed class AmazonBasketSteps : BaseClass
    {
        AmazonHomePage amazonHomePage = new AmazonHomePage();
        ResultPage resultPage = new ResultPage();

        [Given(@"I am on Amazon homepage")]
        public void GivenIAmOnAmazonHomepage()
        {
            amazonHomePage.IsHomePageDisplayed(); 
        }

        [When(@"I enter ""(.*)"" in the search bar")]
        public void WhenIEnterInTheSearchBar(string item)
        {
            amazonHomePage.EnteraAnItemToSearchBar(item);
        }

        [When(@"i click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            resultPage = amazonHomePage.ClickOnButton(); 
        }

        [When(@"the result of ""(.*)"" is displayed")]
        public void WhenTheResultOfIsDisplayed(string p0)
        {
            resultPage.IsResultTitleDisplayed();
            resultPage.IsResultDisplayed();
        }

        [When(@"I select the echo dot of my choice")]
        public void WhenISelectTheEchoDotOfMyChoice()
        {
            resultPage.ClickOnTheFirstResult();  
        }

        [When(@"I select ""(.*)"" as the quantity of my choice")]
        public void WhenISelectAsTheQuantityOfMyChoice(string qty)
        {
           
        }

        [When(@"I click on add to basket button")]
        public void WhenIClickOnAddToBasketButton()
        {
            
        }

        [Then(@"""(.*)"" is added to the basket")]
        public void ThenIsAddedToTheBasket(string p0)
        {
            
        }

        [When(@"""(.*)"" is added to the basket")]
        public void WhenIsAddedToTheBasket(string p0)
        {
            
        }

        [When(@"I click on the basket icon")]
        public void WhenIClickOnTheBasketIcon()
        {
            
        }

        [When(@"I click on delete link")]
        public void WhenIClickOnDeleteLink()
        {
            
        }

        [Then(@"echo do is deleted from the basket")]
        public void ThenEchoDoIsDeletedFromTheBasket()
        {
           
        }

    }

    internal class SearchButton
    {
    }
}
