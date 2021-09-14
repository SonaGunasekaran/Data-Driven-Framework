/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FBDatadriven.Base
{
    public class Baseclass
    {
        public static IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
