using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis1.Drivers
{
   public class CustomDrivers
    {
        public static IWebDriver Chrome()
        {
            return GetDriver(Browser.Chrome);
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browser.Firefox);
        }

        private static IWebDriver GetDriver(Browser browserName)
        {
            IWebDriver driver = null;
            switch (browserName)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Browser.Firefox:
                    driver = new FirefoxDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}
