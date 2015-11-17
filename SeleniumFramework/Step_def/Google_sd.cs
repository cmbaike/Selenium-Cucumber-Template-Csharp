
using SeleniumFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumFramework.Step_def
{
    [Binding]
    public class Google_sd
    {
        HomePage homePage = new HomePage(); 

        [Given(@"I am on the google page")]
        public void GivenIAmOnTheGooglePage()
        {
            homePage.navigateToHomePage();
        }

        [When(@"I enter a search query ""(.*)""")]
        public void WhenIEnterASearchQuery(string p0)
        {
            
        }

        [Then(@"I should see the url of NCC in the search result")]
        public void ThenIShouldSeeTheUrlOfNCCInTheSearchResult()
        {
           
        }
    }   
}
