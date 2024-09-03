using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabProject.Utilities
{
    public class Utils
    {

        public static IWebDriver driver;
        public static string currentUrl;
        public Utils(IWebDriver driver)
        {
            Utils.driver = driver;
        }

        public static void ClickElement(IWebElement locator)
        {
            //IWebElement element = driver.FindElement(locator);
            if (locator.Displayed && locator.Enabled)
            {
                locator.Click();
            }
            else
            {
                throw new ElementClickInterceptedException("Can not click the element");
            }

        }
        //click submit button
        public static void SubmitButton(IWebElement locator)
        {
            //
            //IWebElement submitButton = driver.FindElement(submitButtonLocator);
            //locator.Submit();
            // Optionally perform any validations or actions before clicking submit
            // Example: Check if the submit button is enabled
            if (locator.Displayed && locator.Enabled)
            {
                locator.Submit();
            }
            else
            {
                throw new ElementNotInteractableException("Submit button is not enabled or visible.");
            }

        }
        public static bool IsElementDisplayed1(IWebElement locator)
        {
            try
            {
                return locator.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public static void GoToUrl(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (WebDriverException)
            {
                Console.WriteLine($"Failed to navigate to URL: {url}");
                throw; // Rethrow the exception to indicate failure
            }
        }
        public static void EnterText(IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);

        }

        public static void CLICK(IWebElement locator)
        {
            locator.Click();

        }
        public void getPageTitle()
        {
            string pageTitle = driver.Title;
        }
        public void getPageCurentURL()
        {
            currentUrl = driver.Url;

        }
        public static void validateUrl(string searchString)
        {
            string url = driver.Url;
            // string searchString = "admin/viewSystemUsers";

            // Use assertion to check if the URL contains the search string
            Debug.Assert(url.Contains(searchString, StringComparison.OrdinalIgnoreCase),
                         $"Assertion failed: The URL does not contain the string: {searchString}");

            Console.WriteLine($"The URL contains the string: {searchString}");

        }
        public static void checkdropdown(IWebElement locator)
        {
            try
            {


                // Find the dropdown element
                // IWebElement dropdownElement = driver.FindElement(By.Id("dropdownId")); // Replace with your dropdown locator

                // Create a SelectElement object to interact with the dropdown
                SelectElement selectElement = new SelectElement(locator);

                // Get all options in the dropdown
                IReadOnlyCollection<IWebElement> options = (IReadOnlyCollection<IWebElement>)selectElement.Options;

                // Loop through each option
                foreach (var option in options)
                {
                    string optionText = option.Text;

                    // Perform your verification here
                    // For example, print option text or verify if it contains specific text
                    Console.WriteLine($"Option Text: {optionText}");

                    // Example verification (replace with your actual conditions)
                    if (optionText.Contains("Expected Value"))
                    {
                        Console.WriteLine("Found the expected option.");
                        // Perform actions if the expected value is found
                    }
                }
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"Error finding element: {ex.Message}");
            }
            finally
            {
                // Clean up and close the browser
                driver.Quit();
            }
        }
        public static void SelectDropdownByValue(IWebElement dropdown, string value)
        {
            if (dropdown.Enabled && dropdown.Enabled)
            {
                SelectElement selectElement = new SelectElement(dropdown);
                selectElement.SelectByValue(value);
            }
            else
            {
                throw new ElementNotVisibleException("dropdown is not visible");
            }
        }
        public static void SelectDropdownByText(IWebElement dropdown, string text)
        {
            if (dropdown.Enabled && dropdown.Enabled)
            {
                SelectElement selectElement = new SelectElement(dropdown);
                selectElement.SelectByText(text);
            }
            else
            {
                throw new ElementNotVisibleException("dropdown is not visible");
            }

        }
        public static void SelectValueByIndex(IWebElement dropdownElement, int indexToSelect)
        {
            // Create a SelectElement object to interact with the dropdown
            SelectElement selectElement = new SelectElement(dropdownElement);

            // Select the option by index
            try
            {
                selectElement.SelectByIndex(indexToSelect);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Index '{indexToSelect}' is out of range for the dropdown options.");
            }
        }
        public static bool IsElementDisplayed(IWebElement element, int timeoutInSeconds = 10)
        {
            try
            {
                // Initialize WebDriverWait with the given timeout
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

                // Wait until the element is visible
                return wait.Until(drv => element.Displayed);
            }
            catch (WebDriverTimeoutException)
            {
                // Timeout while waiting for the element to be visible
                return false;
            }
            catch (Exception ex)
            {
                // Log or handle any other exceptions as needed
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
        public static void validatePageTitle(string searchString)
        {
            string title = driver.Title;
            // string searchString = "OrangeHRM";

            // Use assertion to check if the URL contains the search string
            Debug.Assert(title.Contains(searchString, StringComparison.OrdinalIgnoreCase),
                         $"Assertion failed: The URL does not contain the string: {searchString}");

            Console.WriteLine($"The title contains the string: {searchString}");

        }
    }
}
