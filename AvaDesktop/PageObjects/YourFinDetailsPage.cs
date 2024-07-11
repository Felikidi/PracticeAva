using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class YourFinDetailsPage:BasePage
{
    IWebElement primaryOccupation => driver.FindElement(By.XPath("//div[@data-automation='OccupationOrBusiness']//div[@class='v-select__slot']"));
    IWebElement areEmployeed => driver.FindElement(By.XPath("//div[@data-automation='EmploymentStatus']"));
    IWebElement soursOfTheFunds => driver.FindElement(By.XPath("//div[@data-automation='SourceOfTradeFunds']"));
    IWebElement estimatedAnnual => driver.FindElement(By.XPath("//div[@data-automation='EstimatedAnnualIncome']"));
    IWebElement savingAndInvestments => driver.FindElement(By.XPath("//div[@data-automation='SavingsAndInvestments']"));
    IWebElement comfortableRisk => driver.FindElement(By.XPath("//div[@data-automation='AmountIntendInvestingEveryYear']"));
    
    public void FillInYourFinDetailsPage()
    {
        Waiter.WaitElement(By.XPath("//div[@data-automation='OccupationOrBusiness']"));
        SelectRandomOption(primaryOccupation);
    }
}
