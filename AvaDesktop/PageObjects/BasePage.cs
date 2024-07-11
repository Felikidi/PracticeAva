using System;
using System.Threading;
using AvaDesktop.Driver;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class BasePage
{
    public static IWebDriver driver = FirefoxWebDriver.GetDriver();
    protected IWebElement continueButton => driver.FindElement(By.XPath("//button[@type = 'submit']"));

    public void SelectRandomOption(IWebElement element)
    {
        Random random = new Random();
        PerfomJSClick(element);
        Thread.Sleep(1000);
        var options = element.FindElements(By.XPath("//div[@role='option']"));
        options[random.Next(0, options.Count - 1)].Click();
    }

    public void PerfomJSClick(IWebElement element)
    {
        IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        executor.ExecuteScript("arguments[0].click();", element);
    }
}
