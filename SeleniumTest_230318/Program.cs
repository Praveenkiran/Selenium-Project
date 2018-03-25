using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace SeleniumTest_230318
{
    class Program
    {
        
        static void Main(string[] args)
        {                     

        }
  

        [SetUp]
        public void Initialize()
        {
            //Navigate to executeautomation URL
            PropertiesCollection.driver = new FirefoxDriver();            
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");//Logon page         
            Console.WriteLine("Initialize");
        }
        [Test]
        public void ExecuteautomationTest()
        {
            //Login to application
            LoginPageObjects pagelogin = new LoginPageObjects();
            EAPageObject PageEA= pagelogin.Login("Test", "Test123");
            PageEA.FillUserForm("123", "Test", "Test123");          

            Console.WriteLine("Execute Button");
        }
        [TearDown]
        public void cleanup()
        {

            PropertiesCollection.driver.Close();
            Console.WriteLine("Close");
        }
    }
}
