
using System.Threading;
using AvaDesktop.Base;
using AvaDesktop.Helpers;
using AvaDesktop.PageObjects;
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
          signUpPopUpPage.FillInSignUpPopUp();
          yourPersDetailsSignUpPage.SwitchToRegisterFrame();
          yourPersDetailsSignUpPage.FillInYourPersDetailsSignUpPage(country);
          yourFinDetailsPage.FillInYourFinDetailsPage();
          traidingExperienceSignUpPage.FillInTradingExperiencePage();
          termsAndConditionPage.FillInTermsAnsConditionPage();
          if (warningPage.CheckIfWarningExist())
          {
              warningPage.ProccedWarningPopUp();
          }
          almostTherePage.CloseAlmostTherePage();
          tutorialPage.SkipTutorial();

        }
        [TestCase("Afghanistan")]
        public void AfghanistanSignUp(string country)
        {
            avaHomePage.OpenRegistrationPopUp();
            signUpPopUpPage.FillInSignUpPopUp();
            yourPersDetailsSignUpPage.SwitchToRegisterFrame();
            yourPersDetailsSignUpPage.FillInYourPersDetailsSignUpPage(country);
            yourFinDetailsPage.FillInYourFinDetailsPage();
            termsAndConditionPage.FillInTermsAnsConditionPage();
            if (warningPage.CheckIfWarningExist())
            {
                warningPage.ProccedWarningPopUp();
            }
            almostTherePage.CloseAlmostTherePage();
            tutorialPage.SkipTutorial();

        }

        
    }
}