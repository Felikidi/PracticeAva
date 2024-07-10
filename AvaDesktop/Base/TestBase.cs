using System;
using AvaDesktop.Driver;
using AvaDesktop.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AvaDesktop.Base;

public class TestBase
{
    internal IWebDriver driver;
    internal HomePage avaHomePage = new HomePage();
    [SetUp]
    public void BeforeEach()
    {
        driver = ChromeWebDriver.GetDriver();
        
        driver.Navigate().GoToUrl("https://www.avatrade.com");
        
        avaHomePage.AllowCookie();
        
    }
    [TearDown]
    public void AfterEach()
    {
        driver.Close();
    }
}