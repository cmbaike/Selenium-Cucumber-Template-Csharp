using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework.Setup;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using By = OpenQA.Selenium.Extensions.By;


namespace SeleniumFramework.Pages
{
    class HomePage : BrowserType
    {

        public HomePage() {
            PageFactory.InitElements(Driver, this);
 }
      
        public HomePage navigateToHomePage() {
           Driver.Navigate().GoToUrl("http://www.google.co.uk");

           Driver.FindElement(By.SizzleSelector(".gb_P:contains('Gmail')")).Click(); 
            
            return new HomePage();
        }


        [FindsBy(How = How.CssSelector,Using = ".gb_P")]
        public IWebElement gmail { get; set; }

       
    }
}
