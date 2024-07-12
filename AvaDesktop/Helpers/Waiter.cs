using System;
using AvaDesktop.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvaDesktop.Helpers;

public static class Waiter
{
    private static IWebDriver driver = FirefoxWebDriver.GetDriver();

    public static void WaitElement(By element, int timeout = 30)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        wait.Until(ExpectedConditions.ElementIsVisible(element));
    }

    public static bool CheckIfElementExist(By element, int timeout = 30)
    {
        try
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementExists(element));
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
        
    }
}
