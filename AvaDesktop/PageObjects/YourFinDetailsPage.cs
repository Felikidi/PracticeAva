using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class YourFinDetailsPage:BasePage
{
    IWebElement primaryOccupation => driver.FindElement(By.XPath("//div[@data-automation='OccupationOrBusiness']//div[@class='v-select__slot']"));
    IWebElement areEmployeed => driver.FindElement(By.XPath("//div[@data-automation='EmploymentStatus']//div[@class='v-select__slot']"));
    IWebElement soursOfTheFunds => driver.FindElement(By.XPath("//div[@data-automation='SourceOfTradeFunds']//div[@class='v-select__slot']"));
    IWebElement estimatedAnnual => driver.FindElement(By.XPath("//div[@data-automation='EstimatedAnnualIncome']//div[@class='v-select__slot']"));
    IWebElement savingAndInvestments => driver.FindElement(By.XPath("//div[@data-automation='SavingsAndInvestments']//div[@class='v-select__slot']"));
    IWebElement comfortableRisk => driver.FindElement(By.XPath("//div[@data-automation='AmountIntendInvestingEveryYear']//div[@class='v-select__slot']"));
    
    public void FillInYourFinDetailsPage()
    {
        Waiter.WaitElement(By.XPath("//div[@data-automation='OccupationOrBusiness']"));
        
        SelectRandomOption(primaryOccupation);
        SelectRandomOption(areEmployeed);
        SelectRandomOption(soursOfTheFunds);
        SelectRandomOption(estimatedAnnual);
        SelectRandomOption(savingAndInvestments);
        SelectRandomOption(comfortableRisk);
        
        PerfomJSClick(continueButton);
    }
}
