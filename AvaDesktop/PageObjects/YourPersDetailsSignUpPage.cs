using System;
using System.Threading;
using AvaDesktop.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AvaDesktop.PageObjects;

public class YourPersDetailsSignUpPage : BasePage
{
    IWebElement firstName => driver.FindElement(By.XPath("//input[@name = 'FirstName']"));
    IWebElement lastName => driver.FindElement(By.XPath("//input[@name = 'LastName']"));
    IWebElement dateDay => driver.FindElement(By.Id("date-day"));
    IWebElement dateMonth => driver.FindElement(By.Id("date-month"));
    IWebElement dateYear => driver.FindElement(By.Id("date-year"));
    IWebElement countryDropdown => driver.FindElement(By.XPath("//input[@name = 'Country']"));
    IWebElement city => driver.FindElement(By.XPath("//input[@name = 'City']"));
    IWebElement street => driver.FindElement(By.XPath("//input[@name = 'Street']"));
    IWebElement buildingNumber => driver.FindElement(By.XPath("//input[@name = 'BuildingNumber']"));
    IWebElement flat => driver.FindElement(By.XPath("//input[@name = 'Flat']"));
    IWebElement zipCode => driver.FindElement(By.XPath("//input[@name = 'ZipCode']"));
    IWebElement phoneNumber => driver.FindElement(By.XPath("//input[@id='phone-number-input']"));
    IWebElement registrationiFrame => driver.FindElement(By.XPath("//iframe[contains(@url, 'registration')]"));

    public void FillInYourPersDetailsSignUpPage(string country)
    {
        Waiter.WaitElement(By.Id("date-day"),120);
        SelectCountry(country);
        firstName.SendKeys("TestFirstName");
        lastName.SendKeys("TestLastName");
        dateDay.SendKeys("10");
        dateMonth.SendKeys("10");
        dateYear.SendKeys("1990");
        city.SendKeys("Test");
        street.SendKeys("Test");
        buildingNumber.SendKeys("5");
        flat.SendKeys("5");
        zipCode.SendKeys("1000");
        phoneNumber.SendKeys(new Random().Next(1000000, 2000000).ToString());
        Thread.Sleep(1000);
        PerfomJSClick(continueButton);
        
    }

    public void SelectCountry(string country)
    {
        Actions actions = new Actions(driver);
        countryDropdown.Click();
        Thread.Sleep(1000);
        countryDropdown.SendKeys(country);
        Thread.Sleep(1000);
        Waiter.WaitElement(By.XPath($"//span[@class='country-name' and text()='{country}']"));
        Thread.Sleep(1000);
        actions.SendKeys(Keys.Enter).Perform();
        // driver.FindElement(By.XPath($"//span[@class='country-name' and text()='{country}']")).Click();
        Thread.Sleep(3000);
    }

    public void SwitchToRegisterFrame()
    {
        Waiter.WaitElement(By.XPath("//iframe[contains(@url, 'registration')]"),120);
        driver.SwitchTo().Frame(registrationiFrame);

    }
    
}