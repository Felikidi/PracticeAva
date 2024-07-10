using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AvaDesktop.Driver;

public class FirefoxWebDriver
{
    private static IWebDriver _driver;

    private FirefoxWebDriver()
    {
        
    }

    private static FirefoxDriver StartDriver()
    {
       var driver = new FirefoxDriver();
        driver.Manage().Window.Maximize();
        return driver;
    }

    public static IWebDriver GetDriver()
    {
        if (_driver == null)
        {
            _driver = StartDriver();
        }

        return _driver;

    }
}