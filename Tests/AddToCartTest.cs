using SwagLabProject.Base;
using SwagLabProject.Data_Configuration;
using SwagLabProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabProject.Tests
{
    public class AddToCartTest:DemoBase
    {
        public static AddToCartPage addToCartPage;
        public static LoginPage loginPage;

        [Test]
        public void AddItemToChart()
        {
            // Read and deserialize the JSON configuration file
            Config config = ConnectData.LoadConfig();

            // Access the login details
            string username = config.LoginDetails.username;
            string password = config.LoginDetails.Password;

            //initialising  pages 
            addToCartPage = new AddToCartPage(driver);
            loginPage=new LoginPage(driver);
            
            //calling the methods
            loginPage.Login(username,password);
            addToCartPage.AddToCart();
        }
    }
}
