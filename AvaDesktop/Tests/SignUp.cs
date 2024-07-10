
using AvaDesktop.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AvaDesktop.Tests
{
    public class SignUp:TestBase
    {
        [Test]
        public void FranceSignUp()
        {
          
           IWebElement registerButton = driver.FindElement(By.XPath("//a[contains(text(), 'Register now')]"));
           registerButton.Click();
           System.Threading.Thread.Sleep(5000);

        }

        
    }
}