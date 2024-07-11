using System;
using System.Threading;
using AvaDesktop.Driver;
using AvaDesktop.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AvaDesktop.Base;

public class TestBase
{
    internal IWebDriver driver;
    internal HomePage avaHomePage = new HomePage();
    internal SignUpPopUpPage SignUpPopUpPage = new SignUpPopUpPage();
    internal YourPersDetailsSignUpPage YourPersDetailsSignUpPage = new YourPersDetailsSignUpPage();
    internal YourFinDetailsPage YourFinDetailsPage = new YourFinDetailsPage();
    [SetUp]
    public void BeforeEach()
    {
        driver = FirefoxWebDriver.GetDriver();
        driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(120));
        
        driver.Navigate().GoToUrl("https://www.avatrade.com");
        Thread.Sleep(5000);
        avaHomePage.AllowCookie();
        
    }
    [TearDown]
    public void AfterEach()
    {
        driver.Close();
    }
}