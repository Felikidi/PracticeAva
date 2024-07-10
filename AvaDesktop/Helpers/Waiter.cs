using System;
using AvaDesktop.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvaDesktop.Helpers;

public static class Waiter
{
    private static IWebDriver driver = ChromeWebDriver.GetDriver();

    public static void WaitElement(By element, int timeout = 30)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        wait.Until(ExpectedConditions.ElementIsVisible(element));
    }
}
