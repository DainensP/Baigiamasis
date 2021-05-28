using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis1.Test
{
   public class KmiRegistracijaTest : BaseTest
    {
        [Test]
        public static void RegistracijaCheck()
        {
            _kmiRegistracija.NavigateToPage();
            _kunoMasesIndeksas.CookiesSetUp();
            _kmiRegistracija.NameInput("Evaldas");
            _kmiRegistracija.PhoneInput("8562157");
            _kmiRegistracija.PrivacyChechMark();
            _kmiRegistracija.RegistrationButton();
            _kmiRegistracija.ErrorMessageChech();

        }
        
    }
}
