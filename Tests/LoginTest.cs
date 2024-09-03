using SwagLabProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using SwagLabProject.Data_Configuration;
using SwagLabProject.Base;

namespace SwagLabProject.Tests
{
    public class LoginTest:DemoBase
    {
        public static LoginPage loginOBJ;

        [Test]

        public void LoginTests()
        {
            // Read and deserialize the JSON configuration file
            Config config = ConnectData.LoadConfig();

            // Access the login details
            string username = config.LoginDetails.username;
            string password = config.LoginDetails.Password;

            //initialising the Login page 
            loginOBJ = new LoginPage(driver);

            //calling in the Login method and passing passing in login details that are stored in json file
            loginOBJ.Login(username, password);

        }
    }
}
