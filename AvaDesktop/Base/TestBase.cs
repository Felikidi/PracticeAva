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
    internal SignUpPopUpPage signUpPopUpPage = new SignUpPopUpPage();
    internal YourPersDetailsSignUpPage yourPersDetailsSignUpPage = new YourPersDetailsSignUpPage();
    internal YourFinDetailsPage yourFinDetailsPage = new YourFinDetailsPage();
    internal TraidingExperienceSignUpPage traidingExperienceSignUpPage = new TraidingExperienceSignUpPage();
    internal TermsAndConditionPage termsAndConditionPage = new TermsAndConditionPage();
    internal WarningPage warningPage = new WarningPage();
    internal AlmostTherePage almostTherePage = new AlmostTherePage();
    internal TutorialPage tutorialPage = new TutorialPage();
    [SetUp]
    public void BeforeEach()
    {
        driver = FirefoxWebDriver.GetDriver();
        driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(120));
        
        driver.Navigate().GoToUrl("https://www.avatrade.com");
        Thread.Sleep(5000);
        try
        {
            avaHomePage.AllowCookie();
        }
        catch {}
        
        
        
        
    }
    [TearDown]
    public void AfterEach()
    {
        driver.Close();
    }
}