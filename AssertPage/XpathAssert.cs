//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
//TALHA BEĞENDİ

namespace hepsiburadaCase
{ 
   public static class kontrolOzellikleriAssert
   {
        //XPATHASSERT
        [CacheLookup] public static By assert_aramaYapilanUrun = By.XPath("//h1[@class='keyword'][text()[contains(.,'iphone')]]");
        [CacheLookup] public static By assert_urunAd = By.XPath("//h1[@id='product-name'][text()[contains(.,'iPhone 11 64 GB')]]");
        [CacheLookup] public static By assert_ilkYorumTesekkur = By.XPath("//div[@class='paginationContentHolder']/div[1]//span[@class='ReviewCard-module-1ZiTv'][text()[contains(.,'Teşekkür Ederiz.')]]");
    }
}
