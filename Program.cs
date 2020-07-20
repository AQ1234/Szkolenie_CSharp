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
            driver.Navigate().GoToUrl("http://www.1939.pl");

            driver.Manage().Window.Size = new Size(1680, 1150);
            //IWebElement inputButton = driver.FindElement(By.Name("Bitwy i potyczki kampanii wrześniowej 1939 - z Niemcami, Sowietami oraz Słowakami"));
            IWebElement btnClick = driver.FindElement(By.ClassName("cc-btn"));
            btnClick.Click();
            driver.Manage().Window.Maximize();
        }
    }
}
