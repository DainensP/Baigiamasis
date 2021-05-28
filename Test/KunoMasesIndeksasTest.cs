using Baigiamasis1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Baigiamasis1.Test
{
    class KunoMasesIndeksasTest : BaseTest
    {
           
        [TestCase("180", "80", "24.7", TestName = "180.80=24.7")]
        [TestCase("170", "30", "10.4", TestName = "170.30=10.4")]
        [TestCase("190", "65", "18", TestName = "190.65=18")]
        public static void TestKunoMasesIndeksas(string height,string weight,string result)
        {
            _kunoMasesIndeksas.NavigateToPage();
            _kunoMasesIndeksas.CookiesSetUp();
            _kunoMasesIndeksas.InsertTextToHeight(height);
            _kunoMasesIndeksas.InsertTextToWeight(weight);
            _kunoMasesIndeksas.ResultText(result);
            _kunoMasesIndeksas.FieldAreasClear();
        }
      
    }
}
