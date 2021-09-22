/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using Microsoft.IdentityModel.Tokens;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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
        //Screenshot
        public static void TakeScreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sona.g\source\repos\FBDatadriven\FBDatadriven\Screenshot\Test.png");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}