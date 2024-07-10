
using System.Threading;
using AvaDesktop.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AvaDesktop.Tests
{
    public class SignUp:TestBase
    {
        [Test]
        public void FranceSignUp()
        {
          avaHomePage.OpenRegistrationPopUp();
          signUpPopUp.FillInSignUpPopUp();
          Thread.Sleep(5000);

        }

        
    }
}