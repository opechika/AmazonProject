using AmazonProject.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AmazonProject.Hooks
{
    [Binding]
    public sealed class AmazonHooks :BaseClass
    {
       
        // this method opens the browser
        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
            LaunchUrl("https://www.amazon.co.uk");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();   
        }
    }
}
