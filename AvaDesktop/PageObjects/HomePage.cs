using System.Threading;
using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class HomePage:BasePage
{
    IWebElement cookieAllowButton => driver.FindElement(By.Id("ava_allow_all_c"));
    
    IWebElement registerButton => driver.FindElement(By.Id("btn_ga_real_header"));

   
    public void AllowCookie()
    {
        Waiter.WaitElement(By.Id("ava_allow_all_c"));
        cookieAllowButton.Click();
        Thread.Sleep(5000);
    }

    public void OpenRegistrationPopUp()
    {
        Waiter.WaitElement(By.Id("btn_ga_real_header"));
        registerButton.Click();
    }

}