using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://pl.godaddy.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement clickEl = driver.FindElement(By.CssSelector("body.ux-app:nth-child(2) div.marquee-bg:nth-child(5) div.page-main section.marquee div.fluid-grid-module:nth-child(3) div.cms-bg-xl.marquee-image.bg-white-100 div.cms-bg-desktop.marquee-image.bg-white-100 div.cms-bg-tablet.marquee-image.bg-white-100 div.cms-bg-mobile.marquee-image.bg-white-100 div.fluid-grid.flex-row.container.p-b-xl-20.p-b-lg-20 div.xl-column.lg-column.md-column.xs-column.d-flex.flex.lg-min-height-auto.xs-min-height-320px.col-xl-5.col-lg-5.col-md-6.col-xs-12.text-lg-center.text-md-center.text-xs-center.cursor-none.rel-pos-r-xl-n-40.rel-pos-r-lg-n-32:nth-child(4) div.cms-bg-mobile.marquee-image.bg-blue-100.p-t-xs-20.p-b-xs-20 div.d-flex.inherit-height.flex-class.align-items-center.justify-content-center.flex-xl-column.flex-lg-column.flex-md-column.flex-xs-column div.ie11-flex-overflow.md-width-100 div.vsc-paragraph-block div.vsc-paragraph-child-block.text-.text-xs-.padding-bottom-default.child-section-Button.p-b-lg-16.p-b-md-10.p-b-xs-16:nth-child(4) div.text-row-group div.vsc-button-block > a.btn.btn-lg.btn-merch"));
            clickEl.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            IWebElement domain = driver.FindElement(By.CssSelector("body.ux-app:nth-child(2) header:nth-child(4) div.sales-header.logged-out.fos.container-fluid:nth-child(9) div.left-items ul.cmsfeature-nav.fos:nth-child(8) > li.fmenu:nth-child(1)"));

            domain.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement inputTest = driver.FindElement(By.Name("domainToCheck"));

            inputTest.Click();

            inputTest.SendKeys("Misie Patysie");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            IWebElement loupe = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/form[1]/div[1]/span[2]/button[1]"));
            loupe.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            driver.Navigate().GoToUrl("https://pl.godaddy.com/");

        }
    }
}
