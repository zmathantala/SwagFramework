using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabProject.Selectors
{
    public class LoginSelectors
    {
        public static readonly By Username = By.Id("user-name");
        public static readonly By Passowrd = By.Id("password");
        public static readonly By LoginButton = By.Id("login-button");

    }
}
