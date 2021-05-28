using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis1.Page
{
   public class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webdiver)
        {
            Driver = webdiver;
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
