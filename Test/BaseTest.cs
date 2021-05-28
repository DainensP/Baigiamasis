using Baigiamasis1.Drivers;
using Baigiamasis1.Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis1.Test
{

    public class BaseTest
    {
        protected static IWebDriver _driver;
        public static KunoMasesIndeksas _kunoMasesIndeksas;
        public static KmiRegistracija _kmiRegistracija;

        [OneTimeSetUp]
          public static void OneTimeSetUp()
        {
            _driver = CustomDrivers.Chrome();
            _kunoMasesIndeksas = new KunoMasesIndeksas(_driver);
            _kmiRegistracija = new KmiRegistracija(_driver);
            _driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        //[TearDown]
        //public static void TearDown()
        //{
        //    if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
        //    {
        //        MyScreenshot.MakeScreenshot(_driver);
        //    }
        //}

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
