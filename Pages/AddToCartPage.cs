using OpenQA.Selenium;
using SwagLabProject.Selectors;
using SwagLabProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SwagLabProject.Pages
{
    public class AddToCartPage
    {
        public static IWebDriver driver;

        public AddToCartPage(IWebDriver driver)
        {
            AddToCartPage.driver = driver;
        }
        IWebElement BackPacks => driver.FindElement(AddSelectors.BackPack);
        IWebElement AddToChart => driver.FindElement(AddSelectors.AddToCart);
        IWebElement Cart => driver.FindElement(AddSelectors.Cart);

        //Login Method
        public  void AddToCart()
        {
            //Add item on the card
            System.Threading.Thread.Sleep(2000);
            Utils.ClickElement(AddToChart);
            Utils.ClickElement(Cart);

            //Validating the item added  on the cart is correct
            var itemName = BackPacks.Text;
            Assert.That(itemName, Is.EqualTo("Sauce Labs Backpack"));

        }
    }
}
