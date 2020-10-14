
//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
//TALHA BEĞENDİ

namespace hepsiburadaCase
{
    public class hepsiburadaCaseMethodsAssert
    {
        IWebDriver webDriver;
        IWebElement elementAssert;
        public hepsiburadaCaseMethodsAssert(IWebDriver driver)
        {
            this.webDriver = driver;
        }
        public bool Assert_aramaYapilanUrun(string aramaYapilanUrunText)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_aramaYapilanUrun));
            return elementAssert.Text == aramaYapilanUrunText;
        }
        public bool Assert_urunAd(string urunAdText)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_urunAd));
            return elementAssert.Text == urunAdText;
        }
        public bool Assert_ilkYorumTesekkur(string ilkYorumTesekkurText)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_ilkYorumTesekkur));
            return elementAssert.Text == ilkYorumTesekkurText;
        }
    }
}
