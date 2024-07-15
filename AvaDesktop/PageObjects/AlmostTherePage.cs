using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class AlmostTherePage:BasePage
{
    IWebElement crossButton => driver.FindElement(By.Id("typ-close-icon"));

    public void CloseAlmostTherePage()
    {
        Waiter.WaitElement(By.Id("typ-close-icon"));
        PerfomJSClick(crossButton);
        driver.SwitchTo().DefaultContent();
    }
    
}