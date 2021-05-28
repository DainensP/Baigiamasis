using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Baigiamasis1.Page
{
   public class KunoMasesIndeksas : BasePage
    {

        private const string addressUrl = "https://calorycare.lt/kmi/";
        private IWebElement heightField => Driver.FindElement(By.Id("ugis"));
        private IWebElement weightField => Driver.FindElement(By.Id("svoris"));
        private IWebElement resultElement => Driver.FindElement(By.XPath("//div[@class='font-cera-pro']"));

        public KunoMasesIndeksas(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != addressUrl)
            {
                Driver.Url = addressUrl;
            }
        }
        public void InsertTextToHeight(string height)
        {
        
            heightField.SendKeys(height);
        
        }
        public void InsertTextToWeight(string weight)
        {
           
            weightField.SendKeys(weight);

        }
        public void ResultText(string result)
        {
            Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result},but was {resultElement.Text}");
          
           
        }

        public void CookiesSetUp()
        {
            Cookie myCookie = new Cookie("cookieconsent_status", "dismiss", "calorycare.lt", "/",DateTime.Now.AddDays(2));

            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
            Thread.Sleep(1000);
            
        }
        public void FieldAreasClear()
        {
            heightField.Clear();
            weightField.Clear();
            Thread.Sleep(3000);
        }
                 
        
    }
}
