using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AmazonProject.StepDefinition
{
    [Binding]
    public sealed class AmazonBasketSteps
    {
        [Given(@"I am on Amazon homepage")]
        public void GivenIAmOnAmazonHomepage()
        {
           
        }

        [When(@"I enter ""(.*)"" in the search bar")]
        public void WhenIEnterInTheSearchBar(string p0)
        {
            
        }

        [When(@"i click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            
        }

        [When(@"the result of ""(.*)"" is displayed")]
        public void WhenTheResultOfIsDisplayed(string p0)
        {
            
        }

        [When(@"I select the echo dot of my choice")]
        public void WhenISelectTheEchoDotOfMyChoice()
        {
            
        }

        [When(@"I select ""(.*)"" as the quantity of my choice")]
        public void WhenISelectAsTheQuantityOfMyChoice(int p0)
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
}
