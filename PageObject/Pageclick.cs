
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
    public class hepsiburadaCaseMethods
    {
        IWebDriver webDriver;
        IWebElement element;
        public hepsiburadaCaseMethods(IWebDriver driver)
        {
            this.webDriver = driver;
        }
        public void UrunArama(string urun)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunArama));
            element.SendKeys(urun);
        }
        public void AraButton()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.araButton));
            element.Click();
        }
        public void UrunIphone()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunIphone));
            element.Click();
        }
        public void YorumlarButton()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.yorumlarButton));
            element.Click();
        }
        public void IlkYorumEvetTikla()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.ilkYorumEvetTikla));
            element.Click();
        }
    }
}
