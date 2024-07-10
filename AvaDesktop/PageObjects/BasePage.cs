using AvaDesktop.Driver;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class BasePage
{
    public static IWebDriver driver = FirefoxWebDriver.GetDriver();
}