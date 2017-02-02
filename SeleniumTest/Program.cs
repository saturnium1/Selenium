using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Program
    {
       
        static void Main(string[] args)
        {
        }

        [SetUp]

        public void Init()
        {
            PropParam.wd = new ChromeDriver();

            PropParam.wd.Navigate().GoToUrl("http://www.newtours.demoaut.com/");
            Console.WriteLine("Website open: " + PropParam.wd.Title.ToString());

        }

        [Test]
        public void LogIn()
        {
            //PropParam.wd.Navigate().GoToUrl("http://www.w3schools.com/html/tryit.asp?filename=tryhtml_radio");
            //var frame = PropParam.wd.FindElement(By.XPath("//iframe[@id='iframeResult']"));
            //PropParam.wd.SwitchTo().Frame(frame);

            //var form = PropParam.wd.FindElement(By.XPath("/html/body/form"));
            //var radioButtons = form.FindElements(By.TagName("input"));

            //var radioButton = radioButtons[2];
            //radioButton.Click();
            //string sourceCode = PropParam.wd.PageSource;
            //PropParam.wd.SwitchTo().DefaultContent();
            //string sourceCode2 = PropParam.wd.PageSource;

            //int ph = 1;
            public static void Cliks(IWebDriver PropParam, By by)
        {
            var el = PropParam.FindElement(by);
            el.Click();
        }

            IndexPageObject page = new IndexPageObject();

            FlightFinderPageObject flightPage = page.Login("mercury", "mercury");




        }


        [TearDown]

        public void BrowserClose()
        {
            if(PropParam.wd!=null)
                    PropParam.wd.Close();
        }
    }
}
