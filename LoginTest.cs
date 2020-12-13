using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace WebDriver_CSharp_Example
{


    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;
        public string homeURL;

        [Test(Description = "Registration site for Automation")]
        public void Login_is_on_home_page()
        {
            homeURL = "https://opensource-demo.orangehrmlive.com/";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait1 = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
            wait1.Until(driver => driver.FindElement(By.CssSelector("#divLogo")));
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='logInPanelHeading']"));
            Assert.AreEqual("LOGIN Panel", element1.GetAttribute("innerText"));
            driver.FindElement(By.XPath("//*[@id='txtUsername']")).SendKeys("Admin");
            driver.FindElement(By.CssSelector("#txtPassword")).SendKeys("admin123");
            driver.FindElement(By.CssSelector("#btnLogin")).Click();
            WebDriverWait wait2 = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
            wait2.Until(driver => driver.FindElement(By.CssSelector("#branding")));
            driver.Close();

        }
    }

}