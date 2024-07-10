using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class HomePage:BasePage
{
    IWebElement cookieAllowButton => driver.FindElement(By.Id("ava_allow_all_c"));
    
    IWebElement registerButton => driver.FindElement(By.XPath("//a[contains(text(), 'Register now')]"));

   
    public void AllowCookie()
    {
        Waiter.WaitElement(By.Id("ava_allow_all_c"));
        cookieAllowButton.Click();
    }
    

}