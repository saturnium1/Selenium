using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    enum ElemType
    {
        Id,
        Name,
        ClassName,
        Xpath

    }


    class PropParam
    {

        public static IWebDriver wd { get; set; }
    }
}
