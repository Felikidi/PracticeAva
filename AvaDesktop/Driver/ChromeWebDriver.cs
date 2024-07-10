using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AvaDesktop.Driver;

public class ChromeWebDriver
{
    private static IWebDriver _driver;

    private ChromeWebDriver()
    {
        
    }

    private static ChromeDriver StartDriver()
    {
       var driver = new ChromeDriver();
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