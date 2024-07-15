using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class WarningPage : BasePage
{
    public IWebElement iAgree => driver.FindElement(By.XPath("//input[@role='checkbox']"));
    IWebElement completeRegistration => driver.FindElement(By.XPath("//button[@id='complete-registration-button']"));

    public void ProccedWarningPopUp()
    {
        PerfomJSClick(iAgree);
        PerfomJSClick(completeRegistration);
    }

    public bool CheckIfWarningExist()
    {
        return Waiter.CheckIfElementExist(By.XPath("//input[@role='checkbox']"));
    }
}