using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest_230318
{
    class SeleniumSetmethods
    {

        //Enter Text

        public static void EnterText(IWebDriver driver, string element,string value,string elementtype)
        {

            if (elementtype == "id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click in to Button, Checkbox , Optionbox etc

        public static void Click(IWebDriver driver, string element, string elementtype)
        {

            if (elementtype == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                //driver.FindElement(By.Name(element)).Click();
                driver.FindElement(By.XPath(".//*[@id='details']/table/tbody/tr[7]/td/input")).Click();

        }

        //Selecting a Dropdown control

        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {

            if (elementtype == "id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);

        }

    }
}
