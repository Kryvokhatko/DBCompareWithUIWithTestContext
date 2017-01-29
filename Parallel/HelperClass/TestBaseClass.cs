using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace DBCompareWithUIWithTestContext
{
    public class TestBaseClass
    {
        public static IWebDriver driver;

        readonly static string username = ConfigurationManager.AppSettings["Username"];
        readonly static string password = ConfigurationManager.AppSettings["Password"];
        readonly static string url = ConfigurationManager.AppSettings["Url"];

        public static string createUrl(string username, string password, string url)
        {
            string fullUrl = "https://" + username + ":" + password + "@" + url;
            return fullUrl;
        }

        //run before all tests
        public static IWebDriver TestInitialize()
        {
            string url = createUrl(username, password, TestBaseClass.url);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            return driver;
        }

        //close driver
        public static void TestCleanUp()
        {
            try
            {
                driver.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
