using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class TutorialPage:BasePage
{
    private IWebElement skipTutorial => driver.FindElement(By.XPath("//span[@data-key='tourPopupButtonSkip']"));

    public void SkipTutorial()
    {
        Waiter.WaitElement(By.XPath("//span[@data-key='tourPopupButtonSkip']"));
        skipTutorial.Click();
    }
}