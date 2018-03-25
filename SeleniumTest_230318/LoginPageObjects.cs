using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest_230318
{
    class LoginPageObjects
    {
        public LoginPageObjects()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        //Username
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUsername { get; set; }

        //Password
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        //Button
        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string UserName,string Password)
        {
            txtUsername.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            btnLogin.Submit();
            return new EAPageObject();//return to the next page
        }
    }
}
