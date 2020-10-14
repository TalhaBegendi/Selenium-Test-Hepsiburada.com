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
    public static class kontrolOzellikleri
    {
        //XPATH
        [CacheLookup] public static By urunArama = By.XPath("//input[@class='desktopOldAutosuggestTheme-input']");
        [CacheLookup] public static By araButton = By.XPath("//div[@class='SearchBoxOld-buttonContainer'][text()='ARA']");
        [CacheLookup] public static By urunIphone = By.XPath("//a[@data-productid='HB00000NSBZ4']");
        [CacheLookup] public static By yorumlarButton = By.XPath("//table[@id='css-tab-buttons']//td[3]");
        [CacheLookup] public static By ilkYorumEvetTikla = By.XPath("//div[@class='paginationContentHolder']/div[1]//button[@class='ReviewCard-module-1MoiF']");
    }
}
