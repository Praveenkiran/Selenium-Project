using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest_230318
{
    class SeleniumGetMethods
    {

        public static string GetText( string element, Propertytype elementtype)
        {

            if (elementtype == Propertytype.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("Value");
            if (elementtype == Propertytype.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("Value");
            else return string.Empty;

        }

        public static string GetTextFromDDL(string element, Propertytype elementtype)
        {

            if (elementtype == Propertytype.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == Propertytype.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;

        }
    }
}
