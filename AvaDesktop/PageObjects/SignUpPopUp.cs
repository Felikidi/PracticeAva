using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class SignUpPopUp:BasePage
{
    IWebElement emailInput => driver.FindElement(By.Id("input-email"));
    IWebElement passwordInput => driver.FindElement(By.Id("input-password"));
    IWebElement submitButton => driver.FindElement(By.Id("btn_ga_real_main menu_cfd"));

    public void FillInSignUpPopUp()
    {
        Waiter.WaitElement(By.Id("input-email"));
        emailInput.SendKeys("testautomat@dd.com");
        passwordInput.SendKeys("Password1!");
        submitButton.Click();
    }
}