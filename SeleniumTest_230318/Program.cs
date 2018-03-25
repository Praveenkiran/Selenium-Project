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
        IWebDriver driver = new FirefoxDriver();
        //IWebDriver Chdriver = new ChromeDriver();
        static void Main(string[] args)
        {
            //Execute Facebook
            //Step1: Open Facebook
            //Step2: Entering the credentials.
            //Step3: Clicking on Profile to Navigate to Friends list
            //Step4: Clicking on Friends List
            //Step5: Diplaying the list of friends.

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://facebook.com";

            driver.Manage().Window.Maximize();           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            try
            {
                string strUsername = "chukkalapravee@gmail.com";//Text box value
                Assert.AreEqual("Chukkalapraveen@gmail.com", strUsername);

                string strPassword = "Pream1982";//Text box value
                Assert.AreEqual("Pream1982", strPassword);

                
                driver.FindElement(By.Id("email")).SendKeys("chukkalapraveen@gmail.com");
                driver.FindElement(By.Id("pass")).SendKeys("Pream1982" + Keys.Enter);

                driver.FindElement(By.XPath(".//*[@id='navItem_100002098154923']/a/div")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath(".//*[@data-tab-key='friends']")).Click();


                IList<IWebElement> friends = driver.FindElements(By.XPath("//div[@class='fsl fwb fcb']/a"));
                Console.WriteLine("Todatal friends=" + friends.Count);
                Console.WriteLine("*********************************************");
                for (int i = 0; i < friends.Count; i++)
                {
                    Console.WriteLine(friends[i].Text);
                }
                Console.WriteLine("*********************************************");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please Check your Username and Password");
            }
            

        }
  

        [SetUp]
        public void Initialize()
        {
            //Navigate to executeautomation URL
        
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");//Logon page          
            Console.WriteLine("Initialize");
        }
        [Test]
        public void ExecuteautomationTest()
        {
            //Find the Element
           
            driver.FindElement(By.Name("UserName")).SendKeys("Uname");//Login page Uname          
            Console.WriteLine("Execute Username");                    //Login Page

            driver.FindElement(By.Name("Password")).SendKeys("PWD");    //  Login Page Pwd       
            Console.WriteLine("Execute Password");                      //  Login Page Pwd 
          

            driver.FindElement(By.XPath(".//*[@id='userName']/p[3]/input")).Click();//Button Login

            //Perform Apps
            SeleniumSetmethods.SelectDropDown(driver, "TitleId", "Mr.", "id");
            SeleniumSetmethods.EnterText(driver, "Initial", "Testing", "Name");
            SeleniumSetmethods.Click(driver, "Login", "Name");
                        
            Console.WriteLine("Execute Button");
        }
        [TearDown]
        public void cleanup()
        {

            driver.Close();

            Console.WriteLine("Close");
        }
    }
}
