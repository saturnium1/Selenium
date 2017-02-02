using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class FlightFinderPageObject
    {


        public FlightFinderPageObject()
        {
            PageFactory.InitElements(PropParam.wd, this);
        }


        [FindsBy(How = How.Name, Using = "passCount")]
        public IWebElement ddlPassengers { get; set; }

        [FindsBy(How = How.Name, Using = "fromPort")]
        public IWebElement ddlOrigin { get; set; }

        [FindsBy(How = How.Name, Using = "fromMonth")]
        public IWebElement ddlDepartMonth { get; set; }

        [FindsBy(How = How.Name, Using = "fromDay")]
        public IWebElement ddlDepartDate { get; set; }

        [FindsBy(How = How.Name, Using = "toPort")]
        public IWebElement ddlDestination { get; set; }

        [FindsBy(How = How.Name, Using = "toMonth")]
        public IWebElement ddlArriveMonth { get; set; }

        [FindsBy(How = How.Name, Using = "toDay")]
        public IWebElement ddlArriveDate { get; set; }

        [FindsBy(How = How.Name, Using = "airline")]
        public IWebElement ddlAirline { get; set; }

        


    }
}
