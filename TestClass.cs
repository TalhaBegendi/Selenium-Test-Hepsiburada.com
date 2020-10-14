//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Assert = NUnit.Framework.Assert;
//TALHA BEĞENDİ

namespace hepsiburadaCase
{
    public class ChromeAcilisHepsiburada
    {
        IWebDriver Webdriver;
        [OneTimeSetUp]
        public void HepsiburadaGiris()
        {
            Webdriver = new ChromeDriver();
            Webdriver.Manage().Window.Maximize();
            Webdriver.Navigate().GoToUrl("https://www.hepsiburada.com/");
        }
        [Test, Category("Hepsiburada Test")]
        public void Senaryo_01_UrunArama()
        {
            hepsiburadaCaseMethods urunArama = new hepsiburadaCaseMethods(Webdriver);
            hepsiburadaCaseMethodsAssert urunAramaAssert = new hepsiburadaCaseMethodsAssert(Webdriver);
            urunArama.UrunArama("iphone");
            urunArama.AraButton();
            Assert.IsTrue(urunAramaAssert.Assert_aramaYapilanUrun("iphone"), "Aranılan Urun Basariyla Bulundu.");
            urunArama.UrunIphone();
            Assert.IsTrue(urunAramaAssert.Assert_urunAd("iPhone 11 64 GB"), "Urun Modeli Basariyla Bulundu.");
            urunArama.YorumlarButton();
            urunArama.IlkYorumEvetTikla();
            Assert.IsTrue(urunAramaAssert.Assert_ilkYorumTesekkur("Teşekkür Ederiz."), "Teşekkür Ederiz. Yazısı Basariyla Goruldu.");
        }
    }
}
