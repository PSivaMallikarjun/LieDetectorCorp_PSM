using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace RegressionTestingExample
{
    [TestFixture]
    public class RegressionTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Initialize the WebDriver (Chrome)
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void TestLoginFunctionality()
        {
            // Open the application
            driver.Navigate().GoToUrl("http://localhost:5136"); // replace with your URL

            // Find and interact with elements
            var loginButton = driver.FindElement(By.Id("loginButton"));
            var usernameField = driver.FindElement(By.Id("username"));
            var passwordField = driver.FindElement(By.Id("password"));

            // Fill in the login credentials
            usernameField.SendKeys("testuser");
            passwordField.SendKeys("password123");

            // Click the login button
            loginButton.Click();

            // Assert expected behavior, e.g., checking if login was successful
            var logoutButton = driver.FindElement(By.Id("logoutButton"));
            Assert.IsTrue(logoutButton.Displayed, "Login failed, logout button is not displayed.");
        }

        [Test]
        public void TestButtonFunctionality()
        {
            // Open the page
            driver.Navigate().GoToUrl("http://localhost:5136");

            // Locate button and click
            var submitButton = driver.FindElement(By.Id("submitButton"));
            submitButton.Click();

            // Verify the action post-click
            var successMessage = driver.FindElement(By.Id("successMessage"));
            Assert.AreEqual("Form submitted successfully!", successMessage.Text);
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser after the tests
            driver.Quit();
        }
    }
}
