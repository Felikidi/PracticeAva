using AvaDesktop.Helpers;
using OpenQA.Selenium;

namespace AvaDesktop.PageObjects;

public class TraidingExperienceSignUpPage:BasePage
{
    IWebElement relevantExperienceYes => driver.FindElement(By.XPath("//label[@for='option-1_84-1']"));
    IWebElement relevantExperienceNo => driver.FindElement(By.XPath("//label[@for='option-1_84-2']"));

    IWebElement experienceLastYear => driver.FindElement(By.XPath("//div[@data-automation='NumOfTimesTradedinForexCfds']//div[@class='v-select__slot']"));
    IWebElement estimatedValueOfTrades => driver.FindElement(By.XPath("//div[@data-automation='WhatWasTheAverageSizeOfTrades']//div[@class='v-select__slot']"));
    IWebElement tradingWithLeverage => driver.FindElement(By.XPath("//div[@data-automation='TradingWithLeverageApplies']//div[@class='v-select__slot']"));
    IWebElement maxSizePozition => driver.FindElement(By.XPath("//div[@data-automation='TradingWithLeverageMaximumPosition']//div[@class='v-select__slot']"));
    IWebElement openPosition => driver.FindElement(By.XPath("//div[@data-automation='OpenPositionAutomaticallyClose']//div[@class='v-select__slot']"));
    IWebElement primaryPurpose => driver.FindElement(By.XPath("//div[@data-automation='WhyTradeWithUs']//div[@class='v-select__slot']"));
    IWebElement confirmCheckbox => driver.FindElement(By.XPath("//input[@role='checkbox']"));

    public void FillInTradingExperiencePage()
    {
        Waiter.WaitElement(By.XPath("//label[@for='option-1_84-1']"));
        
        PerfomJSClick(relevantExperienceYes);
        
        SelectRandomOption(experienceLastYear);
        SelectRandomOption(estimatedValueOfTrades);
        SelectRandomOption(tradingWithLeverage);
        SelectRandomOption(maxSizePozition);
        SelectRandomOption(openPosition);
        SelectRandomOption(primaryPurpose);
        PerfomJSClick(confirmCheckbox);
        
        PerfomJSClick(continueButton);
    }






}