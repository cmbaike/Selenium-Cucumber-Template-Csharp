using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;




namespace SeleniumFramework.Setup
{
    
    class BrowserType : IBrowser
    {

        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get { return driver; }
            set { driver = value; }
}


        public IWebDriver getDriverObject(string browserTypeChosen)
        {

            string binaryPath;
            EnviromentConfig.ReturnOSDriverBinaryPath(out binaryPath);
            switch (browserTypeChosen.ToUpper())
            {
                case "FIREFOX":
                   
                    Driver =  Driver ?? new FirefoxDriver();
                   
                    break;
                case "CHROME":
                    Driver = Driver ?? new ChromeDriver(@binaryPath);
                    break;

                case "IE":
                    Driver = Driver ?? new InternetExplorerDriver(@binaryPath);
                    break;
            }
            Driver.Manage().Window.Maximize();
            return Driver;

        }
     
        public void tearDown()
        {
            if (Driver != null)
            {
                Driver.Close();
                Driver.Quit();
            }

        }

    }
}
