using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis1.Page
{
    public class KmiRegistracija : BasePage
    {
        public KmiRegistracija(IWebDriver webdriver) : base(webdriver) { }

        private const string addressUrl = "https://calorycare.lt/registracija/";
        private const string resultText = "Įveskite el. pašto adresą.";

        private IWebElement nameInputField => Driver.FindElement(By.CssSelector("#fullname"));
        private IWebElement phoneInputField => Driver.FindElement(By.CssSelector("#phone"));

        private IWebElement privacyCheckBox => Driver.FindElement(By.CssSelector("#privacy"));
        private IWebElement registerButton => Driver.FindElement(By.CssSelector("#forma>div>form>fieldset>div.mt-24.text-center>button"));
        private IWebElement errorMesage => Driver.FindElement(By.CssSelector("text-14.text-red-500"));

        public void NavigateToPage()
        {
            if (Driver.Url != addressUrl)
            {
                Driver.Url = addressUrl;
            }
        }

        public void RegistrationButton()
        {
            registerButton.Click();
        }

        public void NameInput(string name)
        {
            nameInputField.SendKeys(name);
        }
        public void PhoneInput(string phone)
        {
            phoneInputField.SendKeys(phone);
        }
        public void PrivacyChechMark()
        {
            privacyCheckBox.Click();
        }
        public void ErrorMessageChech()
        {
            Assert.IsTrue(errorMesage.Text.Contains(resultText), "Wrong text");
        }
      
    }
}
