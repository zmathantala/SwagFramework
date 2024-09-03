using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabProject.Base
{
    public class DemoBase
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void Init()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

        [OneTimeTearDown]
        public void tearDownSetUp()
        {
            Thread.Sleep(5000);
            driver.Dispose();
            driver.Quit();
        }
    }
}
