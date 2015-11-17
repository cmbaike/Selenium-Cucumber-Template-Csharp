using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumFramework.Setup
{
    [Binding]
     class Hooks : BrowserType
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            getDriverObject("firefox");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            tearDown();
        }
    }
}
