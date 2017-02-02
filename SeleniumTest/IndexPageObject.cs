using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class IndexPageObject
    {

        public IndexPageObject()
        {
                PageFactory.InitElements(PropParam.wd,this);
        }

        [FindsBy(How = How.Name, Using = "userName")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How =How.XPath,Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[1]/a")]
        public IWebElement linkSignOn { get; set; }

        [FindsBy(How =How.XPath,Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[2]/a")]
        public IWebElement linkRegister { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[3]/a")]
        public IWebElement linkSupport { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[4]/a")]
        public IWebElement linkContact { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[1]/td[2]/font/a")]
        public IWebElement linkHome { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[2]/td[2]/a")]
        public IWebElement linFlights { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[3]/td[2]/a")]
        public IWebElement linkHotels { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[4]/td[2]/font/a")]
        public IWebElement linkCarRental { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[5]/td[2]/a")]
        public IWebElement linkCruises { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[6]/td[2]/a")]
        public IWebElement linkDestinations { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[7]/td[2]/a")]
        public IWebElement linkVacations { get; set; }

        [FindsBy(How =How.XPath,Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[6]/td/table/tbody/tr/td[2]/font/a")]
        public IWebElement rLinkYourDestination { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[8]/td/table/tbody/tr/td[2]/font/a")]
        public IWebElement rLinkFeatVacationDestinations { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[10]/td/table/tbody/tr/td[2]/font/a")]
        public IWebElement rLinkRegisterHere { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[12]/td/table/tbody/tr/td/font/a[1]")]
        public IWebElement rLinkBT { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[12]/td/table/tbody/tr/td/font/a[2]")]
        public IWebElement rLinkSalonTravel{ get; set; }

        public FlightFinderPageObject Login(string username, string password)
        {
            txtUsername.InputText(username);
            txtUsername.InputText(password);            
            btnLogin.Clicks();

            return new FlightFinderPageObject();
        }





    }
}
