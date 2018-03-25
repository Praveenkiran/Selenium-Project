using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest_230318
{

    enum Propertytype
    {
        Id,
        Name,
        LinkTest,


    }
    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }
}
