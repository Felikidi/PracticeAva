
using System.Threading;
using AvaDesktop.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AvaDesktop.Tests
{
    public class SignUpTests:TestBase
    {
        [TestCase("France")]
        public void FranceSignUp(string country)
        {
          avaHomePage.OpenRegistrationPopUp();
          SignUpPopUpPage.FillInSignUpPopUp();
          YourPersDetailsSignUpPage.SwitchToRegisterFrame();
          YourPersDetailsSignUpPage.FillInYourPersDetailsSignUpPage(country);
          YourFinDetailsPage.FillInYourFinDetailsPage();
          Thread.Sleep(5000);

        }

        
    }
}