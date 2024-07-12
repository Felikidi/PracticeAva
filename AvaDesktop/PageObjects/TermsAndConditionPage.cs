using System.Net.Mail;
using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class TermsAndConditionPage:BasePage
{
    IWebElement usaResident => driver.FindElement(By.XPath("//input[@name='NoUsaCitizenship']"));
    IWebElement termsAndConditions =>driver.FindElement(By.XPath("//input[@name='TermsAndConditions']"));
    IWebElement receiveUpdates => driver.FindElement(By.XPath("//input[@name='WhatsAppConesnt']"));

    public void FillInTermsAnsConditionPage()
    {
        PerfomJSClick(termsAndConditions);
        PerfomJSClick(receiveUpdates);
        PerfomJSClick(continueButton);
        
    }
    
    
}