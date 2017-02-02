using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public static class NUnitSet
    {

        public static void InputText(this IWebElement element, string value)
        {
            element.SendKeys(value);

        }

        public static void DropDownBoxSelect(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
           
        }

        public static void Clicks(this IWebElement element)
        {
            element.Click();

        }

    }
}
