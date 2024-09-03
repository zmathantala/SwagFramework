using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabProject.Selectors
{
    public class AddSelectors
    { 
        public static readonly By BackPack = By.XPath("//*[contains(text(),'Sauce Labs Backpack')]");
        public static readonly By Cart = By.XPath("//a[@class='shopping_cart_link']");
        public static readonly By AddToCart = By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']");

    }
}

