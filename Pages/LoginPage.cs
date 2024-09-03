using OpenQA.Selenium;
using SwagLabProject.Selectors;
using SwagLabProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabProject.Pages
{
    public class LoginPage
    {
        public static IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            LoginPage.driver = driver;
        }
        IWebElement UserName => driver.FindElement(LoginSelectors.Username);
        IWebElement Password => driver.FindElement(LoginSelectors.Passowrd);
        IWebElement LoginButton => driver.FindElement(LoginSelectors.LoginButton);

        //Login Method
        public void Login(string username, string password)
        {
            Utils.EnterText(UserName, username);
            Utils.EnterText(Password, password);
            Utils.SubmitButton(LoginButton);
     
        }
    }
}
